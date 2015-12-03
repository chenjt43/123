/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	Subject���ݷ���
 * 
 * �����ˣ���	Chenjt
 * �������ڣ�	2015/11/17 15:07:31
 * ����˵����	�Զ����ɴ��룬������д/��չ
 * 
 * �޸��ˣ���	
 * �޸����ڣ�	
 * �޸�˵����	
 * -------------------------------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using Microsoft.ApplicationBlocks.Data;

using Share.Framework;

using Zkjj.Zgyinggu.BusinessEntities;

namespace Zkjj.Zgyinggu.DataAccess.SQLServer
{
	/// <summary>
	/// Subject���ݷ���
	/// </summary>
	public partial class SubjectDataAccess
	{
		#region ��д
		
		#endregion
		
		#region ��չ
        public DataSet GetPagedListAllByConditoin(int pageIndex, int pageSize, string sortExpression, string criteria, out int totalRecords)
        {
            SubjectList SubjectList = new SubjectList();
            string commandTextList = string.Format(@"WITH Subjects AS(
	         SELECT RowId=ROW_NUMBER() OVER(ORDER BY {0}),sub.*,us.DisplayName,us.UserHeadImg
	        ,CommentCount=isnull((select count(0) from dbo.Comment where SubjectId=sub.SubjectId),0) FROM [Subject] sub
	        inner join  dbo.Users us on sub.CreatorId=us.UserId {1}
            )SELECT * FROM Subjects WHERE RowId>{2} AND RowId<={3}", string.IsNullOrEmpty(sortExpression) ? "CreateTime" : sortExpression, criteria, pageIndex > 0 ? (pageIndex - 1) * pageSize : 0, pageIndex * pageSize);

            DataSet dataset =SqlHelper.ExecuteDataset(ConnectionString.ZgyinguRead, CommandType.Text, commandTextList.ToString());
            #region ��ȡ�������ֵ
            string commandTextCount = string.Format("select count(*)  FROM Subject sub {0}", criteria);
            totalRecords = Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString.ZgyinguRead, CommandType.Text, commandTextCount));
            #endregion

            return dataset;
        }

        public SubjectEntity GetSubjectEntity(int id)
        {
            SubjectEntity subjectEntity = new SubjectEntity();
            string commandTextList = string.Format(@"
	         SELECT sub.*,us.DisplayName,us.UserHeadImg
	        ,CommentCount=isnull((select count(0) from dbo.Comment where SubjectId=sub.SubjectId),0) FROM [Subject] sub
	        inner join  dbo.Users us on sub.CreatorId=us.UserId where SubjectId={0}",id);
            bool flag = false;
            using (SqlDataReader item = SqlHelper.ExecuteReader(ConnectionString.ZgyinguRead, CommandType.Text, commandTextList))
            {
                if(item.Read())
                {
                    flag = true;
                    subjectEntity.SubjectId = Convert.ToInt32(item["SubjectId"]);
                    subjectEntity.CategoryId = Convert.ToInt32(item["CategoryId"]);
                    subjectEntity.SubjectName = item["SubjectName"].ToString();
                    subjectEntity.CreatorId = Convert.ToInt32(item["CreatorId"]);
                    subjectEntity.CreateTime = Convert.ToDateTime(item["CreateTime"]).ToString("yyyy-MM-dd HH:mm:ss");
                    subjectEntity.DisplayOrder = Convert.ToInt32(item["DisplayOrder"]);
                    subjectEntity.DisplayName = item["DisplayName"].ToString();
                    subjectEntity.UserHeadImg = item["UserHeadImg"].ToString();
                    subjectEntity.CommentCount = Convert.ToInt32(item["CommentCount"]);
                }
            }
            if(flag)
            { 
                subjectEntity.Comments = new CommentDataAccess().GetCommentsBySubjectId(id);
            }
            return subjectEntity;
        }
		#endregion
		
	}
}

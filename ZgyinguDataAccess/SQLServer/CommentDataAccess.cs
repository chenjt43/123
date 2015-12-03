/*
 * -------------------------------------------------------------------------------------------------
 * 版权信息：	中国英谷平台 版权所有 2015
 * 功能描述：	Comment数据访问
 * 
 * 创建人：　	Chenjt
 * 创建日期：	2015/11/17 15:07:31
 * 创建说明：	自动生成代码，用于重写/扩展
 * 
 * 修改人：　	
 * 修改日期：	
 * 修改说明：	
 * -------------------------------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;

using Microsoft.ApplicationBlocks.Data;

using Share.Framework;

using Zkjj.Zgyinggu.BusinessEntities;

namespace Zkjj.Zgyinggu.DataAccess.SQLServer
{
    /// <summary>
    /// Comment数据访问
    /// </summary>
    public partial class CommentDataAccess
    {
        #region 重写

        #endregion

        #region 扩展
        public CommentEntity GetCommentById(int id)
        {
            CommentEntity comment = null;
            string commandTextList = "select Comment.*,Users.UserHeadImg,CreatorName=Users.DisplayName from Comment,Users where Comment.CreatorId=Users.UserId  and Comment.Id=" + id;
            using (SqlDataReader dataReader = SqlHelper.ExecuteReader(ConnectionString.ZgyinguRead, CommandType.Text, commandTextList))
            {
                if (dataReader.Read())
                {
                    comment = new CommentEntity();
                    comment.Id = Convert.ToInt32(dataReader["Id"]);
                    comment.SubjectId = Convert.ToInt32(dataReader["SubjectId"]);
                    comment.CreatorId = Convert.ToInt32(dataReader["CreatorId"]);
                    comment.CreatorName = Convert.ToString(dataReader["CreatorName"]);
                    comment.CreateTime = Convert.ToDateTime(dataReader["CreateTime"]).ToString("yyyy-MM-dd HH:mm:ss");
                    comment.CommentContent = Convert.ToString(dataReader["CommentContent"]);
                    comment.UserHeadImg = Convert.ToString(dataReader["UserHeadImg"]);
                }
            }
            return comment;
        }

         public int GetCommentCountBySubjectId(int subjectId)
        {
            string commandTextCount = string.Format("select count(0)  FROM Comment where SubjectId={0}", subjectId);
            return Convert.ToInt32(SqlHelper.ExecuteScalar(ConnectionString.ZgyinguRead, CommandType.Text, commandTextCount));
        }
        public List<CommentEntity> GetCommentsBySubjectId(int id)
        {
            List<CommentEntity> commentList = new List<CommentEntity>();
            CommentEntity comment = null;
            string commandTextList = "select Comment.*,Users.UserHeadImg,CreatorName=Users.DisplayName from Comment,Users where Comment.CreatorId=Users.UserId  and Comment.SubjectId=" + id;
            using (SqlDataReader dataReader = SqlHelper.ExecuteReader(ConnectionString.ZgyinguRead, CommandType.Text, commandTextList))
            {
                while (dataReader.Read())
                {
                    comment = new CommentEntity();
                    comment.Id = Convert.ToInt32(dataReader["Id"]);
                    comment.SubjectId = Convert.ToInt32(dataReader["SubjectId"]);
                    comment.CreatorId = Convert.ToInt32(dataReader["CreatorId"]);
                    comment.CreatorName = Convert.ToString(dataReader["CreatorName"]);
                    comment.CreateTime = Convert.ToDateTime(dataReader["CreateTime"]).ToString("yyyy-MM-dd HH:mm:ss");
                    comment.CommentContent = Convert.ToString(dataReader["CommentContent"]);
                    comment.UserHeadImg = Convert.ToString(dataReader["UserHeadImg"]);
                    commentList.Add(comment);
                }
            }
            return commentList;
        }
        #endregion

    }
}

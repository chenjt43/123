/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	Subjectҵ���߼�
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
using System.Data.Common;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

#if EnableWCF
using System.ServiceModel;
#endif
#if EnableDTC
using System.Transactions;
#endif

using Share.Framework;
using Share.Framework.Logging;

using Zkjj.Zgyinggu.BusinessEntities;
using Zkjj.Zgyinggu.BusinessLogic.Logging;
using Zkjj.Zgyinggu.DataAccess;
using Zkjj.Zgyinggu.DataAccess;
#if EnableIDAL
using Zkjj.Zgyinggu.DataAccess.Interface;
#else
using Zkjj.Zgyinggu.DataAccess.SQLServer;
#endif
using Zkjj.Zgyinggu.Exceptions;
#if EnableWCF || EnableServiceContracts
using Zkjj.Zgyinggu.ServiceContracts;
using System.Data;
#endif



namespace Zkjj.Zgyinggu.BusinessLogic
{
    /// <summary>
    /// Subjectҵ���߼�
    /// </summary>
    public partial class SubjectLogic
    {
        #region ��д

        #endregion

        #region ��չ
        public SubjectEntityList GetPagedListAllByConditoin(int pageIndex, int pageSize, int tab)
        {
            string criteria = string.Format("where 1=1 {0}", tab > 0 ? (" and CategoryId=" + tab) : "");
            DataSet ds = DalSubject.GetPagedListAllByConditoin(pageIndex, pageSize, "CreateTime desc", criteria, out _TotalRecords);
            List<SubjectEntity> list = null;
            SubjectEntityList subjectEntityList = new SubjectEntityList();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                list = new List<SubjectEntity>();
                SubjectEntity subjectEntity = null;
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    subjectEntity = new SubjectEntity();
                    subjectEntity.SubjectId =Convert.ToInt32(item["SubjectId"]);
                    subjectEntity.CategoryId = Convert.ToInt32(item["CategoryId"]);
                    subjectEntity.SubjectName = item["SubjectName"].ToString();
                    subjectEntity.CreatorId = Convert.ToInt32(item["CreatorId"]);
                    subjectEntity.CreateTime = Convert.ToDateTime(item["CreateTime"]).ToString("yyyy-MM-dd HH:mm:ss");
                    subjectEntity.DisplayOrder = Convert.ToInt32(item["DisplayOrder"]);
                    subjectEntity.DisplayName = item["DisplayName"].ToString();
                    subjectEntity.UserHeadImg = item["UserHeadImg"].ToString();
                    subjectEntity.CommentCount = Convert.ToInt32(item["CommentCount"]);
                    list.Add(subjectEntity);
                }
                subjectEntityList.List = list;
                subjectEntityList.TotalCount = _TotalRecords;
            }
            return subjectEntityList;
        }

        public SubjectEntity GetSubjectEntity(int id)
        {
            return DalSubject.GetSubjectEntity(id);
        }
        #endregion
    }
}

/*
 * -------------------------------------------------------------------------------------------------
 * 版权信息：	中国英谷平台 版权所有 2015
 * 功能描述：	Subject业务逻辑
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
    /// Subject业务逻辑
    /// </summary>
    public partial class SubjectLogic
    {
        #region 重写

        #endregion

        #region 扩展
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

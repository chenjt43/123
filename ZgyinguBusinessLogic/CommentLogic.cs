/*
 * -------------------------------------------------------------------------------------------------
 * 版权信息：	中国英谷平台 版权所有 2015
 * 功能描述：	Comment业务逻辑
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
#endif



namespace Zkjj.Zgyinggu.BusinessLogic
{
	/// <summary>
	/// Comment业务逻辑
	/// </summary>
	public partial class CommentLogic
	{
		#region 重写
		
		#endregion
	
		#region 扩展
        public CommentEntity CommenAdd(CommentEntity commentEntity)
        {
            Comment comment = new Comment();
            comment.SubjectId = commentEntity.SubjectId;
            comment.CreateTime = DateTime.Now;
            comment.CommentContent = commentEntity.CommentContent;
            Users user = new UsersLogic().GetById(commentEntity.CreatorId);
            comment.CreatorId = user.UserId;
            comment.CreatorName = user.DisplayName;
            DalComment.Add(null,comment);
            return DalComment.GetCommentById(comment.Id);
        }

        public List<CommentEntity> GetCommentBySubjectId(int subjectId)
        {
            return DalComment.GetCommentsBySubjectId(subjectId);
        }
		#endregion
	}
}

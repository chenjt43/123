/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	Commentҵ���߼�
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
#endif



namespace Zkjj.Zgyinggu.BusinessLogic
{
	/// <summary>
	/// Commentҵ���߼�
	/// </summary>
	public partial class CommentLogic
	{
		#region ��д
		
		#endregion
	
		#region ��չ
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

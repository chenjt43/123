/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	��־��ö��
 * 
 * �����ˣ���	Chenjt
 * �������ڣ�	2015/11/17 15:07:32
 * ����˵����	�Զ����ɴ��룬������
 * 
 * �޸��ˣ���	
 * �޸����ڣ�	
 * �޸�˵����	
 * -------------------------------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Zkjj.Zgyinggu.BusinessLogic.Logging
{
	public enum BizLogEnum
	{
		#region ����
		DataDebug,
		SystemError,
		#endregion
		
		#region	


		#region Comment
		CommentAdd,
		CommentRemove,
		CommentRemoveList,
		CommentSave,
		#endregion



		#region Subject
		SubjectAdd,
		SubjectRemove,
		SubjectRemoveList,
		SubjectSave,
		#endregion



		#region SubjectCategory
		SubjectCategoryAdd,
		SubjectCategoryRemove,
		SubjectCategoryRemoveList,
		SubjectCategorySave,
		#endregion



		#region SubjectInfo
		SubjectInfoAdd,
		SubjectInfoRemove,
		SubjectInfoRemoveList,
		SubjectInfoSave,
		#endregion



		#region Users
		UsersAdd,
		UsersRemove,
		UsersRemoveList,
		UsersSave,
		#endregion


		#endregion
	}
}

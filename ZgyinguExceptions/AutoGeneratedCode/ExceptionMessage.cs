/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	�쳣��Ϣ
 * 
 * �����ˣ���	Chenjt
 * �������ڣ�	2015/11/17 15:07:32
 * ����˵����	�Զ����ɴ��룬���ϲ���Ŀ���Ͻ��޸�
 * 
 * �޸��ˣ���	
 * �޸����ڣ�	
 * �޸�˵����	
 * -------------------------------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Zkjj.Zgyinggu.Exceptions
{
	/// <summary>
	/// �쳣��Ϣ
	/// </summary>
	internal partial class ExceptionMessage : ExceptionMessageBase
	{ 
		//Do Not Code Here!
	}
	
	/// <summary>
	/// �쳣��Ϣ����
	/// </summary>
	internal class ExceptionMessageBase
	{
		#region	
		

		/// <summary>
		/// Commentδ�ҵ��쳣
		/// </summary>
		internal static string CommentNotFoundMessage = "δ�ҵ�Comment��IdΪ{0}��";

		

		/// <summary>
		/// Subjectδ�ҵ��쳣
		/// </summary>
		internal static string SubjectNotFoundMessage = "δ�ҵ�Subject��SubjectIdΪ{0}��";

		

		/// <summary>
		/// SubjectCategoryδ�ҵ��쳣
		/// </summary>
		internal static string SubjectCategoryNotFoundMessage = "δ�ҵ�SubjectCategory��IdΪ{0}��";

		

		/// <summary>
		/// SubjectInfoδ�ҵ��쳣
		/// </summary>
		internal static string SubjectInfoNotFoundMessage = "δ�ҵ�SubjectInfo��IdΪ{0}��";

		

		/// <summary>
		/// Usersδ�ҵ��쳣
		/// </summary>
		internal static string UsersNotFoundMessage = "δ�ҵ�Users��UserIdΪ{0}��";

		
		#endregion
	}
}

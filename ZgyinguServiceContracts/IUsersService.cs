/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	Users����ӿ�
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
using System.Text;

#if EnableWCF
using System.ServiceModel;
#endif

using Zkjj.Zgyinggu.BusinessEntities;

namespace Zkjj.Zgyinggu.ServiceContracts
{
	/// <summary>
	/// Users�ӿ�
	/// </summary>
	public partial interface IUsersService
	{
		#region ��д
		
		#endregion
	
		#region ��չ
		/*
		/// <summary>
		/// ����ɾ��
		/// </summary>
		/// <param name="usersList">Users�б�</param>
#if EnableWCF
		[OperationContract(Name = "RemoveList")]
#endif
		void Remove(UsersList usersList);
    */
		#endregion
		
	}
}


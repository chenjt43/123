/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	Usersҵ��ʵ��
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

namespace Zkjj.Zgyinggu.BusinessEntities
{
	/// <summary>
	/// Usersҵ��ʵ��
	/// </summary>
	public class UsersEntity
	{
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string UserHeadImg { get; set; }
        public string Email { get; set; }
	}

    public class LoginModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

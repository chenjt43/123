/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	Usersҵ���߼�
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
	/// Usersҵ���߼�
	/// </summary>
	public partial class UsersLogic
	{
		#region ��д
		public void UsersAdd(UsersEntity userEntity)
        {

            Users user = new Users();
            user.DisplayName = userEntity.DisplayName;
            user.Email = userEntity.Email;
            user.UserName = userEntity.UserName;
            user.UserHeadImg = string.IsNullOrEmpty(userEntity.UserHeadImg) ? "" : userEntity.UserHeadImg;
            user.Password = userEntity.Password;
            DalUsers.Add(null, user);
        }


        public UsersEntity UsersLogin(LoginModel login)
        {
            return DalUsers.UsersLogin(login);
        }

        public UsersEntity GetByUserId(int id)
        {
            return DalUsers.GetByUserId(id);
        }

        public bool GetByUserName(string username)
        {
            return DalUsers.GetByUserName(username);
        }
		#endregion
	}
}

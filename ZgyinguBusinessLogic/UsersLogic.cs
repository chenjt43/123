/*
 * -------------------------------------------------------------------------------------------------
 * 版权信息：	中国英谷平台 版权所有 2015
 * 功能描述：	Users业务逻辑
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
	/// Users业务逻辑
	/// </summary>
	public partial class UsersLogic
	{
		#region 重写
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

/*
 * -------------------------------------------------------------------------------------------------
 * 版权信息：	中国英谷平台 版权所有 2015
 * 功能描述：	Users数据访问
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
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;

using Microsoft.ApplicationBlocks.Data;

using Share.Framework;

using Zkjj.Zgyinggu.BusinessEntities;

namespace Zkjj.Zgyinggu.DataAccess.SQLServer
{
	/// <summary>
	/// Users数据访问
	/// </summary>
	public partial class UsersDataAccess
	{
		#region 重写
		
		#endregion
		
		#region 扩展
        public UsersEntity UsersLogin(LoginModel login)
        {
            UsersEntity entity = null;
            string commandTextList = string.Format(@"select * from Users where UserName='{0}' and Password='{1}'", login.UserName.Trim(),login.Password.Trim());
            using (SqlDataReader item = SqlHelper.ExecuteReader(ConnectionString.ZgyinguRead, CommandType.Text, commandTextList))
            {
                if (item.Read())
                {
                    entity=new UsersEntity();
                    entity.UserId=Convert.ToInt32(item["UserId"]);
                    entity.UserName=item["UserName"].ToString();
                    entity.DisplayName=item["DisplayName"].ToString();
                    entity.UserHeadImg=item["UserHeadImg"].ToString();
                    entity.Email = item["Email"]==null?"":(item["Email"].ToString());
                }
            }
            return entity;
        }

        public UsersEntity GetByUserId(int id)
        {
            UsersEntity entity = null;
            string commandTextList = string.Format(@"select * from Users where UserId={0}", id);
            using (SqlDataReader item = SqlHelper.ExecuteReader(ConnectionString.ZgyinguRead, CommandType.Text, commandTextList))
            {
                if (item.Read())
                {
                    entity = new UsersEntity();
                    entity.UserId = Convert.ToInt32(item["UserId"]);
                    entity.UserName = item["UserName"].ToString();
                    entity.DisplayName = item["DisplayName"].ToString();
                    entity.UserHeadImg = item["UserHeadImg"].ToString();
                    entity.Email = item["Email"] == null ? "" : (item["Email"].ToString());
                }
            }
            return entity;
        }

        public bool GetByUserName(string username)
        {
            string commandTextList = string.Format(@"select 1 from Users where UserName='{0}'", username.Trim());
            using (SqlDataReader item = SqlHelper.ExecuteReader(ConnectionString.ZgyinguRead, CommandType.Text, commandTextList))
            {
                if (item.Read())
                {
                    return true;
                }
            }
            return false;
        }


		#endregion
	}
}

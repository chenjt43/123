/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	Users���ݷ���
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
	/// Users���ݷ���
	/// </summary>
	public partial class UsersDataAccess
	{
		#region ��д
		
		#endregion
		
		#region ��չ
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

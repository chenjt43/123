/*
 * -------------------------------------------------------------------------------------------------
 * 版权信息：	中国英谷平台 版权所有 2015
 * 功能描述：	Users业务实体
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
using System.Text;

namespace Zkjj.Zgyinggu.BusinessEntities
{
	/// <summary>
	/// Users业务实体
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

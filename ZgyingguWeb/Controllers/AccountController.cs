using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using ZgyingguWeb.Models;
using ZgyingguWeb.Providers;
using ZgyingguWeb.Results;
using Zkjj.Zgyinggu.BusinessEntities;
using Zkjj.Zgyinggu.BusinessLogic;

namespace ZgyingguWeb.Controllers
{
    
    public class AccountController : ApiController
    {
        public bool GetByUserName(string username)
        {
            return new UsersLogic().GetByUserName(username);
        }

        /// <summary>
        /// 用户登陆函数
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        [HttpPost]
        public UsersEntity PostUser(LoginModel users)
        {
            try
            {
                return new UsersLogic().UsersLogin(users);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

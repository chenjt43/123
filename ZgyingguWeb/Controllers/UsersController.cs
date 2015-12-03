using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zkjj.Zgyinggu.BusinessEntities;
using Zkjj.Zgyinggu.BusinessLogic;

namespace ZgyingguWeb.Controllers
{
    public class UsersController : ApiController
    {

        UsersLogic logic = new UsersLogic();

        public UsersEntity Get(int id)
        {
            return logic.GetByUserId(id);
        }

        [HttpPost]
        public bool PostUsers(UsersEntity users)
        {
            try
            {
                logic.UsersAdd(users);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
         [HttpPost]
        public bool PutUsers(int id, UsersEntity users)
        {
            try
            {
                Users user = logic.GetById(id);
                user.UserHeadImg = users.UserHeadImg;
                logic.Save(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}

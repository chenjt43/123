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
    public class CommentController : ApiController
    {
        [HttpPost]
        public CommentEntity PostComment(CommentEntity commentEntity)
        {
            return new CommentLogic().CommenAdd(commentEntity);
        }

        public List<CommentEntity> Get(int subjectId)
        {
            return new CommentLogic().GetCommentBySubjectId(subjectId);
        }
    }
}

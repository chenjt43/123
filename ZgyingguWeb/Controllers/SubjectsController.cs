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
    public class SubjectsController : ApiController
    {

        SubjectLogic subjectLogic = new SubjectLogic();
        public SubjectEntityList Get(int p, int size, int tab)
        {
            return subjectLogic.GetPagedListAllByConditoin(p, size, tab);
        }

        // GET api/values/5
        public SubjectEntity Get(int id)
        {
            return subjectLogic.GetSubjectEntity(id);
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPost]
        public List<CommentEntity> PutSubjects(string token, int subjectId, string content)
        {
            return null;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zkjj.Zgyinggu.BusinessEntities
{
    public class SubjectEntity
    {
        public int SubjectId { get; set; }
        public int CategoryId { get; set; }
        public string SubjectName { get; set; }

        public int CreatorId { get; set; }

        public string CreateTime { get; set; }
        
        public int DisplayOrder { get; set; }

        public string DisplayName { get; set; }

        public string UserHeadImg { get; set; }

        public int CommentCount { get; set; }


        public List<CommentEntity> Comments { get; set; }

    }

    public class SubjectEntityList
    {
        public List<SubjectEntity> List { get; set; }
        public int TotalCount { get; set; }
    }
}

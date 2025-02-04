/*
 * -------------------------------------------------------------------------------------------------
 * 版权信息：	中国英谷平台 版权所有 2015
 * 功能描述：	Comment业务实体
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
    /// Comment业务实体
    /// </summary>
    public  class CommentEntity
    {
        #region 扩展
        public  int Id { get; set; }
     
        public string CommentContent { get; set; }


        public int SubjectId { get; set; }

        public int CreatorId { get; set; }

        public String CreatorName { get; set; }

        public string CreateTime { get; set; }

        public string UserHeadImg { get; set; }

        public string Token { get; set; }

        #endregion
    }
}

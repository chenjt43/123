/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	Commentҵ��ʵ��
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
using System.Text;

namespace Zkjj.Zgyinggu.BusinessEntities
{
    /// <summary>
    /// Commentҵ��ʵ��
    /// </summary>
    public  class CommentEntity
    {
        #region ��չ
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

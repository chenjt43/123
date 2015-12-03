/*
 * -------------------------------------------------------------------------------------------------
 * 版权信息：	中国英谷平台 版权所有 2015
 * 功能描述：	日志项枚举
 * 
 * 创建人：　	Chenjt
 * 创建日期：	2015/11/17 15:07:32
 * 创建说明：	自动生成代码，允许补充
 * 
 * 修改人：　	
 * 修改日期：	
 * 修改说明：	
 * -------------------------------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Zkjj.Zgyinggu.BusinessLogic.Logging
{
	public enum BizLogEnum
	{
		#region 公共
		DataDebug,
		SystemError,
		#endregion
		
		#region	


		#region Comment
		CommentAdd,
		CommentRemove,
		CommentRemoveList,
		CommentSave,
		#endregion



		#region Subject
		SubjectAdd,
		SubjectRemove,
		SubjectRemoveList,
		SubjectSave,
		#endregion



		#region SubjectCategory
		SubjectCategoryAdd,
		SubjectCategoryRemove,
		SubjectCategoryRemoveList,
		SubjectCategorySave,
		#endregion



		#region SubjectInfo
		SubjectInfoAdd,
		SubjectInfoRemove,
		SubjectInfoRemoveList,
		SubjectInfoSave,
		#endregion



		#region Users
		UsersAdd,
		UsersRemove,
		UsersRemoveList,
		UsersSave,
		#endregion


		#endregion
	}
}

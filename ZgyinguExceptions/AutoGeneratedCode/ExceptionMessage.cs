/*
 * -------------------------------------------------------------------------------------------------
 * 版权信息：	中国英谷平台 版权所有 2015
 * 功能描述：	异常消息
 * 
 * 创建人：　	Chenjt
 * 创建日期：	2015/11/17 15:07:32
 * 创建说明：	自动生成代码，除合并项目外严禁修改
 * 
 * 修改人：　	
 * 修改日期：	
 * 修改说明：	
 * -------------------------------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Zkjj.Zgyinggu.Exceptions
{
	/// <summary>
	/// 异常消息
	/// </summary>
	internal partial class ExceptionMessage : ExceptionMessageBase
	{ 
		//Do Not Code Here!
	}
	
	/// <summary>
	/// 异常消息基类
	/// </summary>
	internal class ExceptionMessageBase
	{
		#region	
		

		/// <summary>
		/// Comment未找到异常
		/// </summary>
		internal static string CommentNotFoundMessage = "未找到Comment：Id为{0}！";

		

		/// <summary>
		/// Subject未找到异常
		/// </summary>
		internal static string SubjectNotFoundMessage = "未找到Subject：SubjectId为{0}！";

		

		/// <summary>
		/// SubjectCategory未找到异常
		/// </summary>
		internal static string SubjectCategoryNotFoundMessage = "未找到SubjectCategory：Id为{0}！";

		

		/// <summary>
		/// SubjectInfo未找到异常
		/// </summary>
		internal static string SubjectInfoNotFoundMessage = "未找到SubjectInfo：Id为{0}！";

		

		/// <summary>
		/// Users未找到异常
		/// </summary>
		internal static string UsersNotFoundMessage = "未找到Users：UserId为{0}！";

		
		#endregion
	}
}

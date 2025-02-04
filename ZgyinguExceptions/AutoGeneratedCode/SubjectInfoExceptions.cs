/*
 * -------------------------------------------------------------------------------------------------
 * 版权信息：	中国英谷平台 版权所有 2015
 * 功能描述：	SubjectInfo未找到异常
 * 
 * 创建人：　	Chenjt
 * 创建日期：	2015/11/17 15:07:31
 * 创建说明：	自动生成代码，严禁修改
 * -------------------------------------------------------------------------------------------------
 * This file is generated by CodeGenerator(Ver 2.2), a product of ZhouYonghua(Zhou_Yonghua@163.com).
 * -------------------------------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.Text;

using System.Globalization;
using System.Runtime.Serialization;

namespace Zkjj.Zgyinggu.Exceptions
{

	#region SubjectInfo未找到异常
	/// <summary>
	/// SubjectInfo未找到异常
	/// </summary>
#if EnableWCF
	[DataContract]
#else
	[Serializable]
#endif
	public class SubjectInfoNotFoundException
#if EnableWCF
	
#else
	: Exception
#endif
	{
		private string _message;
		
		public SubjectInfoNotFoundException()
		{		
		}
		
		/// <summary>
		/// 未找到此数据项的异常
		/// </summary>
		/// <param name="id">Id</param>

		/// <remarks>错误信息见ExceptionMessage.cs文件</remarks>
		public SubjectInfoNotFoundException(Int32 id)
#if EnableWCF
		{
			this._message = string.Format(ExceptionMessage.SubjectInfoNotFoundMessage, id);
		}
#else
			: this(string.Format(ExceptionMessage.SubjectInfoNotFoundMessage, id), null as Exception)
		{		
		}
#endif

#if EnableWCF
		/// <summary>
		/// 异常消息
		/// </summary>
		[DataMember]
		public string Message
		{
			get { return this._message; }
			set { this._message = value; }
		}
#else
		public SubjectInfoNotFoundException(string message, Exception inner)
			: base(message, inner)
		{
		}
		
		protected SubjectInfoNotFoundException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
		}
#endif
	}
	#endregion

}

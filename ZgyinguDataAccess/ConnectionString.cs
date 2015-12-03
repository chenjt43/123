/*
 * -------------------------------------------------------------------------------------------------
 * 版权信息：	中国英谷平台 版权所有 2015
 * 功能描述：	数据连接字符串
 * 
 * 创建人：　	Chenjt
 * 创建日期：	2015/11/17 15:07:32
 * 创建说明：	自动生成代码，允许重写/扩展
 * 
 * 修改人：　	
 * 修改日期：	
 * 修改说明：	
 * -------------------------------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Zkjj.Zgyinggu.DataAccess
{
	public static class ConnectionString
	{
		/// <summary>
		/// 读取连接串
		/// </summary>
		public static string ZgyinguRead = ConfigurationManager.ConnectionStrings["Zgyingu_Read"].ConnectionString;
		/// <summary>
		/// 写入连接串
		/// </summary>
		public static string ZgyinguWrite = ConfigurationManager.ConnectionStrings["Zgyingu_Write"].ConnectionString;
		
		private static string _DBType;
		/// <summary>
		/// 数据库类型（SQLServer/Oracle）
		/// </summary>
		public static string DBType
		{
			get
			{
				if (_DBType == null)
				{
					string provider = ConfigurationManager.ConnectionStrings["Zgyingu_Write"].ProviderName;
					switch (provider)
					{
						case "System.Data.SqlClient":
							_DBType = "SQLServer";
							break;
						case "System.Data.OracleClient":
							_DBType = "Oracle";
							break;
						default:
							throw new NotSupportedException(string.Format("系统不支持{0}数据库类型！", provider));
					}
				}

				return _DBType;
			}
		}
		
		//public string ZgyinguRead
		//{
		//    get { return ConfigurationManager.ConnectionStrings["Zgyingu_Read"].ConnectionString; }
		//}
		
		//public string ZgyinguWrite
		//{
		//    get { return ConfigurationManager.ConnectionStrings["Zgyingu_Write"].ConnectionString; }
		//}

	}
}


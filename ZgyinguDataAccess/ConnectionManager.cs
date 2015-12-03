/*
 * -------------------------------------------------------------------------------------------------
 * 版权信息：	中国英谷平台 版权所有 2015
 * 功能描述：	连接管理器
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
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.OracleClient;
using System.Text;

namespace Zkjj.Zgyinggu.DataAccess
{
	/// <summary>
	/// 连接管理器
	/// </summary>
	public static class ConnectionManager
	{
		/// <summary>
		/// 获取用于写入的连接
		/// </summary>
		/// <param name="openConnection">是否打开连接</param>
		/// <returns>连接</returns>
		public static DbConnection GetConnectionForWrite(bool openConnection)
		{
			DbConnection connection;
			switch (ConnectionString.DBType)
			{
				case "SQLServer":
					connection = new SqlConnection(ConnectionString.ZgyinguWrite);
					break;
				case "Oracle":
					connection = new OracleConnection(ConnectionString.ZgyinguWrite);
					break;
				default:
					throw new NotSupportedException(string.Format("系统不支持{0}数据库类型！", ConnectionString.DBType));
			}

			if (openConnection)
			{
				connection.Open();
			}

			return connection;
		}
		/// <summary>
		/// 获取用于写入的、已打开的连接
		/// </summary>
		/// <returns>连接</returns>
		public static DbConnection GetConnectionForWrite()
		{
			return GetConnectionForWrite(true);
		}
		/// <summary>
		/// 新建连接并开启事务
		/// （使用后务必关闭事务的连接！）
		/// </summary>
		/// <returns>事务</returns>
		public static DbTransaction GetZgyinguTranscation()
		{
			DbConnection connection = GetConnectionForWrite();

			return GetZgyinguTranscation(connection);
		}

		/// <summary>
		/// 传入连接并开启事务
		/// （使用后务必关闭连接！）
		/// </summary>
		/// <param name="connection">连接</param>
		/// <returns>事务</returns>
		public static DbTransaction GetZgyinguTranscation(DbConnection connection)
		{
			DbTransaction transaction = connection.BeginTransaction();
			return transaction;
		}
	}
}


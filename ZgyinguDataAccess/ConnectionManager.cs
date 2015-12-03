/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	���ӹ�����
 * 
 * �����ˣ���	Chenjt
 * �������ڣ�	2015/11/17 15:07:32
 * ����˵����	�Զ����ɴ��룬������д/��չ
 * 
 * �޸��ˣ���	
 * �޸����ڣ�	
 * �޸�˵����	
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
	/// ���ӹ�����
	/// </summary>
	public static class ConnectionManager
	{
		/// <summary>
		/// ��ȡ����д�������
		/// </summary>
		/// <param name="openConnection">�Ƿ������</param>
		/// <returns>����</returns>
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
					throw new NotSupportedException(string.Format("ϵͳ��֧��{0}���ݿ����ͣ�", ConnectionString.DBType));
			}

			if (openConnection)
			{
				connection.Open();
			}

			return connection;
		}
		/// <summary>
		/// ��ȡ����д��ġ��Ѵ򿪵�����
		/// </summary>
		/// <returns>����</returns>
		public static DbConnection GetConnectionForWrite()
		{
			return GetConnectionForWrite(true);
		}
		/// <summary>
		/// �½����Ӳ���������
		/// ��ʹ�ú���عر���������ӣ���
		/// </summary>
		/// <returns>����</returns>
		public static DbTransaction GetZgyinguTranscation()
		{
			DbConnection connection = GetConnectionForWrite();

			return GetZgyinguTranscation(connection);
		}

		/// <summary>
		/// �������Ӳ���������
		/// ��ʹ�ú���عر����ӣ���
		/// </summary>
		/// <param name="connection">����</param>
		/// <returns>����</returns>
		public static DbTransaction GetZgyinguTranscation(DbConnection connection)
		{
			DbTransaction transaction = connection.BeginTransaction();
			return transaction;
		}
	}
}


/*
 * -------------------------------------------------------------------------------------------------
 * ��Ȩ��Ϣ��	�й�Ӣ��ƽ̨ ��Ȩ���� 2015
 * ����������	���������ַ���
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
using System.Configuration;
using System.Text;

namespace Zkjj.Zgyinggu.DataAccess
{
	public static class ConnectionString
	{
		/// <summary>
		/// ��ȡ���Ӵ�
		/// </summary>
		public static string ZgyinguRead = ConfigurationManager.ConnectionStrings["Zgyingu_Read"].ConnectionString;
		/// <summary>
		/// д�����Ӵ�
		/// </summary>
		public static string ZgyinguWrite = ConfigurationManager.ConnectionStrings["Zgyingu_Write"].ConnectionString;
		
		private static string _DBType;
		/// <summary>
		/// ���ݿ����ͣ�SQLServer/Oracle��
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
							throw new NotSupportedException(string.Format("ϵͳ��֧��{0}���ݿ����ͣ�", provider));
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


using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

using Share.Framework;

using Zkjj.Zgyinggu.DataAccess;
using Zkjj.Zgyinggu.DataAccess.Interface;

namespace Zkjj.Zgyinggu.DataAccess
{
	public sealed class DalFactory
	{
		#region	

		/// <summary>
		/// ����Comment���ݷ��ʶ���
		/// </summary>
		public static ICommentDataAccess CreateComment()
		{
			string typeName = string.Format("Zkjj.Zgyinggu.DataAccess.{0}.CommentDataAccess, Zkjj.Zgyinggu.DataAccess", ConnectionString.DBType);
			return (ICommentDataAccess)ReflectionUtility.CreateInstance(typeName);
		}

		/// <summary>
		/// ����Subject���ݷ��ʶ���
		/// </summary>
		public static ISubjectDataAccess CreateSubject()
		{
			string typeName = string.Format("Zkjj.Zgyinggu.DataAccess.{0}.SubjectDataAccess, Zkjj.Zgyinggu.DataAccess", ConnectionString.DBType);
			return (ISubjectDataAccess)ReflectionUtility.CreateInstance(typeName);
		}

		/// <summary>
		/// ����SubjectCategory���ݷ��ʶ���
		/// </summary>
		public static ISubjectCategoryDataAccess CreateSubjectCategory()
		{
			string typeName = string.Format("Zkjj.Zgyinggu.DataAccess.{0}.SubjectCategoryDataAccess, Zkjj.Zgyinggu.DataAccess", ConnectionString.DBType);
			return (ISubjectCategoryDataAccess)ReflectionUtility.CreateInstance(typeName);
		}

		/// <summary>
		/// ����SubjectInfo���ݷ��ʶ���
		/// </summary>
		public static ISubjectInfoDataAccess CreateSubjectInfo()
		{
			string typeName = string.Format("Zkjj.Zgyinggu.DataAccess.{0}.SubjectInfoDataAccess, Zkjj.Zgyinggu.DataAccess", ConnectionString.DBType);
			return (ISubjectInfoDataAccess)ReflectionUtility.CreateInstance(typeName);
		}

		/// <summary>
		/// ����Users���ݷ��ʶ���
		/// </summary>
		public static IUsersDataAccess CreateUsers()
		{
			string typeName = string.Format("Zkjj.Zgyinggu.DataAccess.{0}.UsersDataAccess, Zkjj.Zgyinggu.DataAccess", ConnectionString.DBType);
			return (IUsersDataAccess)ReflectionUtility.CreateInstance(typeName);
		}

		#endregion
	}
}


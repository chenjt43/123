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
		/// 创建Comment数据访问对象
		/// </summary>
		public static ICommentDataAccess CreateComment()
		{
			string typeName = string.Format("Zkjj.Zgyinggu.DataAccess.{0}.CommentDataAccess, Zkjj.Zgyinggu.DataAccess", ConnectionString.DBType);
			return (ICommentDataAccess)ReflectionUtility.CreateInstance(typeName);
		}

		/// <summary>
		/// 创建Subject数据访问对象
		/// </summary>
		public static ISubjectDataAccess CreateSubject()
		{
			string typeName = string.Format("Zkjj.Zgyinggu.DataAccess.{0}.SubjectDataAccess, Zkjj.Zgyinggu.DataAccess", ConnectionString.DBType);
			return (ISubjectDataAccess)ReflectionUtility.CreateInstance(typeName);
		}

		/// <summary>
		/// 创建SubjectCategory数据访问对象
		/// </summary>
		public static ISubjectCategoryDataAccess CreateSubjectCategory()
		{
			string typeName = string.Format("Zkjj.Zgyinggu.DataAccess.{0}.SubjectCategoryDataAccess, Zkjj.Zgyinggu.DataAccess", ConnectionString.DBType);
			return (ISubjectCategoryDataAccess)ReflectionUtility.CreateInstance(typeName);
		}

		/// <summary>
		/// 创建SubjectInfo数据访问对象
		/// </summary>
		public static ISubjectInfoDataAccess CreateSubjectInfo()
		{
			string typeName = string.Format("Zkjj.Zgyinggu.DataAccess.{0}.SubjectInfoDataAccess, Zkjj.Zgyinggu.DataAccess", ConnectionString.DBType);
			return (ISubjectInfoDataAccess)ReflectionUtility.CreateInstance(typeName);
		}

		/// <summary>
		/// 创建Users数据访问对象
		/// </summary>
		public static IUsersDataAccess CreateUsers()
		{
			string typeName = string.Format("Zkjj.Zgyinggu.DataAccess.{0}.UsersDataAccess, Zkjj.Zgyinggu.DataAccess", ConnectionString.DBType);
			return (IUsersDataAccess)ReflectionUtility.CreateInstance(typeName);
		}

		#endregion
	}
}


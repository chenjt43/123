/*
 * -------------------------------------------------------------------------------------------------
 * 版权信息：	中国英谷平台 版权所有 2015
 * 功能描述：	Subject业务逻辑
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
using System.Data.Common;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

#if EnableWCF
using System.ServiceModel;
#endif
#if EnableDTC
using System.Transactions;
#endif

using Share.Framework;
using Share.Framework.Caching;
using Share.Framework.Logging;

using Zkjj.Zgyinggu.BusinessEntities;
using Zkjj.Zgyinggu.BusinessLogic.Caching;
using Zkjj.Zgyinggu.BusinessLogic.Logging;
using Zkjj.Zgyinggu.DataAccess;
using Zkjj.Zgyinggu.DataAccess;
#if EnableIDAL
using Zkjj.Zgyinggu.DataAccess.Interface;
#else
using Zkjj.Zgyinggu.DataAccess.SQLServer;
#endif
using Zkjj.Zgyinggu.Exceptions;
#if EnableWCF || EnableServiceContracts
using Zkjj.Zgyinggu.ServiceContracts;
#endif



namespace Zkjj.Zgyinggu.BusinessLogic
{
	/// <summary>
	/// Subject业务逻辑
	/// </summary>
	[System.ComponentModel.DataObject]
	public partial class SubjectLogic : SubjectLogicBase
#if EnableWCF || EnableServiceContracts
		, ISubjectService
#endif
	{
		//Do Not Code Here!
	}
	
	/// <summary>
	/// Subject业务逻辑基类
	/// </summary>
	public abstract class SubjectLogicBase
	{
#if EnableIDAL
		protected static readonly ISubjectDataAccess DalSubject = DalFactory.CreateSubject();//数据访问对象
#else
		protected static readonly SubjectDataAccess DalSubject = new SubjectDataAccess();//数据访问对象
#endif
		protected int _TotalRecords;//记录总数

		#region 缓存
		/// <summary>
		/// 移除根据标识获取Subject对象的缓存
		/// </summary>
		/// <param name="subjectId">SubjectId</param>
		protected internal virtual void RemoveGetByIdCache(Int32 subjectId)
		{
			CacheHelper.Remove(BizCacheEnum.SubjectGetById.ToString(), new string[] {subjectId.ToString()}, true);
		}
		#endregion
		
		/// <summary>
		/// 增加
		/// </summary>
		/// <param name="transaction">事务</param>
		/// <param name="needLog">是否记录日志</param>
		/// <param name="subject">Subject</param>
		internal virtual void Add(DbTransaction transaction, bool needLog, Subject subject)
		{
			DalSubject.Add(transaction, subject);
			
			if(needLog)
			{
				LogHelper.Instance().WriteBusinessLog(
					BizLogEnum.SubjectAdd.ToString(),
					new StringBuilder().Append("SubjectId: ").Append(subject.SubjectId.ToString()).ToString(),
					"增加Subject");
			}
		}
		
		/// <summary>
		/// 增加
		/// </summary>
		/// <param name="subject">Subject</param>
		public virtual void Add(Subject subject)
		{
			Add(null, true, subject);
		}

		/// <summary>
		/// 删除
		/// </summary>
		/// <param name="transaction">事务</param>
		/// <param name="needLog">是否记录日志</param>
		/// <param name="subjectId">SubjectId</param>
		internal virtual void Remove(DbTransaction transaction, bool needLog, Int32 subjectId)
		{
			DalSubject.Remove(transaction, subjectId);
			RemoveGetByIdCache(subjectId);
			
			if(needLog)
			{
				LogHelper.Instance().WriteBusinessLog(
					BizLogEnum.SubjectRemove.ToString(),
					new StringBuilder().Append("SubjectId: ").Append(subjectId.ToString()).ToString(),
					"删除Subject");
			}
		}
		
		/// <summary>
		/// 删除
		/// </summary>
		/// <param name="subjectId">SubjectId</param>
		public virtual void Remove(Int32 subjectId)
		{
			Remove(null, true, subjectId);
		}

		/// <summary>
		/// 删除
		/// </summary>
		/// <param name="transaction">事务</param>
		/// <param name="needLog">是否记录日志</param>
		/// <param name="subject">Subject</param>
		internal virtual void Remove(DbTransaction transaction, bool needLog, Subject subject)
		{
			Remove(transaction, needLog, subject.SubjectId);
		}
		
		/// <summary>
		/// 删除
		/// </summary>
		/// <param name="subject">Subject</param>
		public virtual void Remove(Subject subject)
		{
			Remove(null, true, subject);
		}
		    
		/// <summary>
		/// 保存
		/// </summary>
		/// <param name="transaction">事务</param>
		/// <param name="needLog">是否记录日志</param>
		/// <param name="subject">Subject</param>
		internal virtual void Save(DbTransaction transaction, bool needLog, Subject subject)
		{
			DalSubject.Save(transaction, subject);
			RemoveGetByIdCache(subject.SubjectId);
			
			if(needLog)
			{
				LogHelper.Instance().WriteBusinessLog(
					BizLogEnum.SubjectSave.ToString(),
					new StringBuilder().Append("SubjectId: ").Append(subject.SubjectId.ToString()).ToString(),
					"保存Subject");
			}
		}

		/// <summary>
		/// 保存
		/// </summary>
		/// <param name="subject">Subject</param>
		public virtual void Save(Subject subject)
		{
			Save(null, true, subject);
		}
		
#if GetNewId
		/// <summary>
		/// 获取新ID（序列）
		/// </summary>
		/// <returns>新ID</returns>
		public virtual decimal GetNewId()
		{
			return DalSubject.GetNewId();
		}
#endif
    
		/// <summary>
		/// 根据标识获取Subject对象（如果没有满足条件的记录，抛出异常）
		/// </summary>
		/// <param name="subjectId">SubjectId</param>
		/// <returns>Subject</returns>
		public virtual Subject GetById(Int32 subjectId)
		{
			return GetById(subjectId, true);
		}	
		
		/// <summary>
		/// 根据标识获取Subject对象
		/// </summary>
		/// <param name="subjectId">SubjectId</param>
		/// <param name="throwNotFoundException">如果没有满足条件的记录是否抛出异常</param>
		/// <returns>Subject</returns>
		public virtual Subject GetById(Int32 subjectId, bool throwNotFoundException)
		{
			Subject subject = CacheHelper.Get<Subject, Int32>(
				BizCacheEnum.SubjectGetById.ToString(),
				subjectId,
				new CacheMissedGetDataHandler<Subject, Int32>(DalSubject.GetById)
				);
			
			if (throwNotFoundException && subject == null)
			{
				SubjectNotFoundException subjectNotFoundException = new SubjectNotFoundException(subjectId);
#if EnableWCF
				throw new FaultException<SubjectNotFoundException>(subjectNotFoundException, subjectNotFoundException.Message);
#else
				throw subjectNotFoundException;
#endif
			}
			
			return subject;
		}		

		/// <summary>
		/// 获取所有Subject对象列表（分页，可排序）
		/// </summary>
		/// <param name="startRowIndex">起始记录号</param>
		/// <param name="maximumRows">行数</param>
		/// <param name="sortExpression">排序表达式</param>
		/// <returns>Subject列表</returns>
		public virtual SubjectList GetPagedListAll(int startRowIndex, int maximumRows, string sortExpression)
		{
			SubjectList subjectList = DalSubject.GetPagedListAll(startRowIndex, maximumRows, sortExpression, out _TotalRecords);
			
			return subjectList;
		}
		
		/// <summary>
		/// 获取所有Subject对象记录总数
		/// </summary>
		/// <param name="startRowIndex">起始记录号</param>
		/// <param name="maximumRows">行数</param>
		/// <param name="sortExpression">排序表达式</param>
		/// <returns>Subject记录总数</returns>
		public virtual int GetRowCountAll(int startRowIndex, int maximumRows, string sortExpression)
		{
			return _TotalRecords;
		}

#if GetPagedListByCriteria
		/// <summary>
		/// 根据条件获取Subject对象列表（分页，可排序）
		/// </summary>
		/// <param name="startRowIndex">起始记录号</param>
		/// <param name="maximumRows">行数</param>
		/// <param name="sortExpression">排序表达式</param>
		/// <param name="criteria">查询条件(以And开头)</param>
		/// <returns>Subject列表</returns>
		internal virtual SubjectList GetPagedListByCriteria(int startRowIndex, int maximumRows, string sortExpression, string criteria)
		{
			SubjectList subjectList = DalSubject.GetPagedListByCriteria(startRowIndex, maximumRows, sortExpression, criteria, out _TotalRecords);
			
			return subjectList;
		}
		
		/// <summary>
		/// 根据条件获取Subject对象记录总数
		/// </summary>
		/// <param name="startRowIndex">起始记录号</param>
		/// <param name="maximumRows">行数</param>
		/// <param name="sortExpression">排序表达式</param>
		/// <param name="criteria">查询条件(以And开头)</param>
		/// <returns>Subject记录总数</returns>
		internal virtual int GetRowCountByCriteria(int startRowIndex, int maximumRows, string sortExpression, string criteria)
		{
			return _TotalRecords;
		}
#endif
	}	
}


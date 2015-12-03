using System;
using System.Collections.Generic;
using System.Text;

namespace Zkjj.Zgyinggu.BusinessLogic.Caching
{
	/// <summary>
	/// 业务缓存项枚举
	/// </summary>
	public enum BizCacheEnum
	{
		/*
		* 增加业务缓存项后请配置~/BizCache.config
		* */
		#region	
		//只有采用普通代码模板的才需要合并以下代码


		/// <summary>
		/// Comment GetById
		/// </summary>
		CommentGetById,



		/// <summary>
		/// Subject GetById
		/// </summary>
		SubjectGetById,



		/// <summary>
		/// SubjectCategory GetById
		/// </summary>
		SubjectCategoryGetById,



		/// <summary>
		/// SubjectInfo GetById
		/// </summary>
		SubjectInfoGetById,



		/// <summary>
		/// Users GetById
		/// </summary>
		UsersGetById,



		//只有采用Dictionary代码模板的才需要合并以下代码

		/// <summary>
		/// Comment ListAll
		/// </summary>
		CommentListAll,		

		/// <summary>
		/// Subject ListAll
		/// </summary>
		SubjectListAll,		

		/// <summary>
		/// SubjectCategory ListAll
		/// </summary>
		SubjectCategoryListAll,		

		/// <summary>
		/// SubjectInfo ListAll
		/// </summary>
		SubjectInfoListAll,		

		/// <summary>
		/// Users ListAll
		/// </summary>
		UsersListAll,		

		#endregion
	}
}


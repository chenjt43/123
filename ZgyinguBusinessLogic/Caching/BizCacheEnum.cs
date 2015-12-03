using System;
using System.Collections.Generic;
using System.Text;

namespace Zkjj.Zgyinggu.BusinessLogic.Caching
{
	/// <summary>
	/// ҵ�񻺴���ö��
	/// </summary>
	public enum BizCacheEnum
	{
		/*
		* ����ҵ�񻺴����������~/BizCache.config
		* */
		#region	
		//ֻ�в�����ͨ����ģ��Ĳ���Ҫ�ϲ����´���


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



		//ֻ�в���Dictionary����ģ��Ĳ���Ҫ�ϲ����´���

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


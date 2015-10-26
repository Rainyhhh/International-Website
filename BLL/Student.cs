using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using Interwebsite.Model;
namespace Interwebsite.BLL
{
	/// <summary>
	/// Student
	/// </summary>
	public partial class Student
	{
		private readonly Interwebsite.DAL.Student dal=new Interwebsite.DAL.Student();
		public Student()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Interwebsite.Model.Student model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Interwebsite.Model.Student model)
		{
			return dal.Update(model);
		}
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool AddandUpdate(Interwebsite.Model.Student model)
        {
            return dal.AddandUpdate(model);
        }


		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.Delete();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Interwebsite.Model.Student GetModel(string username)
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel(username);
		}


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Interwebsite.Model.Student GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.GetModel();
        }

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Interwebsite.Model.Student GetModelByCache()
		{
			//该表无主键信息，请自定义主键/条件字段
			string CacheKey = "StudentModel-" ;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel();
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Interwebsite.Model.Student)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Interwebsite.Model.Student> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Interwebsite.Model.Student> DataTableToList(DataTable dt)
		{
			List<Interwebsite.Model.Student> modelList = new List<Interwebsite.Model.Student>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Interwebsite.Model.Student model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod
        public DataSet GetListApply()
        {
            return dal.GetListApply("");
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public bool GetModel(String username, String password)
        {
            //该表无主键信息，请自定义主键/条件字段
            if ((dal.GetModel(username, password)).Tables[0].Rows.Count > 0)
                return true;
            else return false;

        }


        /// <summary>
        /// 检查用户名是否存在
        /// </summary>
        public bool checkUsername(String username)
        {
            if (dal.getUsername(username).Tables[0].Rows.Count > 0)
                return true;
            else return false;
        }

       
		#endregion  ExtensionMethod
	}
}


using System;
using System.Data;
using System.Collections.Generic;
using Interwebsite.Model;
namespace Interwebsite.BLL
{
	/// <summary>
	/// Project
	/// </summary>
	public partial class Project
	{
		private readonly Interwebsite.DAL.Project dal=new Interwebsite.DAL.Project();
		public Project()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Interwebsite.Model.Project model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Interwebsite.Model.Project model)
		{
			return dal.Update(model);
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
		public DataSet GetModel(int id)
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel(id);
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
		public List<Interwebsite.Model.Project> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Interwebsite.Model.Project> DataTableToList(DataTable dt)
		{
			List<Interwebsite.Model.Project> modelList = new List<Interwebsite.Model.Project>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Interwebsite.Model.Project model;
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
        public DataSet GetListByPage(int pageSize, int curPage)
		{
			return dal.GetListByPage(pageSize, curPage);
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
        /// <summary>
        /// 获取前几行数据
        /// </summary>
        public DataSet GetTitleList(int top)
        {
            return dal.GetTitleList(top);
        }

		#endregion  ExtensionMethod

        public Model.Project GetModel()
        {
            throw new NotImplementedException();
        }
    }
}


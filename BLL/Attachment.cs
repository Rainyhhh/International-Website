using System;
using System.Data;
using System.Collections.Generic;
using Interwebsite.Model;
using Interwebsite.DAL;
using Interwebsite.Common;
namespace Interwebsite.BLL
{
	/// <summary>
	/// Attachment
	/// </summary>
	public partial class Attachment
	{
		private readonly Interwebsite.DAL.Attachment dal=new Interwebsite.DAL.Attachment();
		public Attachment()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Interwebsite.Model.Attachment model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Interwebsite.Model.Attachment model)
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
		public Interwebsite.Model.Attachment GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Interwebsite.Model.Attachment> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Interwebsite.Model.Attachment> DataTableToList(DataTable dt)
		{
			List<Interwebsite.Model.Attachment> modelList = new List<Interwebsite.Model.Attachment>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Interwebsite.Model.Attachment model;
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
		/// 获取总数
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

        public void Download(string filename, string path)
        {
            DownloadHelper d = new DownloadHelper();
            d.Download2(filename, path);
        }


		#endregion  BasicMethod
		#region  ExtensionMethod
        public DataSet getTitleList(int top)
        {
            return dal.GetTitleList(top);
        }

		#endregion  ExtensionMethod
	}
}


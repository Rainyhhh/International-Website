using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Interwebsite.DAL;
using System.Data.SqlClient;

namespace Interwebsite.BLL
{
    public class Announcement
    {
        private readonly DAL.Announcement dal = new DAL.Announcement();

        public Announcement()
        { }
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Interwebsite.Model.Announcement model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Interwebsite.Model.Announcement model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {
            //该表无主键信息，请自定义主键/条件字段
            return dal.Delete(ID);
        }
        ///<summary>
        /// 获取前几行
        ///</summary>
        public DataSet GetTitleList(int top)
        {
            return dal.GetTitleList(top);
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
            return dal.GetListByPage(pageSize,curPage);
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

        #endregion  ExtensionMethod

        public DataSet GetList(string p)
        {
            return dal.GetListManager(p);
        }

        public DataSet GetAllList()
        {
            return dal.GetList2("");
        }

        public Model.Announcement GetModel()
        {
            throw new NotImplementedException();
        }


     
    }
}

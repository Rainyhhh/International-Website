using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Interwebsite.DAL;
using Interwebsite.Common;
using Maticsoft.DBUtility;

namespace Interwebsite.DAL
{
    public class Announcement
    {
        public bool Add(Interwebsite.Model.Announcement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Announcement(");
			strSql.Append("AnnouncementName,AnnouncementInfo,Author,CreateTime,ModifyTime)");
			strSql.Append(" values (");
			strSql.Append("@AnnouncementName,@AnnouncementInfo,@Author,@CreateTime,@ModifyTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@AnnouncementName", SqlDbType.NVarChar,100),
					new SqlParameter("@AnnouncementInfo", SqlDbType.Text,16),
					new SqlParameter("@Author", SqlDbType.NVarChar,20),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@ModifyTime", SqlDbType.DateTime)};
			parameters[0].Value = model.AnnouncementName;
			parameters[1].Value = model.AnnouncementInfo;
			parameters[2].Value = model.Author;
			parameters[3].Value = model.CreateTime;
			parameters[4].Value = model.ModifyTime;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Interwebsite.Model.Announcement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Announcement set ");
			strSql.Append("ID=@ID,");
			strSql.Append("AnnouncementName=@AnnouncementName,");
			strSql.Append("AnnouncementInfo=@AnnouncementInfo,");
			strSql.Append("Author=@Author,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("ModifyTime=@ModifyTime");
			strSql.Append(" where ");
            strSql.Append("ID='"+model.ID+"'");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@AnnouncementName", SqlDbType.NVarChar,100),
					new SqlParameter("@AnnouncementInfo", SqlDbType.Text,16),
					new SqlParameter("@Author", SqlDbType.NVarChar,20),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@ModifyTime", SqlDbType.DateTime)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.AnnouncementName;
			parameters[2].Value = model.AnnouncementInfo;
			parameters[3].Value = model.Author;
			parameters[4].Value = model.CreateTime;
			parameters[5].Value = model.ModifyTime;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Announcement ");
			strSql.Append(" where ");
            strSql.Append("ID=" + ID);
			SqlParameter[] parameters = {
			};

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public DataSet GetModel(int ID)
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,AnnouncementName,AnnouncementInfo,Author,ModifyTime from Announcement ");
			strSql.Append(" where id=" + ID);
			SqlParameter[] parameters = {
			};

			Interwebsite.Model.Announcement model=new Interwebsite.Model.Announcement();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
                return ds; ;
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Interwebsite.Model.Announcement DataRowToModel(DataRow row)
		{
			Interwebsite.Model.Announcement model=new Interwebsite.Model.Announcement();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["AnnouncementName"]!=null)
				{
					model.AnnouncementName=row["AnnouncementName"].ToString();
				}
				if(row["AnnouncementInfo"]!=null)
				{
					model.AnnouncementInfo=row["AnnouncementInfo"].ToString();
				}
				if(row["Author"]!=null)
				{
					model.Author=row["Author"].ToString();
				}
				//if(row["CreateTime"]!=null && row["CreateTime"].ToString()!="")
				//{
				//	model.CreateTime=DateTime.Parse(row["CreateTime"].ToString());
				//}
				if(row["ModifyTime"]!=null && row["ModifyTime"].ToString()!="")
				{
					model.ModifyTime=DateTime.Parse(row["ModifyTime"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,AnnouncementName,AnnouncementInfo,Author,CreateTime,ModifyTime ");
			strSql.Append(" FROM Announcement ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList2(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,AnnouncementName as 公告名称,Author as 作者,CreateTime as 创建时间,ModifyTime as 修改时间");
            strSql.Append(" FROM Announcement ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        
		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Announcement ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
        public DataSet GetListByPage(int pageSize, int curPage)
        {
            string sql = "select top " + pageSize + " ID,AnnouncementName,modifyTime FROM Announcement where id not in(select top " + (curPage - 1) * pageSize + " id FROM Announcement order by id DESC) order by id DESC";
            DataSet ds = DbHelperSQL.Query(sql.ToString());
            return ds;
        }
		//public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		//{
		//	StringBuilder strSql=new StringBuilder();
		//	strSql.Append("SELECT ID,announcementname,modifytime FROM ( ");
		//	strSql.Append(" SELECT ROW_NUMBER() OVER (");
		//	if (!string.IsNullOrEmpty(orderby.Trim()))
		//	{
		//		strSql.Append("order by T." + orderby );
		//	}
		//	else
		//	{
		//		strSql.Append("order by T. desc");
		//	}
		//	strSql.Append(")AS Row, T.*  from Announcement T ");
		//	if (!string.IsNullOrEmpty(strWhere.Trim()))
		//	{
		//		strSql.Append(" WHERE " + strWhere);
		//	}
		//	strSql.Append(" ) TT");
		//	strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
		//	return DbHelperSQL.Query(strSql.ToString());
		//}
		
        //获取前几行数据
        public DataSet GetTitleList(int top)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (top > 0)
            {
                strSql.Append(" top " + top.ToString());
            }
            strSql.Append(" ID,announcementname,modifytime ");
            strSql.Append(" FROM announcement ");
            strSql.Append(" order by id desc");
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表,没有具体的内容
        /// </summary>
        public DataSet GetListManager(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,AnnouncementName as 公告名称,Author as 作者,CreateTime as 创建时间,ModifyTime as 修改时间");
            strSql.Append(" FROM Announcement ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
    }

	
}

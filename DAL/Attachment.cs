using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Interwebsite.DAL
{
	/// <summary>
	/// 数据访问类:Attachment
	/// </summary>
	public partial class Attachment
	{
		public Attachment()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Interwebsite.Model.Attachment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Attachment(");
			strSql.Append("ID,AttachmentName,UploadName,UploadTime,AttachmentAddress)");
			strSql.Append(" values (");
			strSql.Append("@ID,@AttachmentName,@UploadName,@UploadTime,@AttachmentAddress)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@AttachmentName", SqlDbType.NVarChar,100),
					new SqlParameter("@UploadName", SqlDbType.NVarChar,50),
					new SqlParameter("@UploadTime", SqlDbType.DateTime),
					new SqlParameter("@AttachmentAddress", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.AttachmentName;
			parameters[2].Value = model.UploadName;
			parameters[3].Value = model.UploadTime;
			parameters[4].Value = model.AttachmentAddress;

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
		public bool Update(Interwebsite.Model.Attachment model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Attachment set ");
			strSql.Append("ID=@ID,");
			strSql.Append("AttachmentName=@AttachmentName,");
			strSql.Append("UploadName=@UploadName,");
			strSql.Append("UploadTime=@UploadTime,");
			strSql.Append("AttachmentAddress=@AttachmentAddress");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@AttachmentName", SqlDbType.NVarChar,100),
					new SqlParameter("@UploadName", SqlDbType.NVarChar,50),
					new SqlParameter("@UploadTime", SqlDbType.DateTime),
					new SqlParameter("@AttachmentAddress", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.AttachmentName;
			parameters[2].Value = model.UploadName;
			parameters[3].Value = model.UploadTime;
			parameters[4].Value = model.AttachmentAddress;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Attachment ");
			strSql.Append(" where ");
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
		public Interwebsite.Model.Attachment GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,AttachmentName,UploadName,UploadTime,AttachmentAddress from Attachment ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Interwebsite.Model.Attachment model=new Interwebsite.Model.Attachment();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Interwebsite.Model.Attachment DataRowToModel(DataRow row)
		{
			Interwebsite.Model.Attachment model=new Interwebsite.Model.Attachment();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["AttachmentName"]!=null)
				{
					model.AttachmentName=row["AttachmentName"].ToString();
				}
				if(row["UploadName"]!=null)
				{
					model.UploadName=row["UploadName"].ToString();
				}
				if(row["UploadTime"]!=null && row["UploadTime"].ToString()!="")
				{
					model.UploadTime=DateTime.Parse(row["UploadTime"].ToString());
				}
				if(row["AttachmentAddress"]!=null)
				{
					model.AttachmentAddress=row["AttachmentAddress"].ToString();
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
			strSql.Append("select ID,AttachmentName,UploadName,UploadTime,AttachmentAddress ");
			strSql.Append(" FROM Attachment ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,AttachmentName,UploadName,UploadTime,AttachmentAddress ");
			strSql.Append(" FROM Attachment ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Attachment ");
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
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from Attachment T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Attachment";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod

        public DataSet GetListByPage(int pageSize, int curPage)
        {
            string sql = "select top " + pageSize + " ID,AttachmentName,uploadTime,attachmentaddress FROM Attachment where id not in(select top " + (curPage - 1) * pageSize + " id FROM Attachment order by uploadTime DESC) order by uploadTime DESC";
            DataSet ds = DbHelperSQL.Query(sql.ToString());
            return ds;
        }

        public DataSet GetTitleList(int top)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (top > 0)
            {
                strSql.Append(" top " + top.ToString());
            }
            strSql.Append(" ID,attachmentname ");
            strSql.Append(" FROM attachment ");
            strSql.Append(" order by id desc");
            return DbHelperSQL.Query(strSql.ToString());
        }
    }
}


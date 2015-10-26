using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Interwebsite.DAL
{
	/// <summary>
	/// 数据访问类:School
	/// </summary>
	public partial class School
	{
		public School()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Interwebsite.Model.School model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into School(");
			strSql.Append("ID,SchoolName,Nation,Linkman,LinkAddress,Email,LinkPhone,SchoolInfo,CreateTime,ModifyTime)");
			strSql.Append(" values (");
			strSql.Append("@ID,@SchoolName,@Nation,@Linkman,@LinkAddress,@Email,@LinkPhone,@SchoolInfo,@CreateTime,@ModifyTime)");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@SchoolName", SqlDbType.NVarChar,50),
					new SqlParameter("@Nation", SqlDbType.NVarChar,50),
					new SqlParameter("@Linkman", SqlDbType.NVarChar,50),
					new SqlParameter("@LinkAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@LinkPhone", SqlDbType.Int,4),
					new SqlParameter("@SchoolInfo", SqlDbType.NVarChar,2000),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@ModifyTime", SqlDbType.DateTime)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.SchoolName;
			parameters[2].Value = model.Nation;
			parameters[3].Value = model.Linkman;
			parameters[4].Value = model.LinkAddress;
			parameters[5].Value = model.Email;
			parameters[6].Value = model.LinkPhone;
			parameters[7].Value = model.SchoolInfo;
			parameters[8].Value = model.CreateTime;
			parameters[9].Value = model.ModifyTime;

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
		public bool Update(Interwebsite.Model.School model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update School set ");
			strSql.Append("ID=@ID,");
			strSql.Append("SchoolName=@SchoolName,");
			strSql.Append("Nation=@Nation,");
			strSql.Append("Linkman=@Linkman,");
			strSql.Append("LinkAddress=@LinkAddress,");
			strSql.Append("Email=@Email,");
			strSql.Append("LinkPhone=@LinkPhone,");
			strSql.Append("SchoolInfo=@SchoolInfo,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("ModifyTime=@ModifyTime");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@SchoolName", SqlDbType.NVarChar,50),
					new SqlParameter("@Nation", SqlDbType.NVarChar,50),
					new SqlParameter("@Linkman", SqlDbType.NVarChar,50),
					new SqlParameter("@LinkAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@LinkPhone", SqlDbType.Int,4),
					new SqlParameter("@SchoolInfo", SqlDbType.NVarChar,2000),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@ModifyTime", SqlDbType.DateTime)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.SchoolName;
			parameters[2].Value = model.Nation;
			parameters[3].Value = model.Linkman;
			parameters[4].Value = model.LinkAddress;
			parameters[5].Value = model.Email;
			parameters[6].Value = model.LinkPhone;
			parameters[7].Value = model.SchoolInfo;
			parameters[8].Value = model.CreateTime;
			parameters[9].Value = model.ModifyTime;

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
			strSql.Append("delete from School ");
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
		public Interwebsite.Model.School GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,SchoolName,Nation,Linkman,LinkAddress,Email,LinkPhone,SchoolInfo,CreateTime,ModifyTime from School ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Interwebsite.Model.School model=new Interwebsite.Model.School();
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
		public Interwebsite.Model.School DataRowToModel(DataRow row)
		{
			Interwebsite.Model.School model=new Interwebsite.Model.School();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["SchoolName"]!=null)
				{
					model.SchoolName=row["SchoolName"].ToString();
				}
				if(row["Nation"]!=null)
				{
					model.Nation=row["Nation"].ToString();
				}
				if(row["Linkman"]!=null)
				{
					model.Linkman=row["Linkman"].ToString();
				}
				if(row["LinkAddress"]!=null)
				{
					model.LinkAddress=row["LinkAddress"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["LinkPhone"]!=null && row["LinkPhone"].ToString()!="")
				{
					model.LinkPhone=int.Parse(row["LinkPhone"].ToString());
				}
				if(row["SchoolInfo"]!=null)
				{
					model.SchoolInfo=row["SchoolInfo"].ToString();
				}
				if(row["CreateTime"]!=null && row["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(row["CreateTime"].ToString());
				}
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
			strSql.Append("select ID,SchoolName,Nation,Linkman,LinkAddress,Email,LinkPhone,SchoolInfo,CreateTime,ModifyTime ");
			strSql.Append(" FROM School ");
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
			strSql.Append(" ID,SchoolName,Nation,Linkman,LinkAddress,Email,LinkPhone,SchoolInfo,CreateTime,ModifyTime ");
			strSql.Append(" FROM School ");
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
			strSql.Append("select count(1) FROM School ");
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
			strSql.Append(")AS Row, T.*  from School T ");
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
			parameters[0].Value = "School";
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
	}
}


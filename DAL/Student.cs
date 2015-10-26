using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Interwebsite.DAL
{
	/// <summary>
	/// 数据访问类:Student
	/// </summary>
	public partial class Student
	{
		public Student()
		{}
		#region  BasicMethod



        
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Interwebsite.Model.Student model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Student set ");
			strSql.Append("Username=@Username,");
			strSql.Append("Password=@Password,");
			strSql.Append("Realname=@Realname,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("IDCardNumber=@IDCardNumber,");
			strSql.Append("Birthday=@Birthday,");
			strSql.Append("Ethnic=@Ethnic,");
			strSql.Append("DomicileAddress=@DomicileAddress,");
			strSql.Append("Address=@Address,");
			strSql.Append("Postalcode=@Postalcode,");
			strSql.Append("QQnumber=@QQnumber,");
			strSql.Append("PhoneNumber=@PhoneNumber,");
			strSql.Append("Email=@Email,");
			strSql.Append("FamilyAddress=@FamilyAddress,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("ModifyTime=@ModifyTime,");
			strSql.Append("FirstProject=@FirstProject,");
			strSql.Append("SecondProject=@SecondProject,");
			strSql.Append("GraduateSchool=@GraduateSchool,");
			strSql.Append("Major=@Major,");
			strSql.Append("GraduateTime=@GraduateTime,");
			strSql.Append("EntranceTime=@EntranceTime,");
			strSql.Append("EnglishLevel=@EnglishLevel,");
			strSql.Append("UndergraduateGPA=@UndergraduateGPA,");
			strSql.Append("WorkExperience=@WorkExperience,");
			strSql.Append("RewardsAndPunish=@RewardsAndPunish");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Password", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NVarChar,20),
					new SqlParameter("@IDCardNumber", SqlDbType.NVarChar,30),
					new SqlParameter("@Birthday", SqlDbType.DateTime),
					new SqlParameter("@Ethnic", SqlDbType.NVarChar,30),
					new SqlParameter("@DomicileAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@Address", SqlDbType.NVarChar,100),
					new SqlParameter("@Postalcode", SqlDbType.Int,4),
					new SqlParameter("@QQnumber", SqlDbType.Int,4),
					new SqlParameter("@PhoneNumber", SqlDbType.Int,4),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@FamilyAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@ModifyTime", SqlDbType.DateTime),
					new SqlParameter("@FirstProject", SqlDbType.NVarChar,50),
					new SqlParameter("@SecondProject", SqlDbType.NVarChar,50),
					new SqlParameter("@GraduateSchool", SqlDbType.NVarChar,50),
					new SqlParameter("@Major", SqlDbType.NVarChar,50),
					new SqlParameter("@GraduateTime", SqlDbType.DateTime),
					new SqlParameter("@EntranceTime", SqlDbType.DateTime),
					new SqlParameter("@EnglishLevel", SqlDbType.NVarChar,50),
					new SqlParameter("@UndergraduateGPA", SqlDbType.Int,4),
					new SqlParameter("@WorkExperience", SqlDbType.NVarChar,2000),
					new SqlParameter("@RewardsAndPunish", SqlDbType.NVarChar,2000)};
			parameters[0].Value = model.Username;
			parameters[1].Value = model.Password;
			parameters[2].Value = model.Realname;
			parameters[3].Value = model.Sex;
			parameters[4].Value = model.IDCardNumber;
			parameters[5].Value = model.Birthday;
			parameters[6].Value = model.Ethnic;
			parameters[7].Value = model.DomicileAddress;
			parameters[8].Value = model.Address;
			parameters[9].Value = model.Postalcode;
			parameters[10].Value = model.QQnumber;
			parameters[11].Value = model.PhoneNumber;
			parameters[12].Value = model.Email;
			parameters[13].Value = model.FamilyAddress;
			parameters[14].Value = model.CreateTime;
			parameters[15].Value = model.ModifyTime;
			parameters[16].Value = model.FirstProject;
			parameters[17].Value = model.SecondProject;
			parameters[18].Value = model.GraduateSchool;
			parameters[19].Value = model.Major;
			parameters[20].Value = model.GraduateTime;
			parameters[21].Value = model.EntranceTime;
			parameters[22].Value = model.EnglishLevel;
			parameters[23].Value = model.UndergraduateGPA;
			parameters[24].Value = model.WorkExperience;
			parameters[25].Value = model.RewardsAndPunish;

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
			strSql.Append("delete from Student ");
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
		public Interwebsite.Model.Student GetModel(string Username)
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Username,Password,Realname,Sex,IDCardNumber,Birthday,Ethnic,DomicileAddress,Address,Postalcode,QQnumber,PhoneNumber,Email,FamilyAddress,CreateTime,ModifyTime,FirstProject,SecondProject,GraduateSchool,Major,GraduateTime,EntranceTime,EnglishLevel,UndergraduateGPA,WorkExperience,RewardsAndPunish from Student ");
			strSql.Append(" where ");
            strSql.Append("Username='"+Username+"'");
			SqlParameter[] parameters = {
			};

			Interwebsite.Model.Student model=new Interwebsite.Model.Student();
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
        public Interwebsite.Model.Student GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top1 Username,Password,Realname,Sex,IDCardNumber,Birthday,Ethnic,DomicileAddress,Address,Postalcode,QQnumber,PhoneNumber,Email,FamilyAddress,CreateTime,ModifyTime,FirstProject,SecondProject,GraduateSchool,Major,GraduateTime,EntranceTime,EnglishLevel,UndergraduateGPA,WorkExperience,RewardsAndPunish from Student ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
			};

            Interwebsite.Model.Student model = new Interwebsite.Model.Student();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
		public Interwebsite.Model.Student DataRowToModel(DataRow row)
		{
			Interwebsite.Model.Student model=new Interwebsite.Model.Student();
			if (row != null)
			{
				if(row["Username"]!=null)
				{
					model.Username=row["Username"].ToString();
				}
				if(row["Password"]!=null)
				{
					model.Password=row["Password"].ToString();
				}
				if(row["Realname"]!=null)
				{
					model.Realname=row["Realname"].ToString();
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["IDCardNumber"]!=null)
				{
					model.IDCardNumber=row["IDCardNumber"].ToString();
				}
				if(row["Birthday"]!=null && row["Birthday"].ToString()!="")
				{
					model.Birthday=DateTime.Parse(row["Birthday"].ToString());
				}
				if(row["Ethnic"]!=null)
				{
					model.Ethnic=row["Ethnic"].ToString();
				}
				if(row["DomicileAddress"]!=null)
				{
					model.DomicileAddress=row["DomicileAddress"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Postalcode"]!=null && row["Postalcode"].ToString()!="")
				{
					model.Postalcode=row["Postalcode"].ToString();
				}
				if(row["QQnumber"]!=null && row["QQnumber"].ToString()!="")
				{
					model.QQnumber=row["QQnumber"].ToString();
				}
				if(row["PhoneNumber"]!=null && row["PhoneNumber"].ToString()!="")
				{
					model.PhoneNumber=row["PhoneNumber"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["FamilyAddress"]!=null)
				{
					model.FamilyAddress=row["FamilyAddress"].ToString();
				}
				if(row["CreateTime"]!=null && row["CreateTime"].ToString()!="")
				{
					model.CreateTime=DateTime.Parse(row["CreateTime"].ToString());
				}
				if(row["ModifyTime"]!=null && row["ModifyTime"].ToString()!="")
				{
					model.ModifyTime=DateTime.Parse(row["ModifyTime"].ToString());
				}
				if(row["FirstProject"]!=null)
				{
					model.FirstProject=row["FirstProject"].ToString();
				}
				if(row["SecondProject"]!=null)
				{
					model.SecondProject=row["SecondProject"].ToString();
				}
				if(row["GraduateSchool"]!=null)
				{
					model.GraduateSchool=row["GraduateSchool"].ToString();
				}
				if(row["Major"]!=null)
				{
					model.Major=row["Major"].ToString();
				}
				if(row["GraduateTime"]!=null && row["GraduateTime"].ToString()!="")
				{
					model.GraduateTime=DateTime.Parse(row["GraduateTime"].ToString());
				}
				if(row["EntranceTime"]!=null && row["EntranceTime"].ToString()!="")
				{
					model.EntranceTime=DateTime.Parse(row["EntranceTime"].ToString());
				}
				if(row["EnglishLevel"]!=null)
				{
					model.EnglishLevel=row["EnglishLevel"].ToString();
				}
				if(row["UndergraduateGPA"]!=null && row["UndergraduateGPA"].ToString()!="")
				{
					model.UndergraduateGPA=int.Parse(row["UndergraduateGPA"].ToString());
				}
				if(row["WorkExperience"]!=null)
				{
					model.WorkExperience=row["WorkExperience"].ToString();
				}
				if(row["RewardsAndPunish"]!=null)
				{
					model.RewardsAndPunish=row["RewardsAndPunish"].ToString();
				}
			}
			return model;
		}

		

		

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Student ");
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
			strSql.Append(")AS Row, T.*  from Student T ");
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
			parameters[0].Value = "Student";
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
        public DataSet GetListApply(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Username as 用户名,Realname as 真实姓名,Sex as 性别,IDCardNumber as 身份证号码,QQnumber as QQ,PhoneNumber as 手机号码,Email ");
            strSql.Append(" FROM Student ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public DataSet GetModel(String username, String password)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Username from Student ");
            strSql.Append(" where username=@username");
            strSql.Append(" and password=@password");
            SqlParameter[] parameters = {
                new SqlParameter("@username", SqlDbType.NVarChar,100),
				new SqlParameter("@password", SqlDbType.NVarChar,100),
			};
            parameters[0].Value = username;
            parameters[1].Value = password;
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            return ds;
        }


        ///<summary>
        ///检查用户名是否存在
        ///</summary>
        public DataSet getUsername(string username)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select username from student");
            strSql.Append(" where username=@username");
            SqlParameter[] parameters = {
                                            new SqlParameter("@username", SqlDbType.NVarChar,100),
                                        };
            parameters[0].Value = username;
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            return ds;
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool AddandUpdate(Interwebsite.Model.Student model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Student set ");
            strSql.Append("Realname=@Realname,");
            strSql.Append("Sex=@Sex,");
            strSql.Append("IDCardNumber=@IDCardNumber,");
            strSql.Append("Birthday=@Birthday,");
            strSql.Append("Ethnic=@Ethnic,");
            strSql.Append("DomicileAddress=@DomicileAddress,");
            strSql.Append("Address=@Address,");
            strSql.Append("Postalcode=@Postalcode,");
            strSql.Append("QQnumber=@QQnumber,");
            strSql.Append("PhoneNumber=@PhoneNumber,");
            strSql.Append("Email=@Email,");
            strSql.Append("FamilyAddress=@FamilyAddress,");
            strSql.Append("ModifyTime=@ModifyTime,");
            strSql.Append("FirstProject=@FirstProject,");
            strSql.Append("SecondProject=@SecondProject,");
            strSql.Append("GraduateSchool=@GraduateSchool,");
            strSql.Append("Major=@Major,");
            strSql.Append("GraduateTime=@GraduateTime,");
            strSql.Append("EntranceTime=@EntranceTime,");
            strSql.Append("EnglishLevel=@EnglishLevel,");
            strSql.Append("UndergraduateGPA=@UndergraduateGPA,");
            strSql.Append("WorkExperience=@WorkExperience,");
            strSql.Append("RewardsAndPunish=@RewardsAndPunish");
            strSql.Append("politic=@politic");
            strSql.Append("famzipcode=@famzipcode");
            strSql.Append(" where username=@username");
            SqlParameter[] parameters = {
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NVarChar,20),
					new SqlParameter("@IDCardNumber", SqlDbType.NVarChar,30),
					new SqlParameter("@Birthday", SqlDbType.DateTime),
					new SqlParameter("@Ethnic", SqlDbType.NVarChar,30),
					new SqlParameter("@DomicileAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@Address", SqlDbType.NVarChar,100),
					new SqlParameter("@Postalcode", SqlDbType.NVarChar,6),
					new SqlParameter("@QQnumber", SqlDbType.NVarChar,11),
					new SqlParameter("@PhoneNumber", SqlDbType.NVarChar,15),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@FamilyAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@ModifyTime", SqlDbType.DateTime),
					new SqlParameter("@FirstProject", SqlDbType.NVarChar,50),
					new SqlParameter("@SecondProject", SqlDbType.NVarChar,50),
					new SqlParameter("@GraduateSchool", SqlDbType.NVarChar,50),
					new SqlParameter("@Major", SqlDbType.NVarChar,50),
					new SqlParameter("@GraduateTime", SqlDbType.DateTime),
					new SqlParameter("@EntranceTime", SqlDbType.DateTime),
					new SqlParameter("@EnglishLevel", SqlDbType.NVarChar,50),
					new SqlParameter("@UndergraduateGPA", SqlDbType.Decimal,9),
					new SqlParameter("@WorkExperience", SqlDbType.Text,16),
					new SqlParameter("@RewardsAndPunish", SqlDbType.Text,16),
                    new SqlParameter("@username", SqlDbType.NVarChar,50),
                    new SqlParameter("@politic", SqlDbType.NVarChar,50),
                    new SqlParameter("@famzipcode", SqlDbType.NVarChar,10),
                                        };
            parameters[0].Value = model.Realname;
            parameters[1].Value = model.Sex;
            parameters[2].Value = model.IDCardNumber;
            parameters[3].Value = model.Birthday;
            parameters[4].Value = model.Ethnic;
            parameters[5].Value = model.DomicileAddress;
            parameters[6].Value = model.Address;
            parameters[7].Value = model.Postalcode;
            parameters[8].Value = model.QQnumber;
            parameters[9].Value = model.PhoneNumber;
            parameters[10].Value = model.Email;
            parameters[11].Value = model.FamilyAddress;
            parameters[12].Value = model.ModifyTime;
            parameters[13].Value = model.FirstProject;
            parameters[14].Value = model.SecondProject;
            parameters[15].Value = model.GraduateSchool;
            parameters[16].Value = model.Major;
            parameters[17].Value = model.GraduateTime;
            parameters[18].Value = model.EntranceTime;
            parameters[19].Value = model.EnglishLevel;
            parameters[20].Value = model.UndergraduateGPA;
            parameters[21].Value = model.WorkExperience;
            parameters[22].Value = model.RewardsAndPunish;
            parameters[23].Value = model.Username;
            parameters[24].Value = model.politic;
            parameters[25].Value = model.famzipcode;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 增加一条数据
        /// </summary>
        public bool Add(Interwebsite.Model.Student model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Student(");
            strSql.Append("Username,Password,Realname,Sex,PhoneNumber,Email,CreateTime,ModifyTime)");
            strSql.Append(" values (");
            strSql.Append("@Username,@Password,@Realname,@Sex,@PhoneNumber,@Email,@CreateTime,@ModifyTime)");
            SqlParameter[] parameters = {
					new SqlParameter("@Username", SqlDbType.NVarChar,100),
					new SqlParameter("@Password", SqlDbType.NVarChar,100),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NVarChar,20),
					new SqlParameter("@PhoneNumber", SqlDbType.NVarChar,15),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@ModifyTime", SqlDbType.DateTime),
                                        };
            parameters[0].Value = model.Username;
            parameters[1].Value = model.Password;
            parameters[2].Value = model.Realname;
            parameters[3].Value = model.Sex;
            parameters[4].Value = model.PhoneNumber;
            parameters[5].Value = model.Email;
            parameters[6].Value = model.CreateTime;
            parameters[7].Value = model.ModifyTime;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Username as 用户名,Password,Realname as 真实姓名,Sex,IDCardNumber,Birthday,Ethnic,DomicileAddress,Address,Postalcode,QQnumber,PhoneNumber,Email,FamilyAddress,CreateTime,ModifyTime,FirstProject,SecondProject,GraduateSchool,Major,GraduateTime,EntranceTime,EnglishLevel,UndergraduateGPA,WorkExperience,RewardsAndPunish,famzipcode,politic");
            strSql.Append(" FROM Student ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }


		#endregion  ExtensionMethod
	}
}


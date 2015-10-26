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
    public class Admin
    {
        public bool login(string Useranmename,string Password)
        {


			StringBuilder strSql=new StringBuilder();
			strSql.Append("select username from Admin");
			strSql.Append(" where username='" + Useranmename+"' and password='"+Password+"'");
			SqlParameter[] parameters = {
			};
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
                return true;
			}
			else
			{
                return false;
			}

        }
    }
}

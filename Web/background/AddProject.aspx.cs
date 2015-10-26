using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Interwebsite.Web.background
{
    public partial class AddProject : System.Web.UI.Page
    {
        private static string  str2="";
        protected void Page_Load2(object sender, EventArgs e)
        {
            
        }

        protected void surebtn2_Click(object sender, EventArgs e)
        {
            Model.Project project = new Model.Project();
            project.ProjectName = projectname2.Text;
            project.ProjectInfo = Context.Request.Form["mycontent"];
            project.RecruitGuide = Context.Request.Form["mycontent2"];
            project.CreateTime= DateTime.Now;
            project.ModifyTime = DateTime.Now;
            project.Attachment = str2;
            Interwebsite.BLL.Project projectbll = new BLL.Project();
            bool rows=projectbll.Add(project);
            if (rows == true)
            {
                Response.Write("<script>alert('新建成功');</script>");
                str2 = "";
            }
            if (rows == false)
                Response.Write("<script>alert('新建失败');</script>");

        }

 

       

    }
}
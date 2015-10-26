using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Interwebsite.BLL;

namespace Interwebsite.Web.background
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string username = Request["username"];
            string password = Request["password"];
            BLL.Admin adminbll = new BLL.Admin();
            if (adminbll.login(username,password)==true)
            {
                Response.Redirect("index.aspx");
                Session["username"] = username;
                Session["password"] = password;
            }
            if (adminbll.login(username, password)==false)
            {
                Response.Write("<script>alert('用户名或者密码有错！')</script>");
            }


        }
    }
}
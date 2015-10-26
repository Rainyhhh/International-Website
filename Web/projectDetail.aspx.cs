using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interwebsite
{
    public partial class projectDetail : System.Web.UI.Page
    {
        private int tid;//传过来的参数
        private BLL.Project am = new BLL.Project();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                tid = int.Parse(Request.QueryString[0].ToString());
                Bind();
            }
        }
        protected void Bind()
        {
            //Console.Write(tid);           
            project.DataSource = am.GetModel(tid);
            project.DataBind();
        }
    }
}
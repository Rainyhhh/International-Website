using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Interwebsite.Model;

namespace Interwebsite
{
    public partial class announcementDetail : System.Web.UI.Page
    {
        private int tid;//传过来的参数
        private BLL.Announcement am = new BLL.Announcement();
        private DataTable dt = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //tname = Request.QueryString[0].ToString();
                tid = int.Parse(Request.QueryString[0].ToString());
                dt = am.GetModel(tid).Tables[0];
                Bind();
            }
        }
        protected void Bind()
        {
            string d = dt.Rows[0][4].ToString();
            string[] dat = d.Split('/',' ','-');
            year.Text = dat[0];
            month.Text = dat[1];
            date.Text = dat[2];
            title.Text = dt.Rows[0][1].ToString();
            author.Text = dt.Rows[0][3].ToString();
            announce.DataSource = dt;
            announce.DataBind();
        }

    }
}
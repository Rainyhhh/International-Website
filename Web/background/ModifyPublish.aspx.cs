using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Interwebsite.Web.background.ueditor_mini1_0_0_src.ueditor_mini1_0_0_src.examples
{
    public partial class Publsih2 : System.Web.UI.Page
    {
        private BLL.Announcement announcement = new BLL.Announcement();
        private DataTable dt = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["Id"]);
            dt = announcement.GetModel(id).Tables[0];
            publishModify.DataSource = dt;
            announcementname.Text = dt.Rows[0][1].ToString();
            author2.Text = dt.Rows[0][3].ToString();
            publishModify.DataBind();
        }

        protected void add2_Click(object sender, EventArgs e)
        {
            Model.Announcement announ = new Model.Announcement();
            BLL.Announcement announbll = new BLL.Announcement();
            announ.AnnouncementInfo = Context.Request.Form["mycontent"];
            announ.AnnouncementName = announcementname.Text;
            announ.Author = author2.Text;
            announ.ID = int.Parse(Request.QueryString["Id"]);
            announ.ModifyTime = DateTime.Now;
            announbll.Delete(announ.ID);
            bool result = announbll.Add(announ);
            if (result == true)
            {
                Response.Write("<script>alert('修改成功！');window.location.href='NoticeManage.aspx';</script>");
            }
            if (result == false)
                Response.Write("<script>alert('修改失败！');window.location.href='NoticeManage.aspx';</script>");
        }
    }
}
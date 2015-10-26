using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Interwebsite.Web
{
    public partial class Publish : System.Web.UI.Page
    {
        protected void Page_Load2(object sender, EventArgs e)
        {

        }

        protected void add2_Click(object sender, EventArgs e)
        {
            Model.Announcement announcement = new Model.Announcement();
            announcement.AnnouncementInfo = Context.Request.Form["mycontent"];
            announcement.AnnouncementName = announcementname2.Text;
            announcement.Author = author2.Text;
            announcement.CreateTime = DateTime.Now;
            announcement.ModifyTime = DateTime.Now;

            BLL.Announcement anouncementbll = new BLL.Announcement();
            bool result=anouncementbll.Add(announcement);
            if (result == true)
                Response.Write("<script>alert('新建成功！');</script>");
            else
               Response.Write("<script>alert('新建失败！');</script>");

        }

       
    }
}
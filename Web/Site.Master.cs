using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Interwebsite
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        private DataTable AnnouncementList = null;
        private DataTable ProjectList = null;
        private DataTable AttachmentList = null;
        private Interwebsite.BLL.Announcement at = new BLL.Announcement();
        private Interwebsite.BLL.Attachment att = new BLL.Attachment();
        private Interwebsite.BLL.Project pt = new BLL.Project();
        protected void Page_Load(object sender, EventArgs e)
        {
            AnnouncementList = at.GetTitleList(4).Tables[0];
            AttachmentList = att.getTitleList(4).Tables[0];
            ProjectList = pt.GetTitleList(4).Tables[0];
            Bind();
        }
        public void Bind()
        {
            announce.DataSource = AnnouncementList;
            project.DataSource = ProjectList;
            attach.DataSource = AttachmentList;
            announce.DataBind();
            project.DataBind();
            attach.DataBind();
        }
    }
}

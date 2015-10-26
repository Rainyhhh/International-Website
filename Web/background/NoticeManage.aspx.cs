using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Interwebsite.Web.background
{
    public partial class NoticeManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Interwebsite.BLL.Announcement announcement = new BLL.Announcement();
            GridView1.DataSource = announcement.GetAllList();
            GridView1.DataBind();
        }

        protected void GridView1_DataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType==DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "color=this.style.backgroundColor;this.style.backgroundColor='#CCC';this.style.cursor='pointer';");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=color;");


                string strId =GridView1.DataKeys[e.Row.RowIndex].Value.ToString();
                e.Row.Attributes.Add("ondblclick", "location.href='ModifyPublish.aspx?Id=" + strId + "'");
                e.Row.Attributes["style"] = "Cursor:hand";
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int strId = int.Parse(GridView1.DataKeys[e.NewEditIndex].Values[0].ToString());
            Response.Redirect("ModifyPublish.aspx?Id=" + strId);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = int.Parse(GridView1.DataKeys[e.RowIndex].Values[0].ToString());
            BLL.Announcement anounbll = new BLL.Announcement();
            anounbll.Delete(ID);
            Response.Redirect("NoticeManage.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string select = DropDownList1.SelectedValue;
            if (select == "公告名称")
                select = "AnnouncementName";
            if (select == "作者")
                select = "Author";
            string selecttext = TextBox1.Text;
            string selectstr = select + "='" + selecttext+"'";
            BLL.Announcement announ = new BLL.Announcement();
            DataSet ds = announ.GetList(selectstr);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}
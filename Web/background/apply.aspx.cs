using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interwebsite.Web.background
{
    public partial class apply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Interwebsite.BLL.Student studentbll = new Interwebsite.BLL.Student();
            GridView.DataSource = studentbll.GetListApply();
            GridView.DataBind();
        }

        protected void Searchbtn_Click(object sender, EventArgs e)
        {
            Interwebsite.BLL.Student studentbll = new Interwebsite.BLL.Student();
            string wherestr = DropDownList1.SelectedValue;
            if (wherestr == "用户名") wherestr = "Username";
            if (wherestr == "真实姓名") wherestr = "Realname";

            string selectstr = SearchTextBox.Text;

            GridView.DataSource = studentbll.GetList(wherestr + "='" + selectstr + "'");
            GridView.DataBind();
            
        }

        protected void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "color=this.style.backgroundColor;this.style.backgroundColor='#CCC';this.style.cursor='pointer';");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=color;");


                string strId = GridView.DataKeys[e.Row.RowIndex].Value.ToString();
                e.Row.Attributes.Add("ondblclick", "location.href='ModifyStudent.aspx?Username=" + strId + "'");
                e.Row.Attributes["style"] = "Cursor:hand";
            }
        }
    }
}
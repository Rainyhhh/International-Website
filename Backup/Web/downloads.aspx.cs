using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Interwebsite.BLL;
namespace Interwebsite
{
    public partial class downloads : System.Web.UI.Page
    {
        private DataTable list = null;
        private BLL.Attachment at = new BLL.Attachment();
        private int pageSize = 10;
        private int curPage = 1;
        private int total = 0;
        private int pageCount;//页面数量
        private string filename;
        private string address;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                list = at.GetListByPage(pageSize, curPage).Tables[0];
                updateList();
                Bind();
            }
        }

        protected void Bind()
        {
            attachmentList.DataSource = list;
            attachmentList.DataBind();
        }

        protected void updateList()//更新数据
        {
            list = at.GetListByPage(pageSize, curPage).Tables[0];
            total = at.GetRecordCount("");
            if (total % pageSize == 0)
                pageCount = total / pageSize;
            else
                pageCount = total / pageSize + 1;
            if (total == 0)
            {
                this.LinkBtnPageInfo.Text = "0/0";
            }
            else
            {
                this.LinkBtnPageInfo.Text = curPage.ToString() + "/" + pageCount.ToString();
            }
        }
        protected void LinkFirst_Click(object sender, EventArgs e)//最前页
        {
            curPage = 1;
            updateList();
            Bind();
        }
        protected void LinkPrevious_Click(object sender, EventArgs e)//上一页
        {
            if (curPage > 1)
                curPage--;
            updateList();
            Bind();
        }
        protected void LinkNext_Click(object sender, EventArgs e)//下一页
        {
            if (curPage < pageCount)
                curPage++;
            updateList();
            Bind();
        }
        protected void LinkLast_Click(object sender, EventArgs e)//末页
        {
            curPage = pageCount;
            updateList();
            Bind();
        }
        protected void download(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            filename = lb.CommandArgument;
            address = lb.CommandName;
            at.Download(filename, address+"/"+filename);
        }
    }
}
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
    public partial class announcement : System.Web.UI.Page
    {
        private DataTable list = null;
        private BLL.Announcement am = new BLL.Announcement();
        private int pageSize = 8;
        private static int curPage = 1;
        private int total = 0;
        private int pageCount;//页面数量
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                list = am.GetListByPage(pageSize, curPage).Tables[0];
                total = am.GetRecordCount("");
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
                //updateList();
                Bind();
            }
        }

        protected void Bind()
        {
            announcementList.DataSource = list;
            announcementList.DataBind();
        }
        protected void updateList()//更新数据
        {
            list = am.GetListByPage(pageSize, curPage).Tables[0];
            total = am.GetRecordCount("");
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

    }
    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Interwebsite
{
    public partial class _index : System.Web.UI.Page
    {
        private DataTable titleList = null;
        private BLL.Announcement am = new BLL.Announcement();
        private Interwebsite.BLL.Student stu = new Interwebsite.BLL.Student();
        String username1 = null;
        String password = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                titleList = am.GetTitleList(4).Tables[0];
                Bind();
            }
        }

        protected void Bind()
        {
            announcementList.DataSource = titleList;
            announcementList.DataBind();
        }

        protected void login(object sender, EventArgs e)
        {
            username1 = this.GetMD5(Username.Value.ToString(),"");
            password = this.GetMD5(Pass.Value.ToString(),"");
            if (stu.GetModel(username1, password))
                Response.Redirect("register.aspx?username="+username1);
            else errors.Text = "用户名不存在或密码错误！";
        }

        public string GetMD5(string sDataIn, string move)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bytValue, bytHash;
            bytValue = System.Text.Encoding.UTF8.GetBytes(move + sDataIn);
            bytHash = md5.ComputeHash(bytValue);
            md5.Clear();
            string sTemp = "";
            for (int i = 0; i < bytHash.Length; i++)
            {
                sTemp += bytHash[i].ToString("x").PadLeft(2, '0');
            }
            return sTemp;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Web.UI.HtmlControls;

namespace Interwebsite
{
    public partial class apply : System.Web.UI.Page
    {
        private Interwebsite.BLL.Student stu = new Interwebsite.BLL.Student();
        private Interwebsite.Model.Student student = new Model.Student();
        String username1 = null;
        String password = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs e)
        {
            username1 = this.GetMD5(username.Value.ToString(),"");
            password = this.GetMD5(pass.Value.ToString(),"");
            if(username1.Equals(""))
                errors.Text = "用户名不能为空！";
            else if(password.Equals(""))
                errors.Text = "请输入密码！";
            else
            {
               if (stu.GetModel(username1, password))
                   Response.Redirect("register.aspx?username="+username1);
               else errors.Text = "用户名不存在或密码错误！";
            }
        }

        protected void registration(object sender, EventArgs e)
        {
            student.Username = this.GetMD5(username2.Value,"") ;
            student.Password = this.GetMD5(pass2.Value,"");
            student.Realname = name.Value;
            student.Sex = gender.Value;
            student.PhoneNumber = phone.Value;
            student.Email = email.Value;
            student.CreateTime = DateTime.Now;
            student.ModifyTime = DateTime.Now;
            if (stu.checkUsername(student.Username))
            {
                username2_require.InnerHtml = "用户名已存在！";
            }
            else
            {
                stu.Add(student);
                Response.Redirect("register.aspx?username="+student.Username);
            }
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
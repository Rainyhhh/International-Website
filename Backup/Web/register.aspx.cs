using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Globalization;

namespace Interwebsite
{
    public partial class register : System.Web.UI.Page
    {
        Model.Student student = new Model.Student();
        Interwebsite.BLL.Student studentbll = new Interwebsite.BLL.Student();
        DataTable studentList = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                String username = (Request.QueryString["username"]).ToString();
                student.Username = username;
                getInfo(username);
            }
        }

        protected void getInfo(String username)
        {
            studentList = studentbll.GetList(" Username='" + username + "' ").Tables[0];
            name.Value = studentList.Rows[0][2].ToString();
            gender.Value = studentList.Rows[0][3].ToString();
            idno.Value = studentList.Rows[0][4].ToString();
            birthdate.Value = studentList.Rows[0][5].ToString();
            nationality.Value = studentList.Rows[0][6].ToString();
            city.Value = studentList.Rows[0][7].ToString();
            address.Value = studentList.Rows[0][8].ToString();
            zipcode.Value = studentList.Rows[0][9].ToString();
            qqno.Value = studentList.Rows[0][10].ToString();
            phone.Value = studentList.Rows[0][11].ToString();
            email.Value = studentList.Rows[0][12].ToString();
            famaddress.Value = studentList.Rows[0][13].ToString();
            preferedprogram.Value = studentList.Rows[0][16].ToString();
            altprogram.Value = studentList.Rows[0][17].ToString();
            graduated.Value = studentList.Rows[0][18].ToString();
            major.Value = studentList.Rows[0][19].ToString();
            gradtime.Value = studentList.Rows[0][20].ToString();
            starttime.Value = studentList.Rows[0][21].ToString();
            englishskill.Value = studentList.Rows[0][22].ToString();
            gpa.Value = studentList.Rows[0][23].ToString();
            workexp.Value = studentList.Rows[0][24].ToString();
            rewardspunisment.Value = studentList.Rows[0][25].ToString();
            famzipcode.Value = studentList.Rows[0][26].ToString();
            politic.Value = studentList.Rows[0][27].ToString();
        }

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            String username = (Request.QueryString["username"]).ToString();
            student.Username = username;
            student.FirstProject = preferedprogram.Value;
            student.SecondProject = altprogram.Value;
            student.Realname = name.Value;
            student.Sex = gender.Value;
            student.IDCardNumber = idno.Value;
            if (birthdate.Value.ToString() != "")
                student.Birthday = Convert.ToDateTime(birthdate.Value);
            //student.Birthday = DateTime.ParseExact(birthdate.Value.ToString(), "yyyy/MM/dd", CultureInfo.CurrentCulture, DateTimeStyles.None);
            student.Ethnic = nationality.Value;//民族
            student.politic = politic.Value;
            student.FamilyAddress = city.Value;//户籍所在地
            student.famzipcode = famzipcode.Value;
            student.DomicileAddress = address.Value;//联系地址
            student.Postalcode = zipcode.Value;
            student.QQnumber = qqno.Value;
            student.PhoneNumber = phone.Value;
            student.Email = email.Value;
            student.FamilyAddress = famaddress.Value;//家庭住址
            student.GraduateSchool = graduated.Value;
            student.Major = major.Value;
            if (gradtime.Value.ToString() != "")
                student.GraduateTime = Convert.ToDateTime(gradtime.Value);
            //student.GraduateTime = DateTime.ParseExact(gradtime.Value, "yyyy/MM/dd", CultureInfo.CurrentCulture, DateTimeStyles.None);
            if (starttime.Value.ToString() != "")
                student.EntranceTime = Convert.ToDateTime(starttime.Value);
            //student.EntranceTime = DateTime.ParseExact(starttime.Value, "yyyy/MM/dd", CultureInfo.CurrentCulture, DateTimeStyles.None);
            student.EnglishLevel = englishskill.Value;
            if(gpa.Value != "")
            student.UndergraduateGPA = decimal.Parse(gpa.Value);
            student.WorkExperience = workexp.Value;
            student.RewardsAndPunish = rewardspunisment.Value;
            student.ModifyTime = DateTime.Now;
            bool result = studentbll.AddandUpdate(student);
            if (result == true)
            {
                Response.Write("<script>alert('修改成功！');</script>");
            }
            else
            {
                Response.Write("<script>alert('修改失败！');</script>");
            }
        }

    }
}
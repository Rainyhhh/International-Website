using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Interwebsite.Web.background.ueditor_mini1_0_0_src.ueditor_mini1_0_0_src.examples
{
    public partial class ModifyProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.Student studentbll = new BLL.Student();
            string username=Request.QueryString["Username"];
            Model.Student student = new Model.Student();
            student = studentbll.GetModel(username);
            this.preferedprogram.Text = student.FirstProject.ToString();
            this.altprogram.Text = student.SecondProject.ToString();
            this.graduated.Text = student.GraduateSchool;
            this.major.Text = student.Major;
            this.gradyear.Text = student.GraduateTime.ToString();
            this.startyear.Text = student.EntranceTime.ToString();
            this.englishskill.Text = student.EnglishLevel;
            this.gpa.Text = student.UndergraduateGPA.ToString();
            this.rewardspunisment.Text = student.RewardsAndPunish;
            this.name.Text = student.Realname;
            this.gender.Text = student.Sex;
            this.idno.Text = student.IDCardNumber;
            // this.politic.Text政治面貌
            this.nationality.Text = student.Ethnic;
            this.city.Text = student.DomicileAddress;
            this.address.Text = student.Address;
            this.zipcode.Text = student.Postalcode.ToString();
            this.phone.Text = student.PhoneNumber.ToString();
            this.email.Text = student.Email;
            this.famaddress.Text = student.FamilyAddress;
            //this.famzipcode.Text
            //this.parid.Valu
            //this.parrelation
            //this.parwork
            //this.parphone


        }

    

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            Interwebsite.Model.Student student = new Interwebsite.Model.Student();
            student.Username = "wati";
            student.Password = "sdf";
            student.FirstProject = Request["preferedprogram"];
            student.SecondProject = Request["altprogram"];
            student.Realname = Request["name"];
            student.Sex = Request["gender"];
            //student.IDCardNumber =int.Parse(Request["idno"]);
            student.Birthday = DateTime.Parse(Request["birthdate"]);
            student.Ethnic = Request["nationality"];//名族
            student.FamilyAddress = Request["city"];//户籍所在地
            //政治面貌
            student.DomicileAddress = Request["adress"];//联系地址
            //student.Postalcode =int.Parse(Request["zipcode"]);
            //student.QQNumber = int.Parse(Request["qq"]);
            //student.PhoneNumber =int.Parse(Request["phone"]);
            student.Email = Request["email"];
            student.FamilyAddress = Request["famadress"];//家庭住址
            student.GraduateSchool = Request["graduated"];
            student.Major = Request["major"];
            //student.GraduateTime = DateTime.Parse(Request["gradyear"]);
            //student.EntranceTime = DateTime.Parse(Request["startyear"]);
            student.EnglishLevel = Request["englishskill"];
            //student.UndergraduateGPA = int.Parse(Request["gpa"]);
            student.WorkExperience = Request["workexp"];
            student.RewardsAndPunish = Request["rewardspunisment"];
            student.CreateTime = DateTime.Now;
            student.ModifyTime = DateTime.Now;
        }


    }
}
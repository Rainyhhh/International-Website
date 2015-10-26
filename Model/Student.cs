using System;
namespace Interwebsite.Model
{
	/// <summary>
	/// Student:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Student
	{
		public Student()
		{}
		#region Model
		private string _username;
		private string _password;
		private string _realname;
		private string _sex;
		private string _idcardnumber;
		private DateTime? _birthday;
		private string _ethnic;
		private string _domicileaddress;
		private string _address;
		private string _postalcode;
		private string _qqnumber;
		private string _phonenumber;
		private string _email;
		private string _familyaddress;
		private DateTime? _createtime;
		private DateTime? _modifytime;
		private string _firstproject;
		private string _secondproject;
		private string _graduateschool;
		private string _major;
		private DateTime? _graduatetime;
		private DateTime? _entrancetime;
		private string _englishlevel;
		private decimal _undergraduategpa;
		private string _workexperience;
		private string _rewardsandpunish;
        private string _famzipcode;
        private string _politic;
		/// <summary>
		/// 
		/// </summary>
		public string Username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Realname
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IDCardNumber
		{
			set{ _idcardnumber=value;}
			get{return _idcardnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Birthday
		{
			set{ _birthday=value;}
			get{return _birthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ethnic
		{
			set{ _ethnic=value;}
			get{return _ethnic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DomicileAddress
		{
			set{ _domicileaddress=value;}
			get{return _domicileaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Postalcode
		{
			set{ _postalcode=value;}
			get{return _postalcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQnumber
		{
			set{ _qqnumber=value;}
			get{return _qqnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PhoneNumber
		{
			set{ _phonenumber=value;}
			get{return _phonenumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FamilyAddress
		{
			set{ _familyaddress=value;}
			get{return _familyaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ModifyTime
		{
			set{ _modifytime=value;}
			get{return _modifytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FirstProject
		{
			set{ _firstproject=value;}
			get{return _firstproject;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SecondProject
		{
			set{ _secondproject=value;}
			get{return _secondproject;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GraduateSchool
		{
			set{ _graduateschool=value;}
			get{return _graduateschool;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Major
		{
			set{ _major=value;}
			get{return _major;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? GraduateTime
		{
			set{ _graduatetime=value;}
			get{return _graduatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EntranceTime
		{
			set{ _entrancetime=value;}
			get{return _entrancetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EnglishLevel
		{
			set{ _englishlevel=value;}
			get{return _englishlevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal UndergraduateGPA
		{
			set{ _undergraduategpa=value;}
			get{return _undergraduategpa;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WorkExperience
		{
			set{ _workexperience=value;}
			get{return _workexperience;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RewardsAndPunish
		{
			set{ _rewardsandpunish=value;}
			get{return _rewardsandpunish;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string politic
        {
            set { _politic = value; }
            get { return _politic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string famzipcode
        {
            set { _famzipcode = value; }
            get { return _famzipcode; }
        }
		#endregion Model

	}
}


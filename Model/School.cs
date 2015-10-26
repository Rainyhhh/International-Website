using System;
namespace Interwebsite.Model
{
	/// <summary>
	/// School:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class School
	{
		public School()
		{}
		#region Model
		private int _id;
		private string _schoolname;
		private string _nation;
		private string _linkman;
		private string _linkaddress;
		private string _email;
		private int? _linkphone;
		private string _schoolinfo;
		private DateTime? _createtime;
		private DateTime? _modifytime;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SchoolName
		{
			set{ _schoolname=value;}
			get{return _schoolname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Nation
		{
			set{ _nation=value;}
			get{return _nation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Linkman
		{
			set{ _linkman=value;}
			get{return _linkman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LinkAddress
		{
			set{ _linkaddress=value;}
			get{return _linkaddress;}
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
		public int? LinkPhone
		{
			set{ _linkphone=value;}
			get{return _linkphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SchoolInfo
		{
			set{ _schoolinfo=value;}
			get{return _schoolinfo;}
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
		#endregion Model

	}
}


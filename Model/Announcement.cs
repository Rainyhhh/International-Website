using System;
namespace Interwebsite.Model
{
	/// <summary>
	/// Announcement:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Announcement
	{
		public Announcement()
		{}
		#region Model
		private int _id;
		private string _announcementname;
		private string _announcementinfo;
		private string _author;
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
		public string AnnouncementName
		{
			set{ _announcementname=value;}
			get{return _announcementname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AnnouncementInfo
		{
			set{ _announcementinfo=value;}
			get{return _announcementinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Author
		{
			set{ _author=value;}
			get{return _author;}
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


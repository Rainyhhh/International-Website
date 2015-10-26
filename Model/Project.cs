using System;
namespace Interwebsite.Model
{
	/// <summary>
	/// Project:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Project
	{
		public Project()
		{}
		#region Model
		private int _id;
		private string _projectname;
		private string _projectinfo;
		private string _recruitguide;
		private DateTime? _createtime;
		private DateTime? _modifytime;
        private string _attachment;
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
		public string ProjectName
		{
			set{ _projectname=value;}
			get{return _projectname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProjectInfo
		{
			set{ _projectinfo=value;}
			get{return _projectinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RecruitGuide
		{
			set{ _recruitguide=value;}
			get{return _recruitguide;}
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

        public string Attachment
        {
            set { _attachment = value; }
            get { return _attachment; }
        }

		#endregion Model

	}
}


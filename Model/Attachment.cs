using System;
namespace Interwebsite.Model
{
	/// <summary>
	/// Attachment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Attachment
	{
		public Attachment()
		{}
		#region Model
		private int _id;
		private string _attachmentname;
		private string _uploadname;
		private DateTime? _uploadtime;
		private string _attachmentaddress;
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
		public string AttachmentName
		{
			set{ _attachmentname=value;}
			get{return _attachmentname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UploadName
		{
			set{ _uploadname=value;}
			get{return _uploadname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UploadTime
		{
			set{ _uploadtime=value;}
			get{return _uploadtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AttachmentAddress
		{
			set{ _attachmentaddress=value;}
			get{return _attachmentaddress;}
		}
		#endregion Model

	}
}


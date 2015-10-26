using System;
using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO; 

namespace Interwebsite.Common
{
    public class DownloadHelper
    {
        public void Download(string filename,string path)
        {
          
            string filePath = System.Web.HttpContext.Current.Server.MapPath(path);//路径
            //以字符流的形式下载文件 
            FileStream fs = new FileStream(filePath, FileMode.Open);
            byte[] bytes = new byte[(int)fs.Length]; 
            fs.Read(bytes, 0, bytes.Length); fs.Close();
            System.Web.HttpContext.Current.Response.ContentType = "application/octet-stream";         //通知浏览器下载文件而不是打开 
            System.Web.HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment;  filename=" + HttpUtility.UrlEncode(filename, System.Text.Encoding.UTF8));
            System.Web.HttpContext.Current.Response.BinaryWrite(bytes); 
            System.Web.HttpContext.Current.Response.Flush();
            System.Web.HttpContext.Current.Response.End(); 
        }

        public void Download2(string FileName,string FilePath)
        {
            string fileName = FileName;//客户端保存的文件名
            string filePath = System.Web.HttpContext.Current.Server.MapPath(FilePath);//路径
            System.IO.FileInfo fileinfo = new System.IO.FileInfo(filePath);
            if (fileinfo.Exists == true)
            {
                const long ChunkSize = 102400;//100k每次读取文件，只读取100k，这样可以缓解服务器的压力
                byte[] buffer = new byte[ChunkSize];
                System.Web.HttpContext.Current.Response.Clear();
                System.IO.FileStream iStream = System.IO.File.OpenRead(filePath);
                long dataLengthToRead = iStream.Length;//获取下载的文件总大小
                System.Web.HttpContext.Current.Response.ContentType = "application/octet-stream";
                System.Web.HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(fileName));
                while (dataLengthToRead > 0 && System.Web.HttpContext.Current.Response.IsClientConnected)
                {
                    int lengthRead = iStream.Read(buffer, 0, Convert.ToInt32(ChunkSize));//读取的大小
                    System.Web.HttpContext.Current.Response.OutputStream.Write(buffer, 0, lengthRead);
                    System.Web.HttpContext.Current.Response.Flush();
                    dataLengthToRead = dataLengthToRead - lengthRead;
                }
                System.Web.HttpContext.Current.Response.Close();
            }
        }
    }
}

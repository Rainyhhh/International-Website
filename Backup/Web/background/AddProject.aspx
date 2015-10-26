<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddProject.aspx.cs" Inherits="Interwebsite.Web.background.AddProject" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html;charset=utf-8"/>
    <title>添加项目</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <script type="text/javascript" src="ueditor/ueditor.all.js"></script>
    <script type="text/javascript" src="ueditor/ueditor.config.js"></script>
    <link href="ueditor/themes/default/css/ueditor.css" rel="Stylesheet"/>
    <script type="text/javascript" src="ueditor/lang/zh-cn/zh-cn.js"></script>
    <style type="text/css">
        h1{
            font-family: "微软雅黑";
            font-weight: normal;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
    <table>
    <tr><td><asp:Label ID="L" runat="server" Text="项目名称:"></asp:Label></td>
    <td > 
        <asp:TextBox ID="projectname2" runat="server" Width="795px"></asp:TextBox>
        </td>
    </tr>
    <tr>
    <td><asp:Label ID="La" runat="server" Text="项目简介："></asp:Label></td>
    <td>
        <script type="text/plain" id="myEditor" name="mycontent" style="width:800px;height:240px;"></script>
        <script type="text/javascript">
    var editor = new UE.ui.Editor();
    editor.render('myEditor');
        </script>
    </td>
    </tr>
    <tr>
    <td>
        <asp:Label ID="Lab" runat="server" Text="招生简章"></asp:Label>
    </td>
    <td>
        <script type="text/plain" id="Script" name="mycontent2" style="width:800px;height:240px;"></script>
<script type="text/javascript">
    var editor = new UE.ui.Editor();
    editor.render('Script');
</script>
    </td>
    </tr>
    </table>

    <table style="width: 404px">
  
    <td colspan="2" align="center">
        <asp:Button ID="surebtn2" runat="server" Text="确定" onclick="surebtn2_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="cancel2" runat="server" Text="取消" />
        </td>            
    </tr>
    </table>



    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyPublish.aspx.cs" Inherits="Interwebsite.Web.background.ueditor_mini1_0_0_src.ueditor_mini1_0_0_src.examples.Publsih2" enableEventValidation="false"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta content="JavaScript" name="vs_defaultClientScript">
     <script src="../../ckeditor/ckeditor.js" type="text/javascript"></script>

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

    <title></title>
</head>
<body>
    <form id="Form2" runat="server">
         <table style="width: 100%; height: 100px;" cellspacing="1" border="0" 
            bgcolor="#E0E0E0" cellpadding="0" >         
         <tr>
                <td align="left" class="tb" colspan="2" style="text-align: left">
                    <h3>&nbsp;</h3>
                    <h3 align="center">公告添加/修改</h3>
                    <br />
                </td>
            </tr>
            <tr>
            <td align="center" style="height: 24px; width: 15%;">
                    名称：</td>
                <td align="left" style="padding-left: 16px; height: 24px;">
                    <asp:TextBox ID="announcementname" runat="server" CssClass="inpt" 
                        Width="200px"></asp:TextBox></td>
               </tr> 
         </table>

        <asp:DataList id="publishModify" style="width: 100%; height: 308px;" cellspacing="1" border="0" 
            bgcolor="#E0E0E0" cellpadding="0" runat="server">
            <ItemTemplate>
                <tr>
            <td align="center" style="height: 24px; width: 15%;">
                    说明：</td>
                <td align="left" style="padding-left: 16px; height: 24px;">
                   
                   <div id="editortext" runat="server">
                   <script type="text/plain" id="myEditor" name="mycontent" style="width:800px;height:240px;">
                         <p><%# DataBinder.Eval(Container.DataItem,"AnnouncementInfo") %></p>
                   </script>
<script type="text/javascript">
    var editor = new UE.ui.Editor();
    editor.render('myEditor');
</script>
                 </div>  
                   </td>
               </tr> 
                    
            </ItemTemplate>
        </asp:DataList>
        <table style="width: 100%; height: 100px;" cellspacing="1" border="0" 
            bgcolor="#E0E0E0" cellpadding="0" >
         <tr>
                <td align="center" style="height: 24px; width: 15%;">
                    作者：</td>
                <td align="left" style="padding-left: 16px; height: 24px">
                    <asp:TextBox ID="author2" class="textfield" runat="server" 
                        onclick="setday(this)" Width="150px"  CssClass="inpt"></asp:TextBox></td>
            </tr>          
            <tr>
                <td align="right" style="height: 24px; width:15%;">
                    &nbsp;</td>
                <td align="left" style="padding-left: 16px; height: 24px">
                    <asp:Button ID="modify2" runat="server" CssClass="button_on" 
                        Text="修改" Visible="False" />
                    <asp:Button ID="add2" runat="server" CssClass="button_on" 
                        Text="添加" onclick="add2_Click" />
                    <input id="return2" class="button_on" onclick="history.go(-1);" type="button" 
                        value="返回" /></td>
            </tr>
        </table>
        
    </form>
</body>
</html>

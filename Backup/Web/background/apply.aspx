<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="apply.aspx.cs" Inherits="Interwebsite.Web.background.apply" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="搜索条件："></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>用户名</asp:ListItem>
            <asp:ListItem>真实姓名</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:TextBox ID="SearchTextBox" runat="server" Width="343px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Searchbtn" runat="server" onclick="Searchbtn_Click" Text="搜索Search" />
        <br />
        <br />
</div>
<div align="center">
        <asp:GridView ID="GridView" runat="server" DataKeyNames="用户名" 
            onrowdatabound="GridView_RowDataBound" BorderWidth="0px" Font-Size="Large" 
            Height="40px" Width="800px">
            <HeaderStyle Font-Names="微软雅黑" ForeColor="Blue" Height="40px" />
            <RowStyle Font-Names="Dotum" Height="40px" HorizontalAlign="Center" 
                VerticalAlign="Middle" />
        </asp:GridView>
        </div>
    
    
    </form>
</body>
</html>

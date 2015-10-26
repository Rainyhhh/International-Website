<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NoticeManage.aspx.cs" Inherits="Interwebsite.Web.background.NoticeManager" %>

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
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>ID</asp:ListItem>
            <asp:ListItem>公告名称</asp:ListItem>
            <asp:ListItem>作者</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="搜索" onclick="Button1_Click" />
        <br />
    
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="ID" 
            onrowdatabound="GridView1_DataBound" BorderWidth="0px" Width="900px" 
            onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing">
            <Columns>
                <asp:CommandField ShowEditButton="True">
                <ItemStyle Font-Names="微软雅黑" ForeColor="#00CC00" />
                </asp:CommandField>
                <asp:CommandField ShowDeleteButton="True">
                <ItemStyle Font-Names="微软雅黑" ForeColor="#00CC00" />
                </asp:CommandField>
            </Columns>
            <HeaderStyle Font-Names="微软雅黑" ForeColor="#00CC00" Height="40px" />
            <RowStyle BorderWidth="0px" Font-Names="微软雅黑" Height="40px" 
                HorizontalAlign="Center" VerticalAlign="Middle" Width="1000px" />
            <SelectedRowStyle ForeColor="#33CCFF" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>

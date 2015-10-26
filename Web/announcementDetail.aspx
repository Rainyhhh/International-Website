<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="announcementDetail.aspx.cs" Inherits="Interwebsite.announcementDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="gdl-page-left mb0 eight columns" style="margin-top:20px;">
	<div class="row">
		<div class="gdl-page-item mb0 pb20 gdl-blog-full twelve columns">
			<div class="row">
				<div class="twelve columns mb40">
	                <div class="column-service-wrapper">
	                    <div class="column-service-title-wrapper">
	                        <img src="img/announce.png" style="width:35px;margin-left:0px;"/>
	                        <h2 class="column-service-title" style="position:relative;margin-top:-30px;margin-left:50px;">
	                            新闻公告<span class="sub-title">Announcements</span>
	                        </h2>
                        </div>                                               
                        <div class="blog-content-wrapper">
                            <div class="stunning-text-inner-wrapper gdl-border-x bottom">
                        <div class="blog-date-wrapper">                         
                            <div class="blog-date-value">
                                <asp:Label ID="date" runat="server" Font-Names="Comic Sans MS" ></asp:Label>
                            </div>
                            <div class="blog-month-value">
                                <asp:Label runat="server" ID="month" Font-Names="微软雅黑"></asp:Label>
                            </div>
                            <div class="blog-year-value">
                                <asp:Label runat="server" ID="year" Font-Names="Consolas"></asp:Label>
                            </div>
                        </div>
                        <div class="blog-content-wrapper">
                            <h1 class="blog-title" style="color:#1bc4de;">
                                <asp:Label ID="title" runat="server"></asp:Label>
                            </h1>
                            
                            <div class="blog-author" style="margin-top:20px;">
                                <span>
                                    发布人：
                                </span>
                                <asp:Label ID="author" runat="server"></asp:Label>
                            </div>
                            <div class="clear"></div>
                            <div class="clear"></div>
                            </div>
                            </div>
                            </div>
                        <asp:DataList ID="announce" runat="server"   BorderStyle="None" BorderWidth="0" CellPadding="0" 
                                CellSpacing="0">
                            <ItemTemplate>
                        <div class="blog-content-wrapper" style="padding-top:20px;padding-left:20px;padding-right:20px;">
                                <div class="blog-content" style="font-size:15px;color:#4a4a4a;font-family:微软雅黑;">
                                    <p><%#DataBinder.Eval(Container.DataItem,"announcementinfo")%></p>
                                </div>
                            </div>
                            </ItemTemplate>
                        </asp:DataList>
                    </div>
                </div>
            </div>
        </div>
        
    </div>
</div> 
</asp:Content>

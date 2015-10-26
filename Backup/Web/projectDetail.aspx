<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="projectDetail.aspx.cs" Inherits="Interwebsite.projectDetail" %>
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
	                        <img src="img/project.png" style="width:35px;margin-left:0px;"/>
	                        <h2 class="column-service-title" style="position:relative;margin-top:-30px;margin-left:50px;">
	                            合作项目<span class="sub-title">Projects</span>
	                        </h2>
                        </div>
                        <asp:DataList ID="project" runat="server"   BorderStyle="None" BorderWidth="0" CellPadding="0" 
                                CellSpacing="0">
                            <ItemTemplate>
                        <div class="blog-content-wrapper">
                            <div class="stunning-text-inner-wrapper gdl-border-x bottom">
                            
                            <h1 class="blog-title" style="color:#4a4a4a;" runat="server">
                                <p><%#DataBinder.Eval(Container.DataItem,"projectname")%></p>
                            </h1>
                            </div>
                        </div>
                        <div class="blog-content-wrapper">
                            <div class="stunning-text-inner-wrapper gdl-border-x bottom">
                            <h1 class="blog-title" style="color:#1bc4de;">
                                <span>项目简介(Introduction)</span>
                            </h1>
                            <div class="clear"></div>
                            <div class="clear"></div>
                            <br />
                            <div class="blog-content" style="font-size:15px;color:#4a4a4a;font-family:微软雅黑;">
                                <p><%#DataBinder.Eval(Container.DataItem,"projectInfo")%></p>
                            </div>
                            </div>
                        </div>
                        <div class="blog-content-wrapper">
                            <div class="stunning-text-inner-wrapper gdl-border-x bottom">
                            <h1 class="blog-title" style="color:#1bc4de;">
                                <span>招生简章(Enrollment Guide)</span>
                            </h1>
                            <div class="clear"></div>
                            <div class="clear"></div>
                            <br />
                            <div class="blog-content" style="font-size:15px;color:#4a4a4a;font-family:微软雅黑;">
                                <p><%#DataBinder.Eval(Container.DataItem,"recruitguide")%></p>
                            </div>
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

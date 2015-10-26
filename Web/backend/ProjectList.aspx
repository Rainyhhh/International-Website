<%@ Page Title="" Language="C#" MasterPageFile="Manage.Master" AutoEventWireup="true" CodeBehind="ProjectList.aspx.cs" Inherits="Interwebsite.Web.backend.ProjectList" %>
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
	                            修改项目<span class="sub-title">Edit</span>
	                        </h2>
                            <div class="custom-sidebar" style="font-size:12pt">
                                    <ul>
                                    <li class="cat-item cat-item-3" style="border-bottom:inset;">
                                        <span><asp:HyperLink ID="HyperLink1" runat="server" Text="sdfjlwkejfwelfkwlef"></asp:HyperLink></span>
                                        <span style="float:right;">
                                         <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="#">修改</asp:HyperLink>
                                        <asp:LinkButton ID="HyperLink3" runat="server">删除</asp:LinkButton></span>
                                        <span style="float:right;margin-right:3%;">3242432423</span>
                                    </li>
                                    </ul>
							</div>
                        </div>
                    </div>
                    <div class="clear"></div>
					<div class="gdl-pagination">
						<asp:LinkButton Cssclass="current" id="LinkFirst" onclick="LinkFirst_Click" runat="server">
							首页
						</asp:LinkButton> 
						<asp:LinkButton Cssclass="current" id="LinkPrevious" onclick="LinkPrevious_Click" runat="server">
							上一页
						</asp:LinkButton>
                        <asp:Label CssClass="current"  ID="LinkBtnPageInfo" runat="server"></asp:Label>                                     
						<asp:LinkButton Cssclass="current" id="LinkNext" onclick="LinkNext_Click" runat="server">
							下一页
						</asp:LinkButton>
						<asp:LinkButton class="current" id="LinkLast" onclick="LinkLast_Click" runat="server">
							末页
						</asp:LinkButton>
						<div class="clear">
						</div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</asp:Content>

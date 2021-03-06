﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="announcement.aspx.cs" Inherits="Interwebsite.announcement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="gdl-page-left mb0 eight columns" style="margin-top:20px;">
		<div class="row">
			<div class="gdl-page-item mb0 twelve columns">
			<div class="row">
				<div class="twelve columns mb40">
	                <div class="column-service-wrapper">
	                    <div class="column-service-title-wrapper">
	                        <img src="img/announce.png" style="width:35px;margin-left:0px;"/>
	                        <h2 class="column-service-title" style="position:relative;margin-top:-30px;margin-left:50px;">
	                            新闻公告<span class="sub-title">Announcements</span>
	                        </h2>
	                        <div class="custom-sidebar" style="font-size:12pt">
                                <asp:repeater id="announcementList" runat="server">
                                    <ItemTemplate>
                                    <ul>
                                    <li class="cat-item cat-item-3">
                                        <span><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/announcementDetail.aspx?id=" + DataBinder.Eval(Container.DataItem,"id") %>' Text='<%#DataBinder.Eval(Container.DataItem, "AnnouncementName").ToString().Length>25?DataBinder.Eval(Container.DataItem, "AnnouncementName").ToString().Substring(0,25)+"...":DataBinder.Eval(Container.DataItem, "AnnouncementName")%>'></asp:HyperLink></span>
                                        <span style="float:right;"><%# DataBinder.Eval(Container.DataItem,"ModifyTime") %></span>
                                    </li>
                                    </ul>
                                    </ItemTemplate>
                                </asp:repeater>
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
				<div class="clear"></div>
			</div>
		</div>
	</div>
</div>
                
</asp:Content>

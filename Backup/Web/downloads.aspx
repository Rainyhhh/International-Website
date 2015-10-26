<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="downloads.aspx.cs" Inherits="Interwebsite.downloads" %>
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
	                                <img src="img/attachment.png" style="width:35px;margin-left:0px;"/>
	                                <h2 class="column-service-title" style="position:relative;margin-top:-30px;margin-left:50px;">
	                                    文档下载<span class="sub-title">Attachments</span>
	                                </h2>
	                                <div class="custom-sidebar" style="font-size:12pt">
									    <asp:repeater id="attachmentList" runat="server">
                                            <ItemTemplate>
                                            <ul>
                                                <li class="cat-item cat-item-3">
											    <a>
												    <%# DataBinder.Eval(Container.DataItem,"attachmentname") %>
											    </a>
                                                <asp:LinkButton ID="LinkButton2" CssClass="current" onclick="download" style="float:right;" runat="server" CommandArgument='<%# DataBinder.Eval(Container.DataItem,"attachmentname") %>' CommandName='<%# DataBinder.Eval(Container.DataItem,"attachmentaddress") %>'>
                                                    下载
                                                </asp:LinkButton>
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


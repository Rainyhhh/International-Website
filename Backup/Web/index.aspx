<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Interwebsite._index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>厦门大学软件学院硕士交流项目</title>
    <!--[if lt IE 9]>
        <script src="http://html5shiv.googlecode.com/svn/trunk/html5.js">
        </script>
    <![endif]-->
    <link rel="stylesheet" href="css/style.css" type="text/css"/>
    <meta name="viewport" content="width=device-width, user-scalable=no"/>
    <link rel="stylesheet" href="css/foundation-responsive.css"/>
    <link rel="stylesheet" id="style-custom-css" href="css/style-custom.css"
    type="text/css" media="all"/>
    <link rel="stylesheet" id="layerslider_css-css" href="css/layerslider.css"
    type="text/css" media="all"/>
    <link rel="stylesheet" id="superfish-css" href="css/superfish.css" type="text/css"
    media="all"/>
    <link rel="stylesheet" id="fancybox-css" href="css/fancybox.css" type="text/css"
    media="all"/>
    <link rel="stylesheet" id="fancybox-thumbs-css" href="css/jquery.fancybox-thumbs.css"
    type="text/css" media="all"/>
    <link rel="stylesheet" id="flex-slider-css" href="css/flexslider.css"
    type="text/css" media="all"/>
    <!-- <div class="fit-vids-style">­
    <style>
    .fluid-width-video-wrapper { width: 100%; position: relative; padding:
    0; } .fluid-width-video-wrapper iframe, .fluid-width-video-wrapper object,
    .fluid-width-video-wrapper embed { position: absolute; top: 0; left: 0;
    width: 100%; height: 100%; }
    </style>
    </div> -->
    <script type="text/javascript" async="" src="js/ga.js">
    </script>
    <script type="text/javascript" src="js/jquery.js">
    </script>
    <style type="text/css">
    </style>
    <script type="text/javascript" src="js/layerslider.kreaturamedia.jquery.js">
    </script>
    <script type="text/javascript" src="js/jquery-easing-1.3.js">
    </script>
    <script type="text/javascript" src="js/jquery.fitvids.js">
    </script>
    <script type="text/javascript" src="js/comment-reply.js">
    </script>
    <script type="text/javascript">
        var _gaq = _gaq || [];
        _gaq.push(['_setAccount', 'UA-28008475-11']);
        _gaq.push(['_trackPageview']); (function () {
            var ga = document.createElement('script');
            ga.type = 'text/javascript';
            ga.async = true;
            ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
            var s = document.getElementsByTagName('script')[0];
            s.parentNode.insertBefore(ga, s);
        })();
    </script>
    <style type="text/css">
        .recentcomments a{display:inline !important;padding:0 !important;margin:0
        !important;}
    </style>
    <link rel="stylesheet" href="css/skin.css" type="text/css"/>
</head>

<body class="home page page-id-9 page-template-default">
<form runat="server">
<div class="body-outer-wrapper">
		<div class="body-wrapper boxed-style">		
		<div class="top-navigation-wrapper boxed-style">
















		</div>
			<div class="header-wrapper main" style="background: white;">
				<div class="logo-wrapper" style="margin-left:40px;">
					<h1><a href="#"><img src="img/default.png" alt="default-logo"/></a></h1>
				</div>
                <div class="logo-right-text" style="margin-top:0px;">
                    <div class="logo-right-text-content" style="margin-top:10px;margin-right:20px;margin-bottom:10px;">
                        <img src="img/register.png" style="width:20px;margin-left:0px;" />
                        <a style="font-size: 12pt; color: #aaa;font-family:微软雅黑;" href="background/login.aspx">管理登录<span class="sub-title">
                                    Login
                                  </span></a>
                    </div>
                </div>
				<div class="clear"></div>
        <div class="gdl-navigation-wrapper">
						<div class="responsive-menu-wrapper">
							<select id="menu-main" class="menu dropdown-menu">
							<option value="" class="blank">– Main Menu –</option>
							<option class="menu-item menu-item-type-post_type menu-item-object-page menu-item-2471 menu-item-depth-0" value="index.aspx">首页</option>	
							<option class="menu-item menu-item-type-post_type menu-item-object-page menu-item-2471 menu-item-depth-0" value="apply.aspx">在线报名</option>	
							<option class="menu-item menu-item-type-post_type menu-item-object-page menu-item-2526 menu-item-depth-0" value="projects.aspx">合作项目</option>	
							<option class="menu-item menu-item-type-post_type menu-item-object-page menu-item-2527 menu-item-depth-0" value="announcement.aspx">公告新闻</option>	
							<option class="menu-item menu-item-type-post_type menu-item-object-page menu-item-2499 menu-item-depth-0" value="downloads.aspx">文档下载</option>
                            <option class="menu-item menu-item-type-post_type menu-item-object-page menu-item-2499 menu-item-depth-0" value="contact.aspx">联系我们</option>		
							</select>
						</div>
          <div class="clear">
          </div>
          <div class="navigation-wrapper">
            <div id="main-superfish-wrapper" class="menu-wrapper">
              <ul id="menu-main-1" class="sf-menu sf-js-enabled">
                <li id="menu-item-2466" style="width: 130px;text-align: center;margin-left:60px;"  class="menu-item menu-item-type-post_type menu-item-object-page  menu-item-2466">
                  <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="index.aspx" ToolTip="homepage">
                    首页
                  </asp:HyperLink>
                </li>
                <li id="menu-item-2471" style="width: 130px;text-align: center;" class="menu-item menu-item-type-post_type menu-item-object-page menu-item-2471">
                  <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="apply.aspx" ToolTip="register">
                    在线报名
                  </asp:HyperLink>
                </li>
                <li id="menu-item-2526" style="width: 130px;text-align: center;"  class="menu-item menu-item-type-post_type menu-item-object-page menu-item-2526">
                  <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="projects.aspx" ToolTip="projects" >
                    合作项目
                  </asp:HyperLink>
                </li>
                <li id="menu-item-2527" style="width: 130px;text-align: center;"  class="menu-item menu-item-type-post_type menu-item-object-page menu-item-2527">
                  <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="announcement.aspx" ToolTip="announcements">
                    公告新闻
                  </asp:HyperLink>
                </li>
                <li id="menu-item-2499" style="width: 130px;text-align: center;"  class="menu-item menu-item-type-post_type menu-item-object-page menu-item-2499">
                  <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="downloads.aspx" ToolTip="download">
                    文档下载
                  </asp:HyperLink>
                </li>
                <li id="menu-item-2472" style="width: 130px;text-align: center;"  class="menu-item menu-item-type-post_type menu-item-object-page menu-item-2472">
                  <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="contact.aspx" ToolTip="contact us">
                    联系我们
                  </asp:HyperLink>
                </li>
              </ul>
            </div>
            <div class="clear">
            </div>
          </div>
          <div class="clear">
          </div>
        </div>
        <div class="content-wrapper container main">
          <div id="post-9" class="post-9 page type-page status-publish hentry">
            <div class="page-wrapper single-page ">
              <div class="gdl-top-slider">
                <div class="gdl-top-layer-slider-wrapper">
                  <script type="text/javascript">
                      jQuery(document).ready(function () {
                          jQuery("#layerslider_1").layerSlider({
                              width: '940px',
                              height: '395px',
                              responsive: true,
                              autoStart: true,
                              pauseOnHover: true,
                              firstLayer: 1,
                              animateFirstLayer: true,
                              twoWaySlideshow: true,
                              keybNav: true,
                              touchNav: true,
                              imgPreload: true,
                              navPrevNext: true,
                              navStartStop: true,
                              navButtons: true,
                              skin: 'bluediamond',
                              skinsPath: 'http://themes.goodlayers2.com/bluediamond/wp-content/plugins/LayerSlider/skins/',
                              globalBGColor: 'transparent',
                              yourLogo: false,
                              yourLogoStyle: 'position: absolute; left: 10px; top: 10px; z-index: 99;',
                              yourLogoLink: false,
                              yourLogoTarget: '_self',

                              loops: 0,
                              forceLoopNum: true,
                              autoPlayVideos: false,

                              autoPauseSlideshow: 'auto',
                              youtubePreview: 'maxresdefault.jpg',

                              cbInit: function (element) { },
                              cbStart: function (data) { },
                              cbStop: function (data) { },
                              cbPause: function (data) { },
                              cbAnimStart: function (data) { },
                              cbAnimStop: function (data) { },
                              cbPrev: function (data) { },
                              cbNext: function (data) { }
                          });
                      });
                  </script>
                  <div id="layerslider_1" style="margin: 0px auto; position: relative; visibility: visible;"
                  class="ls-container ls-bluediamond">
                    <div class="ls-inner" style="background-color: transparent; width: 940px; height: 395px;">
                      <div class="ls-layer ls-active" style="width: 940px; height: 395px; left: 0px; right: auto; top: 0px; bottom: auto; visibility: visible; display: none;">
                        <img class="ls-s2" src="./img/pic5.jpg" alt="slider4" style="position: absolute; top: -2px; left: -2px; margin-left: 0px; margin-top: 0px; width: 945px; height: 400px; padding: 0px; border-width: 0px; display: none;"/>
                        <asp:HyperLink runat="server" CssClass="ls-s2" style="position: absolute; top: 25px; left: 25px; font-size: 30px; font-weight: normal; color:#1bc4de; font-family:微软雅黑; white-space: nowrap; width: auto; height: auto; padding: 0px; border-width: 0px; margin-left: -846px; margin-top: 0px; display: block;" NavigateUrl="~/projects.aspx">美国北卡罗来纳大学夏洛特分校留学项目</asp:HyperLink>
                      </div>
                      <div class="ls-layer ls-active" style="width: 940px; height: 395px; left: 0px; right: auto; top: 0px; bottom: auto; visibility: visible; display: none;">
                        <img class="ls-s2" src="./img/pic2.jpg" alt="slider4" style="position: absolute; top: -2px; left: -2px; margin-left: 0px; margin-top: 0px; width: 945px; height: 400px; padding: 0px; border-width: 0px; display: none;"/>
                      </div>
                      <div class="ls-layer ls-active" style="width: 940px; height: 395px; left: 0px; right: auto; top: 0px; bottom: auto; visibility: visible; display: none;">
                        <img class="ls-s2" src="./img/pic3.jpg" alt="slider4" style="position: absolute; top: -2px; left: -2px; margin-left: 0px; margin-top: 0px; width: 945px; height: 400px; padding: 0px; border-width: 0px; display: none;"/>
                      </div>
                      <div class="ls-layer ls-active" style="width: 940px; height: 395px; left: 0px; right: auto; top: 0px; bottom: auto; visibility: visible; display: none;">
                        <img class="ls-s2" src="./img/pic4.jpg" alt="slider4" style="position: absolute; top: -2px; left: -2px; margin-left: 0px; margin-top: 0px; width: 945px; height: 400px; padding: 0px; border-width: 0px; display: none;"/>
                      </div>
                    </div>
                    <a class="ls-nav-prev" href="http://themes.goodlayers2.com/bluediamond/#">
                    </a>
                    <a class="ls-nav-next" href="http://themes.goodlayers2.com/bluediamond/#">
                    </a>
                  </div>
                  <div class="clear">
                  </div>
                </div>
                <div class="row gdl-page-row-wrapper">
                  <div class="gdl-page-left mb0 twelve columns">
                    <div class="row">
                      <div class="gdl-page-item mb0 twelve columns">
                        <div class="row">
                          <div class="twelve columns mb0">
                            <div class="gdl-page-content">
                            </div>
                          </div>
                          <div class="clear">
                          </div>
                        </div>
                        <div class="row">
                          <div class="nine columns ">
                            <div class="column-service-wrapper">
                              <div class="column-service-title-wrapper">
                                <img src="img/announce.png" style="width:35px;margin-left:0px;"/>
                                <h2 class="column-service-title" style="position:relative;margin-top:-30px;margin-left:50px;">
                                  新闻公告
                                  <span class="sub-title">
                                    Announcements
                                  </span>
                                </h2>
                                <div class="custom-sidebar">                      
                                    <asp:repeater id="announcementList" runat="server">
                                        <ItemTemplate>
                                            <ul>
                                            <li>
                                        <span><asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "~/announcementDetail.aspx?id=" + DataBinder.Eval(Container.DataItem,"id") %>' Text='<%#DataBinder.Eval(Container.DataItem, "AnnouncementName").ToString().Length>25?DataBinder.Eval(Container.DataItem, "AnnouncementName").ToString().Substring(0,25)+"...":DataBinder.Eval(Container.DataItem, "AnnouncementName")%>'></asp:HyperLink></span>
                                        <span style="float:right;"><%# DataBinder.Eval(Container.DataItem,"ModifyTime") %></span>
                                            </li>
                                            </ul>
                                        </ItemTemplate>
                                        </asp:repeater>                                  
                                </div>
                                <a class="gdl-button" href="announcement.aspx">
                                  More ...
                                </a>
                              </div>
                            </div>
                          </div>
                          <div class="three columns  gdl-border-y">
                            <div class="column-service-wrapper">
                              <div class="column-service-title-wrapper">
                                <img src="img/login.png" style="width:35px;margin-left:0px;"/>
                                <h2 class="column-service-title" style="position:relative;margin-top:-30px;margin-left:50px;">
                                  学生登录
                                  <span class="sub-title">
                                    Login
                                  </span>
                                </h2>
                                <div class="contact-form-wrapper">
                                  <form class="gdl-contact-form ">
                                    <ol class="forms">
                                      <li class="form-input">
                                        <strong>
                                          用户名:
                                        </strong>
                                        <input type="text" id="Username" class="require-field" runat="server" style="width:70%;margin-right:10% !important;"/>
                                      </li>
                                      <li class="form-input">
                                        <strong>
                                          密码:
                                        </strong>
                                        <input type="password" id="Pass" class="require-field password" runat="server" style="width:70%;"/>
                                      </li>
                                      <!-- <li><input type="hidden" name="receiver" value="ss@ss.ss"></li> -->
                                      <li class="buttons">
                                        <asp:LinkButton ID="LinkButton1"  CssClass="contact-submit button" style="float: right;" runat="server" OnClick="login" BackColor="#1bc4de" ForeColor="White" Font-Bold="true">
                                          登录
                                        </asp:LinkButton>
                                      </li>
                                      <li>
                                          <asp:Label ID="errors" runat="server" Text="" ForeColor="Red"></asp:Label>
                                      </li>
                                    </ol>
                                  </form>
                                  <div class="clear">
                                  </div>
                                </div>
                              </div>
                            </div>
                          </div>
                          <div class="clear">
                          </div>
                        </div>
                        <!-- 我是分割线 -->
                        <div class="row">
                          <div class="twelve columns mb40">
                            <div class="gdl-header-wrapper">
                              <img src="img/advan.png" style="width:35px;margin-left:0px;"/>
                              <h2 class="column-service-title" style="position:relative;margin-top:-30px;margin-left:50px; font-size:14pt;">
                                我们的优势
                                <span class="sub-title">
                                  Advantages
                                </span>
                              </h2>
                            </div>
                            <div class="portfolio-carousel-wrapper">
                              <div class="portfolio-item-holder row" data-index="0" data-num="4" data-width="240"
                              data-max="7" style="width: 1680px; margin-left: -10px;">
                                <div class="three columns portfolio-item mb0" style="float: left; width: 240px; height: 288px;">
                                  <div class="portfolio-media-wrapper gdl-image">
                                    <a data-rel="fancybox" data-fancybox-group="gal0" title="Justo Malesuada Ullem">
                                      <span class="portfolio-thumbnail-image-hover">
                                      </span>
                                      <span class="hover-zoom hover-icon">
                                      </span>
                                    </a>
                                    <img src="img/advantage2.jpg" alt="与国外知名高校合作" title="与国外知名高校合作"/>
                                  </div>
                                  <div class="portfolio-context">
                                    <h2 class="portfolio-title">
                                      <a>
                                        与国外知名高校合作
                                      </a>
                                    </h2>
                                    <div class="portfolio-tag">
                                      <a>
                                        cooperation
                                      </a>
                                      ,
                                      <a>
                                        foreign
                                      </a>
                                    </div>
                                  </div>
                                  <div class="clear">
                                  </div>
                                </div>
                                <div class="three columns portfolio-item mb0" style="float: left; width: 240px; height: 288px;">
                                  <div class="portfolio-media-wrapper gdl-image">
                                    <a data-rel="fancybox" data-fancybox-group="gal0" title="Justo Malesuada Ullem">
                                      <span class="portfolio-thumbnail-image-hover">
                                      </span>
                                      <span class="hover-zoom hover-icon">
                                      </span>
                                    </a>
                                    <img src="img/advantage1.jpg" alt="师资力量强大"/>
                                  </div>
                                  <div class="portfolio-context">
                                    <h2 class="portfolio-title">
                                      <a>
                                        师资力量强大
                                      </a>
                                    </h2>
                                    <div class="portfolio-tag">
                                      <a>
                                        teachers
                                      </a>
                                      ,
                                      <a>
                                        strength
                                      </a>
                                    </div>
                                  </div>
                                  <div class="clear">
                                  </div>
                                </div>
                                <div class="three columns portfolio-item mb0" style="float: left; width: 240px; height: 288px;">
                                  <div class="portfolio-media-wrapper gdl-image">
                                    <a data-rel="fancybox" data-fancybox-group="gal0" title="Justo Malesuada Ullem">
                                      <span class="portfolio-thumbnail-image-hover">
                                      </span>
                                      <span class="hover-zoom hover-icon">
                                      </span>
                                    </a>
                                    <img src="img/advantage3.jpg" alt="教学模式新颖"/>
                                  </div>
                                  <div class="portfolio-context">
                                    <h2 class="portfolio-title">
                                      <a>
                                        教学模式新颖
                                      </a>
                                    </h2>
                                    <div class="portfolio-tag">
                                      <a>
                                        teaching pattern
                                      </a>
                                      ,
                                      <a>
                                        fashion
                                      </a>
                                    </div>
                                  </div>
                                  <div class="clear">
                                  </div>
                                </div>
                                <div class="three columns portfolio-item mb0" style="float: left; width: 240px; height: 288px;">
                                  <div class="portfolio-media-wrapper gdl-image">
                                    <a data-rel="fancybox" data-fancybox-group="gal0" title="Justo Malesuada Ullem">
                                      <span class="portfolio-thumbnail-image-hover">
                                      </span>
                                      <span class="hover-zoom hover-icon">
                                      </span>
                                    </a>
                                    <img src="img/advantage4.jpg" alt="毕业即可获得国外高校硕士学位"/>
                                  </div>
                                  <div class="portfolio-context">
                                    <h2 class="portfolio-title">
                                      <a>
                                        毕业即可获得国外高校硕士学位
                                      </a>
                                    </h2>
                                    <div class="portfolio-tag">
                                      <a>
                                        graduation
                                      </a>
                                      ,
                                      <a>
                                        master degree
                                      </a>
                                    </div>
                                  </div>
                                  <div class="clear">
                                  </div>
                                </div>
                              </div>
                              <div class="clear">
                              </div>
                            </div>
                            <div class="clear">
                            </div>
                          </div>
                          <div class="clear">
                          </div>
                        </div>
                        </div>
                        </div>                    
                  </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
                        <div class="copyright-outer-wrapper boxed-style">
                          <div class="container copyright-container">
                            <div class="copyright-wrapper">
                              <div class="copyright-left">
                                ©Copyright
                                <a href="http:software.xmu.edu.cn" target="_blank">
                                  Software School of Xiamen University
                                </a>
                              </div>
                              <div class="clear">
                              </div>
                            </div>
                          </div>
                        </div>
                      
            
                </div>
            </div>
    </div>
    </form>
</body>
</html>
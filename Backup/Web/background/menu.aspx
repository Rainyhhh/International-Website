<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="Interwebsite.Web.background.menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>无标题文档</title>
<style type="text/css">
html, body {height:100%;overflow:hidden;} /*为兼容ie7,ff*/
body {font-family:Arial, Helvetica, sans-serif; font-size:12px; margin:0px; text-align:center; border-right:1px #ccc solid;}
a {color: #000; text-decoration: none;}
#menu img {_margin-top: 12px;}/*没办法,ie6对list-style-image支持不好*/
#all {width: 100%;height:100%;}
#menu {width: 96%;}
#menu ul {padding:0; margin: 0; list-style: none;}
#menu ul li {background-image:url(/match/public/images/menu_bg.gif); background-repeat: repeat-x; background-position:center; height: 32px;;margin-top: 2px; margin-bottom: 2px; border:1px #ccc solid; line-height: 2.8;}
</style>
</head>

<body>
<div id="all">
    <div id="menu">
        <ul>
            <li><img src="images/li.jpg" />&nbsp;&nbsp;&nbsp; <a href="Publish.aspx" target="main">发布公告</a></li>
            <li><img src="images/li.jpg" />&nbsp;&nbsp;&nbsp; <a href="apply.aspx" target="main">查看报名情况</a></li>
            <li><img src="images/li.jpg" />&nbsp;&nbsp;&nbsp; <a href="NoticeManage.aspx" target="main">公告管理</a></li>
            <li><img src="images/li.jpg" />&nbsp;&nbsp;&nbsp; <a href="AddProject.aspx" target="main">添加项目</a></li>
        </ul>
    </div>
</div>
</body>
</html>

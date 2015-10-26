<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="Interwebsite.Web.background.main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <meta charset="utf-8">
  <title>Adminity - Dashboard</title>
  <link rel="shortcut icon" href="images/favicon.gif">
  <!---CSS Files-->
  <link rel="stylesheet" href="css/master.css">
  <link rel="stylesheet" href="css/tables.css">
  <!---jQuery Files-->
  <script src="js/jquery-1.7.1.min.js"></script>
  <script src="js/jquery-ui-1.8.17.min.js"></script>
  <script src="js/styler.js"></script>
  <script src="js/jquery.tipTip.js"></script>
  <script src="js/colorpicker.js"></script>
  <script src="js/sticky.full.js"></script>
  <script src="js/global.js"></script>
  <script src="js/flot/jquery.flot.min.js"></script>
  <script src="js/flot/jquery.flot.resize.min.js"></script>
  <script src="js/jquery.dataTables.min.js"></script>
  <!---Fonts-->
  <link href='http://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700' rel='stylesheet' type='text/css'>
  <link href='http://fonts.googleapis.com/css?family=Ubuntu:500' rel='stylesheet' type='text/css'>
  <!--[if lt IE 9]>
  <script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
  <![endif]-->
  <!--[if lte IE 8]>
  <script language="javascript" type="text/javascript" src="js/flot/excanvas.min.js"></script>
  <![endif]-->
</head>
<body>

  

  <!--- CONTENT AREA -->

  <div class="content container_12">
      <div class="ad-notif-info grid_12"><p>Welcome to Adminity! You can dismiss me by clicking me!</p></div>
      <div class="box grid_3">
        <div class="box-head"><h2>新闻</h2></div>
        <div class="box-content">
          <p>This is a simple panel. All panels in Adminity are collapsible by clicking on the header.
          <br>
          Creating a panel like this one is very easy, 
          you only need 3 divs with classes 'box', 'box-head' and 'box-content'.
          <br><br>
          Adminity also includes a styler. Open it by clicking the eye icon near the logo. A tooltip will tell you what color each colorpicker changes.<br><br>
          <input type="button" class="button green" value="Read more" />
          </p>
        </div>
      </div>
      <div class="box grid_3">
        <div class="box-head"><span class="box-icon-24 fugue-24 counter"></span><h2>报名情况</h2></div>
        <div class="box-content ad-stats">
          <ul>
            <li><h3>李二狗</h3> Unique Visitors</li>
            <li class="stats-up"><h3>张三</h3> Page Views</li>
            <li class="stats-up"><h3>李四</h3> Ad Revenue</li>
            <li class="stats-down"><h3>王五</h3> Maintenance Costs</li>
            <li class="stats-up"><h3>赵六</h3> Moved up Google</li>
          </ul>
        </div>
      </div>
     
    

<script>    /* SCRIPTS */
    $(function () {
        var sin = [], cos = [];
        for (var i = 0; i < 14; i += 0.5) {
            sin.push([i, Math.sin(i)]);
            cos.push([i, Math.cos(i)]);
        }
        var plot = $.plot($("#flot-demo"),
             [{ data: sin, label: "Green", color: "#71a100" }, { data: cos, label: "Blue", color: "#308eef"}], {
                 series: {
                     lines: { show: true },
                     points: { show: true }
                 },
                 grid: { hoverable: true },
                 yaxis: { min: -1.2, max: 1.2 }
             });
        var previousPoint = null;
        $("#flot-demo").bind("plothover", function (event, pos, item) {
            if ($("#enablePosition:checked").length > 0) {
                var str = "(" + pos.x.toFixed(2) + ", " + pos.y.toFixed(2) + ")";
                $("#hoverdata").text(str);
            }
        });
    }); /* for the flot chart demo */

    $('#example').dataTable({
        "bJQueryUI": true
    }); /* For the data tables */
</script>

<div style="display:none"><script src='http://v7.cnzz.com/stat.php?id=155540&web_id=155540' language='JavaScript' charset='gb2312'></script></div>
</body>
</html>


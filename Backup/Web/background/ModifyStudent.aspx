<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyStudent.aspx.cs" Inherits="Interwebsite.Web.background.ueditor_mini1_0_0_src.ueditor_mini1_0_0_src.examples.ModifyProject" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
 <meta http-equiv="Content-Type" content="text/html;charset=utf-8"/>
    <title>UMEDITOR 过滤规则定制化</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script type="text/javascript" src="jquery.js"></script>
    <style type="text/css">
        h1{
            font-family: "微软雅黑";
            font-weight: normal;
        }
    </style>
</head>
<body>
<form runat="server">
   <div class="gdl-page-left mb0 eight columns" style="margin-top:20px;">
	<div class="row">
		<div class="gdl-page-item mb0 pb20 gdl-blog-full twelve columns">
			<div class="row">
				<div class="twelve columns mb40">
	                <div class="column-service-wrapper">
	                    <div class="column-service-title-wrapper">
	                        <img src="images/register.png" style="width:35px;margin-left:0px;"/>
	                        <h2 class="column-service-title" style="position:relative;margin-top:-30px;margin-left:50px; font-family:@微软雅黑">
	                            学生信息<span class="sub-title" style="font-family:@Dotum;">/Student Information</span>
	                        </h2>
                            
                            <div class="gdl-page-left mb0 six columns" style="margin-top:20px;" style="min-height:942px;">
                            <div class="gdl-sidebar-wrapper gdl-border-y right" >
                                <h1 class="blog-title" style="color:#1bc4de;font-size:17px;">
                                    <span>项目选择(Program Details)</span>
                                </h1>
                                <div class="contact-form-wrapper">
                                  <form class="gdl-contact-form " action="">
                                    <ol class="forms">
                                      <li>
                                        <strong>首选项目：</strong>
                                        <asp:TextBox ID="preferedprogram" runat="server"></asp:TextBox>
                                      </li>
                                      <li>
                                        <strong>候补项目:</strong>
                                        <asp:TextBox ID="altprogram" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      </ol>
                                    </form>
                                </div>
                            </div>
                            <div class="stunning-text-inner-wrapper gdl-border-x bottom">
                                <h1 class="blog-title" style="color:#1bc4de;font-size:17px;">
                                    <span>学习经历(Education Information)</span>
                                </h1>
                                <div class="contact-form-wrapper">
                                  <form class="gdl-contact-form " action="">
                                    <ol class="forms">
                                      <li class="form-input">
                                        <strong>毕业院校：</strong>
                                        <asp:TextBox ID="graduated" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>专业:</strong>
                                        <asp:TextBox ID="major" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>毕业年份:</strong>
                                        <asp:TextBox ID="gradyear" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>入学年份:</strong>
                                        <asp:TextBox ID="startyear" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>英语水平:</strong>
                                        <asp:TextBox ID="englishskill" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>本科GPA:</strong>
                                        <asp:TextBox ID="gpa" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      </ol>
                                    </form>
                                </div>
                            </div>
                            <div class="stunning-text-inner-wrapper gdl-border-x bottom">
                                <h1 class="blog-title" style="color:#1bc4de;font-size:17px;">
                                    <span>奖惩情况(Performance)</span>
                                </h1>
                                <div class="contact-form-wrapper">
                                  <form class="gdl-contact-form " action="">
                                    <ol class="forms">
                                      <li class="form-input">
                                        <strong>奖惩情况：</strong>
                                        <br /><asp:TextBox ID="rewardspunisment" runat="server" Width="80%" 
                                              Enabled="true" TextMode="MultiLine"></asp:TextBox>
                                      </li>
                                      </ol>
                                    </form>
                                </div>
                            </div>
                       </div>
                       </div>
                            <div class="gdl-page-right mb0 six columns" style="margin-top:20px;">
                            <div class="stunning-text-inner-wrapper gdl-border-x bottom">
                                <h1 class="blog-title" style="color:#1bc4de;font-size:17px;">
                                    <span>个人信息(Personal Information)</span>
                                </h1>
                                <div class="contact-form-wrapper">
                                  <form class="gdl-contact-form " action="">
                                    <ol class="forms">
                                      <li class="form-input">
                                        <strong>姓名：</strong>
                                        <asp:TextBox ID="name" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>性别:</strong>
                                        <asp:TextBox ID="gender" class="require-field password" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>身份证号:</strong>
                                        <asp:TextBox ID="idno" class="require-field password" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>政治面貌：</strong>
                                        <asp:TextBox ID="politic" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>民族：</strong>
                                        <asp:TextBox ID="nationality" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>户籍所在地：</strong>
                                        <asp:TextBox ID="city" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>联系地址(在校通讯地址):</strong>
                                        <asp:TextBox ID="address" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>邮政编码:</strong>
                                        <asp:TextBox ID="zipcode" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>手机(重要)：</strong>
                                        <asp:TextBox ID="phone" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>电子邮箱：</strong>
                                        <asp:TextBox ID="email" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>家庭居住地址：</strong>
                                        <asp:TextBox ID="famaddress" runat="server" Enabled="true"></asp:TextBox>
                                        </li>
                                      <li class="form-input">
                                        <strong>邮政编码:</strong>
                                        <asp:TextBox ID="famzipcode" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      </ol>
                                    </form>
                                </div>
                            </div>
                            <div class="stunning-text-inner-wrapper gdl-border-x bottom">
                                <h1 class="blog-title" style="color:#1bc4de;font-size:17px;">
                                    <span>家庭情况(Family Information)</span>
                                </h1>
                                <div class="contact-form-wrapper">
                                  <form class="gdl-contact-form " action="">
                                    <ol class="forms">
                                      <li class="form-input">
                                        <strong>姓名：</strong>
                                        <asp:TextBox ID="parid" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>亲属关系:</strong>
                                        <asp:TextBox ID="parrelation" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>工作单位:</strong>
                                        <asp:TextBox ID="parwork" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      <li class="form-input">
                                        <strong>联系电话:</strong>
                                        <asp:TextBox ID="parphone" runat="server" Enabled="true"></asp:TextBox>
                                      </li>
                                      </ol>
                                    </form>
                                </div>
                            </div>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>

    <div class="row">
		<div class="gdl-page-item mb0 pb20 gdl-blog-full twelve columns">
			<div class="row">
				<div class="twelve columns mb40">
	                <div class="column-service-wrapper">
	                    <div class="column-service-title-wrapper">
                              <div class="stunning-text-inner-wrapper gdl-border-x bottom">
                                <h1 class="blog-title" style="color:#1bc4de;font-size:17px;">
                                    <span>工作经历(Working Experience)</span>
                                </h1>
                                <div class="contact-form-wrapper">
                                  <form class="gdl-contact-form " action="">
                                    <ol class="forms">
                                      <li class="form-input">
                                        <strong>工作经历介绍（在校生填写实习经历社会实践亦可）:</strong>
                                        <asp:TextBox id="workexp" runat="server" Width="80%" Enabled="true" 
                                              TextMode="MultiLine"></asp:TextBox>
                                      </li>
                                      </ol>
                                    </form>
                                </div>
                            </div>
                            
                        </div>

                        &nbsp;</div>
                </div>
            </div>
        </div>
    </div>
</form>
</div>
</body>
</html>

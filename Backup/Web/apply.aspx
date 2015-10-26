<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="apply.aspx.cs" Inherits="Interwebsite.apply" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">    
    <script language="javascript" type="text/javascript">
// <![CDATA[
    function username_blur() {
        var username = document.getElementById("<%=username2.ClientID%>").value;
        var username2_require = document.getElementById("<%=username2_require.ClientID%>");
        if (username == "") {
            username2_require.innerHTML = "请输入用户名！";
            return false;
        }
        if (username.length < 8 || username.length > 18) {
            username2_require.innerHTML = "用户名长度不符合要求！";
            return false;
        }
        for (var i = 0; i < username.length; i++) {
            var text = username.charAt(i);
            if (!(text <= 9 && text >= 0) && !(text >= 'a' && text <= 'z') && !(text >= 'A' && text <= 'Z') && text != "_") {
                username2_require.innerHTML = "用户名只能是数字、字母、下划线组成！";
                break;
                return false;
            }
        }
        return true;
    }
    function password_blur() {
        var password = document.getElementById("<%=pass2.ClientID%>").value;
        var password_require = document.getElementById("password_require");
        if (password == "") {
            password_require.innerHTML = "请输入密码！";
            return false;
        }
        if (password.length < 8 || password.length > 20) {
            password_require.innerHTML = "密码长度不符合要求！";
            return false;
        }
        password_require.innerHTML = "（8-20位字符）";
        return true;
    }
    function password2_blur() {
        var password1 = document.getElementById("<%=pass2.ClientID%>").value;
        var password2 = document.getElementById("<%=Password2.ClientID%>").value;
        var password2_require = document.getElementById("password2_require");
        if (password1 != password2) {
            password2_require.innerHTML = "密码不一致！";
            return false;
        }
        password2_require.innerHTML = "";
        return true;
    }
    function name_blur() {
        var name = document.getElementById("<%=name.ClientID%>").value;
        var name_require = document.getElementById("name_require");
        if (name == "") {
            name_require.innerHTML = "姓名不能为空！";
            return false;
        }
        name_require.innerHTML = "";
        return true;
    }
    function sex_blur() {
        var sex = document.getElementById("<%=gender.ClientID%>").value;
        var sex_require = document.getElementById("sex_require");
        if (sex == "") {
            sex_require.innerHTML = "性别不能为空！";
            return false;
        }
        sex_require.innerHTML = "";
        return true;
    }
    function phone_blur() {
        var phone = document.getElementById("<%=phone.ClientID%>").value;
        var phone_require = document.getElementById("phone_require");
        if (phone == "") {
            phone_require.innerHTML = "电话不能为空！";
            return false;
        }
        for (var i = 0; i < phone.length; i++) {
            var text = phone.charAt(i);
            if (!(text <= 9 && text >= 0)) {
                phone_require.innerHTML = "电话号码只能是数字！";
                return false;
            }
        }
        phone_require.innerHTML = "";
        return true;
    }
    function email_blur() {
        var email = document.getElementById("<%=email.ClientID%>").value;
        var email_require = document.getElementById("email_require");
        if (email == "") {
            email_require.innerHTML = "邮箱不能为空！";
            return false;
        }
        for (var i = 0; i < email.length; i++) {
            var text = email.charAt(i);
            if (text == '@' && i!=email.length - 1) {
                email_require.innerHTML = "";
                return true;
            }
        }
        email_require.innerHTML = "邮箱格式不正确!";
        return false;
    };
    function total() {
        
        if (username_blur() && password_blur() && password2_blur() && name_blur() && sex_blur() && phone_blur() && email_blur()) {
            document.getElementById("<%=register.ClientID%>").click();
            
            return;
        }
        if (!username_blur()) {
            document.getElementById("<%=username2.ClientID%>").style["border-color"] = "red";
        }
        else document.getElementById("<%=username2.ClientID%>").style["border-color"] = "#e3e3e3";
        if (!password_blur()) {
            document.getElementById("<%=pass2.ClientID%>").style["border-color"] = "red";
        }
        else document.getElementById("<%=pass2.ClientID%>").style["border-color"] = "#e3e3e3";
        if(!password2_blur()) {
            document.getElementById("<%=Password2.ClientID%>").style["border-color"] = "red";
            }
        else document.getElementById("<%=Password2.ClientID%>").style["border-color"] = "#e3e3e3";
        if(!name_blur()) {
            document.getElementById("<%=name.ClientID%>").style["border-color"] = "red";
        }
        else document.getElementById("<%=name.ClientID%>").style["border-color"] = "#e3e3e3";
        if(!sex_blur()) {
            document.getElementById("<%=gender.ClientID%>").style["border-color"] = "red";
        }
        else document.getElementById("<%=gender.ClientID%>").style["border-color"] = "#e3e3e3";
        if(!phone_blur()) {
            document.getElementById("<%=phone.ClientID%>").style["border-color"] = "red";
        }
        else document.getElementById("<%=phone.ClientID%>").style["border-color"] = "#e3e3e3";
        if(!email_blur()) {
            document.getElementById("<%=email.ClientID%>").style["border-color"] = "red";
        }
        else document.getElementById("<%=email.ClientID%>").style["border-color"] = "#e3e3e3";
        return true;
    }

</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="gdl-page-left mb0 eight columns" style="margin-top:20px;">
	<div class="row">
		<div class="gdl-page-item mb0 pb20 gdl-blog-full twelve columns">
			<div class="row">
				<div class="twelve columns mb40">
	                <div class="column-service-wrapper">
	                    <div class="column-service-title-wrapper">
	                        <img src="img/register.png" style="width:35px;margin-left:0px;"/>
	                        <h2 class="column-service-title" style="position:relative;margin-top:-30px;margin-left:50px;">
	                            在线申请<span class="sub-title">Registration</span>
	                        </h2>
                            <div class="gdl-page-left mb0 six columns" style="margin-top:20px;" style="min-height:942px;">
                            <div class="gdl-sidebar-wrapper gdl-border-y right" >
                               <h1 class="blog-title" style="color:#1bc4de;font-size:17px;">
                                    <span>已有账号，直接登录...</span>
                                </h1>
                                <div class="contact-form-wrapper">
                                    <ol class="forms">
                                      <li class="form-input">
                                        <strong>用户名:</strong>
                                        <input type="text" id="username" name="username" class="require-field" runat="server" style="width:70%;"/>
                                      </li>
                                      <li class="form-input">
                                        <strong>密码:</strong>
                                        <input type="password" id="pass" class="require-field" runat="server" style="width:70%;"/>
                                      </li>
                                      <li class="buttons">
                                        <asp:LinkButton ID="LinkButton1"  CssClass="contact-submit button" style="float: right; margin-right:20px;" runat="server" OnClick="login" BackColor="#1bc4de" ForeColor="White" Font-Bold="true" BorderWidth="0">
                                          登录
                                        </asp:LinkButton>
                                      </li>
                                      <li>
                                          <asp:Label ID="errors" runat="server" Text="" ForeColor="Red"></asp:Label>
                                      </li>
                                      </ol>
                                </div> 
                       </div>
                    </div>
                            <div class="gdl-page-right mb0 six columns" style="margin-top:20px;">
                                <h1 class="blog-title" style="color:#1bc4de;font-size:17px;">
                                    <span>没有账号，先申请一个吧...</span>
                                </h1>
                                <div class="contact-form-wrapper">
                                    <ol class="forms">
                                      <li class="form-input">
                                        <strong>用户名:</strong>
                                        <input type="text" id="username2" name="username2" class="require-field" runat="server" style="width:70%;" onblur="username_blur()"/>
                                        <span runat="server" id="username2_require" style="font-size:small; font-family:微软雅黑; color:red; margin-left:80px;">（8-20位字母、数字或'_'组成）</span>
                                      </li>
                                      <li class="form-input">
                                        <strong>密码:</strong>
                                        <input type="password" id="pass2" class="require-field" runat="server" style="width:70%;" onblur="password_blur()"/>
                                        <br /><span id="password_require" style="font-size:small; font-family:微软雅黑; color:red; margin-left:80px;">（8-20位字符）</span>
                                      </li>
                                      <li class="form-input">
                                        <strong>确认密码:</strong>
                                        <input type="password" id="Password2" class="require-field" runat="server" style="width:70%;" onblur="password2_blur()"/>
                                        <br /><span id="password2_require" style="font-size:small; font-family:微软雅黑; color:red; margin-left:80px;"></span>
                                      </li>
                                      <li class="form-input">
                                        <strong>姓名:</strong>
                                        <input type="text" id="name" class="require-field" runat="server" style="width:70%;" onblur="name_blur()"/>
                                        <span id="name_require" style="font-size:small; font-family:微软雅黑; color:red; margin-left:80px;"></span>
                                      </li>
                                      <li class="form-input">
                                        <strong>性别:</strong>
                                        <input type="text" id="gender" class="require-field" runat="server" style="width:70%;" onblur="sex_blur()"/>
                                        <span id="sex_require" style="font-size:small; font-family:微软雅黑; color:red; margin-left:80px;"></span>
                                      </li>
                                      <li class="form-input">
                                        <strong>手机(重要):</strong>
                                        <input type="text" id="phone" class="require-field" runat="server" style="width:70%;" onblur="phone_blur()"/>
                                        <span id="phone_require" style="font-size:small; font-family:微软雅黑; color:red; margin-left:80px;"></span>
                                      </li>
                                      <li class="form-input">
                                        <strong>电子邮箱:</strong>
                                        <input type="text" id="email" class="require-field" runat="server" style="width:70%;" onblur="email_blur()"/>
                                        <span id="email_require" style="font-size:small; font-family:微软雅黑; color:red; margin-left:80px;"></span>
                                      </li>
                                      <li class="buttons">
                                         <button id="regis" class="contact-submit button-on" runat="server" onclick="total()" style="float: right; background-color:#1bc4de; color:White; font-weight:bold;">注册</button>
                                         <asp:LinkButton ID="register" CssClass="contact-submit button" runat="server" OnClick="registration"></asp:LinkButton>
                                      </li>
                                      </ol>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</div>
</div>

</asp:Content>

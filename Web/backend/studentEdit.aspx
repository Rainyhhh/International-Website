<%@ Page Title="" Language="C#" MasterPageFile="Manage.Master" AutoEventWireup="true" CodeBehind="studentEdit.aspx.cs" Inherits="Interwebsite.Web.backend.studentEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script src="Scripts/WdatePicker.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="gdl-page-left mb0 eight columns" style="margin-top: 20px;">
        <div class="row">
            <div class="gdl-page-item mb0 pb20 gdl-blog-full twelve columns">
                <div class="row">
                    <div class="twelve columns mb40">
                        <div class="column-service-wrapper">
                            <div class="column-service-title-wrapper">
                                <img src="img/register.png" style="width: 35px; margin-left: 0px;" />
                                <h2 class="column-service-title" style="position: relative; margin-top: -30px; margin-left: 50px;">学生信息修改<span class="sub-title">Edit</span>
                                </h2>
                                <div class="gdl-page-left mb0 six columns" style="margin-top: 20px; min-height: 850px;">
                                    <div class="stunning-text-inner-wrapper gdl-border-x bottom">
                                        <h1 class="blog-title" style="color: #1bc4de; font-size: 17px;">
                                            <span>项目选择(Program Details)</span>
                                        </h1>
                                        <div class="contact-form-wrapper">
                                            <ol class="forms">
                                                <li class="form-input">
                                                    <strong>首选项目:</strong>
                                                    <input type="text" id="preferedprogram" name="preferedprogram" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>候补项目:</strong>
                                                    <input type="text" id="altprogram" name="altprogram" class="require-field password" runat="server" style="width: 70%;" />
                                                </li>
                                            </ol>
                                        </div>
                                    </div>
                                    <div class="stunning-text-inner-wrapper gdl-border-x bottom">
                                        <h1 class="blog-title" style="color: #1bc4de; font-size: 17px;">
                                            <span>学习经历<br />
                                                (Education Information)</span>
                                        </h1>
                                        <div class="contact-form-wrapper">
                                            <ol class="forms">
                                                <li class="form-input">
                                                    <strong>毕业院校：</strong>
                                                    <input type="text" id="graduated" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>专业:</strong>
                                                    <input type="text" id="major" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>毕业时间:</strong>
                                                    <input type="text" id="gradtime" class="require-field" runat="server" style="width: 70%;" onclick="WdatePicker({ dateFmt: 'yyyy/MM/dd' })" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>入学年份:</strong>
                                                    <input type="text" id="starttime" class="require-field" runat="server" style="width: 70%;" onclick="WdatePicker({ dateFmt: 'yyyy/MM/dd' })" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>英语水平:</strong>
                                                    <input type="text" id="englishskill" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>本科GPA:</strong>
                                                    <input type="text" id="gpa" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                            </ol>
                                        </div>
                                    </div>
                                    <div class="stunning-text-inner-wrapper gdl-border-x bottom">
                                        <h1 class="blog-title" style="color: #1bc4de; font-size: 17px;">
                                            <span>家庭情况<br />
                                                (Family Information)</span>
                                        </h1>
                                        <div class="contact-form-wrapper">
                                            <ol class="forms">
                                                <li class="form-input">
                                                    <strong>姓名:</strong>
                                                    <input type="text" id="parid" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>亲属关系:</strong>
                                                    <input type="text" id="parrelation" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>工作单位:</strong>
                                                    <input type="text" id="parwork" runat="server" style="width: 100%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>联系电话:</strong>
                                                    <input type="text" id="parphone" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                            </ol>
                                        </div>
                                    </div>
                                </div>
                                <div class="gdl-page-right mb0 six columns" style="margin-top: 20px;">
                                    <div class="stunning-text-inner-wrapper gdl-border-x bottom">
                                        <h1 class="blog-title" style="color: #1bc4de; font-size: 17px;">
                                            <span>个人信息(Personal Information)</span>
                                        </h1>
                                        <div class="contact-form-wrapper">
                                            <ol class="forms">
                                                <li class="form-input">
                                                    <strong>姓名:</strong>
                                                    <input type="text" id="name" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>性别:</strong>
                                                    <input type="text" id="gender" class="require-field password" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>身份证号:</strong>
                                                    <input type="text" id="idno" class="require-field password" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>出生日期:</strong>
                                                    <input type="text" id="birthdate" onclick="WdatePicker({ dateFmt: 'yyyy/MM/dd' })" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>政治面貌:</strong>
                                                    <input type="text" id="politic" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>民族:</strong>
                                                    <input type="text" id="nationality" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>户籍所在地:</strong>
                                                    <input type="text" id="city" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>联系地址(在校通讯地址):</strong>
                                                    <input type="text" id="address" runat="server" style="width: 100%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>邮政编码:</strong>
                                                    <input type="text" id="zipcode" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>QQ:</strong>
                                                    <input type="text" id="qqno" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>手机(重要):</strong>
                                                    <input type="text" id="phone" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>电子邮箱:</strong>
                                                    <input type="text" id="email" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>家庭居住地址:</strong>
                                                    <input type="text" id="famaddress" runat="server" style="width: 100%;" />
                                                </li>
                                                <li class="form-input">
                                                    <strong>邮政编码:</strong>
                                                    <input type="text" id="famzipcode" class="require-field" runat="server" style="width: 70%;" />
                                                </li>
                                            </ol>
                                        </div>
                                    </div>
                                </div>
                                <div class="clear"></div>
                                <div class="gdl-page-item mb0 pb20 gdl-blog-full twelve columns">
                                    <div class="row">
                                        <div class="twelve columns mb40">
                                            <div class="column-service-wrapper">
                                                <div class="column-service-title-wrapper">
                                                    <h1 class="blog-title" style="color: #1bc4de; font-size: 17px;">
                                                        <span>奖惩情况(Performance)</span>
                                                    </h1>
                                                    <div class="contact-form-wrapper">
                                                        <ol class="forms">
                                                            <li class="form-input">
                                                                <strong>奖惩情况：</strong>
                                                                <textarea id="Textarea1" runat="server" style="width: 100%; height: 80px;"></textarea>
                                                            </li>
                                                        </ol>
                                                    </div>
                                                    <h1 class="blog-title" style="color: #1bc4de; font-size: 17px;">
                                                        <span>工作经历(Working Experience)</span>
                                                    </h1>
                                                    <div class="contact-form-wrapper">
                                                        <ol class="forms">
                                                            <li class="form-input">
                                                                <strong>工作经历介绍（在校生填写实习经历社会实践亦可）:</strong>
                                                                <textarea id="Textarea2" runat="server" style="width: 100%; height: 80px;"></textarea>
                                                            </li>
                                                        </ol>
                                                    </div>
                                                </div>
                                                <asp:LinkButton ID="LinkButton2" CssClass="contact-submit button"
                                                    Style="float: right; margin-right: 45%;" runat="server"
                                                    BackColor="#1bc4de" ForeColor="White"
                                                    Font-Bold="true" BorderStyle="Double">
                                          提交Submit
                                                </asp:LinkButton>
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
    </div>

</asp:Content>

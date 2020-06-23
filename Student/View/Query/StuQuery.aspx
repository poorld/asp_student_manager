<%@ Page Title="" Theme="Main" Language="C#" MasterPageFile="~/Master/MasterPager.Master" AutoEventWireup="true" CodeBehind="StuQuery.aspx.cs" Inherits="Student.Service.Query.StuQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input type="hidden" id="stu_query" />
    <div id="cont2">
        <div class="stu-item">
            <img src="https://teenyda-blog.oss-cn-shenzhen.aliyuncs.com/blog-image/avatar.jpg" />
            <div class="info">
                <p>
                    <span class="span-txt">学号</span>
                    <span class="stu-value">1915100104</span>
                </p>

                <p>
                    <span class="span-txt">姓名</span>
                    <span class="stu-value">露小哒哒</span>
                </p>

                <p>
                    <span class="span-txt">性别</span>
                    <span class="stu-value">男</span>
                </p>
            </div>

            <div class="info">
                <p>
                    <span class="span-txt">年级</span>
                    <span class="stu-value">2017级</span>
                </p>

                <p>
                    <span class="span-txt">专业</span>
                    <span class="stu-value">计算机科学与技术</span>
                </p>

                <p>
                    <span class="span-txt">班级</span>
                    <span class="stu-value">计17计算机专升本1班</span>
                </p>
            </div>

            <div class="info">
                <p>
                    <span class="span-txt">籍贯</span>
                    <span class="stu-value">广西</span>
                </p>

                <p>
                    <span class="span-txt">联系方式</span>
                    <span class="stu-value">15278389583</span>
                </p>

                <p>
                    <span class="span-txt">住址</span>
                    <span class="stu-value">广西容县杨梅镇凤美村2号</span>
                </p>
            </div>

            <div class="btn-op">
                  <button class="button is-info is-light is-small">修改</button>
                  <button class="button is-danger is-light is-small">删除</button>
            </div>
        </div>

    </div>
</asp:Content>

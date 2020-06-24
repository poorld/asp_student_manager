<%@ Page Title="" Theme="Main" Language="C#" MasterPageFile="~/Master/StuMasterPager.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Student.View.Student.Student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card">
      <div class="card-image">
        <figure class="image is-4by3">
          <img src="/App_Themes/Image/dzq.jpg" alt="Placeholder image">
        </figure>
      </div>
      <div class="card-content">
        <div class="media">
          <div class="media-left">
            <figure class="image is-64x64">
              <img src="/App_Themes/Image/avator.jpg" alt="Placeholder image">
            </figure>
          </div>
          <div class="media-content">
            <p class="title is-4" id="stu_name">John Smith</p>
            <p class="subtitle is-6" id="stu_grade">@2017级</p>
          </div>
        </div>

        <div class="content">
            <span id="stu_profession">计算机科学与技术</span>
            <span id="stu_class">计17计算机专升本1班</span>
            <span id="stu_contact">15278389583</span>
            <span id="stu_address">南宁师范大学4-217</span>
            <button style="margin-top: -4px;" class="button is-small is-primary is-light" onclick="update()">修改</button>
          <br>
          <br>
          <time datetime="2016-1-1">11:09 PM - 1 Jan 2016</time>
        </div>
      </div>
    </div>

    <%--<div class="stu-bottom">
        <div class="bottom-item">
            <span>性别</span>
            <span>男</span>
        </div>

        <div class="bottom-item">
            <span>年级</span>
            <span>2017级</span>
        </div>

        <div class="bottom-item">
            <span>专业</span>
            <span>计算机科学与技术</span>
        </div>

        <div class="bottom-item">
            <span>班级</span>
            <span>计17计算机专升本1班</span>
        </div>

        <div class="bottom-item">
            <span>籍贯</span>
            <span>广西</span>
        </div>

        <div class="bottom-item">
            <span>联系方式</span>
            <span>15278389583</span>
        </div>

        <div class="bottom-item">
            <span>住址</span>
            <span>南宁师范大学4-217</span>
        </div>

    </div>--%>
</asp:Content>

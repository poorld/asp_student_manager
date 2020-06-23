<%@ Page Title="" Theme="Main" Language="C#" MasterPageFile="~/Master/MasterPager.Master" AutoEventWireup="true" CodeBehind="StuAdd.aspx.cs" Inherits="Student.Service.Add.StuAdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <input type="hidden" id="stuSett" runat="server"/>
    <input type="hidden" id="stuId" />
    <div id="stu-form">
        <div class="field">
            <div class="control">
                <label for="stu_no">学号</label>
                <input class="input is-primary is-small" id="stu_no" type="text" placeholder="加油，小学生" />
            </div>
        </div>

        <div class="field">
            <div class="control">
                <label for="stu_name">姓名</label>
                <input class="input is-primary is-small" id="stu_name" type="text" placeholder="加油，小学生" />
            </div>
        </div>

        <div class="field">
          <div class="control">
            <label for="stu_sex">性别</label>
            <div class="select is-primary is-small">
              <select id="stu_sex">
                <option selected="selected" value="男">男</option>
                <option value="女">女</option>
              </select>
            </div>
          </div>
        </div>

        <div class="field">
            <div class="control">
                <label for="stu_age">年龄</label>
                <input class="input is-primary is-small" id="stu_age" type="number" placeholder="加油，小学生" />
            </div>
        </div>

        <div class="field">
            <div class="control">
                <label for="stu_grade">年级</label>
                <input class="input is-primary is-small" id="stu_grade" type="text" placeholder="加油，小学生" />
            </div>
        </div>

         <div class="field">
            <div class="control">
                <label for="stu_profession">专业</label>
                <input class="input is-primary is-small" id="stu_profession" type="text" placeholder="加油，小学生" />
            </div>
        </div>

        <div class="field">
            <div class="control">
                <label for="stu_class">班级</label>
                <input class="input is-primary is-small" id="stu_class" type="text" placeholder="加油，小学生" />
            </div>
        </div>

        <div class="field">
            <div class="control">
                <label for="stu_native_place">籍贯</label>
                <input class="input is-primary is-small" id="stu_native_place" type="text" placeholder="加油，小学生" />
            </div>
        </div>

        <div class="field">
            <div class="control">
                <label for="stu_contact">联系方式</label>
                <input class="input is-primary is-small" id="stu_contact" type="text" placeholder="加油，小学生" />
            </div>
        </div>

        <div class="field">
            <div class="control">
                <label for="stu_address">住址</label>
                <input class="input is-primary is-small" id="stu_address" type="text" placeholder="加油，小学生" />
            </div>
        </div>

        <button class="button is-info is-focused is-small" onclick="submit()">提交</button>

    </div>
</asp:Content>

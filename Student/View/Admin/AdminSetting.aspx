<%@ Page Title="" Theme="Main" Language="C#" MasterPageFile="~/Master/MasterPager.Master" AutoEventWireup="true" CodeBehind="AdminSetting.aspx.cs" Inherits="Student.View.Admin.AdminSetting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="stu-form">
        <div class="field">
            <div class="control">
                <label for="admin_no">帐号</label>
                <input class="input is-primary is-small" id="admin_no" type="text" disabled/>
            </div>
        </div>

        <div class="field">
            <div class="control">
                <label for="admin_pass">密码</label>
                <input class="input is-primary is-small" id="admin_pass" type="text" placeholder="输入密码" />
            </div>
        </div>

        <button class="button is-info is-focused is-small" onclick="updatePassword()">提交</button>
    </div>
</asp:Content>

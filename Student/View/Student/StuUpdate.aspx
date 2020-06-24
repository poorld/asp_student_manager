<%@ Page Title="" Theme="Main" Language="C#" MasterPageFile="~/Master/StuMasterPager.Master" AutoEventWireup="true" CodeBehind="StuUpdate.aspx.cs" Inherits="Student.View.Student.StuUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="stu-form">
        <div class="field">
            <div class="control">
                <label for="admin_no">籍贯</label>
                <input class="input is-primary is-small" id="stu_native_place" type="text" />
            </div>
        </div>

        <div class="field">
            <div class="control">
                <label for="admin_pass">联系方式</label>
                <input class="input is-primary is-small" id="stu_contact" type="text" placeholder="" />
            </div>
        </div>

        <div class="field">
            <div class="control">
                <label for="admin_pass">住址</label>
                <input class="input is-primary is-small" id="stu_address" type="text" placeholder="" />
            </div>
        </div>

        <button class="button is-info is-focused is-small" onclick="stuUpdate()">提交</button>
    </div>
</asp:Content>

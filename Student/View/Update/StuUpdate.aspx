<%@ Page Title="" Language="C#" Theme="Main"  MasterPageFile="~/Master/MasterPager.Master" AutoEventWireup="true" CodeBehind="StuUpdate.aspx.cs" Inherits="Student.Service.Update.StuUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    学号<asp:textbox ID="stuId" runat="server" TextMode="Number"></asp:textbox><br />
    姓名<asp:textbox ID="stuName" runat="server"></asp:textbox><br />
    性别<asp:RadioButtonList ID="stuSex" runat="server">
        <asp:ListItem Text="男" Value="男"/>
        <asp:ListItem Text="女" Value="女" />
      </asp:RadioButtonList><br />
    年龄<asp:textbox ID="stuAge" runat="server"></asp:textbox><br />
   <asp:Button Text="查询" runat="server" OnClick="Unnamed_Click1" />
    <asp:Button Text="修改" runat="server" OnClick="Unnamed_Click" />
</asp:Content>

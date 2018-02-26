<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="ChPwd.aspx.cs" Inherits="ChPwd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    Old Password
    <asp:TextBox ID="TextBoxOPwd" TextMode="Password" runat="server"></asp:TextBox><br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBoxOPwd"
        runat="server" ErrorMessage="Password is required"></asp:RequiredFieldValidator>
    <p />
    New Password
    <asp:TextBox ID="TextBoxNPwd" TextMode="Password" runat="server"></asp:TextBox><br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="TextBoxNPwd"
        runat="server" ErrorMessage="New Password is required"></asp:RequiredFieldValidator>
    <p />
    Confirm Password
    <asp:TextBox ID="TextBoxCPwd" TextMode="Password" runat="server"></asp:TextBox><br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBoxCPwd"
        runat="server" ErrorMessage="Confirm Password is required"></asp:RequiredFieldValidator><br />
    <asp:CompareValidator ID="CompareValidator1" ControlToCompare="TextBoxNPwd" ControlToValidate="TextBoxCPwd"
        runat="server" ErrorMessage="Passwords did not match"></asp:CompareValidator>
    <p />
    <asp:Button ID="ButtonChPwd" runat="server" Text="Change" OnClick="ButtonChPwd_Click" />
    <p />
    <asp:Label ID="LabelACK" runat="server" Text=""></asp:Label>
</asp:Content>

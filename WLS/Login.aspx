<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            display: block;
            float: left;
            text-align: left;
            width: 855px;
            font-family: "Times New Roman", Times, serif;
            font-weight: bold;
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <center>
        <div class="page">
            <div class="header" style="background-color: #99CCFF">
                <div class="style1">
                    <p style="background-color: #99CCFF">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        Wired Equivalent Privacy For WLAN Security</p>
                </div>
                <h2>Login </h2>
                <p style="background-color: #99CCFF">&nbsp;</p>
                <form id="form1" runat="server" style="background-color: #FFFFFF">
                        Username   <asp:TextBox ID="TextBoxUname" runat="server"></asp:TextBox><br/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBoxUname" runat="server" ErrorMessage="Username is required"></asp:RequiredFieldValidator>
                        <p/>
                        Password   <asp:TextBox ID="TextBoxPwd" TextMode="Password" runat="server"></asp:TextBox><br/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBoxPwd" runat="server" ErrorMessage="Password is required"></asp:RequiredFieldValidator>
                        <p/>
                        <asp:Button ID="ButtonLogin" runat="server" Text="Login" 
                                onclick="ButtonLogin_Click" />
                        <p/>
                <asp:Label ID="LabelACK" runat="server" Text=""></asp:Label>
                </form>
                <p style="background-color: #99CCFF">&nbsp;</p>
            </div>
           
        </div>
        <div class="footer">
        </div>
    </center>
</body>
</html>

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" Trace="false" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
    <table>
        <tr>
            <td>
                MAC Address
            </td>
            <td>
                <asp:TextBox ID="TextBoxMAC" runat="server" 
                    ontextchanged="TextBoxMAC_TextChanged" AutoPostBack="True"></asp:TextBox>
            </td>
             <td>
                 <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBoxMAC" runat="server" ErrorMessage="MAC address is required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                IP Address
            </td>
            <td>
                <asp:TextBox ID="TextBoxIP" runat="server" AutoPostBack="True" 
                    ontextchanged="TextBoxIP_TextChanged"></asp:TextBox>
            </td>
             <td>
                 <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="TextBoxIP" runat="server" ErrorMessage="IP address is required"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Node
            </td>
            <td>
                <asp:DropDownList ID="DropDownListNodes" runat="server" 
                    style="position: relative; top: -2px; left: 0px; width: 121px; margin-left: 0px">
                    <asp:ListItem Value="A">NodeA</asp:ListItem>
                    <asp:ListItem Value="B">NodeB</asp:ListItem>
                    <asp:ListItem Value="C">NodeC</asp:ListItem>
                    <asp:ListItem Value="D">NodeD</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
    </table>

    <asp:Button ID="ButtonLogin" runat="server" Text="Enroll" 
        onclick="ButtonLogin_Click" />
    <p />
    <asp:Label ID="LabelACK" runat="server" Text=""></asp:Label>
    </updatepanel>
</asp:Content>

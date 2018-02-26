<%@ Page Title="" Language="C#" Trace="false" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="AUsers.aspx.cs" Inherits="AUsers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    

   
    <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px" 
        AllowPaging="True" AutoGenerateRows="False" CellPadding="4" DataKeyNames="mac" 
        DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" 
    EmptyDataText="No nodes found">
        <AlternatingRowStyle BackColor="White" />
        <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
        <EditRowStyle BackColor="#2461BF" />
        <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
        <Fields>
            <asp:BoundField DataField="mac" HeaderText="MAC Address" ReadOnly="True" 
                SortExpression="mac" />
            <asp:BoundField DataField="ip" HeaderText="IP Address" SortExpression="ip" />
            <asp:BoundField DataField="node" HeaderText="Node" SortExpression="node" />
            <asp:BoundField DataField="auth" HeaderText="Authentication" 
                SortExpression="auth" />
            <asp:HyperLinkField DataNavigateUrlFields="node" 
                DataNavigateUrlFormatString="Connect.aspx?node={0}" Text="Connect" />
        </Fields>
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
    </asp:DetailsView>

   
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnStr %>" 
        SelectCommand="SELECT * FROM [nodes]"></asp:SqlDataSource>


 <p/>
    <asp:Label ID="LabelAck" runat="server" Text=""></asp:Label>

   
</asp:Content>


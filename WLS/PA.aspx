<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PA.aspx.cs" Inherits="PA" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        CellPadding="4" DataKeyNames="mac" DataSourceID="SqlDataSource1" 
        ForeColor="#333333" GridLines="None" EmptyDataText="No nodes found">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="mac" HeaderText="MAC Address" ReadOnly="True" 
                SortExpression="mac" />
            <asp:BoundField DataField="ip" HeaderText="IP Address" SortExpression="ip" />
            <asp:BoundField DataField="node" HeaderText="Node" SortExpression="node" />
            <asp:BoundField DataField="auth" HeaderText="Authentication" 
                SortExpression="auth" />
            <asp:HyperLinkField DataNavigateUrlFields="node" 
                DataNavigateUrlFormatString="Start.aspx?node={0}" Text="Start" />
        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:ConnStr %>" 
        SelectCommand="SELECT * FROM [nodes] WHERE ([auth] = @auth)">
        <SelectParameters>
            <asp:Parameter DefaultValue="y" Name="auth" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>
    <p/>
    <p/>
    <asp:Label ID="LabelACK" runat="server" Text=""></asp:Label>
</asp:Content>


<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <br />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; From:
        <input id="fromTextBox" type="text" runat="server" />&nbsp; to:
        <input id="toTextBox" type="text" runat="server" />&nbsp;
        <asp:Button ID="calculateButton" runat="server" OnClick="calculateButton_Click" Text="Calculate" />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="resultLabel" runat="server" Text="Result"></asp:Label>
    </p>
    <br />
    <br />
    <br />
    <br />
    <br />

</asp:Content>

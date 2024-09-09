<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BookWaves.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div style="text-align:center; margin-top: 20px;">
            <h2>Welcome to BookWaves</h2>
            <asp:Button ID="btnLogin" runat="server" Text="Login"   />
            <asp:Button ID="btnRegister" runat="server" Text="Register"    />
        </div>
    </main>

</asp:Content>


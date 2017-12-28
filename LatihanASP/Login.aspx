<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LatihanASP.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h2>Login Admin PT. Oke Oce</h2>
    <hr />
            <form id="Form1" method="post" runat="server">
                <div class="form-group">
                    <label for="nama">Username:</label>
                    <asp:TextBox ID="username" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="email">Password:</label>
                    <asp:TextBox ID="password" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="btn_save" CssClass="btn btn-md btn-primary" OnClick="login" runat="server" Text="Login" />
                </div>
            </form>
</asp:Content>

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Create.aspx.cs" Inherits="LatihanASP.Create" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <!-- Remove This Before You Start -->
    <h2>Tambah Barang PT. Oke Oce</h2>
    <hr />
            <form id="Form1" method="post" runat="server">
                <div class="form-group">
                    <label for="nama">Nama:</label>
                    <asp:TextBox ID="nama" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="email">Deskripsi:</label>
                    <asp:TextBox ID="deskripsi" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="nohp">Harga:</label>
                    <asp:TextBox ID="harga" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button ID="btn_save" CssClass="btn btn-md btn-primary" OnClick="save" runat="server" Text="Save" />
                    <button type="reset" class="btn btn-md btn-danger">Cancel</button>
                </div>
</form>
</asp:Content>

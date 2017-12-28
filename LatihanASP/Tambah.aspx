<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tambah.aspx.cs" Inherits="LatihanASP.Tambah" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <h2>Tambah Barang PT. Oke Oce</h2>
 <form id="form1" runat="server">
    <div class="form-group">
        <label for="name">Nama</label>
        <asp:TextBox CssClass="form-control" ID="nama" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="deskripsi">Deskripsi</label>
        <asp:TextBox CssClass="form-control" ID="deskripsi" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="harga">Harga</label>
        <asp:TextBox CssClass="form-control" ID="harga" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Button CssClass="btn btn-md btn-primary" ID="Button1" runat="server" OnClick="save" Text="Submit" />
        <button class="btn btn-md btn-danger" type="reset">Reset</button>
    </div>
 </form>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update2.aspx.cs" Inherits="LatihanASP.Update2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!-- Remove This Before You Start -->
    <h2>Edit Barang PT. Oke Oce</h2>
    <hr />
            <form id="Form1" method="post" runat="server">
                <div class="form-group">
                    <label for="nama">Nama:</label>
                    <asp:TextBox ID="iduser" CssClass="form-control" runat="server" Visible="False"></asp:TextBox>
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
                    <asp:Button ID="btn_save" CssClass="btn btn-md btn-primary" OnClick="update" runat="server" Text="Update" />
                    <button type="reset" class="btn btn-md btn-danger">Cancel</button>
                </div>
            </form>
</asp:Content>
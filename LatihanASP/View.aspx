<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="View.aspx.cs" Inherits="LatihanASP.View" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <!-- Remove This Before You Start -->
    <h2>Daftar Barang PT. Oke Oce</h2>
            <table class="table table-bordered">
                <thead>
                <tr>
                    <th>Nama</th>
                    <th>Deskripsi</th>
                    <th>Harga</th>
                    <th>Aksi</th>
                </tr>
                </thead>
                <tbody>
                    <asp:PlaceHolder ID="PlaceHolder_Data" runat="server"></asp:PlaceHolder>
                </tbody>
            </table>
</asp:Content>

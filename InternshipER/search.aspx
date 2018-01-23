<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="InternshipER.searchForm" %>

<asp:Content ID="Search" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/Search.css">
    <div class="container">
    <div class="row col-md-12 col-md-offset-1 custyle">
        <table class="table table-striped custab">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Firma</th>
                    <th>Pozisyon</th>
                    <th>Açıklama</th>
                    <th>Lokasyon</th>
                    <th>İlan Tarihi</th>
                    <th>Son Tarihi</th>
                    <th>Staj Dönemi</th>
                    <th class="text-center"></th>
                </tr>
            </thead>
            <asp:PlaceHolder ID = "searchTable" runat="server" />
        </table>
    </div>
</div>
    </asp:Content>

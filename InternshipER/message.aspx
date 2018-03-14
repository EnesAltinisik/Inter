<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="message.aspx.cs" Inherits="InternshipER.WebForm1" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/Stream.css">
    <link rel="stylesheet" type="text/css" href="Content/bootstrap.min.css">
    <link href="//netdna.bootstrapcdn.com/font-awesome/4.0.3/css/fontawesome.css" rel="stylesheet">
    <div class="row col-md-12 col-md-offset-1 custyle">
        <table class="table table-striped custab">
            <thead>
                <tr>
                    <th>#</th>
                    <th>Gönderici</th>
                    <th>Mesaj</th>
                    <th class="text-center"></th>
                </tr>
            </thead>
            <asp:PlaceHolder ID = "messageTable" runat="server" />
        </table>
    </div>
</asp:Content>

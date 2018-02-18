<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="InternshipER._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/Stream.css">
    <link rel="stylesheet" type="text/css" href="Content/bootstrap.min.css">
    <link href="//netdna.bootstrapcdn.com/font-awesome/4.0.3/css/fontawesome.css" rel="stylesheet">
    <asp:PlaceHolder ID="newsfeed" runat="server" />
    <button class="fa-arrow-down" >Daha Fazla</button>
</asp:Content>

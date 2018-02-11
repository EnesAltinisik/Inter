<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="jobAds.aspx.cs" Inherits="InternshipER.jobAds" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <br />
        <br />
        <br />

        <div class="alert alert-warning alert-dismissible" role="alert">
            <h2>under construction.</h2>
        </div>

        <br />

        <div class="panel-group" id="accordion">
            <div class="faqHeader">Açık İlanlarım</div>
            <asp:PlaceHolder ID = "openAds" runat="server" />
        </div>
        <div class="panel-group" id="accordion">
            <div class="faqHeader">Kapalı İlanlarım</div>
            <asp:PlaceHolder ID = "closedAds" runat="server" />
        </div>
    </div>


    <style>
    .faqHeader {
        font-size: 27px;
        margin: 20px;
    }
    .panel-heading [data-toggle="collapse"]:after {
        font-family: 'Glyphicons Halflings';
        content: "\e072"; /* "play" icon */
        float: right;
        color: #F58723;
        font-size: 18px;
        line-height: 22px;
        /* rotate "play" icon from > (right arrow) to down arrow */
        -webkit-transform: rotate(-90deg);
        -moz-transform: rotate(-90deg);
        -ms-transform: rotate(-90deg);
        -o-transform: rotate(-90deg);
        transform: rotate(-90deg);
    }
    .panel-heading [data-toggle="collapse"].collapsed:after {
        /* rotate "play" icon from > (right arrow) to ^ (up arrow) */
        -webkit-transform: rotate(90deg);
        -moz-transform: rotate(90deg);
        -ms-transform: rotate(90deg);
        -o-transform: rotate(90deg);
        transform: rotate(90deg);
        color: #454444;
    }
</style>
</asp:Content>

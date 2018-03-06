<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="companyMap.aspx.cs" Inherits="InternshipER.companyMap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <h3>Firmalar : Harita Görünümü</h3>
        <div id="map"></div>
        <script>
      function initMap() {
          var uluru = { lat: 39.935291, lng: 32.860920 };
        var map = new google.maps.Map(document.getElementById('map'), {
          zoom: 6,
          center: uluru
        });
        var marker = new google.maps.Marker({
          position: uluru,
          map: map
        });
      }
        </script>
        <script async defer
            src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBfwnyg_sJupaI-e-MuAxGh7jbLK83Beu8&callback=initMap">
        </script>
    <style>
       #map {
        height: 400px;
        width: 100%;
       }
    </style>


</asp:Content>


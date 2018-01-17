<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="company.aspx.cs" Inherits="InternshipER.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" type="text/css" href="Content/Student.css">
    <script src="https://use.fontawesome.com/bfdd1d98a1.js"></script>
    <div class="container">
        <div class="row">
            <section id="about" class="section section-about wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
                <div class="row grid-divider">
                    <div class="profile">
                        <div class="row">
                            <div class="col-padding">
                                <div class="col-sm-9">
                                    <div class="info-profile">
                                        <h2>
                                            <asp:Label ID="name" runat="server" class="info" Text="name"></asp:Label>
                                        </h2>
                                        <h3>
                                            <asp:Label ID="title" runat="server" class="info" Text="title"></asp:Label></h3>
                                        <p align="justify">
                                            <asp:Label ID="description" runat="server" class="info" Text="description"></asp:Label>
                                        </p>
                                        <div class="row">
                                            <div class="col-sm-5">
                                                <ul class="ul-info">
                                                    <li class="li-info">
                                                        <span class="title-info">Adres</span>
                                                        <asp:Label ID="address" runat="server" class="info" Text="adres"></asp:Label>
                                                    </li>
                                                    <li class="li-info">
                                                        <span class="title-info">Email</span>
                                                        <asp:Label ID="email" runat="server" class="info" Text="email"></asp:Label>
                                                    </li>
                                                </ul>
                                            </div>
                                            <div class="col-sm-5">
                                                <ul class="ul-info">
                                                    <li class="li-info">
                                                        <span runat="server" class="title-info">Web Adresi</span>
                                                        <asp:Label ID="website" runat="server" class="info" Text="websiteadres-dumm"></asp:Label>
                                                    </li>
                                                    <li class="li-info">
                                                        <span class="title-info">Telefon</span>
                                                        <asp:Label ID="tel" runat="server" class="info" Text="+99999999999"></asp:Label>
                                                    </li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="col-padding">
                                <div class="col-sm-3">
                                    <div class="photo-profile">
                                        <img id="img-profile" src="img/logo2.png">
                                    </div>
                                    <div class="available">
                                        <i class="fa fa-check" aria-hidden="true"></i>
                                        <span class="text-available">Onaylanmış Profil</span>
                                    </div>
                                    <a href="cv/cv-1.pdf" target="cv">
                                        <div class="download-resume">
                                            <i class="fa fa-plus" aria-hidden="true"></i>
                                            <span class="text-download">YENİ İLAN</span>
                                        </div>
                                    </a>
                                    <div>
                                        <br />
                                        <span class="title-links">Sosyal Platformlar</span>
                                        <ul class="ul-social-links">
                                            <li class="li-social-links">
                                                <a href="www.facebook.com/dummyinternshipper" data-tootik="Facebook" data-tootik-conf="square"><i class="fa fa-facebook" aria-hidden="true"></i></a>
                                            </li>
                                            <li class="li-social-links">
                                                <a href="www.twitter.com/dummyinternshipper" data-tootik="Twitter" data-tootik-conf="square"><i class="fa fa-twitter" aria-hidden="true"></i></a>
                                            </li>
                                            <li class="li-social-links">
                                                <a href="#" data-tootik="Google Plus" data-tootik-conf="square"><i class="fa fa-google-plus" aria-hidden="true"></i></a>
                                            </li>
                                            <li class="li-social-links">
                                                <a href="https://www.linkedin.com/dummyinternshipper" data-tootik="Linkedin" data-tootik-conf="square"><i class="fa fa-linkedin" aria-hidden="true"></i></a>
                                            </li>
                                            <li class="li-social-links">
                                                <a href="#" data-tootik="Dribbble" data-tootik-conf="square"><i class="fa fa-dribbble" aria-hidden="true"></i></a>
                                            </li>
                                            <li class="li-social-links">
                                                <a href="#" data-tootik="Pinterest" data-tootik-conf="square"><i class="fa fa-pinterest-p" aria-hidden="true"></i></a>
                                            </li>
                                            <li class="li-social-links">
                                                <a href="#" data-tootik="Vimeo" data-tootik-conf="square"><i class="fa fa-vimeo" aria-hidden="true"></i></a>
                                            </li>
                                            <li class="li-social-links">
                                                <a href="#" data-tootik="Behance" data-tootik-conf="square"><i class="fa fa-behance" aria-hidden="true"></i></a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="company.aspx.cs" Inherits="InternshipER.companyForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/Company.css">
    <link rel="stylesheet" type="text/css" href="Content/Student.css">
    <script src="Scripts/Company.js"></script>
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
                                        <td colspan="2">
                                            <h2>
                                                <asp:Label ID="name" runat="server" class="info" Text="name"></asp:Label>
                                            </h2>
                                            <div style="float: right">
                                                <button type="button" class="btn btn-primary btn-xs" data-toggle="modal" data-target="#myModal">
                                                    Profil Düzenle
                                               
                                                </button>
                                            </div>
                                        </td>
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
                                    <div class="reviews">
                                        <div class="row blockquote review-item">
                                            <div class="col-md-1 text-center">
                                                <img class="rounded-circle reviewer" src="http://standaloneinstaller.com/upload/avatar.png">
                                                <div class="caption">
                                                    <small>by <a href="#joe">Joe</a></small>
                                                </div>

                                            </div>
                                            <div class="col-md-3">
                                                <h4>My awesome review</h4>
                                                <div class="ratebox text-center" data-id="0" data-rating="5"></div>
                                                <p class="review-text">My awesome review. My awesome review. My awesome review. My awesome review. My awesome review. My awesome review. My awesome review. My awesome review. My awesome review. My awesome review. My awesome review. </p>

                                                <small class="review-date">March 26, 2017</small>
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
                                    <a data-toggle="modal" data-target="#myModal2">
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
    <!--Change profile popup-->
    <script src="Scripts/WebForms/Company.js"></script>
    <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                    <h4 class="modal-title" id="myModalLabel">Profil Düzenleme</h4>
                </div>
                <div class="modal hide" id="myModal">

                    <button type="button" class="close" data-dismiss="modal">x</button>
                    <h3>Login to MyWebsite.com</h3>
                </div>
                <div class="modal-body" align="center">
                    <div class="container">
                        <div class="row">
                            <div class="col-xs-6">
                                <div class="form-group">
                                    <label for="usr">Şirket ismi:</label>
                                    <input type="text" value="" runat="server" class="form-control" id="companyName">
                                </div>
                                <div class="form-group">
                                    <label for="usr">Alt başlık:</label>
                                    <input type="text" value="" runat="server" class="form-control" id="companyTitle">
                                </div>
                                <div class="form-group">
                                    <label for="comment">Firma Açıklama:</label>
                                    <textarea runat="server" value="" class="form-control" rows="5" id="companyDescription"></textarea>
                                </div>
                                <div class="form-group">
                                    <label for="usr">Adres:</label>
                                    <input type="text" value="" runat="server" class="form-control" id="companyAddress">
                                </div>
                            </div>
                            <div class="col-xs-6">
                                <div class="form-group">
                                    <label for="usr">Web Sitesi:</label>
                                    <input type="text" value="" runat="server" class="form-control" id="companyWebsite">
                                </div>
                                <div class="form-group">
                                    <label for="usr">Telefon:</label>
                                    <input type="text" value="" runat="server" class="form-control" id="companyPhone">
                                </div>
                                <div class="form-group">
                                    <label for="usr">Email:</label>
                                    <input type="text" value="" runat="server" class="form-control" id="companyEmail">
                                </div>
                                <div class="form-group">
                                    <span class="form-group-btn">
                                        <span class="btn btn-primary btn-file">Logo&hellip;
                                   
                                            <input type="file" single>
                                        </span>
                                    </span>
                                    <input type="text" runat="server" id="companyLogo" class="form-control" readonly>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <asp:Button class="btn btn-primary" type="submit" runat="server" ID="submitSettings" OnClick="updateCompanyProfile" CausesValidation="False" OnDataBinding="updateCompanyProfile" UseSubmitBehavior="False" Text="Kaydet"></asp:Button>
                </div>
            </div>
        </div>
    </div>
    <script src="Scripts/WebForms/Company.js"></script>
    <div class="modal fade" id="myModal2" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                    <h4 class="modal-title" id="myModalLabel2">Yeni İlan Oluştur</h4>
                </div>
                <div class="modal-body" align="center">
                    <div class="container">
                        <div class="row">
                            <div class="col-xs-6">
                                <div class="form-group">
                                    <label for="usr">Başlık</label>
                                    <input type="text" value="" runat="server" class="form-control" id="jobTitle">
                                </div>
                                <div class="form-group">
                                    <label for="comment">İş Açıklaması</label>
                                    <textarea runat="server" value="" class="form-control" rows="5" id="jobDesc"></textarea>
                                </div>
                            </div>
                            <div class="col-xs-6">
                                <div class="form-group">
                                    <label for="usr">Adres</label>
                                    <input type="text" runat="server" value="" class="form-control" id="jobLocation">
                                </div>
                                <div class="form-group">
                                    <span class="form-group-btn">
                                        <span class="fa fa-plus">Logo&hellip;
                                   
                                   

                                            <input type="file" single>
                                        </span>
                                    </span>
                                    <input type="text" runat="server" id="Text7" class="form-control" readonly>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <asp:Button type="submit" runat="server" ID="SubmitChanges" OnClick="createNewJob" CausesValidation="False" OnDataBinding="createNewJob" UseSubmitBehavior="False" TabIndex="4" class="form-control btn btn-login" Text="Kaydet"></asp:Button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

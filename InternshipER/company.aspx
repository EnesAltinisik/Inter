<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="company.aspx.cs" Inherits="InternshipER.companyForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/Company.css">
    <script src="Scripts/WebForms/Company.js"></script>
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
                                    <div class="row" style="margin-top: 40px; background-color="">
                                        <div id="postReviewBox" runat="server" class="col-md-12">
                                            <div class="well well-sm">
                                                <div class="text-right">
                                                    <a class="btn btn-success btn-green" href="#reviews-anchor" id="open-review-box">Değerlendirme Yaz</a>
                                                </div>

                                                <div class="row" id="post-review-box" style="display: none;">
                                                    <div class="col-md-12">
                                                            <input runat="server" id="ratingsHidden" name="rating" value="" type="hidden">
                                                            <input type="text" runat="server" class="form-control" id="reviewTitle" placeholder="Değerlendirme Başlığı">
                                                            <textarea class="form-control animated" cols="15" runat="server" id="newReview" name="comment" placeholder="Değerlendirmenizi buraya giriniz..." rows="15"></textarea>

                                                            <div class="text-right">
                                                                <div class="stars starrr" data-rating="0"></div>
                                                                <a class="btn btn-danger btn-sm" href="#" id="close-review-box" style="display: none; margin-right: 10px;">
                                                                    <span class="glyphicon glyphicon-remove"></span>Vazgeç</a>
                                                                <asp:Button class="btn btn-success btn-lg" type="submit" runat="server" id="reviewSubmit" onclick="SaveReviewClick_Event" causesvalidation="False" ondatabinding="SaveReviewClick_Event" usesubmitbehavior="False" tabindex="4" Text="Kaydet"></asp:button>

                                                            </div>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                    </div>


                                    <div class="reviews">
                                        <div class="col-md-5 blockquote review-item">
                                            <div class="col-md-3 text-center">
                                                <img class="rounded-circle reviewer" src="http://standaloneinstaller.com/upload/avatar.png">
                                                <div class="caption">
                                                    <small>by<a href="#reviewer"> <asp:Label ID="labelname4" runat="server" Text="Label"></asp:Label></a></small>
                                                </div>

                                            </div>
                                            <div class="col-md-9">
                                                <h4><asp:Label ID="labelname1" runat="server" Text="Label"></asp:Label></h4>
                                                <div class="ratebox text-center" data-id="0" data-rating="5"></div>
                                                <p class="review-text"><asp:Label ID="labelname2" runat="server" Text="Label"></asp:Label></p>
                                                <small class="review-date"><asp:Label ID="labelname3" runat="server" Text="Label"></asp:Label></small>
                                            </div>
                                        </div>
                                        <div class="col-md-5 blockquote review-item">
                                            <div class="col-md-3 text-center">
                                                <img class="rounded-circle reviewer" src="http://standaloneinstaller.com/upload/avatar.png">
                                                <div class="caption">
                                                    <small>by<a href="#reviewer"> <asp:Label ID="labelname8" runat="server" Text="Label"></asp:Label></a></small>
                                                </div>

                                            </div>
                                            <div class="col-md-9">
                                                <h4><asp:Label ID="labelname5" runat="server" Text="Label"></asp:Label></h4>
                                                <div class="ratebox text-center" data-id="0" data-rating="5"></div>
                                                <p class="review-text"><asp:Label ID="labelname6" runat="server" Text="Label"></asp:Label></p>
                                                <small class="review-date"><asp:Label ID="labelname7" runat="server" Text="Label"></asp:Label></small>
                                            </div>
                                        </div>
                                    </div>


                                    <div class="row col-md-12 custyle">
                                        <table class="table table-striped custab">
                                            <thead>
                                                <tr>
                                                    <th>#</th>
                                                    <th>Pozisyon</th>
                                                    <th>Açıklama</th>
                                                    <th>Lokasyon</th>
                                                    <th>İlan Tarihi</th>
                                                    <th>Son Tarihi</th>
                                                    <th>Staj Dönemi</th>

                                                    <th class="text-center"></th>
                                                </tr>
                                            </thead>
                                            <asp:PlaceHolder ID="searchTable" runat="server" />
                                        </table>
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
                                        <div class="download-resume">
                                            <i class="fa fa-plus" aria-hidden="true"></i>
                                            <asp:LinkButton ID="JobOrFav" runat="server" OnClick="FavouritesClick_Event" causesvalidation="False" ondatabinding="FavouritesClick_Event" usesubmitbehavior="False"></asp:LinkButton>                                        
                                        </div>
                                         <div class="download-resume">
                                            <i class="fa fa-plus" aria-hidden="true"></i>
                                            <asp:LinkButton ID="videoTalk" runat="server" OnClick="CompanyVideoTalk" causesvalidation="False" ondatabinding="CompanyVideoTalk" usesubmitbehavior="False"></asp:LinkButton>                                        
                                        </div>
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
    <div class="modal fade" runat="server" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                    <h4 class="modal-title" id="myModalLabel">Profil Düzenleme</h4>
                </div>
                <div class="modal hide" id="myModal3">

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
    <script type="text/javascript">
    function openModal() {
        $('#myModal2').modal('show');
    }
</script>
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

    <script src="Scripts/WebForms/Company.js"></script>
    <div class="modal fade" id="myModal4" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                    <h4 class="modal-title" id="myModalLabel4">Yeni Mülakat Daveti Oluştur</h4>
                </div>
                <div class="modal-body" align="center">
                    <div class="container">
                        <div class="row">
                            <div class="col-xs-6">
                                <div class="form-group">
                                    <label for="usr">Mülakatın yapılacağı poziyon </label>
                                    <input type="text" value="" runat="server" class="form-control" id="Text1">
                                </div>
                                <div class="form-group">
                                    <label for="comment">Mülakat hakkında bilgi</label>
                                    <textarea runat="server" value="" class="form-control" rows="5" id="Textarea1"></textarea>
                                </div>
                            </div>
                            <div class="col-xs-6">
                                <div class="form-group">
                                    <label for="usr">Mülakat Tarihi ve Saati</label>
                                    <input type="text" runat="server" value="" class="form-control" id="Text2">
                                </div>
                            </div>
                         </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <asp:Button type="submit" runat="server" ID="Button1" OnClick="createNewJob" CausesValidation="False" OnDataBinding="createNewJob" UseSubmitBehavior="False" TabIndex="4" class="form-control btn btn-login" Text="Kaydet"></asp:Button>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

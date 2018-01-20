<%@ Page Title="Student Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="InternshipER.WebForm2" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <link rel="stylesheet" type="text/css" href="Content/Student.css">
   <script src="https://use.fontawesome.com/bfdd1d98a1.js"></script>
<div class="container">
	<div class="row">
		<section id="about" class="section section-about wow fadeInUp" style="visibility: visible; animation-name: fadeInUp;">
					<div class="profile">
						<div class="row">
							<div class="col-sm-3">
								<div class="photo-profile">
									<img id="img-profile" src="img/logo2.png">
								</div>
								<a href="cv/cv-1.pdf" target="cv">
									<div class="download-resume">
										<i class="fa fa-check" aria-hidden="true"></i>
										<span class="text-download">CV indir</span>
									</div>
								</a>
									<div class="download-resume">
										<button type="button" class="btn btn-primary btn-xs" data-toggle="modal" data-target="#myModal">
                                                    Profil Düzenle
                                         </button>
									</div>
                                
							</div>
							<div class="col-sm-8">
								<div class="info-profile">
									<h2><span>HI I'M</span> <asp:Label ID="studentName" runat="server" class="info" Text="öğrenci ismi"></asp:Label></h2>
									<h3>
                                            <asp:Label ID="studentDepartment" runat="server" class="info" Text="öğrenci bölümü"></asp:Label>
                                     </h3>
									<p align="justify">
                                            <asp:Label ID="studentDescription" runat="server" class="info" Text="öğrenci açıklaması"></asp:Label>
                                     </p>
									<div class="row">
										<div class="col-sm-6">
											<ul class="ul-info">
												<li class="li-info">
													<span class="title-info">Yas</span>
                                                     <asp:Label ID="studentAge" runat="server" class="info" Text="Yas"></asp:Label>
												</li>
												<li class="li-info">
													<span class="title-info">Adres</span>
                                                    <asp:Label ID="studentAdress" runat="server" class="info" Text="Adres"></asp:Label>
												</li>
												<li class="li-info">
													<span class="title-info">E mail</span>
                                                     <asp:Label ID="studentEmail" runat="server" class="info" Text="Email"></asp:Label>
												</li>
											</ul>
										</div>
										<div class="col-sm-6">
											<ul class="ul-info">
												<li class="li-info">
													<span class="title-info">Telefon</span>
                                                     <asp:Label ID="studentPhone" runat="server" class="info" Text="05xx xxx xx xx"></asp:Label>
												</li>
												<li class="li-info">
													<span class="title-info">Web sitesi</span>
                                                     <asp:Label ID="studentWebsite" runat="server" class="info" Text="www.ogrenci.tr"></asp:Label>
												</li>
												<li class="li-info">
													<span class="title-info">Ülke</span>
                                                     <asp:Label ID="studentCountry" runat="server" class="info" Text="Türkiye"></asp:Label>
												</li>
											</ul>
										</div>
										<div class="col-sm-12">
											<span class="title-links">Sosyal Platformlar</span>
											<ul class="ul-social-links">
												<li class="li-social-links">
													<a href="www.facebook.com/shineblue30" data-tootik="Facebook" data-tootik-conf="square"><i class="fa fa-facebook" aria-hidden="true"></i></a>
												</li>
												<li class="li-social-links">
													<a href="www.twitter.com/shineblue30" data-tootik="Twitter" data-tootik-conf="square"><i class="fa fa-twitter" aria-hidden="true"></i></a>
												</li>
												<li class="li-social-links">
													<a href="#" data-tootik="Google Plus" data-tootik-conf="square"><i class="fa fa-google-plus" aria-hidden="true"></i></a>
												</li>
												<li class="li-social-links">
													<a href="https://www.linkedin.com/in/shineblue30/" data-tootik="Linkedin" data-tootik-conf="square"><i class="fa fa-linkedin" aria-hidden="true"></i></a>
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
                            <form method="post" action='' name="login_form" align="center">
                                <div class="col-xs-6">
                                    <div class="form-group">
                                        <label for="usr">Öğrenci ismi:</label>
                                        <input type="text" runat="server" class="form-control" id="studentNameEdit">
                                    </div>
                                    <div class="form-group">
                                        <label for="usr">Öğrenci Bölümü:</label>
                                        <input type="text" runat="server" class="form-control" id="studentDepartmentEdit">
                                    </div>
                                    <div class="form-group">
                                        <label for="usr">Öğrencinin Yaş:</label>
                                        <input type="text" runat="server" class="form-control" id="studentAgeEdit">
                                    </div>
                                    <div class="form-group">
                                        <label for="usr">Öğrencini Ülkesi:</label>
                                        <input type="text" runat="server" class="form-control" id="studentCountryEdit">
                                    </div>
                                    <div class="form-group">
                                        <label for="comment">Öğrenci Hakkında:</label>
                                        <textarea runat="server" class="form-control" rows="5" id="studentDescriptionEdit"></textarea>
                                    </div>
                                    <div class="form-group">
                                        <label for="usr">Adres:</label>
                                        <input type="text" runat="server" class="form-control" id="studentAdressEdit">
                                    </div>
                                </div>
                                <div class="col-xs-6">
                                    <div class="form-group">
                                        <label for="usr">Web Sitesi:</label>
                                        <input type="text" runat="server" class="form-control" id="studentWebsiteEdit">
                                    </div>
                                    <div class="form-group">
                                        <label for="usr">Telefon:</label>
                                        <input type="text" runat="server" class="form-control" id="studentPhoneEdit">
                                    </div>
                                    <div class="form-group">
                                        <label for="usr">Email:</label>
                                        <input type="text" runat="server" class="form-control" id="studentEmailEdit">
                                    </div>
                                    <div class="form-group">
                                        <span class="form-group-btn">
                                            <span class="btn btn-primary btn-file">Photo&hellip;
                                    <input type="file" single>
                                            </span>
                                        </span>
                                        <input type="text" runat="server" id="studentPhotoEdit" class="form-control" readonly>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <a href="#" class="btn btn-primary">Kaydet</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

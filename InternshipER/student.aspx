<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="student.aspx.cs" Inherits="InternshipER._Default" %>


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
										<span class="text-download">DOWNLOAD RESUME</span>
									</div>
								</a>
								<div class="available">
									<i class="fa fa-check" aria-hidden="true"></i>
									<span class="text-available">available on freelance</span>
								</div>
							</div>
							<div class="col-sm-8">
								<div class="info-profile">
									<h2><span>HI I'M</span> InternsiphEr</h2>
									<h3>web developer & web designer</h3>
									<p align="justify">Hello! I’m INternshiphER. Pointer project.</p>
									<div class="row">
										<div class="col-sm-6">
											<ul class="ul-info">
												<li class="li-info">
													<span class="title-info">Age</span>
													<span class="info">31</span>
												</li>
												<li class="li-info">
													<span class="title-info">Address</span>
													<span class="info">Ankara, Turkey</span>
												</li>
												<li class="li-info">
													<span class="title-info">Email</span>
													<span class="info">xxx@yahoo.com</span>
												</li>
											</ul>
										</div>
										<div class="col-sm-6">
											<ul class="ul-info">
												<li class="li-info">
													<span class="title-info">Phone</span>
													<span class="info">+966 531 184 434</span>
												</li>
												<li class="li-info">
													<span class="title-info">Website</span>
													<span class="info">www.shineblue.com</span>
												</li>
												<li class="li-info">
													<span class="title-info">Nationality</span>
													<span class="info">Turkey</span>
												</li>
											</ul>
										</div>
										<div class="col-sm-12">
											<span class="title-links">Social Links</span>
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
</asp:Content>

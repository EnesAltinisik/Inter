<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="login.aspx.cs" Inherits="InternshipER.login" %>

<%@ MasterType VirtualPath="~/Site.Master" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="LoginContent" runat="server">
    <script src="Scripts/WebForms/Login.js"></script>
    <link rel="stylesheet" type="text/css" href="Content/Login.css">
    <div class="container">
        <div class="row">
            <div class="col-md-6 col-md-offset-3">
                <div class="panel panel-login">
                    <div class="panel-heading">
                        <div class="row">
                            <div class="col-xs-6">
                                <a href="#" class="active" id="login-form-link">Giriş</a>
                            </div>
                            <div class="col-xs-6">
                                <a href="#" id="register-form-link">Kayıt</a>
                            </div>
                        </div>
                        <hr>
                    </div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-lg-12">
                                <form id="loginForm" role="form" style="display: block;">
                                    <div class="form-group">
                                        <input type="text" name="login-username" id="loginUsername" tabindex="1" class="form-control" placeholder="Kullanıcı Adı" value="" runat="server">
                                    </div>
                                    <div class="form-group">
                                        <input type="password" name="login-password" id="loginPassword" tabindex="2" class="form-control" placeholder="Şifre" value="" runat="server">
                                    </div>
                                    <div class="form-group text-center">
                                        <input type="checkbox" tabindex="3" class="" name="remember" id="remember">
                                        <label for="remember">Beni Hatırla</label>
                                    </div>
                                    <div class="form-group">
                                        <div class="row">
                                            <div class="col-sm-6 col-sm-offset-3">
                                                <asp:Button type="submit" runat="server" name="login-submit" id="loginSubmit" onclick="loginClick_Event" causesvalidation="False" ondatabinding="loginClick_Event" usesubmitbehavior="False" tabindex="4" class="form-control btn btn-login" Text="Giriş Yap"></asp:button>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <div class="row">
                                            <div class="col-lg-12">
                                                <div class="text-center">
                                                    <a href="" tabindex="5" class="forgot-password">Şifremi unuttum</a>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </form>
                                <form id="registerForm" style="display: none;">
                                    
                                    <div> 
                                            <div class="col-sm-5 col-sm-offset-1">
                                                <asp:LinkButton runat="server" href="studentRegister.aspx" class=" btn btn-register" Text="Öğrenci"></asp:LinkButton>
                                            </div>
                                            <div class="col-sm-5 col-sm-offset-1">
                                                <asp:LinkButton runat="server"  href="companyRegister.aspx" class=" btn btn-register" Text="Sirket"></asp:LinkButton>
                                            </div>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

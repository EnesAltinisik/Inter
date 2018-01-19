<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="companyRegister.aspx.cs" Inherits="InternshipER.companyLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>
 <link rel="stylesheet" type="text/css" href="Content/Register.css">

  <div class="container">
    <h1>Firma Kayıt Formu</h1>
    <p>Bütün bilgiler zorunludur.</p>
    <hr>

    <p>
    <label><b>Firma İsmi</b></label>
        </p>
    <p><input type="text" runat="server"  id="companyName" required>
    </p>
    <p>
    <label><b>Kullanıcı Adı</b></label>
        </p>
    <p><input type="text" runat="server"  id="userName" required>
        </p>
    <p>
    <label><b>Email</b></label>
        </p>
    <p><input type="text" runat="server" id="email" required>
        </p>
    <p>
    <label><b>Şifre</b></label></p>
    <p><input type="password" runat="server" id="psw" required>
        </p>
    <p>
    <label><b>Şifre Tekrarı</b></label></p>
    <p><input type="password" runat="server"  id="pswRepeat" required>
        </p>
    <label>
      <input type="checkbox" checked="checked" style="margin-bottom:15px"> Remember me
    </label>
    

    <div class="clearfix">
      <asp:Button type="button" runat="server" OnClick="cancelbtn_Click" class="cancelbtn" Text="Vazgeç" CausesValidation="False" OnDataBinding="cancelbtn_Click"></asp:button>
      <asp:button type="submit" runat="server" onclick ="registerClick_Event" class="signupbtn" Text="Kayıt Ol" CausesValidation="False" OnDataBinding="registerClick_Event"></asp:button>
    </div>
  </div>

</asp:Content>

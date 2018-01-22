<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="studentRegister.aspx.cs" Inherits="InternshipER.studentRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<!DOCTYPE html>

<link rel="stylesheet" type="text/css" href="Content/Register.css">

  <div class="container">
    <h1>Stajyer Kayıt Formu</h1>
    <p>Bütün bilgiler zorunludur.</p>
    <hr>

    <p>
    <label><b>Stajyer İsmi</b></label>
        </p>
    <p><input type="text" runat="server"  id="studentName" required>
    </p>
       <p>
    <label><b>Okuduğu Üniversite</b></label>
        </p>
   
      <asp:DropDownList ID="schoolName"  
    runat="server"  
    AutoPostBack="true"   Font-Size="Large"  ForeColor="Blue" Font-Bold="true" Font-Italic="true" 
    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">  
    <asp:ListItem Value="TOBB Ekonomi ve Teknoloji Üniversitesi(Ankara)"></asp:ListItem>  
    <asp:ListItem Value="Abant İzzet Baysal Üniversitesi (Bolu)"></asp:ListItem>  
    <asp:ListItem Value="Adnan Menderes Üniversitesi (Aydın)"></asp:ListItem>  
    <asp:ListItem Value="Ankara Üniversitesi(Ankara)"></asp:ListItem>  
    <asp:ListItem Value="Atılım Üniversitesi (Ankara)"></asp:ListItem>   
    <asp:ListItem Value="Bahçeşehir Üniversitesi(İstanbul)"></asp:ListItem>   
</asp:DropDownList>  

      <br />

      <br />

     <p>
    <label><b>Okuduğu Bölüm</b></label>
        </p>

    <asp:DropDownList ID="schoolDepartment"  
    runat="server"  
    AutoPostBack="true"   Font-Size="Large"  ForeColor="Blue" Font-Bold="true" Font-Italic="true" 
    OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">  
    <asp:ListItem Value="Bilgisayar Mühendisliği "></asp:ListItem>  
    <asp:ListItem Value="Endüstri Mühendisliği"></asp:ListItem>  
    <asp:ListItem Value="Elektrik-Elektronik Mühendisliği"></asp:ListItem>  
    <asp:ListItem Value="Ekonomi ve Finans"></asp:ListItem>  
    <asp:ListItem Value="Matematik"></asp:ListItem>   
    <asp:ListItem Value="Medya ve İletişim"></asp:ListItem>   
</asp:DropDownList>  
 
   
      <br />
 
   
      <br />
 
   
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
      <asp:Button type="button" runat="server" OnClick="cancelbtn_Click" class="cancelbtn" Text="Vazgeç" CausesValidation="False" OnDataBinding="cancelbtn_Click" Width="380px"></asp:button>
      <asp:Button type="submit" runat="server" onclick ="registerClick_Event" class="signupbtn" Text="Kayıt Ol" CausesValidation="False" OnDataBinding="registerClick_Event" Height="50px" Width="333px"></asp:Button>
    </div>
  </div>

</asp:Content>
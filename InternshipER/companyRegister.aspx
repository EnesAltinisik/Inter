<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="companyRegister.aspx.cs" Inherits="InternshipER.companyLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>
 <link rel="stylesheet" type="text/css" href="Content/Register.css">

  <div class="container">
    <h1>Sign Up</h1>
    <p>Please fill in this form to create an company account for any user.</p>
    <hr>

    <p>
    <label><b>Company name</b></label>
        </p>
    <p><input type="text" runat="server" placeholder="Enter Comapny Name" id="companyName" required>
    </p>
    <p>
    <label><b>User Name</b></label>
        </p>
    <p><input type="text" runat="server" placeholder="Enter User Name" id="userName" required>
        </p>
    <p>
    <label><b>Email</b></label>
        </p>
    <p><input type="text" runat="server" placeholder="Enter Email" id="email" required>
        </p>
    <p>
    <label><b>Password</b></label></p>
    <p><input type="password" runat="server" placeholder="Enter Password" id="psw" required>
        </p>
    <p>
    <label><b>Repeat Password</b></label></p>
    <p><input type="password" runat="server" placeholder="Repeat Password" id="pswRepeat" required>
        </p>
    <label>
      <input type="checkbox" checked="checked" style="margin-bottom:15px"> Remember me
    </label>
    
    <p>By creating an account you agree to our <a href="#" style="color:dodgerblue">Terms & Privacy</a>.</p>

    <div class="clearfix">
      <button type="button" onclick="cancelbtn_Click" class="cancelbtn">Cancel </button>
      <button type="submit" runat="server" onclick ="registerClick_Event" class="signupbtn">Sign Up</button>
    </div>
  </div>

</asp:Content>

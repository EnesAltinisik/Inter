<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="tests.aspx.cs" Inherits="InternshipER.tests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button type="submit"  runat="server" OnClick="testClick_Event" class="signupbtn" Text="Test Ekle" CausesValidation="False" OnDataBinding="testClick_Event"></asp:Button>
    <br />
    <br />
    <table class="table table-striped custab table-list-search">
        <thead>
            <tr>
                <th>Test Adı:</th>
                <th>Soru Sayısı:</th>
                <th>Süre:</th>
            </tr>
        </thead>
        <tbody>
            <asp:PlaceHolder ID="testTable" runat="server" />
        </tbody>
    </table>
</asp:Content>


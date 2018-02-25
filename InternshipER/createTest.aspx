<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="createTest.aspx.cs" Inherits="InternshipER.createTest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/createTest.css">
    <div class="questionMaker">
        <asp:RadioButtonList id="questionType" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButton_SelectedIndexChanged" CellPadding="5">
            <asp:ListItem Text="Çoktan Seçmeli" />
            <asp:ListItem Text="Kod" />
            <asp:ListItem Text="Açık Uçlu" />
            <asp:ListItem Text="Ses Kaydı" />
        </asp:RadioButtonList>      
        <asp:TextBox runat="server" ID="question" TextMode="MultiLine" Row="5" Height="100px" Width="200px"></asp:TextBox>
    </div>
    <br />
    <div class="addedQuestions">

    </div>
</asp:Content>


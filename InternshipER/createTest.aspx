<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="createTest.aspx.cs" Inherits="InternshipER.createTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="Content/createTest.css">
    <div class="questionMaker">
        <asp:RadioButtonList ID="questionType" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="RadioButton_SelectedIndexChanged" CellPadding="5" AutoPostBack="true" CausesValidation="False" OnDataBinding="RadioButton_SelectedIndexChanged" usesubmitbehavior="False">
            <asp:ListItem Text="Çoktan Seçmeli" />
            <asp:ListItem Text="Kod" />
            <asp:ListItem Text="Açık Uçlu" />
            <asp:ListItem Text="Ses Kaydı" />
        </asp:RadioButtonList>
        <asp:Label runat="server" Text="Soru Giriniz:"></asp:Label><br />
        <asp:TextBox runat="server" ID="question" TextMode="MultiLine" Row="5" Height="100px" Width="200px"></asp:TextBox><br />
        <asp:Button ID="addChoice" runat="server" OnClick="addChoice_Click" Text="Seçenek Ekle" CausesValidation="False" OnDataBinding="addChoice_Click" UseSubmitBehavior="False" />
        <asp:PlaceHolder ID="multipleChoices" runat="server" />

    </div>
    <div class="addedQuestions">
        <asp:PlaceHolder ID="addedQuestions" runat="server" />
    </div>
</asp:Content>


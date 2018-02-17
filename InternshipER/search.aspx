<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="search.aspx.cs" Inherits="InternshipER.searchForm" %>

<asp:Content ID="Search" ContentPlaceHolderID="MainContent" runat="server">
    <script src="Scripts/WebForms/Search.js"></script>
    <link rel="stylesheet" type="text/css" href="Content/Search.css">
    <div class="container">
    <div class="row col-md-12 col-md-offset-1 custyle">
          <div class="col-md-3">
            <form action="#" method="get">
                <div class="input-group">
                    <!-- USE TWITTER TYPEAHEAD JSON WITH API TO SEARCH -->
                    <input class="form-control" id="system-search" name="q" placeholder="Search for" required>
                    <span class="input-group-btn">
                        <button type="submit" class="btn btn-default"><i class="glyphicon glyphicon-search"></i></button>
                          <asp:Label ID="Label4" text="Location" runat="server"    ForeColor="#000000"></asp:Label>
                           
                    </span>
                         <asp:DropDownList id="dropdownlist" runat="server"> 
                          </asp:DropDownList>
          
                </div>
            </form>
        </div>
        <table  class="table table-striped custab table-list-search">
            <thead>
                <tr>
                  <asp:PlaceHolder ID = "searchTableHeader" runat="server" />
                </tr>
            </thead>
            <tbody>
            <asp:PlaceHolder ID = "searchTable" runat="server" />
            </tbody>
        </table>
    </div>
</div>


    <div class="modal fade" id="searchModal" tabindex="-1" role="dialog" aria-labelledby="searchModalLabel">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                    <h4 class="modal-title" id="searchModalLabel">Staj Basvurusu</h4>
                </div>
                <div class="modal-body" align="center">
                    <div class="container">
                        <div class="row">
                            <form method="post" action='' name="login_form" align="center">
                                <div class="col-xs-9">
                                    <div class="form-group">
                                        <label for="comment">Öğrenci Hakkında:</label>
                                        <textarea runat="server" class="form-control" rows="5" id="sop"></textarea>
                                    </div>
                                </div>
                              
                            </form>
                        </div>
                    </div>
                </div>
                <<div class="modal-footer">
                    <asp:Button class="btn btn-primary" type="submit" runat="server" ID="submitSettings" OnClick="jobAdd2User" CausesValidation="False" OnDataBinding="jobAdd2User" UseSubmitBehavior="False" Text="Kaydet"></asp:Button>
                </div>
            </div>
        </div>
    </div>
    </asp:Content>

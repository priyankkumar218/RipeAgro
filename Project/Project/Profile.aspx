<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Project.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <div class="navbar navbar-inverse navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" runat="server" href="~/Profile" style="font-family: 'Arial Rounded MT Bold'; font-size: xx-large; text-decoration: underline overline; color: #008000;">Ripe Agro-Tech</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="~/ViewStock">View Stock</a></li>
                    </ul>
                    <asp:LoginView runat="server" ViewStateMode="Disabled">
                        <AnonymousTemplate>
                            <ul class="nav navbar-nav navbar-right">
                                <li><a runat="server" href="~/Profile">Profile</a></li>
                            </ul>
                        </AnonymousTemplate>
                    </asp:LoginView>
                </div>
            </div>
        </div>
     <div class="jumbotron">
        <h2 style="font-family: 'Arial Rounded MT Bold'; text-decoration: underline overline; color: #008000">Profile</h2>
        <hr />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <h3>  
            <asp:Label ID="Label1" runat="server" CssClass="col-md-2 control-label"></asp:Label>  
        </h3>
        <h3>  
            <asp:Label ID="Label2" runat="server" CssClass="col-md-2 control-label"></asp:Label>  
        </h3>  
        <h3>  
            <asp:Label ID="Label3" runat="server" CssClass="col-md-2 control-label"></asp:Label>  
        </h3>
        <h3>  
            <asp:Label ID="Label4" runat="server" CssClass="col-md-2 control-label"></asp:Label>  
        </h3>
        <h3>  
            <asp:Label ID="Label5" runat="server" CssClass="col-md-2 control-label"></asp:Label>  
        </h3>
        <h3>  
            <asp:Button ID="LogOut" runat="server" Height="47px" onclick="Button1_Click" Text="Logout" Width="92px" CssClass="btn btn-default"/>  
        </h3>  
    </div>
</asp:Content>

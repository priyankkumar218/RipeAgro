<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Project.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
 <div class="jumbotron">
 <h2 style="font-family: 'Arial Rounded MT Bold'; text-decoration: underline overline; color: #008000">Contact Us</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>We are always here to help you. Ask your questions and click then on send query.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="YourName" CssClass="col-md-2 control-label">Please enter your name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="YourName" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="YourName"
                    CssClass="text-danger" ErrorMessage="The name field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="YourEmail" CssClass="col-md-2 control-label">Please enter your email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="YourEmail" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="YourEmail"
                    CssClass="text-danger" ErrorMessage="The email field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="QueryArea" CssClass="col-md-2 control-label">What do you want to know?</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="QueryArea" CssClass="form-control" TextMode="MultiLine" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="QueryArea"
                    CssClass="text-danger" ErrorMessage="We love the feedbacks and queries. Please provide it here..." />
            </div>
        </div>
          <div class="form-group">
               <div class="col-md-offset-2 col-md-10">
                   <asp:Button runat="server" OnClick="Submit_Click" Text="Send Query" CssClass="btn btn-default" />
               </div>
          </div>
        </div>
     <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </div>
</div>
</asp:Content>

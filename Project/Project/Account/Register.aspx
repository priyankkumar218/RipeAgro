<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Project.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="jumbotron">
        <h2 style="font-family: 'Arial Rounded MT Bold'; text-decoration: underline overline; color: #008000">Register</h2>
        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorMessage" />
        </p>

        <div class="form-horizontal">
            <h4>Create a new account.</h4>
            <hr />
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <asp:ValidationSummary runat="server" CssClass="text-danger" />
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="EmployeeId" CssClass="col-md-2 control-label">User name</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="EmployeeId" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="EmployeeId"
                        CssClass="text-danger" ErrorMessage="The employee id field is required." />
                </div>
            </div>
             <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="FullName" CssClass="col-md-2 control-label">Full name</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="FullName" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="FullName"
                        CssClass="text-danger" ErrorMessage="The full name field is required." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Password</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                        CssClass="text-danger" ErrorMessage="The password field is required." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">Confirm password</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                        CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                    <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                        CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label runat="server" CssClass="col-md-2 control-label">What's your gender?</asp:Label>
                <div class="col-md-10">
                    <asp:RadioButton ID="Male" Text="Male" runat="server"  GroupName="Gender" CssClass="radio"/>
                    <asp:RadioButton ID="Female" Text="Female" runat="server" GroupName="Gender" CssClass="radio" />
                </div>
            </div>
            <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="DropDownList1" CssClass="col-md-2 control-label">Choose your department</asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Accounts</asp:ListItem>
                        <asp:ListItem>Finance</asp:ListItem>
                        <asp:ListItem>Sales</asp:ListItem>
                        <asp:ListItem>HR</asp:ListItem>
                        <asp:ListItem>Production</asp:ListItem>
                        <asp:ListItem>Marketing</asp:ListItem>
                    </asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label runat="server" AssociatedControlID="Designation" CssClass="col-md-2 control-label">What's your designation?</asp:Label>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="Designation" CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="FullName"
                        CssClass="text-danger" ErrorMessage="The designation field is required." />
                </div>
            </div>
   
            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                        <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-default" />
                </div>
            </div>
            <br />
        </div>
      </div>
</asp:Content>

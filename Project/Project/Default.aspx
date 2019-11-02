<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1 style="font-family: 'Arial Rounded MT Bold'; text-decoration: underline overline; color: #008000">We Power Agriculture</h1>
        <p class="lead">We are agriculture tech based startup to empower and equip millions of farmers across the globe.</p>
        <p><a href="/About" class="btn btn-primary btn-lg">Learn more about us&raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Our Services</h2>
            <p class="lead">Our services include consultation, software development and Geographical analytics.</p>
             <p>
                <a class="btn btn-default" href="/Services">Know more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Our Clients</h2>
            <p class="lead"> We provide services to almost all the key players working towards development
                in agriculture. Some of them are: Seeds and Co, Fertilizers Pvt Ltd and IBM </p>
        </div>
        <div class="col-md-4">
            <h2>You are one of us?</h2>
            <p class="lead">
                We are always happy to see new faces. Click on Login to view organization related data at one place.
            </p>
            <p>
                <a class="btn btn-default" href="/Account/Login">Login &raquo;</a>
            </p>
        </div>
    </div>

    <h2>Look, What our clients are saying about us</h2>
    <div class="row">
        <blockquote>
            <p class="lead">You guys are the best in the business. We are using their blockchain tool and it's very efficient for our work.</p>
            <small><cite title="Source Title">John Doe, IBM</cite></small>
        </blockquote>
            <blockquote class="blockquote-reverse">
            <p class="lead">Really glad that we approached you. Best Consultation services.</p>
            <small><cite title="Source Title">Gordon, XYZ Fertilizers</cite></small>
        </blockquote>
    </div>

</asp:Content>

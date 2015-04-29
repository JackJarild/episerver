<%@ Page Language="c#" Inherits="ProjektUppgiftEPi.Views.Pages.StandardPageTemplate" MasterPageFile="~/Views/MasterPages/Site.Master" CodeBehind="StandardPageTemplate.aspx.cs" %>

<%@ Import Namespace="ProjektUppgiftEPi.Business" %>

<asp:Content runat="server" ContentPlaceHolderID="main">
    <div class="row">
        <div class="col-xs-12">
            <EPiServer:Property runat="server"
                PropertyName="Image" CssClass="img-responsive" />
        </div>
    </div>

    <div class="row">
        <div class="col-xs-12">
            <div class="jumbotron">
                <hr />
                <h2 class="intro-text text-center">
                    <EPiServer:Property runat="server" PropertyName="SecondHeadline">
                    </EPiServer:Property>
                </h2>
                <hr />
                <EPiServer:Property runat="server" PropertyName="MainContent"></EPiServer:Property>

            </div>
        </div>
    </div>
</asp:Content>


<asp:Content runat="server" ContentPlaceHolderID="left">
    <div class="row">
        <div class="col-xs-12">
            <div class="container-fluid">
                <div class="row">
                    <EPiServer:Property runat="server" PropertyName="LeftContent">
                        <RenderSettings Tag="Teaser"></RenderSettings>
                    </EPiServer:Property>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="center">
    <div class="row">
        <div class="col-xs-12">
            <div class="container-fluid">
                <div class="row">
                    <EPiServer:Property runat="server" PropertyName="CenterContent">
                        <RenderSettings Tag="Teaser"></RenderSettings>
                    </EPiServer:Property>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="right">
    <div class="row">
        <div class="col-xs-12">
            <div class="container-fluid">
                <div class="row">
                    <EPiServer:Property runat="server" PropertyName="RightContent">
                        <RenderSettings Tag="Teaser"></RenderSettings>
                    </EPiServer:Property>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

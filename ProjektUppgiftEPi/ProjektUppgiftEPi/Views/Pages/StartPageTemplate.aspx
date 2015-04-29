<%@ Page Language="c#" Inherits="ProjektUppgiftEPi.Views.Pages.StartPageTemplate" MasterPageFile="~/Views/MasterPages/Site.Master" CodeBehind="StartPageTemplate.aspx.cs" %>

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
                <div class="text-center">
                    <h2 class="brand-before">
                        <small>Welcome to</small>
                    </h2>
                    <h2 class="brand-name">
                        <EPiServer:Property ID="Property1" runat="server" PropertyName="Headline"></EPiServer:Property>
                    </h2>
                    <hr class="tagline-divider" />
                    <h2>
                        <small>By
                           
                            <strong>Jack Järild</strong>
                        </small>
                    </h2>
                </div>
            </div>
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
    <div class="col-xs-4">
        <div class="container-fluid">
            <div class="row">
                <div class="col-xs-12">
                    <%--<img src="http://s3-eu-west-1.amazonaws.com/petrus-blog/placeholder.png" class="img-responsive" />
                        <h2>Rubrik</h2>
                        <div>Min text</div>--%>

                    <EPiServer:Property runat="server" PropertyName="LeftContent">
                        <RenderSettings Tag="Teaser"></RenderSettings>
                    </EPiServer:Property>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="center">
    <div class="col-xs-4">
        <div class="container-fluid">
            <div class="row">
                <div class="col-xs-12">
                    <%--<img src="http://s3-eu-west-1.amazonaws.com/petrus-blog/placeholder.png" class="img-responsive" />
                    <h2>Rubrik</h2>
                    <div>Min text</div>--%>

                    <EPiServer:Property runat="server" PropertyName="CenterContent">
                        <RenderSettings Tag="Teaser"></RenderSettings>
                    </EPiServer:Property>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="right">
    <div class="col-xs-4">
        <div class="container-fluid">
            <div class="row">
                <div class="col-xs-12">
                    <%--<img src="http://s3-eu-west-1.amazonaws.com/petrus-blog/placeholder.png" class="img-responsive" />
                    <h2>Rubrik</h2>
                    <div>Min text</div>--%>

                    <EPiServer:Property runat="server" PropertyName="RightContent">
                        <RenderSettings Tag="Teaser"></RenderSettings>
                    </EPiServer:Property>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

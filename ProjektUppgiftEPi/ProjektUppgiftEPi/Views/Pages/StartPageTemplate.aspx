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
                    <h1>
                        <EPiServer:Property ID="Property1" runat="server" PropertyName="Headline"></EPiServer:Property>                        
                    </h1>
                </div>
                <EPiServer:Property runat="server" PropertyName="MainContent"></EPiServer:Property>
            </div>
        </div>
    </div>

    <div class="row">
        <div class="col-xs-4">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-xs-12">
                        <img src="http://s3-eu-west-1.amazonaws.com/petrus-blog/placeholder.png" class="img-responsive" />
                        <h2>Rubrik</h2>
                        <div>Min text</div>

                    </div>
                </div>
            </div>
        </div>
        <div class="col-xs-4">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-xs-12">
                        <img src="http://s3-eu-west-1.amazonaws.com/petrus-blog/placeholder.png" class="img-responsive" />
                        <h2>Rubrik</h2>
                        <div>Min text</div>

                    </div>
                </div>
            </div>
        </div>
        <div class="col-xs-4">
            <div class="container-fluid">
                <div class="row">
                    <div class="col-xs-12">
                        <img src="http://s3-eu-west-1.amazonaws.com/petrus-blog/placeholder.png" class="img-responsive" />
                        <h2>Rubrik</h2>
                        <div>Min text</div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

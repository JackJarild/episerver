<%@ Page Language="c#" Inherits="ProjektUppgiftEPi.Views.Pages.StandardPageTemplate" MasterPageFile="~/Views/MasterPages/Site.Master" CodeBehind="StandardPageTemplate.aspx.cs" %>
<%@ Import Namespace="ProjektUppgiftEPi.Business" %>

<asp:Content runat="server" ContentPlaceHolderID="main">
    <h1>
        <EPiServer:Property runat="server" PropertyName="Headline"></EPiServer:Property>
    </h1>

    <div>
        <EPiServer:Property runat="server" PropertyName="MainContent" />
    </div>
  
    <div>
      <EPiServer:Property runat="server" PropertyName="BlockContents"></EPiServer:Property>
    </div>
</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="right">
  <EPiServer:Property runat="server" PropertyName="RightContent">
    <RenderSettings Tag="Teaser"></RenderSettings>
  </EPiServer:Property>
    
            
</asp:Content>
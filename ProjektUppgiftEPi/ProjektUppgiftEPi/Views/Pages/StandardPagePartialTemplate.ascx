<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StandardPagePartialTemplate.ascx.cs" Inherits="ProjektUppgiftEPi.Views.Pages.StandardPagePartialTemplate" %>
<%@ Import Namespace="EPiServer.ServiceLocation" %>
<%@ Import Namespace="EPiServer.Web.Routing" %>
<div class="jumbotron MyJumbo">
  <div>
    <EPiServer:Property runat="server"
      PropertyName="TeaserImage" CssClass="img-responsive" />
  </div>
  <h4>
    <EPiServer:Property runat="server" PropertyName="PageName" />
  </h4>
  <div>
    <EPiServer:Property runat="server" PropertyName="TeaserText" />
    <a href="<%=UrlResolver.Current.GetUrl(CurrentData.PageLink) %>">
      &nbsp;Read more
    </a>&raquo;
  </div>
</div>
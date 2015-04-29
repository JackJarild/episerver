<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RandomTeaserTemplate.ascx.cs" Inherits="ProjektUppgiftEPi.Views.Blocks.RandomTeaserTemplate" %>
<%@ Import Namespace="EPiServer.Web.Routing" %>
<div class="jumbotron">
  <div>
    <img src="<%=UrlResolver.Current.GetUrl(SelectedPage.TeaserImage) %>" class="img-responsive"/>
  </div>
  <h4>
      <%=SelectedPage.PageName %>
  </h4>
  <div>
    <%=SelectedPage.TeaserText %>
    <a href="<%=UrlResolver.Current.GetUrl(SelectedPage.PageLink) %>">
      &nbsp;Read more
    </a>&raquo;
  </div>
</div>
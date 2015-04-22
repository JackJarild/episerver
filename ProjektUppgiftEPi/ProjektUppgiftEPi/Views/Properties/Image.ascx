<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Image.ascx.cs" Inherits="ProjektUppgiftEPi.Views.Properties.Image" %>
<%@ Import Namespace="EPiServer.Web" %>
<%@ Import Namespace="EPiServer.Web.Routing" %>

<%if (CurrentData != null) 
  { %>
    <img src="<%#UrlResolver.Current.GetUrl(CurrentData) %>"
        title="<%#CurrentData != null ? ImageFile.Copyright : string.Empty %>"
        class="img-responsive" />
<% } %>

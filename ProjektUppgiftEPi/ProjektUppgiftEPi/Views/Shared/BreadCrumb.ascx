<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BreadCrumb.ascx.cs" Inherits="ProjektUppgiftEPi.Views.Shared.BreadCrumb" %>


<EPiServer:PageList runat="server" id="MyBreadcrumb">
  <HeaderTemplate>
    <ul class="breadcrumb">
  </HeaderTemplate>
  <ItemTemplate>
    <li><EPiServer:Property PropertyName="PageLink" runat="server"/> </li>    
  </ItemTemplate>  
  <FooterTemplate>
    </ul>
  </FooterTemplate>
</EPiServer:PageList>
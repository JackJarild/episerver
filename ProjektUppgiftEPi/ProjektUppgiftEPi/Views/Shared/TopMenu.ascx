<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TopMenu.ascx.cs" Inherits="ProjektUppgiftEPi.Views.Shared.TopMenu" %>
<%@ Import Namespace="EPiServer.Core" %>
<%@ Import Namespace="ProjektUppgiftEPi.Models.Pages" %>
<%@ Import Namespace="ProjektUppgiftEPi.Business" %>
<%@ Import Namespace="EPiServer.ServiceLocation" %>
<%@ Import Namespace="EPiServer" %>

<nav class="navbar">
    <ul class="nav navbar-nav">
        <li <%=GetMenuItemCss(ContentReference.StartPage) %>>
            <a href="<%=GetUrl(ContentReference.StartPage) %>">Home</a>
        </li>
        <asp:Repeater runat="server" ID="Menu" OnItemDataBound="Menu_OnItemDataBound">
            <ItemTemplate>
                <li <%#GetMenuItemCss((ContentReference)Eval("PageLink")) %>>

                    <a href="<%#Eval("LinkUrl") %>" <%#GetMenuLinkAttributes((ContentReference)Eval("PageLink")) %>>

                        <%#Eval("PageName") %></a>
                    <ul class="dropdown-menu" runat="server" id="SubmenuUL">
                        <asp:Repeater runat="server" ID="Submenu">
                            <ItemTemplate>
                                <li><a href="<%#Eval("LinkUrl") %>"><%#Eval("PageName") %></a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
    <div class="languageSelector">
        <asp:DropDownList runat="server" ID="Language"
            DataTextField="Name" DataValueField="LanguageID" AutoPostBack="True" />
    </div>
</nav>

<script language="c#" runat="server">
    protected string GetMenuLinkAttributes(ContentReference page)
    {
        if (page.HasChildren())
        {
            return "data-toggle=\"dropdown\"";
        }

        return string.Empty;
    }

    protected string GetMenuItemCss(ContentReference page)
    {
        // TODO: Kolla även om page är "förfader" till CurrentPage   

        if (page.CompareToIgnoreWorkID(CurrentPage.PageLink)
            ||
            (
            !page.CompareToIgnoreWorkID(ContentReference.StartPage)
            &&
            page.IsAncestorOf(CurrentPage.PageLink)
            ))
        {
            return "class=\"active\"";
        }

        return "class=\"dropdown\"";
    }
</script>

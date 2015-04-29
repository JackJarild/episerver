<%@ Page Language="c#" Inherits="ProjektUppgiftEPi.Views.Pages.SearchPageTemplate" MasterPageFile="~/Views/MasterPages/Site.Master" CodeBehind="SearchPageTemplate.aspx.cs" %>

<asp:Content runat="server" ContentPlaceHolderID="main">
    <div class="mainbody">
        <div class="search-container">
            <div class="text-center">
                <input runat="server" class="form-control MyForm" type="search" id="txtSearch"/>
                <asp:Button runat="server" ID="btnSearch" CssClass="btn" OnClick="btnSearch_OnClick" Text="Search"></asp:Button>
            </div>

            <EPiServer:SearchDataSource runat="server" ID="sdsFreeText">
                <SelectParameters>
                    <asp:QueryStringParameter QueryStringField="query" Name="SearchQuery"/>
                </SelectParameters>
            </EPiServer:SearchDataSource>
            
            <asp:Repeater runat="server" ID="rptSearchResult">
                <HeaderTemplate>
                    <div class="search">
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="SearchResult">
                        <EPiServer:Property runat="server" PropertyName="PageLink"/>
                    </div>
                </ItemTemplate>
                <FooterTemplate>
                    </div>
                </FooterTemplate>
            </asp:Repeater> 
        </div>
    </div>
</asp:Content>
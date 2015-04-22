<%@ Page Language="c#" Inherits="ProjektUppgiftEPi.Views.Pages.SearchPageTemplate" MasterPageFile="~/Views/MasterPages/Site.Master" CodeBehind="SearchPageTemplate.aspx.cs" %>

<asp:Content runat="server" ContentPlaceHolderID="main">
    <h1>
        <EPiServer:Property runat="server" PropertyName="Headline" />
    </h1>

    <asp:Panel runat="server" DefaultButton="btnSearch">
        <asp:TextBox runat="server" ID="txtSearch"></asp:TextBox>&nbsp;
    <asp:Button runat="server" ID="btnSearch" Text="Search"
        OnClick="btnSearch_OnClick" />
    </asp:Panel>

    <EPiServer:SearchDataSource runat="server" ID="sdsFreetext">
        <SelectParameters>
            <asp:QueryStringParameter QueryStringField="query"
                Name="SearchQuery" />
        </SelectParameters>
    </EPiServer:SearchDataSource>

    <hr />
    <asp:Repeater runat="server" ID="rptSearchResults">
        <ItemTemplate>
            <div class="searchresult">
                <EPiServer:Property runat="server" PropertyName="PageLink" />
                <br/>
                <%#Eval("TeaserText") %>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <div class="paging">
        <%for (int i = 1; i <= TotalPages; i++)
          { %>
        <a href="<%=this.GetPagingUrl(i) %>"><%=i %></a>&nbsp;
    <% } %>
        <asp:DropDownList runat="server" ID="ddlPageSize" AutoPostBack="True" OnSelectedIndexChanged="ddlPageSize_OnSelectedIndexChanged">
            <Items>
                <asp:ListItem Enabled="False"></asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Value="10">10</asp:ListItem>
                <asp:ListItem Value="20">20</asp:ListItem>
            </Items>
        </asp:DropDownList>
    </div>
</asp:Content>
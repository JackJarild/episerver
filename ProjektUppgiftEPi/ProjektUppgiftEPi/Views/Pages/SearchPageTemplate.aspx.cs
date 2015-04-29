using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;
using EPiServer.Web.WebControls;
using ProjektUppgiftEPi.Models.Pages;
using ProjektUppgiftEPi.Business;

namespace ProjektUppgiftEPi.Views.Pages
{

    [TemplateDescriptor(Path = "~/Views/Pages/SearchPageTemplate.aspx")]
    public partial class SearchPageTemplate : EPiServer.TemplatePage<SearchPage>
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!string.IsNullOrWhiteSpace(Query))
                {
                    sdsFreeText.PageLink = CurrentPage.SearchRoot;
                    sdsFreeText.DataBind();

                    // Hämta resultatet som en lista
                    var result = sdsFreeText
                      .Select(DataSourceSelectArguments.Empty)
                      .Cast<BasePage>();

                    rptSearchResult.DataSource = result;

                    rptSearchResult.DataBind();
                }
            }
        }

        protected string Query
        {
            get { return Request.QueryString["query"] ?? string.Empty; }
        }

        protected void btnSearch_OnClick(object sender, EventArgs e)
        {
            var url = UriSupport.AddQueryString(
              Request.RawUrl, "query", txtSearch.Value);
            Response.Redirect(url, true);
        }
    }
}
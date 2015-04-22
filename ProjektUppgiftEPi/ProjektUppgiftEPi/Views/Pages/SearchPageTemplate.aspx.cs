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
                    sdsFreetext.PageLink = ContentReference.StartPage;
                    sdsFreetext.DataBind();

                    // Hämta resultatet som en lista
                    var result = sdsFreetext
                      .Select(DataSourceSelectArguments.Empty)
                      .Cast<BasePage>();
                    TotalRows = result.Count();

                    rptSearchResults.DataSource = result
                      .Skip((PageNumber - 1) * PageSize)
                      .Take(PageSize);

                    rptSearchResults.DataBind();

                    ddlPageSize.SelectedValue = PageSize.ToString();
                }
            }
        }

        protected void btnSearch_OnClick(object sender, EventArgs e)
        {
            var url = UriSupport.AddQueryString(
              Request.RawUrl, "query", txtSearch.Text);
            Response.Redirect(url, true);
        }

        protected string Query
        {
            get { return Request.QueryString["query"] ?? string.Empty; }
        }

        protected int PageNumber
        {
            get
            {
                return Request.QueryString["page"].ToInt(1);
            }
        }

        public int TotalRows { get; set; }

        public int TotalPages
        {
            get
            {
                return (int)Math.Ceiling(TotalRows / (double)PageSize);
            }
        }

        public string GetPagingUrl(int i)
        {
            return UriSupport.AddQueryString
              (Request.RawUrl, "page", i.ToString());
        }

        protected int PageSize
        {
            get
            {
                return Request.QueryString["pagesize"].ToInt(2);
            }
        }

        protected void ddlPageSize_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var url = UriSupport.AddQueryString(
           Request.RawUrl, "pagesize", ddlPageSize.SelectedValue);
            Response.Redirect(url, true);
        }
    }
}
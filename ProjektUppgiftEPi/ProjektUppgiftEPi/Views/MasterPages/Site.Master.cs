using EPiServer.DataAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using ProjektUppgiftEPi.Models.Pages;

namespace ProjektUppgiftEPi.Views.MasterPages
{
    public partial class Site : MasterPageBase
    {
        private List<LanguageBranch> availableLanguages;

        private string selectedLanguage;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Page.Header.Controls.Add(new HtmlMeta
            //{
            //    Name = "description",
            //    Content = CurrentPage.MetaDescription
            //});

            //var langCookie = Request.Cookies["language"];

            //if (langCookie != null && !string.IsNullOrEmpty(langCookie.Value))
            //{
            //  if (langCookie.Value != CurrentPage.LanguageID)
            //  {
            //    Response.Redirect(UriSupport.AddLanguageSelection(CurrentPage.LinkURL, langCookie.Value), true);
            //  }
            //}
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.Web.WebControls;
using EPiServer.ServiceLocation;
using ProjektUppgiftEPi.Models.Pages;

namespace ProjektUppgiftEPi.Views.Shared
{
    public partial class TopMenu : BaseUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Menu.DataSource =
                ServiceLocator.Current
                .GetInstance<IContentLoader>()
                .GetChildren<BasePage>(ContentReference.StartPage);
            Menu.DataBind();

            if (Request[Language.UniqueID] != CurrentPage.LanguageID && Page.IsPostBack)
            {
                ChangeLanguage(Request[Language.UniqueID]);
            }

            Language.DataSource =
                ServiceLocator.Current
                .GetInstance<ILanguageBranchRepository>()
                .ListAll()
                .Where(x => x.Enabled)
                .OrderBy(x => x.SortIndex);
            Language.DataBind();

            Language.SelectedValue = CurrentPage.LanguageID;
        }

        private void ChangeLanguage(string language)
        {
            Response.Cookies.Add(new HttpCookie("language", language) { Expires = DateTime.Now.AddYears(1) });

            var languageBranch =
                ServiceLocator.Current.GetInstance<ILanguageBranchRepository>().Load(language);

            if (!languageBranch.Enabled) return;

            // Kolla om sidan är översatt till språket
            if (CurrentPage.ExistingLanguages.Any(c => c.Name == languageBranch.LanguageID))
            {
                Response.Redirect(UriSupport.AddLanguageSelection(CurrentPage.LinkURL, languageBranch.LanguageID), true);
            }

            // Sidan var inte översatt - kontroller om sidan har ett fallback-språk
            var languageFallbacks =
                ServiceLocator.Current.GetInstance<IContentLanguageSettingsHandler>().GetFallbackLanguages(
                    CurrentPage.ContentLink, languageBranch.LanguageID);
            if (languageFallbacks.Contains(CurrentPage.LanguageBranch))
            {
                Response.Redirect(UriSupport.AddLanguageSelection(CurrentPage.LinkURL, languageBranch.LanguageID), true);
            }

            // Ingen fallback - gör ingenting
            return;
        }

        protected void Menu_OnItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            // hitta inre repeatern
            var submenu = e.Item.FindControl("Submenu") as Repeater;
            // bind inre rep till sidorna under nuvarande topmenyalt
            if (submenu != null)
            {
                var page = e.Item.DataItem as PageData;
                if (page != null)
                {
                    var children = ServiceLocator.Current
                        .GetInstance<IContentLoader>()
                        .GetChildren<BasePage>(page.PageLink)
                        .Where(x => x.VisibleInMenu);

                    var ul = e.Item.FindControl("SubmenuUL");
                    if (ul != null)
                    {
                        ul.Visible = children.Any();
                    }

                    var menuLink = e.Item.FindControl("MenuLink");
                    if (menuLink != null)
                    {
                    }

                    submenu.DataSource = children;
                    submenu.DataBind();
                }
            }
        }

        //protected void btnChangeLanguage_OnClick(object sender, EventArgs e)
        //{            
        //    var selectedLanguage = Request[Language.UniqueID];

        //    if (Page.IsPostBack && !string.IsNullOrEmpty(selectedLanguage))
        //    {
        //        Response.Cookies.Add(new HttpCookie("language", selectedLanguage) { Expires = DateTime.Now.AddYears(1) });

        //        var languageBranch =
        //            ServiceLocator.Current.GetInstance<ILanguageBranchRepository>().Load(selectedLanguage);

        //        if (!languageBranch.Enabled) return;

        //        // Kolla om sidan är översatt till språket
        //        if (CurrentPage.ExistingLanguages.Any(c => c.Name == languageBranch.LanguageID))
        //        {
        //            Response.Redirect(UriSupport.AddLanguageSelection(CurrentPage.LinkURL, languageBranch.LanguageID), true);
        //        }

        //        // Sidan var inte översatt - kontroller om sidan har ett fallback-språk
        //        var languageFallbacks =
        //            ServiceLocator.Current.GetInstance<IContentLanguageSettingsHandler>().GetFallbackLanguages(
        //                CurrentPage.ContentLink, languageBranch.LanguageID);
        //        if (languageFallbacks.Contains(CurrentPage.LanguageBranch))
        //        {
        //            Response.Redirect(UriSupport.AddLanguageSelection(CurrentPage.LinkURL, languageBranch.LanguageID), true);
        //        }

        //        // Ingen fallback - gör ingenting
        //        return;
        //    }
        //}
    }
}
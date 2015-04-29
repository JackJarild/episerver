using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using ProjektUppgiftEPi.Models.Blocks;
using ProjektUppgiftEPi.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.WebControls;

namespace ProjektUppgiftEPi.Views.Blocks
{
    public partial class RandomTeaserTemplate : BlockControlBase<RandomTeaser>
    {
        private BasePage _selectedPage;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected BasePage SelectedPage
        {
            get
            {
                if (_selectedPage == null)
                {
                    var pages =
                        ServiceLocator.Current.GetInstance<IContentLoader>().GetDescendents(CurrentData.Root ??
                                                                                            CurrentPage.PageLink).ToList
                            ();

                    if (pages.Any())
                    {
                        var page = pages[new Random().Next(0, pages.Count())];
                        _selectedPage = ServiceLocator.Current.GetInstance<IContentLoader>().Get<BasePage>(page);
                    }
                }

                if (_selectedPage != null) return _selectedPage;

                return CurrentPage as BasePage;
            }
        }
    }
}
using System;
using System.Web;
using System.Web.UI;
using ProjektUppgiftEPi.Models.Pages;
using EPiServer;

namespace ProjektUppgiftEPi.Views.MasterPages
{
    public class MasterPageBase : MasterPage
    {
        protected BasePage CurrentPage
        {
            get
            {
                if (HttpContext.Current == null)
                {
                    throw new NotSupportedException("Unable to retrieve the current page without an HTTP context");
                }

                var pb = HttpContext.Current.Handler as PageBase;

                if (pb == null)
                {
                    throw new NotSupportedException("Unable to get the current PageBase object, unable to identify the current page");
                }

                var currentPage = pb.CurrentPage as BasePage;

                if (currentPage == null)
                {
                    throw new NotSupportedException("The current page type does not inherit BasePage");
                }

                return currentPage;
            }
        }
    }
}
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

namespace ProjektUppgiftEPi.Views.Shared
{
    public partial class BreadCrumb : EPiServer.UserControlBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          MyBreadcrumb.DataSource =
            ServiceLocator.Current.GetInstance<IContentLoader>()
            .GetAncestors(CurrentPage.PageLink)
            .Where(x => this.HasTemplate(x)).Reverse();
          MyBreadcrumb.DataBind();
    }

    private bool HasTemplate(IContent content)
    {
      var pageData = content as PageData;
      if (pageData != null) return pageData.HasTemplate();

      return false;
     }
  }
}
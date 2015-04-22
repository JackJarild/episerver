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

namespace ProjektUppgiftEPi.Views.Pages
{
    [TemplateDescriptor(Path = "~/Views/Pages/StandardPageTemplate.aspx")]
    public partial class StandardPageTemplate : EPiServer.TemplatePage<StandardPage>
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
    }
}


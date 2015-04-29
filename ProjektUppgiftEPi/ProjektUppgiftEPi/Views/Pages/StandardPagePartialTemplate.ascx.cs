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
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;
using ProjektUppgiftEPi.Models.Pages;

namespace ProjektUppgiftEPi.Views.Pages
{
    [TemplateDescriptor(Tags = new[] {"Teaser"})]
    public partial class StandardPagePartialTemplate : ContentControlBase<StandardPage>
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.WebControls;
using EPiServer.Framework.DataAnnotations;
using ProjektUppgiftEPi.Models.Media;
using EPiServer.ServiceLocation;

namespace ProjektUppgiftEPi.Views.Properties
{
    [TemplateDescriptor(TagString = "Image2")]
    public partial class Image : PropertyControlBase<ContentReference>
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.DataBind();
        }

        protected ImageFile ImageFile
        { 
            get
            {
                return
                    ServiceLocator.Current.GetInstance<IContentLoader>()
                    .Get<ImageFile>(CurrentData);
            }
        }
    }
}
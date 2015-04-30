using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using EPiServer;

namespace ProjektUppgiftEPi.Models.Pages
{
    [AvailableContentTypes(ExcludeOn = new[] { typeof(StandardPage), typeof(StartPage) })]
    [ContentType(DisplayName = "Start page", GUID = "255070ed-29af-4295-a3e0-1da5f2d65a88", Description = "")]
    [ImageUrl("~/Static/Images/startpage-icon.png")]
    public class StartPage : BasePage
    {
        [UIHint("Image2")]
        public virtual ContentReference Image { get; set; }

        [Display(Description = "The text visible at the top of the page", Name = "First small headline", Order = 7)]
        [CultureSpecific]
        public virtual XhtmlString FirstSmallHeadline { get; set; }

        [Display(Description = "The text visible at the top of the page", Name = "Second small headline", Order = 7)]
        [CultureSpecific]
        public virtual XhtmlString SecondSmallHeadline { get; set; } 
    }
}
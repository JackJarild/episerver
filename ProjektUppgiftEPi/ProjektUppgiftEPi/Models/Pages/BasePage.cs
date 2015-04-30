using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace ProjektUppgiftEPi.Models.Pages
{

    public abstract class BasePage : PageData
    {
        [Display(Description = "Meta title", Name = "Title", Order = 1, GroupName = SystemTabNames.Settings)]
        [CultureSpecific]
        public virtual string Title
        {
            get
            {
                var title = this.GetPropertyValue(x => x.Title);
                return string.IsNullOrEmpty(title) ? this.PageName : title;
            }
            set
            {
                this.SetPropertyValue(x => x.Title, value);
            }
        }

        [Display(Description = "Meta description", Name = "Description", Order = 2, GroupName = SystemTabNames.Settings)]
        [UIHint("textarea")]
        public virtual string MetaDescription { get; set; }

        [Display(Description = "The text visible at the top of the page", Name = "Headline", Order = 3, GroupName = SystemTabNames.Content)]
        [CultureSpecific]
        public virtual string Headline { get; set; }

        [Display(Description = "The text visible at the top of the page", Name = "Headline", Order = 3, GroupName = SystemTabNames.Content)]
        [CultureSpecific]
        public virtual string MainHeadline { get; set; }

        [Display(Description = "The text visible at the top of the page", Name = "Headline", Order = 3, GroupName = SystemTabNames.Content)]
        [CultureSpecific]
        public virtual string SecondMainHeadline { get; set; }


        [Display(Description = "The text visible at the top of the page", Name = "Second Headline", Order = 7, GroupName = SystemTabNames.Content)]
        [CultureSpecific]
        public virtual XhtmlString SecondHeadline { get; set; } 

        [Display(Description = "The main content text", Name = "Main content", Order = 4, GroupName = SystemTabNames.Content)]
        [CultureSpecific]
        public virtual XhtmlString MainContent { get; set; }

        [Display(Description = "Teaser text", Name = "Teaser", Order = 5, GroupName = "Teaser")]
        [CultureSpecific]
        public virtual string TeaserText { get; set; }

        [UIHint(UIHint.Image)]
        [Display(Description = "Teaser image", Name = "Teaser image", Order = 6, GroupName = "Teaser")]
        public virtual ContentReference TeaserImage { get; set; }
    }
}
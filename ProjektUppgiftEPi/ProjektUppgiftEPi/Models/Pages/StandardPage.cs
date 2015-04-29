using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace ProjektUppgiftEPi.Models.Pages
{
    [ContentType(DisplayName = "Standard", GUID = "942342a1-b7c3-440c-8527-6089162b34c3", Description = "")]
    public class StandardPage : BasePage
    {
        public virtual ContentArea BlockContents { get; set; }

        public virtual ContentArea LeftContent { get; set; }

        public virtual ContentArea CenterContent { get; set; }

        public virtual ContentArea RightContent { get; set; }
        
        [UIHint("Image2")]
        public virtual ContentReference Image { get; set; }
    }
}
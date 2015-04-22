using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace ProjektUppgiftEPi.Models.Pages
{
    [ContentType(DisplayName = "SearchPage", GUID = "c1795db6-fce3-45e4-bff5-100b6b117672", Description = "")]
    public class SearchPage : BasePage
    {
           [CultureSpecific]
           [Display(
                Name = "Search root",
                Description = "Find pages beneath this page",
                GroupName = SystemTabNames.Content,
                Order = 1)]
     
        public virtual PageReference SearchRoot { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace ProjektUppgiftEPi.Models.Blocks
{
    [ContentType(DisplayName = "RandomTeaser", GUID = "b9312ae6-91d3-4e6e-aa02-71369c517551", Description = "")]
    public class RandomTeaser : BlockData
    {
        [Display(Name = "Root", Description = "The random page is selected from descendants of this page")]
        public virtual ContentReference Root { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Framework.DataAnnotations;

namespace ProjektUppgiftEPi.Models.Media
{
    [ContentType(GUID = "3ce1eea0-08ad-4a64-be7f-c39dcb855757")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,png,bmp")]
    public class ImageFile : ImageData
    {
        /// <summary>
        /// Gets or sets the copyright.
        /// </summary>
        /// <value>
        /// The copyright.
        /// </value>
        public virtual string Copyright { get; set; }
    }
}
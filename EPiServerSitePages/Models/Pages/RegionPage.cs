using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServerSitePages.Models.Pages;

namespace EPiServerSitePages.Models.Pages
{
    [ContentType(DisplayName = "Region"), AvailableContentTypes(Include = new Type[] { typeof(CityPage) }, IncludeOn = new Type[] { typeof(CountryPage) })]
    public class RegionPage : PageData
    {
        [Display(Name = "Name", Description = "", GroupName = SystemTabNames.Content, Order = 1)]
        public virtual String RegionName { get; set; }

        [Display(Name = "Square", Description = "", GroupName = SystemTabNames.Content, Order = 2)]
        public virtual String RegionSquare { get; set; }

    }
}
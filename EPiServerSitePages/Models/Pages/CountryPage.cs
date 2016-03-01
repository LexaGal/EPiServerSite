using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EPiServerSitePages.Models.Pages
{
    [ContentType(DisplayName = "Country"), AvailableContentTypes(Include = new Type[] { typeof(RegionPage) })]
    public class CountryPage : PageData
    {
        [Display(Name = "Name", Description = "", GroupName = SystemTabNames.Content, Order = 1)]
        public virtual String CountryName { get; set; }

        [Display(Name = "Square", Description = "", GroupName = SystemTabNames.Content, Order = 2)]
        public virtual String CountrySquare { get; set; }
    }
}
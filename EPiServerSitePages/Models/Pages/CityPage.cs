using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EPiServerSitePages.Models.Pages
{

    [ContentType(DisplayName = "City"), AvailableContentTypes(IncludeOn = new Type[] { typeof(RegionPage) })]
    public class CityPage : PageData
    {
        [Display(Name = "Name", Description = "", GroupName = SystemTabNames.Content, Order = 1)]
        public virtual String CityName { get; set; }

        [Display(Name = "Square", Description = "", GroupName = SystemTabNames.Content, Order = 2)]
        public virtual String CitySquare { get; set; }

    }
}
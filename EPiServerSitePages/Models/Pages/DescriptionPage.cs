using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web.WebControls;
using EPiServerSitePages.Models.Blocks;
using EPiServerSitePages.Models.Properties;
using EpiSS.Models.Blocks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EPiServerSitePages.Models.Pages
{

    [ContentType(DisplayName = "DescriptionPage", GUID = "0e522182-f277-4bbe-a53b-e8b6b095b3af", Description = "")]
    public class DescriptionPage : PageData
    {
        public DescriptionPage() : base()
        {
            IsReadOnly = false;
        }

        public void Add(List<DescriptionItem> list)
        {
            Block.DescriptionItems = list.AsEnumerable();
        }

        public virtual PagesListBlock Block { get; set; }
    }
}
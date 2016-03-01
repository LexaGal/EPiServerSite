using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServerSitePages.Models.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EPiServerSitePages.Models.Blocks
{
    [ContentType]
    public class PagesListBlock : BlockData
    {
        [BackingType(typeof(DescriptionItemProperty))]
        public virtual IEnumerable<DescriptionItem> DescriptionItems { get; set; }
    }
}
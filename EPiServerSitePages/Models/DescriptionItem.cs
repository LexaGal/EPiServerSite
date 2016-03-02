using EPiServer.Core;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPiServerSitePages.Models.Blocks
{
    [ContentType]
	public class DescriptionItem
    {
        public String PageName { get; set; }
        public String PageType { get; set; }
        public String ItemName { get; set; }
        public String ItemSquare { get; set; }
        public String Item => this.ToString();
        public String PageReference { get; set; }

        public override string ToString()
        {
            return string.Format("Page: {0} - {1}, Data: {2} - {3}", PageName, PageType, ItemName, ItemSquare);
        }

    }
}
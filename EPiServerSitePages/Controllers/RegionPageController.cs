using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EPiServerSitePages.Models.Pages;

namespace EPiServerSitePages.Controllers
{
    public class RegionPageController : PageController<RegionPage>
    {
        public ActionResult Index(RegionPage currentPage)
        {
            return View(currentPage);
        }
    }
}
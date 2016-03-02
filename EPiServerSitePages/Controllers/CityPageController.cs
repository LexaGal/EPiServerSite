using EPiServer.Web.Mvc;
using EPiServerSitePages.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPiServerSitePages.Controllers
{
    public class CityPageController : PageController<CityPage>
    {
        public ActionResult Index(CityPage currentPage)
        {
            return View(currentPage);
        }
    }
}
using EPiServer.Web.Mvc;
using EPiServerSitePages.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPiServerSitePages.Controllers
{
    namespace MyEPiServerSiteMVC.Controllers
    {
        public class CountryPageController : PageController<CountryPage>
        {
            public ActionResult Index(CountryPage currentPage)
            {
                return View(currentPage);
            }
        }
    }
}
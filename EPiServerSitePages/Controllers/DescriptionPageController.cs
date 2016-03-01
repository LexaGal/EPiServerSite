using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EPiServerSitePages.Models.Pages;
using EPiServerSitePages.Models.Blocks;
using EPiServer.Filters;
using EPiServer.DataAbstraction;

namespace EPiServerSitePages.Controllers
{
    public class DescriptionPageController : PageController<DescriptionPage>
    {
        public ActionResult Index(DescriptionPage currentPage)
        {
            currentPage = currentPage.CreateWritableClone() as DescriptionPage;

            PageDataCollection countryPages = DataFactory.Instance.FindPagesWithCriteria(ContentReference.RootPage, InitPropertyCriteriaCollection("CountryPage"));

            List<DescriptionItem> list = new List<DescriptionItem>();

            foreach (var countryPage in countryPages)
            {
                list.Add(new DescriptionItem() { PageName = countryPage.Name, PageType = countryPage.PageTypeName, ItemName = (countryPage as CountryPage).CountryName, ItemSquare = (countryPage as CountryPage).CountrySquare, PageReference = countryPage});
                
                PageDataCollection regionPages = DataFactory.Instance.FindPagesWithCriteria(countryPage.ContentLink.ToPageReference(), InitPropertyCriteriaCollection("RegionPage"));

                
                foreach (var regionPage in regionPages)
                {
                    list.Add(new DescriptionItem() { PageName = regionPage.Name, PageType = regionPage.PageTypeName, ItemName = (regionPage as RegionPage).RegionName, ItemSquare = (regionPage as RegionPage).RegionSquare, PageReference = regionPage });
                    PageDataCollection cityPages = DataFactory.Instance.FindPagesWithCriteria(regionPage.ContentLink.ToPageReference(), InitPropertyCriteriaCollection("CityPage"));
                    
                    foreach (var cityPage in cityPages)
                    {
                        list.Add(new DescriptionItem() { PageName = cityPage.Name, PageType = cityPage.PageTypeName, ItemName = (cityPage as CityPage).CityName, ItemSquare = (cityPage as CityPage).CitySquare, PageReference = cityPage });
                    }
                }
            }

            currentPage.Add(list);
            return View(currentPage);
        }

        public PropertyCriteriaCollection InitPropertyCriteriaCollection(string page)
        {
            PropertyCriteriaCollection criterias = new PropertyCriteriaCollection();
            PropertyCriteria criteria = new PropertyCriteria();
            criteria.Condition = CompareCondition.Equal;
            criteria.Name = "PageTypeID";
            criteria.Type = PropertyDataType.PageType;
            criteria.Value = PageType.Load(page).ID.ToString();
            criteria.Required = true;
            criterias.Add(criteria);
            return criterias;
        }
    }
}
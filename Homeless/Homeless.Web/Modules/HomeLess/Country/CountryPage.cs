
namespace Homeless.HomeLess.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HomeLess/Country"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CountryRow))]
    public class CountryController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HomeLess/Country/CountryIndex.cshtml");
        }
    }
}
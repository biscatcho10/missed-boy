
namespace Homeless.HomeLess.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HomeLess/City"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CityRow))]
    public class CityController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HomeLess/City/CityIndex.cshtml");
        }
    }
}
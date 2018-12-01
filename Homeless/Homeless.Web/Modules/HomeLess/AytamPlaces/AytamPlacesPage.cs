
namespace Homeless.HomeLess.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HomeLess/AytamPlaces"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.AytamPlacesRow))]
    public class AytamPlacesController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HomeLess/AytamPlaces/AytamPlacesIndex.cshtml");
        }
    }
}
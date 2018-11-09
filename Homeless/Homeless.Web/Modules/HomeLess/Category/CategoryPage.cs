
namespace Homeless.HomeLess.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HomeLess/Category"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.CategoryRow))]
    public class CategoryController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HomeLess/Category/CategoryIndex.cshtml");
        }
    }
}
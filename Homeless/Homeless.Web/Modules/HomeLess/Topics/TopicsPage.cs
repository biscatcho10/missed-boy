
namespace Homeless.HomeLess.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HomeLess/Topics"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.TopicsRow))]
    public class TopicsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HomeLess/Topics/TopicsIndex.cshtml");
        }
    }
}
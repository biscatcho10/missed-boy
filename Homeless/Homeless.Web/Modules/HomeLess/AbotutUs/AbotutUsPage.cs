
namespace Homeless.HomeLess.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HomeLess/AbotutUs"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.AbotutUsRow))]
    public class AbotutUsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HomeLess/AbotutUs/AbotutUsIndex.cshtml");
        }
    }
}
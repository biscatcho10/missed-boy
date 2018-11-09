
namespace Homeless.HomeLess.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("HomeLess/Contactus"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ContactusRow))]
    public class ContactusController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/HomeLess/Contactus/ContactusIndex.cshtml");
        }
    }
}
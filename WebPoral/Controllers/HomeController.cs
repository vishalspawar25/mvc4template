using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace WebPoral.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View();
        }
    }
}
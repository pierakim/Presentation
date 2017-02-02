using System;
using System.Web.Mvc;
using Presentation.Model;

namespace Presentation.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var model = new ContactViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel model)
        {
            try
            {
                var saveError = false;
                var test = false;
                if (ModelState.IsValid)
                {
                    try
                    {
                        test = true;
                    }
                    catch (Exception ex)
                    {
                        saveError = true;
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
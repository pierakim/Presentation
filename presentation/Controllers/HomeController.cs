using System;
using System.Web.Mvc;
using Presentation.Model;
using Presentation.Web.Tools;

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
                        var contactDetail = new ContactEmail
                        {
                            To = model.ContactEmail,
                            ContactName = model.ContactName,
                            ContactPhoneNumber = model.ContactPhoneNumber,
                            ContactDescription = model.ContactDescription
                        };

                        EmailManager.SendMail(contactDetail);

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
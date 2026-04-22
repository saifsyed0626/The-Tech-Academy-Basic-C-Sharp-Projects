using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using EntityFramework;
using NewsletterAppMVC.Models;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (var db = new NewsletterEntities())
            {
                var signupVms = db.SignUps
                    .AsEnumerable()
                    .Select(s => new SignupVm
    {
                    Id = s.Id,
                    FirstName = s.FirstName,
                     LastName = s.LastName,
                    EmailAddress = s.EmailAddress
    })
    .ToList();

                return View(signupVms);
            }
        }
    }
}
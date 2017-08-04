using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Contact.Models;

namespace Contact.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        // [Route("/contact/list")]
        // public ActionResult ContactList()
        // {Models
        //     List<string> allContacts = Contact.GetAll();
        //     return View(allContacts);
        // }
        //
        // [HttpPost("/clear/list/clear")]
        // public ActionResult ContactListClear()
        // {
        //     Contact.ClearAll();
        //     return View();
        // }

         [HttpPost("/contact/create")]
         public ActionResult CreateContact()
         {
            Contact newContact = new Contact (Request.Form["new-contact"]);
            newContact.Save();
            return View(newContact);
         }

    }
}

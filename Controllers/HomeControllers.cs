using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace Contact.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("/contact/list")]
        public ActionResult ContactList()
        {
            List<string> allTasks = Task.GetAll();
            return View(allTasks);
        }

        [HttpPost("/clear/list/clear")]
        public ActionResult TaskListClear()
        {
            Task.ClearAll();
            return View();
        }

        [HttpPost("/contact/create")]
        public ActionResult CreateTask()
        {
            Contact newContact = new Contact (Request.Form["new-contact"]);
            newContact.Save();
            return View(newContact);
        }

    }
}

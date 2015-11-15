using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using PostRefresh.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PostRefresh.Controllers
{
    public class HomeController : Controller
    {
        private TodoRepository Repository { get; }

        public HomeController(TodoRepository repository)
        {
            Repository = repository;
        }

        // GET: /
        [HttpGet]
        public IActionResult Index()
        {
            var model = Repository.GetItems();

            return View(model);
        }

        [HttpPost, Route("Save")]
        public IActionResult Save([FromForm]string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                Repository.AddItem(title);
            }

            var model = Repository.GetItems();

            return View("Index", model);
        }
    }
}

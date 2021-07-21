using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEvents.Models;

namespace CodingEvents.Controllers
{
    
    public class EventsController : Controller
    {
        //private static List<string> Events = new List<string>();

        private static List<Event> Events = new List<Event>();

        [HttpGet]
        public IActionResult Index()
        {
            

            ViewBag.events = Events;

            return View();
        }

        [HttpGet] 
        // /events/add
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/events/add")]
        public IActionResult NewEvent(string name, string description)
        {
            Events.Add(new Event(name, description));
            return Redirect("/events");
        }
    }
}

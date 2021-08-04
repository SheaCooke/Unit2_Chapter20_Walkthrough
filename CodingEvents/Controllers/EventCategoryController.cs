using CodingEvents.Data;
using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Controllers
{

    
    public class EventCategoryController : Controller
    {

        private EventDbContext _context;

        public EventCategoryController(EventDbContext dbContext)
        {
            _context = dbContext; 
        }


        public IActionResult Index()
        {
            List<EventCategory> eventCategories = _context.EventCategory.ToList();
            return View(eventCategories);
        }
    }
}

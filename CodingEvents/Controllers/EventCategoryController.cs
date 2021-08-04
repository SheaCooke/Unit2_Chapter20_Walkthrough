using CodingEvents.Data;
using CodingEvents.Models;
using CodingEvents.ViewModles;
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


        public IActionResult Create()
        {
            AddEventCategoryViewModel addEventCategoryViewModel = new AddEventCategoryViewModel();
            return View(addEventCategoryViewModel);
        }

        [HttpPost]
        //[Route("/create")]
        public IActionResult /*ProcessCreateEventCategoryForm*/Create(AddEventCategoryViewModel addEventCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                EventCategory newEventCategory = new EventCategory
                {
                    Name = addEventCategoryViewModel.Name
                };
                _context.EventCategory.Add(newEventCategory);
                _context.SaveChanges();
                return Redirect("Index");
            }

            return View();


        }
    }
}

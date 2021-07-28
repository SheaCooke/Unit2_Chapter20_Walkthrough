using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodingEvents.ViewModles
{


    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Description required")]
        [StringLength(500, ErrorMessage = "Description is too long")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }


        [Required(ErrorMessage = "Please enter a location for the event.")]
        public string Location { get; set; }

        [Range(0, 100000, ErrorMessage ="Amount must be between 0 and 100,000")]
        public int Attendees { get; set; }

        [Compare("RegistrationRequired", ErrorMessage ="Must be true")]
        public bool IsTrue { get { return true; } }

        [Required(ErrorMessage = "Enter true or false")]
        public bool RegistrationRequired { get; set; }

        public EventType Type { get; set; }

        public List<SelectListItem> EventTypes { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(EventType.Conference.ToString(), ((int)EventType.Conference).ToString()),
            new SelectListItem(EventType.Meetup.ToString(), ((int)EventType.Meetup).ToString()),
            new SelectListItem(EventType.Workshop.ToString(), ((int)EventType.Workshop).ToString()),
            new SelectListItem(EventType.Social.ToString(), ((int)EventType.Social).ToString()),

        };


    }
}

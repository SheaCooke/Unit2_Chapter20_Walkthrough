using CodingEvents.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.ViewModles
{
    public class AddEventTagViewModel
    {
        public int EventId { get; set; }
        public Event Event { get; set; }

        public List<SelectListItem> Tags { get; set; }

        public int TagId { get; set; }


        public AddEventTagViewModel(Event theEvent, List<Tag> possibleTags)
        {
            Tags = new List<SelectListItem>();

            foreach (var i in possibleTags)
            {
                Tags.Add(new SelectListItem
                {
                    Value = i.Id.ToString(),
                    Text = i.Name
                });


            }

            Event = theEvent;
        }


        public AddEventTagViewModel() { }




    }
}

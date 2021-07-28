using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Models
{
    
    public class Event
    {

        public string Name { get; set; }
        public string Description { get; set; }

        public string ContactEmail { get; set; }

        public string Location { get; set; }

        public int Attendees { get; set; }

        public bool IsTrue { get { return true; } }

        public bool RegistrationRequired { get; set; }


        public int Id { get; }

        private static int nextId = 1;

        public Event(string name, string description, string contactEmail) :this()
        {
            this.Name = name;
            this.Description = description;
            this.ContactEmail = contactEmail;
            
        }

        public Event()
        {
            this.Id = nextId;
            nextId++;
        }


        public override string ToString()
        {
            return base.ToString();
            {
                return Name;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event && Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}

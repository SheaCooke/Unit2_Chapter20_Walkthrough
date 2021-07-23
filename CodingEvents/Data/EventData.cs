using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEvents.Models;

namespace CodingEvents.Data
{
    public class EventData
    {

        /*public static Dictionary<int, Event> Events = new Dictionary<int, Event>();*/
        public static List<Event> Events = new List<Event>();

        public static void Add(Event newEvent)
        {
            /*Events[newEvent.Id] = newEvent;*/
            Events.Add(newEvent);
        }

        public static IEnumerable<Event> GetAll()
        {
            /*return Events.Values;*/
            return Events;
        }

        public static Event GetById(int Id)
        {
            /*return Events[Id];*/
            return Events.FirstOrDefault(x => x.Id == Id);
        }

        public static void Remove(int Id)
        {
            /*Events.Remove(Id);*/
            Events.RemoveAll(x => x.Id == Id);
        }
    }
}

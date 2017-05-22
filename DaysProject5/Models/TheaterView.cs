using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DaysProject6.Models
{
    public class TheaterView
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string City { get; set; }
        public string Level { get; set; }
        
        public TheaterView()
        {

        }
        public TheaterView(int id, string name, int capacity, string city, string level)
        {
            ID = id;
            Name = name;
            Capacity = capacity;
            City = city;
            Level = level;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelLayer.Models
{
    public class Theater
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int Capacity { get; set; }
        public virtual City City { get; set; }
        public virtual Level Level { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

        public Theater()
        {

        }
        public Theater(int id, string name, int capacity, City city, Level level)
        {
            ID = id;
            Name = name;
            Capacity = capacity;
            City = city;
            Level = level;
        }
    }
}

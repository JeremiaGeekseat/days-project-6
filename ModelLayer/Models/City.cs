using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelLayer.Models
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Theater> Theaters { get; set; }

        public City()
        {

        }

        public City(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}

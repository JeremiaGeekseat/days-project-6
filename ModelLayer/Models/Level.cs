using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelLayer.Models
{
    public class Level
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Theater> Theaters { get; set; }

        public Level()
        {

        }
        public Level(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}

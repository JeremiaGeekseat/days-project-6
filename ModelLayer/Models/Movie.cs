using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ModelLayer.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public double WeekendRevenure { get; set; }
        public double GrossRevenue { get; set; }
        [Column(TypeName = "date")]
        public DateTime Released { get; set; }
        public Boolean Recommended { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

        public Movie()
        {

        }
        public Movie(int id, string title, double weekendRevenue, double grossRevenue, DateTime released, Boolean recommended)
        {
            ID = id;
            Title = title;
            WeekendRevenure = weekendRevenue;
            GrossRevenue = grossRevenue;
            Released = released;
            Recommended = recommended;
        }
    }
}

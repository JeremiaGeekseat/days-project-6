using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelLayer.Models
{
    public class Ticket
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public int Payment { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Theater Theater { get; set; }

        public Ticket()
        {

        }
        public Ticket(int id, string name, string email, int payment, Movie movie, Theater theater)
        {
            ID = id;
            Name = name;
            Email = email;
            Payment = payment;
            Movie = movie;
            Theater = theater;
        }
    }
}

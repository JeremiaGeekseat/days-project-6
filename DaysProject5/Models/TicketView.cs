using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DaysProject6.Models
{
    public class TicketView
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Payment { get; set; }
        public string Movie { get; set; }
        public string Theater { get; set; }

        public TicketView()
        {

        }
        public TicketView(int id, string name, string email, int payment, string movie, string theater)
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
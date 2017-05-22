using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public User()
        {

        }

        public User(int id, string email, string password)
        {
            ID = id;
            Email = email;
            Password = password;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerse.Database.Models.People
{
    public class User
    {
        public int Id { get; set; }
        private static int IdCounter { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }

        public User(int id, string firstName, string lastName, string email, string password, DateTime created)
        {
            id = IdCounter++;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Created = DateTime.Now;

        }
    }
}

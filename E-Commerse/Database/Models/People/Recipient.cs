using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerse.Database.Models.People
{
    public class Recipient:User
    {
        public Recipient(int id, string firstName, string lastName, string email, string password, DateTime creaded)
            : base(id, firstName, lastName, email, password, creaded)
        {


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Single_Responsibility_Principle.After
{
    //To adhere to SRP, we can refactor the class as follows:

    internal class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public void Add()
        {
            //Add user to database
        }
        public void SendEmail()
        {
            //Send email to user
        }
    }
}

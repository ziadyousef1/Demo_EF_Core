using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.Single_Responsibility_Principle.Before
{
    //states that every class or module has one responsibility or one specific functionality. If your class has many responsibilities, maybe it is time to split it in smaller ones
    //To do this, always when you are coding ask yourself, what is the responsibility of the class that you're working on? If there is an and, then it is required to break it up. 
    //example adding a user to the database &&and&& sending an email
    //Example of a class that violates SRP:
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
    public class UserRepository
    {
        public void Add(User user)
        {
            //Add user to database
        }
    }
    public class EmailService
    {
        public void SendEmail(User user)
        {
            //Send email to user
        }
    }

}

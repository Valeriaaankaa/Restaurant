using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    /// <summary>
    /// Information about User that orders dishes
    /// </summary>

    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserLogin { get; set; }
        public string UserEmail { get; set; }
        public int UserPhone { get; set; }
        public string UserPassword { get; set; }
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public Role Role { get; set;  }

        public override string ToString()
        {
            return $"User ID: {UserId}\n" + $"Name: {UserName}\n" + $"Surname: {UserSurname}\n" 
                + $"UserLogin: {UserLogin}\n" + $"UserEmail: {UserEmail}\n" + $"UserPassword: {UserPassword}\n"
                + $"BirthDay: {BirthDay.ToString()}\n" + $"PhoneNumber: {PhoneNumber}\n" + $"Role: {Role.ToString()}\n";
        }
    }
}

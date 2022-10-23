using Restaurant.Interfaces;
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

    public class RestaurantUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateOnly BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public List<Order> UserOrders { get; set; }

        public RestaurantUser (string Name, string Surname, string Login, string Email, string PhoneNumber, DateOnly BirthDay)
        {
            this.Name =  Name;
            this.Surname = Surname;
            this.Login = Login;
            this.Email = Email;
            this.PhoneNumber = PhoneNumber;
            this.BirthDay = BirthDay;
        }

        public RestaurantUser ()
	    {

	    }

        public void DeleteObject(List<RestaurantUser> users, string userlogin)
        {              
            var user = users.FirstOrDefault(u=>u.Login == userlogin);
            users.Remove(user);
        }

        public bool UpdateObject(List<RestaurantUser> users, RestaurantUser updateuser)
        {
            var user = users.FirstOrDefault(u=>u.Login == updateuser.Login);
            if( user == null)
            { 
                return false;               
            }
            else
            {
                users.Remove(user);
                users.Add(updateuser);  
                return true;
            }

        }
    }
}

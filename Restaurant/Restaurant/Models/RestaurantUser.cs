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

    public class RestaurantUser:IEditObject<RestaurantUser>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateOnly BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public Role Role { get; set; }
        public List<Order> UserOrders { get; set; }

        public RestaurantUser CreateObject()
        {
            //USER REGISTRATION
            RestaurantUser user = new RestaurantUser(); 
            Console.Write("Enter User Name of the new User: ");
            user.Name = Console.ReadLine();
            Console.Write("Enter User Surname of the new User: ");
            user.Surname = Console.ReadLine();
            Console.Write("Enter User Login of the new User: ");
            user.Login = Console.ReadLine();
            Console.Write("Enter User Email of the new dish: ");
            user.Email = Console.ReadLine();
            Console.Write("Enter User Phone of the new dish: ");
            user.PhoneNumber = Console.ReadLine();
            Console.Write("Write your Birthday day:");
            int dayimp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write your Birthday month:");
            int monthimp = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write your Birthday year:");
            int yearimp = Convert.ToInt32(Console.ReadLine());
            user.BirthDay = new DateOnly(yearimp, monthimp, dayimp);
            string password, confirm;
            do
            {
                Console.Write("Write Password:");
                password = Console.ReadLine();
                Console.Write("Confirm Password:");
                confirm = Console.ReadLine();
            }
            while (password != confirm);
    
             return user;
        }

        public void DeleteObject(List<RestaurantUser> users)
        {
            Console.Write("Enter the Login of the User you want to delete:");
            string userlogin = Console.ReadLine();
            users.RemoveAll(x => x.Login == userlogin);
        }

        public void UpdateObject(List<RestaurantUser> users)
        {

            Console.Write("Enter the Login of the User you want to change: ");
            string userlogin = Console.ReadLine();
            Console.WriteLine("What do you want to change?\n 1.User Name\n2.User Surname\n3.User Birthday\n4. Change Password\nYour choice:");
            int choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.Write("Write new Name:");
                    string username = Console.ReadLine();
                    users.Where(i => i.Login == userlogin).ToList().ForEach(p => p.Name = username);
                    break;
                case 2:
                    Console.Write("Write new Surname:");
                    string usersurname = Console.ReadLine();
                    users.Where(i => i.Login == userlogin).ToList().ForEach(p => p.Surname = usersurname);
                    break;
                case 3:
                    Console.Write("Write day:");
                    int day = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write month:");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write year:");
                    int year = Convert.ToInt32(Console.ReadLine());
                    DateOnly NewBirthDay = new DateOnly(year, month, day);
                    users.Where(i => i.Login == userlogin).ToList().ForEach(p => p.BirthDay = NewBirthDay);
                    break;
                case 4:
                    string password, confirm;
                    do
                    {
                        Console.Write("Write Password:");
                        password = Console.ReadLine();
                        Console.Write("Confirm Password:");
                        confirm = Console.ReadLine();
                    }
                    while (password != confirm);
                    users.Where(i => i.Login == userlogin && i.Password != password).ToList().ForEach(p => p.Password = confirm);
                    break;
                default:
                    Console.WriteLine("Your choice is invalid");
                    break;
            }
        }
    }
}

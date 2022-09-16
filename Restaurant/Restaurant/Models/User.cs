using Restaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    /// <summary>
    /// Information about User that orders dishes
    /// </summary>

    public class User:IPrintable,IEditObject<User>
    {
        private DateTime birthDay;

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserLogin { get; set; }
        public string UserEmail { get; set; }
        public int UserPhone { get; set; }
        public string UserPassword { get; set; }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public string PhoneNumber { get; set; }
        public Role Role { get; set; }
        public List<Order> UserOrders { get; set; }

        public User CreateObject()
        {
            //USER REGISTRATION
            User user = new User(); 
            Console.Write("Enter User Name of the new User: ");
            user.UserName = Console.ReadLine();
            Console.Write("Enter User Surname of the new User: ");
            user.UserSurname = Console.ReadLine();
            Console.Write("Enter User Login of the new User: ");
            user.UserLogin = Console.ReadLine();
            Console.Write("Enter User Email of the new dish: ");
            user.UserEmail = Console.ReadLine();
            Console.Write("Enter User Phone of the new dish: ");
            user.PhoneNumber = Console.ReadLine();
            //Console.Write("Write your Birthday day:");
            //int dayimp = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Write your Birthday month:");
            //int monthimp = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Write your Birthday year:");
            //int yearimp = Convert.ToInt32(Console.ReadLine());
            //user.BirthDay = new DateTime(yearimp, monthimp, dayimp);
            Console.Write("Enter your birthday: ");
            DateTime.TryParse(Console.ReadLine(), out birthDay);
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

        public void DeleteObject(List<User> users)
        {
            Console.Write("Enter the Login of the User you want to delete:");
            string userlogin = Console.ReadLine();
            users.RemoveAll(x => x.UserLogin == userlogin);
        }

        public string Print()
        {
            return $"User ID: {UserId}\n" + $"Name: {UserName}\n" + $"Surname: {UserSurname}\n" 
                + $"UserLogin: {UserLogin}\n" + $"UserEmail: {UserEmail}\n" + $"UserPassword: {UserPassword}\n"
                + $"BirthDay: {BirthDay.ToString()}\n" + $"PhoneNumber: {PhoneNumber}\n" + $"Role: {Role.ToString()}\n";
        }

        public void UpdateObject(List<User> users)
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
                    users.FirstOrDefault(x => x.UserName == username && x.UserLogin == userlogin);
                    break;
                case 2:
                    Console.Write("Write new Surname:");
                    string usersurname = Console.ReadLine();
                    users.FirstOrDefault(x => x.UserName == usersurname && x.UserLogin == userlogin);
                    break;
                case 3:
                    Console.Write("Write day:");
                    int day = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write month:");
                    int month = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Write year:");
                    int year = Convert.ToInt32(Console.ReadLine());
                    DateTime NewBirthDay = new DateTime(year, month, day);
                    users.FirstOrDefault(x => x.BirthDay == NewBirthDay && x.UserLogin == userlogin);
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
                    users.FirstOrDefault(x => x.UserLogin == userlogin && x.UserPassword != password);
                    break;
                default:
                    Console.WriteLine("Your choice is invalid");
                    break;
            }
        }
    }
}

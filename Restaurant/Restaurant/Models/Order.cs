﻿using Restaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    
    public class Order:IPrintable
    {
        /// <summary>
        /// Information about User, that make order, place and date
        /// </summary>
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public RestaurantUser RestaurantUser { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<Dish> DishesOrder { get; set; }

        public string Print()
        {
            return $"OrderId: {Id}\n" + $"OrderDate: {OrderDate.ToString()}\n" + $"Address: {Address}\n"
               + "UserOrder Information:" + $"{RestaurantUser.ToString()}\n" + $"OrderStatus: {OrderStatus.ToString()}\n";
        }

       
    }
}

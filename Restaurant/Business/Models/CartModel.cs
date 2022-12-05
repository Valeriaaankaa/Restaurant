using System;
using System.Collections.Generic;
using System.Linq;
using Data.Entities;

namespace Business.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public virtual void AddItem(DishModel dishModel, int quantity)
        {
            CartLine? line = lineCollection.Where(d => d.Dish.Id == dishModel.Id).FirstOrDefault();
            if(line == null)
                lineCollection.Add(new CartLine
                {
                    Dish = dishModel,
                    Quantity = quantity
                });
            else
            {
                line.Quantity += quantity;
            }

        }
        public virtual void RemoveLine(DishModel dishModel) => lineCollection.RemoveAll(l => l.Dish.Id == dishModel.Id);
        public virtual decimal ComputeTotalValue() => lineCollection.Sum(e => e.Dish.Price * e.Quantity);
        public virtual void Clear() => lineCollection.Clear();
        public virtual IEnumerable<CartLine> Lines => lineCollection;

    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public DishModel Dish { get; set; }
        public int Quantity { get; set; }
    }

}

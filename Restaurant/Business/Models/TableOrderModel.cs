using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class TableOrderModel
    {
        private List<TableLine> lineCollection = new List<TableLine>();
        public virtual void AddItem(RestaurantTableModel tableModel, TimeOnly timeBegin, TimeOnly timeEnd)
        {
            TableLine? line = lineCollection.Where(d => d.TableOrder.Id == tableModel.Id).FirstOrDefault();
            if (line == null)
                lineCollection.Add(new TableLine
                {
                    TableOrder= tableModel,
                    TimeBegin=timeBegin,
                    TimeEnd=timeEnd
                });

        }
        public virtual void RemoveLine(RestaurantTable tableModel) => lineCollection.RemoveAll(l => l.TableOrder.Id == tableModel.Id);
     //   public virtual decimal ComputeTotalValue() => lineCollection.Sum(e => e.Dish.Price * e.Quantity);
        public virtual void Clear() => lineCollection.Clear();
        public virtual IEnumerable<TableLine> Lines => lineCollection;

    }

    public class TableLine
    {
        public int TableLineID { get; set; }
        public RestaurantTableModel TableOrder { get; set; }
        public TimeOnly TimeBegin { get; set; }
        public TimeOnly TimeEnd { get; set; }

    }
}


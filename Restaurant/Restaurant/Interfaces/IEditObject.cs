using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Interfaces
{
    internal interface IEditObject<T>
    {
        T CreateObject();
        void UpdateObject(List<T> obj);
        void DeleteObject(List<T> obj);
    }
}

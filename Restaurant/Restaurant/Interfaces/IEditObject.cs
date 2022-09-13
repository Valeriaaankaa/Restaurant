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
        List<T> UpdateObject(List<T> obj);
        List<T> DeleteObject(List<T> obj);
    }
}

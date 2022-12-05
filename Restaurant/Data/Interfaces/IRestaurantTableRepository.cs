﻿using Data.Entities;

namespace Data.Interfaces
{
    public interface IRestaurantTableRepository : IRepository<RestaurantTable>
    {
        IEnumerable<RestaurantTable> Tables { get; }
    }
}

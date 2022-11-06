using AutoMapper;
using Business.Models;
using Data.Entities;
using System.Linq;

namespace Business
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Admin, AdminModel>()
                .ForMember(r => r.Name, r => r.MapFrom(x => x.Person.Name))
                .ForMember(r => r.Surname, r => r.MapFrom(x => x.Person.Surname))
                .ForMember(r => r.BirthDay, r => r.MapFrom(x => x.Person.BirthDay))
                .ForMember(r => r.PhoneNumber, r => r.MapFrom(x => x.Person.PhoneNumber))
                .ForMember(r => r.Login, r => r.MapFrom(x => x.Login))
                .ForMember(r => r.Email, r => r.MapFrom(x => x.Email))
                .ForMember(r => r.Password, r => r.MapFrom(x => x.Password))
                .ReverseMap();

            CreateMap<Customer, CustomerModel>()
                .ForMember(r => r.Name, r => r.MapFrom(x => x.Person.Name))
                .ForMember(r => r.Surname, r => r.MapFrom(x => x.Person.Surname))
                .ForMember(r => r.BirthDay, r => r.MapFrom(x => x.Person.BirthDay))
                .ForMember(r => r.PhoneNumber, r => r.MapFrom(x => x.Person.PhoneNumber))
                .ForMember(r => r.Login, r => r.MapFrom(x => x.Login))
                .ForMember(r => r.Email, r => r.MapFrom(x => x.Email))
                .ForMember(r => r.Password, r => r.MapFrom(x => x.Password))
                .ForMember(r => r.OrderId, r => r.MapFrom(x => x.CustomerOrder.Id))
                .ReverseMap();

            CreateMap<Order, OrderModel>()
                .ForMember(r => r.OrderDate, r => r.MapFrom(x => x.OrderDate))
                .ForMember(r => r.OrderStatus, r => r.MapFrom(x => x.OrderStatus))
                .ForMember(r => r.Address, r => r.MapFrom(x => x.Address))
                .ForMember(r => r.TableOrderId, r => r.MapFrom(x => x.TableOrderId))
                .ForMember(rm => rm.DishOrders, r => r.MapFrom(x => x.DishesOrder.Select(rd => rd.Id)))
                .ReverseMap();
            
            
            CreateMap<DishOrder, DishOrderModel>()
                .ForMember(r => r.Amount, r => r.MapFrom(x => x.Amount))
                .ForMember(r => r.Description, r => r.MapFrom(x => x.Dish.Description))
                .ForMember(r => r.ImgPath, r => r.MapFrom(x => x.Dish.ImgPath))
                .ForMember(r => r.Name, r => r.MapFrom(x => x.Dish.Name))
                .ForMember(r => r.Price, r => r.MapFrom(x => x.Dish.Price))
                .ForMember(r => r.DishGroup, r => r.MapFrom(x => x.Dish.DishGroup))
                .ForMember(rm => rm.DishCompositions, r => r.MapFrom(x => x.Dish.DishCompositions.Select(rd => rd.Id)))
                .ReverseMap();


            CreateMap<TableOrder, TableOrderModel>()
                .ForMember(r => r.Name, r => r.MapFrom(x => x.RestaurantTable.Name))
                .ForMember(r => r.TimeBegin, r => r.MapFrom(x => x.TimeBegin))
                .ForMember(r => r.TimeEnd, r => r.MapFrom(x => x.TimeEnd))
                .ForMember(r => r.Zone, r => r.MapFrom(x => x.RestaurantTable.Zone))
                .ReverseMap();

            CreateMap<DishComposition, DishCompositionModel>()
                .ForMember(r => r.Name, r => r.MapFrom(x => x.Ingredient.Name))
                .ForMember(r => r.ImportDate, r => r.MapFrom(x => x.Ingredient.ImportDate))
                .ForMember(r => r.ExpirationDate, r => r.MapFrom(x => x.Ingredient.ExpirationDate))
                .ForMember(r => r.Amount, r => r.MapFrom(x => x.Amount))
                .ForMember(r => r.IngredientId, r => r.MapFrom(x => x.IngredientId))
                .ReverseMap();
        }
    }
}
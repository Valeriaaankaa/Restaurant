using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Models;

namespace Business
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Dish, DishModel>()
                .ForMember(r => r.Name, r => r.MapFrom(x => x.Name))
                .ForMember(r => r.ImgPath, r => r.MapFrom(x => x.ImgPath))
                .ForMember(r => r.Price, r => r.MapFrom(x => x.Price))
                .ForMember(r => r.Description, r => r.MapFrom(x => x.Description))
                .ForMember(r => r.DishGroup, r => r.MapFrom(x => x.DishGroup))
                .ForMember(r => r.DishCompositionIds, r => r.MapFrom(x => x.DishCompositions.Select(t => t.Id)))
                 .ReverseMap();

            /* CreateMap<DishModel, Dish>()
                 .ForMember(r => r.Name, r => r.MapFrom(x => x.Name))
                 .ForMember(r => r.ImgPath, r => r.MapFrom(x => x.ImgPath))
                 .ForMember(r => r.Price, r => r.MapFrom(x => x.Price))
                 .ForMember(r => r.Description, r => r.MapFrom(x => x.Description))
                 .ForMember(r => r.DishGroup, r => r.MapFrom(x => x.DishGroup))

                 .ForMember(r => r.DishCompositions, r => r.MapFrom(l => l.DishCompositionIds.Select(id => new DishComposition {Id = id })));*/



            CreateMap<DishComposition, DishCompositionModel>()
                .ForMember(r => r.Amount, r => r.MapFrom(x => x.Amount))
                .ForMember(r => r.Ingredient, r => r.MapFrom(x => x.Ingredient))
                .ReverseMap();

        }
    }        
}

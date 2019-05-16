using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DoAn1.Data.Dto;
using DoAn1.Data.Models;

namespace DoAn1.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OrderDto, Order>();
            CreateMap<ProductDto, Product>();
        }
    }
}

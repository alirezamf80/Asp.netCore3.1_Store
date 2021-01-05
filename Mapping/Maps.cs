using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netCore3._1_Store.Data;
using Asp.netCore3._1_Store.Models;
using AutoMapper;

namespace Asp.netCore3._1_Store.Mapping
{
    public class Maps:Profile
    {
        public Maps()
        {
            CreateMap<Kala, DetailsKalaViewModel>().ReverseMap();
            CreateMap<Kala, CreateKalaViewModel>().ReverseMap();
            CreateMap<Customer, CustomerViewModel>().ReverseMap();
            CreateMap<OrderApp, OrderAppViewModel>().ReverseMap();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WaiMai.Model;
using WaiMai.UI.Models;

namespace WaiMai.UI.App_Start
{
    public class MapperConfig
    {
        public static  void Register()
        {
            var mapper=  AutoMapper.Mapper.CreateMap<FoodInfo, FoodDto>();
            mapper.ForMember(o => o.ShopName, t => t.MapFrom(s => s.Shop.Name));

            AutoMapper.Mapper.CreateMap<AreaInfo, AreaDto>();
            AutoMapper.Mapper.CreateMap<Shop, ShopDto>();
            AutoMapper.Mapper.CreateMap<CourierInfo, CourierDto>();

            var map = AutoMapper.Mapper.CreateMap<OrderInfo, OrderDto>();
            map.ForMember(o => o.OrderId, t => t.MapFrom(s => s.ID));
            map.ForMember(o => o.IsDiscount, t => t.MapFrom(s =>s.Total-s.RealTotal>0));
        }
    }
}
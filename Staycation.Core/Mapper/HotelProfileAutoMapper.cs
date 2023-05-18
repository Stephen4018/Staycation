using AutoMapper;
using HotelDto.HotelManagementDto;
using Staycation.Domian.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Staycation.Core.Mapper
{
    public class HotelProfileAutoMapper : Profile
    {
        public HotelProfileAutoMapper()
        {

            CreateMap<HotelMotel, HotelLandPageDto>().ReverseMap();
            CreateMap<HotelMotel, HotelDetailsDto>().ReverseMap();

        }
     
      
    }
}

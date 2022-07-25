using AutoMapper;
using Core.Models;
using DataAccessLayer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            
            CreateMap<EmployeeGetDto, TblEmployee>();
            CreateMap<TblEmployee, EmployeeGetDto>()
                .ForMember(dest => dest.Status, 
                opt => opt.MapFrom(
                    src => src.Status == 0 ?
                    "Deaktiv" :
                    "Aktiv"));

            CreateMap<AddEmployeeDto, TblEmployee>().ForMember(dest => dest.Status, opt => opt.MapFrom(src => 0));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagerSys.Dtos;
using VehicleManagerSys.Entity.IVS;
using AutoMapper;

namespace VehicleManagerSys.Main.Profiles
{
    public class VehicleProfile : Profile
    {
        public VehicleProfile()
        {
            IMappingExpression<VehicleInfo, LOGIN_VEHICLE_INFO> expression =
                CreateMap<VehicleInfo, LOGIN_VEHICLE_INFO>();
            expression.ForMember(dest => dest.HPHM, opt => opt.MapFrom(src => src.PlateNo));
        }
    }
}

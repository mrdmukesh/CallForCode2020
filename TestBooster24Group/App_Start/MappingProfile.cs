using AutoMapper;
using TestBooster24GroupApp.Core.Dto;
using TestBooster24GroupApp.Core.Models;
using TestBooster24GroupApp.Core.Repositories;

namespace TestBooster24GroupApp.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<TestBoosetr24Group, TestBoosetr24GroupDto>();
            Mapper.CreateMap<Patient, PatientDto>();
            Mapper.CreateMap<City, CityDto>();
            Mapper.CreateMap<Doctor, DoctorDto>();
            Mapper.CreateMap<Specialization, SpecializationDto>();
            //Mapper.CreateMap<DoctorFormViewModel, Doctor>();
        }
    }
}
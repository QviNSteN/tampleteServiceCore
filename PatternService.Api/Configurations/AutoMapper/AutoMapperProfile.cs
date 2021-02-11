using System;
using System.Linq;
using AutoMapper;
using AutoMapper.EquivalencyExpression;
using FormGenerator.Data;
using FormGenerator.Data.Entity;

namespace FormGenerator.Api.Configurations.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
           // CreateMap<ClassDTO, ClassEntity>();
        }
    }
}

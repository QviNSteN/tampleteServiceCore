using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using FormGenerator.General.Expansions;
using FormGenerator.Data.Entity;
using FormGenerator.BI.Options;
using AutoMapper;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace FormGenerator.Api.Configurations.AutoMapper
{
    public class FormatterObjectToString : IValueResolver<object, object, string>
    {
        private readonly IMapper _mapper;

        public FormatterObjectToString(IMapper mapper)
        {
            _mapper = mapper;
        }

        public string Resolve(object source, object destination, string result, ResolutionContext context)
        {
            return result;
        }
    }

}
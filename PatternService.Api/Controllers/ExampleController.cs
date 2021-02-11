using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.Collection;
using AutoMapper;
using AutoMapper.EntityFrameworkCore;

namespace FormGenerator.Api.Controllers
{
    [ApiController]
    [Route("form/[Controller]")]
    public class ExampleController : ControllerBase
    {
        private readonly ILogger<ExampleController> _logger;
        private readonly IMapper _mapper;

        public ExampleController(ILogger<ExampleController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok();
        }
    }
}

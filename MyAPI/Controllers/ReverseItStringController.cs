using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyAPI.Services;

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReverseItStringController(ReverseItStringService reverseItStringService) : ControllerBase
    {
        private readonly ReverseItStringService _reverseItStringService = reverseItStringService;

        [HttpGet("{arg}")]
        public string ReverseIt(string arg)
        {
            return _reverseItStringService.ReverseIt(arg);
        }
    }
}

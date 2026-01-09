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
    public class OddOrEvenController(OddOrEvenService oddOrEvenService) : ControllerBase
    {
        private readonly OddOrEvenService _oddOrEvenService = oddOrEvenService;

        [HttpGet("{num}")]
        public string OddOrEven(double num)
        {
            return _oddOrEvenService.OddOrEven(num);
        }
    }
}

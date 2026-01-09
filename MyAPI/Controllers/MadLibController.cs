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
    public class MadLibController(MadLibService madLibService) : ControllerBase
    {
        private readonly MadLibService _madLibService = madLibService;

        [HttpGet("{creature_adjective}/{creature}/{place}/{things}/{adverb_1}/{adverb_2}/{base_verb}/{adverb_3}/{adverb_4}/{past_verb}")]
        public string MadLib(string creature_adjective, string creature, string place, string things, string adverb_1, string adverb_2, string base_verb, string adverb_3, string adverb_4, string past_verb)
        {
            return _madLibService.MadLib(creature_adjective, creature, place, things, adverb_1, adverb_2, base_verb, adverb_3, adverb_4, past_verb);
        }
    }
}

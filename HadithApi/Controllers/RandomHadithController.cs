using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace HadithApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomHadithController : ControllerBase
    {
        private readonly Random random = new ();
        // GET: api/<RandomHadithController>
        [HttpGet]
        public ActionResult<IEnumerable<Hadith>> Get()
        {
            var hadithJson = System.IO.File.ReadAllText("https://raw.githubusercontent.com/Pienteger/HadithApi/master/hadith.json");
            var allHadith = JsonConvert.DeserializeObject<IEnumerable<Hadith>>(hadithJson);
            return Ok(allHadith);
        }

        // GET api/<RandomHadithController>/single
        [HttpGet("single")]
        public ActionResult<Hadith> GetSingle()
        {
            List<Hadith> hadiths = new();
            var hadithJson = System.IO.File.ReadAllText("./hadith.json");
            hadiths = JsonConvert.DeserializeObject<List<Hadith>>(hadithJson);
            if (hadiths.Count < 1)
                return new Hadith { };
            return Ok(hadiths[random.Next(0, hadiths.Count)]);
        }
    }
}

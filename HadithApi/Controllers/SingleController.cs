using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;

namespace HadithApi.Controllers
{
    [EnableCors("Policy")]
    [Route("bn/[controller]")]
    [ApiController]
    public class SingleController : ControllerBase
    {
        private const string dataPath = "./hadith.json";
        private readonly Random random = new();

        [HttpGet]
        public async Task<ActionResult<Hadith>> GetSingle()
        {
            var response = await System.IO.File.ReadAllTextAsync(dataPath);
            var hadiths = JsonConvert.DeserializeObject<List<Hadith>>(response);

            if (hadiths?.Count < 1)
                return new Hadith { };
            return Ok(hadiths?[random.Next(0, hadiths.Count)]);
        }

    }
}

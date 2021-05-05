using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HadithApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomHadithController : ControllerBase
    {
        private const string dataPath = "https://raw.githubusercontent.com/Pienteger/HadithApi/master/hadith.json";
        private readonly Random random = new();
        // GET: api/<RandomHadithController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hadith>>> Get()
        {
            var http = new HttpClient();
            var response = await http.GetAsync(dataPath);
            var result = await response.Content.ReadAsStringAsync();
            var allHadith = JsonConvert.DeserializeObject<IEnumerable<Hadith>>(result);
            return Ok(allHadith);
        }

        // GET api/<RandomHadithController>/single
        [HttpGet("single")]
        public async Task<ActionResult<Hadith>> GetSingle()
        {
            List<Hadith> hadiths = new();
            var http = new HttpClient();
            var response = await http.GetAsync(dataPath);
            var result = await response.Content.ReadAsStringAsync();

            hadiths = JsonConvert.DeserializeObject<List<Hadith>>(result);
            if (hadiths.Count < 1)
                return new Hadith { };
            return Ok(hadiths[random.Next(0, hadiths.Count)]);
        }
    }
}

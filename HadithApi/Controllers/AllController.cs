using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Newtonsoft.Json;

namespace HadithApi.Controllers
{
    [EnableCors("Policy")]
    [Route("bn/[controller]")]
    [ApiController]
    public class AllController : ControllerBase
    {
        private const string dataPath = "./hadith.json";
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hadith>>> Get()
        {
            var response = await System.IO.File.ReadAllTextAsync(dataPath);
            var allHadith = JsonConvert.DeserializeObject<IEnumerable<Hadith>>(response);
            return Ok(allHadith);
        }
    }
}

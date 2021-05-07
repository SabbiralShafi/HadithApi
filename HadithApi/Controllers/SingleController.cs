using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using HadithApi.Data;
using Microsoft.AspNetCore.Cors;

namespace HadithApi.Controllers
{
    [EnableCors("Policy")]
    [Route("bn/[controller]")]
    [ApiController]
    public class SingleController : ControllerBase
    {
        private readonly Random random = new();
        private readonly HadithApiContext context;

        public SingleController(HadithApiContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public  ActionResult<Hadith> GetSingle()
        {
            var hadiths = context.Hadith.ToList();

            if (hadiths.Count < 1)
                return new Hadith();
            return Ok(hadiths[random.Next(0, hadiths.Count)]);
        }

    }
}

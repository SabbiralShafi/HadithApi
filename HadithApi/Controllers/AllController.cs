using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using HadithApi.Data;
using Microsoft.AspNetCore.Cors;

namespace HadithApi.Controllers
{
    [EnableCors("Policy")]
    [Route("bn/[controller]")]
    [ApiController]
    public class AllController : ControllerBase
    {
        private readonly HadithApiContext context;

        public AllController(HadithApiContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Hadith>> Get()
        {
            return Ok(context.Hadith.ToList());
        }
    }
}

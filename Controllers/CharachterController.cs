
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharachterController : ControllerBase
    {
        private static List<Charachter> charachters = new List<Charachter>{
            new Charachter(),
            new Charachter{Id = 1, Name = "Sam"}
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Charachter>> Get()
        {
            return Ok(charachters);
        }

         [HttpGet("{id}")]
        public ActionResult<List<Charachter>> GetSingle(int id)
        {
            return Ok(charachters.FirstOrDefault(c => c.Id == id));
        }
    }
}
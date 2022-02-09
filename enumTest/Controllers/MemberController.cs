using enumTest.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using enumTest.Data;
using enumTest.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace enumTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MemberController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<MemberController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MemberController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MemberController>
        [HttpPost]
        public IActionResult Post([FromBody] MemberDto dto)
        {

            EGender parsedGender;
            if (!Enum.TryParse<EGender>(dto.Gender, true, out parsedGender))
            {
                return Ok("not a valid gender");
            }
            //error, not a valid language

          
            var memberinfo = new TblmemberInfo()
            {
                Name = dto.Name,
                Mobile = dto.Mobile,
                Gender = dto.Gender
            };
            _context.TblmemberInfos.Add(memberinfo);
            _context.SaveChanges();
            return Ok(memberinfo);
        }

        // PUT api/<MemberController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MemberController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using McafeeRosterManagement.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace McafeeRosterManagement.API.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {
        private readonly RosterDBContext _context;
        public ValuesController (RosterDBContext context)
        {
            _context = context;
        }
        // GET api/values
        [HttpGet("values")]
        public IActionResult GetValues() {
            var values = _context.Aschedule.Where(x => x.Wwid == 20008607);
            return Ok(values);
        }

        // GET api/values/5
        [HttpGet ("{id}")]
        public IActionResult GetValues(int id) { 
            var value = _context.Users.FirstOrDefault(x => x.Wwid == id);
            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post ([FromBody] string value) { }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public void Delete (int id) { }
    }
}
﻿using Event.API.Data;
using Event.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Event.API.Controllers
{
    [ApiController]
    [Route("api/programmings")]
    public class ProgramminsController: ControllerBase
    {
        private readonly DataContext _context;


        public ProgramminsController(DataContext context)
        {



            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.programmings.ToListAsync());


        }
        [HttpPost]
        public async Task<ActionResult> Post(Programming programming)
        {

            _context.Add(programming);
            await _context.SaveChangesAsync();
            return Ok(programming);




        }

    }
}

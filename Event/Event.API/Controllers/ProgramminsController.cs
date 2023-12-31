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

        //get por lista
        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.programmings.ToListAsync());


        }

        // get por parametro

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {

            var programming = await 
                _context.programmings.FirstOrDefaultAsync(x => x.Id == id);
            if(programming == null)
            {

                return NotFound();

            }
            return Ok(programming);

        }
        [HttpPost]
        public async Task<ActionResult> Post(Programming programming)
        {

            _context.Add(programming);
            await _context.SaveChangesAsync();
            return Ok(programming);
            




        }

        [HttpPut]
        public async Task<ActionResult> Put(Programming programming)
        {

            _context.Update(programming);
            await _context.SaveChangesAsync();
            return Ok(programming);





        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var afectado = await _context.programmings.Where(x => x.Id == id).ExecuteDeleteAsync();

            if (afectado == 0)
            {

                return NotFound();
            }

            return NoContent();

        }
    }
}

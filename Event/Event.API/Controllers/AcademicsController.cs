﻿using Event.API.Data;
using Event.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Event.API.Controllers
{

    [ApiController]
    [Route("api/academics")]
    public class AcademicsController:ControllerBase
    {
        private readonly DataContext _context;


        public AcademicsController(DataContext context) {
        
        
        
        _context = context;
        }

        [HttpGet]
        public async Task < ActionResult> Get() {

            return Ok(await _context.Academics.ToListAsync());
        
        
        }

        [HttpPost]
        public async Task<ActionResult> Post(Academic academic)
        {

            _context.Add(academic);
            await _context.SaveChangesAsync();
            return Ok(academic);




        }

    }
}

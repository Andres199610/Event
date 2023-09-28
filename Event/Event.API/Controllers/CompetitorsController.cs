using Event.API.Data;
using Event.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Event.API.Controllers
{
    [ApiController]
    [Route("api/competitors")]
    public class CompetitorsController: ControllerBase
    {
        private readonly DataContext _context;


        public CompetitorsController(DataContext context)
        {



            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Competitors.ToListAsync());


        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {

            var competitor = await
                _context.Competitors.FirstOrDefaultAsync(x => x.Id == id);
            if (competitor == null)
            {

                return NotFound();

            }
            return Ok(competitor);

        }

        [HttpPost]
        public async Task<ActionResult> Post(Competitor competitor)
        {

            _context.Add(competitor);
            await _context.SaveChangesAsync();
            return Ok(competitor);




        }
        [HttpPut]
        public async Task<ActionResult> Put(Competitor competitor)
        {

            _context.Update(competitor);
            await _context.SaveChangesAsync();
            return Ok(competitor);




        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {

            var afectado = await _context.Competitors.Where(x => x.Id == id).ExecuteDeleteAsync();

            if (afectado == 0)
            {

                return NotFound();
            }

            return NoContent();

        }
    }
}

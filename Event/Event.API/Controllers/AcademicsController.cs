using Event.API.Data;
using Microsoft.AspNetCore.Mvc;

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


    }
}

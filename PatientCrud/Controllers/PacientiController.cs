using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PatientCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientiController : ControllerBase
    {
        private readonly DataContext _context;

        public PacientiController(DataContext context)
        {
            this._context = context;
        }



        [HttpGet]
        public async Task<ActionResult<List<Pacienti>>> Get()
        {

                
            return Ok(await _context.pacientet.ToListAsync());
        }
        [HttpGet("(id)")]
        public async Task<ActionResult<Pacienti>> Get(int id)
        {
            var Pacienti = await _context.pacientet.FindAsync(id);
            if (Pacienti == null)
                return BadRequest("Pacienti nuk u gjet!");
            return Ok(Pacienti);
        }
        [HttpPost]
        public async Task<ActionResult<List<Pacienti>>> AddPacient(Pacienti pacient)
        {
            _context.pacientet.Add(pacient);
            await _context.SaveChangesAsync();
            return Ok(await _context.pacientet.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Pacienti>>> UpdatePacient(Pacienti request)
        {
            var pacientidb = await _context.pacientet.FindAsync(request.Id);
            if (pacientidb == null)
                return BadRequest("Pacienti nuk u gjet!");
            pacientidb.Name = request.Name;
            pacientidb.Surname= request.Surname;
            pacientidb.Email = request.Email;
            pacientidb.Birthday = request.Birthday;
            pacientidb.City = request.City;

            await _context.SaveChangesAsync();

            return Ok(await _context.pacientet.ToListAsync());
        }
        [HttpDelete("(id)")]
        public async Task<ActionResult<List<Pacienti>>> Delete(int id)
        {
            var pacientidb = await _context.pacientet.FindAsync(id);
            if (pacientidb == null)
                return BadRequest("Pacienti nuk u gjet!");



           _context.pacientet.Remove(pacientidb);
            await _context.SaveChangesAsync();
            return Ok(await _context.pacientet.ToListAsync());
        }
    }
}
 
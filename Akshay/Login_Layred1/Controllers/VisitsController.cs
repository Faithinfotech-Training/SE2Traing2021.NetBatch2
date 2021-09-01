using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login_Layred1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitsController : ControllerBase
    {
        private readonly AppDBContext _context;
        private readonly VisitService pagevisits;

        public VisitsController(AppDBContext context, VisitService visit)
        {
            _context = context;
            pagevisits = visit;
        }

        // GET: api/PageVisits
        [HttpGet]
        public IActionResult GetVisits()
        {
            return Ok(_context.Visits.ToList());
        }

        // GET: api/PageVisits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Visit>> GetVisits(int id)
        {
            var visits = await _context.Visits.FindAsync(id);

            if (visits == null)
            {
                return NotFound();
            }

            return visits;
        }

        // PUT: api/PageVisits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVisits(int id, Visit visits)
        {
            if (id != visits.Id)
            {
                return BadRequest();
            }

            _context.Entry(visits).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!pagevisits.VisitsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost("page/{page}")]

        public IActionResult PageVisits(String page)
        {
            pagevisits.increaseViews(page);
            return Ok();
        }

        // POST: api/PageVisits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Visit>> PostVisits(Visit visits)
        {
            _context.Visits.Add(visits);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVisits", new { id = visits.Id }, visits);
        }

        // DELETE: api/PageVisits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVisits(int id)
        {
            var visits = await _context.Visits.FindAsync(id);
            if (visits == null)
            {
                return NotFound();
            }

            _context.Visits.Remove(visits);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

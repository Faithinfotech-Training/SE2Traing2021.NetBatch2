using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProffesorManagementSystem.Models;

namespace ProffesorManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TblProfessorsController : ControllerBase
    {
        private readonly PractiseContext _context;

        public TblProfessorsController(PractiseContext context)
        {
            _context = context;
        }

        // GET: api/TblProfessors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblProfessor>>> GetTblProfessors()
        {
            return await _context.TblProfessors.ToListAsync();
        }

        // GET: api/TblProfessors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblProfessor>> GetTblProfessor(int id)
        {
            var tblProfessor = await _context.TblProfessors.FindAsync(id);

            if (tblProfessor == null)
            {
                return NotFound();
            }

            return tblProfessor;
        }

        // PUT: api/TblProfessors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblProfessor(int id, TblProfessor tblProfessor)
        {
            if (id != tblProfessor.ProfessorId)
            {
                return BadRequest();
            }

            _context.Entry(tblProfessor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblProfessorExists(id))
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

        //new

        //PATCH
      
        [HttpPatch]
        public void ChangePassword(int proffesorId,decimal salary)
        {
            var user = new TblProfessor() { ProfessorId = proffesorId, Salary=salary};
            using (var db = new PractiseContext())
            {
                db.TblProfessors.Attach(user);
                db.Entry(user).Property(x => x.Salary).IsModified = true;
                db.SaveChanges();
            }
        }

        // POST: api/TblProfessors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblProfessor>> PostTblProfessor(TblProfessor tblProfessor)
        {
            _context.TblProfessors.Add(tblProfessor);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblProfessorExists(tblProfessor.ProfessorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblProfessor", new { id = tblProfessor.ProfessorId }, tblProfessor);
        }

        // DELETE: api/TblProfessors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblProfessor(int id)
        {
            var tblProfessor = await _context.TblProfessors.FindAsync(id);
            if (tblProfessor == null)
            {
                return NotFound();
            }

            _context.TblProfessors.Remove(tblProfessor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblProfessorExists(int id)
        {
            return _context.TblProfessors.Any(e => e.ProfessorId == id);
        }
    }
}

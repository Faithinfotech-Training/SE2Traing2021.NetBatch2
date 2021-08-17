using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRM.Models;

namespace CRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseEnquiriesController : ControllerBase
    {
        private readonly CRMContext _context;

        public CourseEnquiriesController(CRMContext context)
        {
            _context = context;
        }

        // GET: api/CourseEnquiries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CourseEnquiry>>> GetCourseEnquiries()
        {
            return await _context.CourseEnquiries.ToListAsync();
        }

        // GET: api/CourseEnquiries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CourseEnquiry>> GetCourseEnquiry(int id)
        {
            var courseEnquiry = await _context.CourseEnquiries.FindAsync(id);

            if (courseEnquiry == null)
            {
                return NotFound();
            }

            return courseEnquiry;
        }

        // PUT: api/CourseEnquiries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourseEnquiry(int id, CourseEnquiry courseEnquiry)
        {
            if (id != courseEnquiry.CourseEnquiryId)
            {
                return BadRequest();
            }

            _context.Entry(courseEnquiry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseEnquiryExists(id))
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

        // POST: api/CourseEnquiries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CourseEnquiry>> PostCourseEnquiry(CourseEnquiry courseEnquiry)
        {
            _context.CourseEnquiries.Add(courseEnquiry);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CourseEnquiryExists(courseEnquiry.CourseEnquiryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCourseEnquiry", new { id = courseEnquiry.CourseEnquiryId }, courseEnquiry);
        }

        // DELETE: api/CourseEnquiries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourseEnquiry(int id)
        {
            var courseEnquiry = await _context.CourseEnquiries.FindAsync(id);
            if (courseEnquiry == null)
            {
                return NotFound();
            }

            _context.CourseEnquiries.Remove(courseEnquiry);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CourseEnquiryExists(int id)
        {
            return _context.CourseEnquiries.Any(e => e.CourseEnquiryId == id);
        }
    }
}

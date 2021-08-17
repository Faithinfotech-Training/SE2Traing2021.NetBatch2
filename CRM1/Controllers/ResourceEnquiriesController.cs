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
    public class ResourceEnquiriesController : ControllerBase
    {
        private readonly CRMContext _context;

        public ResourceEnquiriesController(CRMContext context)
        {
            _context = context;
        }

        // GET: api/ResourceEnquiries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResourceEnquiry>>> GetResourceEnquiries()
        {
            return await _context.ResourceEnquiries.ToListAsync();
        }

        // GET: api/ResourceEnquiries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ResourceEnquiry>> GetResourceEnquiry(int id)
        {
            var resourceEnquiry = await _context.ResourceEnquiries.FindAsync(id);

            if (resourceEnquiry == null)
            {
                return NotFound();
            }

            return resourceEnquiry;
        }

        // PUT: api/ResourceEnquiries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResourceEnquiry(int id, ResourceEnquiry resourceEnquiry)
        {
            if (id != resourceEnquiry.ResourceEnquiryId)
            {
                return BadRequest();
            }

            _context.Entry(resourceEnquiry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResourceEnquiryExists(id))
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

        // POST: api/ResourceEnquiries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ResourceEnquiry>> PostResourceEnquiry(ResourceEnquiry resourceEnquiry)
        {
            _context.ResourceEnquiries.Add(resourceEnquiry);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ResourceEnquiryExists(resourceEnquiry.ResourceEnquiryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetResourceEnquiry", new { id = resourceEnquiry.ResourceEnquiryId }, resourceEnquiry);
        }

        // DELETE: api/ResourceEnquiries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResourceEnquiry(int id)
        {
            var resourceEnquiry = await _context.ResourceEnquiries.FindAsync(id);
            if (resourceEnquiry == null)
            {
                return NotFound();
            }

            _context.ResourceEnquiries.Remove(resourceEnquiry);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ResourceEnquiryExists(int id)
        {
            return _context.ResourceEnquiries.Any(e => e.ResourceEnquiryId == id);
        }
    }
}

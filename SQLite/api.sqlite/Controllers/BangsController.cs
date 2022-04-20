
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Northwind.Data;
using Northwind.Models;

namespace api.sqlite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BangsController : ControllerBase
    {
        private readonly NorthwindContext _context;

        public BangsController(NorthwindContext context)
        {
            _context = context;
        }

        // GET: api/Bangs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bang>>> GetBangs()
        {
            return await _context.Bangs.ToListAsync();
        }

        // GET: api/Bangs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bang>> GetBang(long id)
        {
            var bang = await _context.Bangs.FindAsync(id);

            if (bang == null)
            {
                return NotFound();
            }

            return bang;
        }
        // GET ALL BANG
        [HttpGet("GetNDBang")]
        public async Task<IEnumerable<NdBang>> GetNDBang()
        {
            return await _context.NdBangs.ToListAsync();
        }
        //GET BANG THEO ID
        [HttpGet("GetBangNDBangForID")]
        public async Task<IEnumerable<Bang>> GetBangNDBangForID(int BangID)
        {
            return await _context.Bangs
            .Include(e => e.NdBangs)
            .Where(p => p.Id == BangID)
            .ToListAsync();
        }
        //GET BANG THEO ID AND VI TRI
        [HttpGet("GetBangNDBangForVT")]
        public async Task<IEnumerable<Bang>> GetBangNDBangForVT(int BangID, string VTCot, string VTDong)
        {
            return await _context.Bangs
            .Include(e => e.NdBangs)
            .Where(p => p.Id == BangID && p.NdBangs
            .Any(c => c.VtDong.Equals(VTDong) && c.VtCot.Equals(VTCot)))
            .ToListAsync();
        }
        // PUT: api/Bangs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBang(long id, Bang bang)
        {
            if (id != bang.Id)
            {
                return BadRequest();
            }

            _context.Entry(bang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BangExists(id))
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

        // POST: api/Bangs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bang>> PostBang(Bang bang)
        {
            _context.Bangs.Add(bang);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BangExists(bang.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetBang", new { id = bang.Id }, bang);
        }

        // DELETE: api/Bangs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBang(long id)
        {
            var bang = await _context.Bangs.FindAsync(id);
            if (bang == null)
            {
                return NotFound();
            }

            _context.Bangs.Remove(bang);
            await _context.SaveChangesAsync();

            return NoContent();
        }
       
        private bool BangExists(long id)
        {
            return _context.Bangs.Any(e => e.Id == id);
        }
    }
}

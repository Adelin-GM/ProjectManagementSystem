using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Server.Data;
using ProjectManagement.Shared;

namespace ProjectManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LinesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Lines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Line>>> GetLine()
        {
            return await _context.Line.ToListAsync();
        }

        // GET: api/Lines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Line>>> GetLine(Guid id)
        {
            var lines = await _context.Line.ToListAsync();
            List<Line> lineList = new List<Line>();
            if (lines == null)
            {
                return NotFound();
            }
            foreach (var line in lines)
            {
                if (line.ReportId == id)
                {
                    lineList.Add(line);
                }
            }

            return lineList;
        }


        // PUT: api/Lines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLine(Guid id, Line line)
        {
            if (id != line.Id)
            {
                return BadRequest();
            }

            _context.Entry(line).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LineExists(id))
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

        // POST: api/Lines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Line>> PostLine(Line line)
        {
            _context.Line.Add(line);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLine", new { id = line.Id }, line);
        }

        // DELETE: api/Lines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLine(Guid id)
        {
            var line = await _context.Line.FindAsync(id);
            if (line == null)
            {
                return NotFound();
            }

            _context.Line.Remove(line);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool LineExists(Guid id)
        {
            return _context.Line.Any(e => e.Id == id);
        }
    }
}

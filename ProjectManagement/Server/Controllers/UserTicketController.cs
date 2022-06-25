using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Server.Data;
using ProjectManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTicketController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserTicketController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/UserTickets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserTicket>>> GetUserTicket()
        {
            return _context.UserTicket.ToList();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<UserTicket>>> GetUserProject(Guid id)
        {
            List<UserTicket> UserTicketList = new List<UserTicket>();
            var list = await _context.UserTicket.ToListAsync();
            foreach (var item in list)
            {
                if (item.TicketId == id)
                {
                    UserTicketList.Add(item);
                }
            }
            return UserTicketList;
        }

        // PUT: api/UserTickets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserTicket(Guid id, UserTicket userTicket)
        {
            if (id != userTicket.Id)
            {
                return BadRequest();
            }

            _context.Entry(userTicket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserTicketExists(id))
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

        // POST: api/UserTickets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserTicket>> PostUserTicket(UserTicket userTicket)
        {
            _context.UserTicket.Add(userTicket);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserTicket", new { id = userTicket.Id }, userTicket);
        }


        // DELETE: api/UserTickets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserTicket(Guid id)
        {
            var userTicket = await _context.UserTicket.FindAsync(id);
            if (userTicket == null)
            {
                return NotFound();
            }

            _context.UserTicket.Remove(userTicket);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserTicketExists(Guid id)
        {
            return _context.UserTicket.Any(e => e.Id == id);
        }
    }
}

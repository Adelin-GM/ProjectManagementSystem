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
    public class UserProjectsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserProjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/UserProjects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserProject>>> GetUserProject()
        {
            return await _context.UserProject.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<UserProject>>> GetUserProject(Guid id)
        {
            List<UserProject> UserProjectList = new List<UserProject>();
            var list = await _context.UserProject.ToListAsync();
            foreach (var item in list)
            {
                if (item.ProjectId == id)
                {
                    UserProjectList.Add(item);
                }
            }
            return UserProjectList;
        }

        [HttpGet("{id}/{name}")]
        public async Task<ActionResult<IEnumerable<UserProject>>> GetUserProject(Guid id, string name)
        {
            List<UserProject> UserProjectList = new List<UserProject>();
            var list = await _context.UserProject.ToListAsync();
            foreach (var item in list)
            {
                if (item.UserName == name)
                {
                    UserProjectList.Add(item);
                }
            }
            return UserProjectList;
        }

        // GET: api/UserProjects/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<UserProject>> GetUserProject(Guid id)
        //{
        // var userProject = await _context.UserProject.FindAsync(id);

        //if (userProject == null)
        //{
        // return NotFound();
        // }

        // return userProject;
        // }

        // PUT: api/UserProjects/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserProject(Guid id, UserProject userProject)
        {
            if (id != userProject.Id)
            {
                return BadRequest();
            }

            _context.Entry(userProject).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserProjectExists(id))
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

        // POST: api/UserProjects
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserProject>> PostUserProject(UserProject userProject)
        {
            _context.UserProject.Add(userProject);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserProject", new { id = userProject.Id }, userProject);
        }

        // DELETE: api/UserProjects/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserProject(Guid id)
        {
            var userProject = await _context.UserProject.FindAsync(id);
            if (userProject == null)
            {
                return NotFound();
            }

            _context.UserProject.Remove(userProject);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserProjectExists(Guid id)
        {
            return _context.UserProject.Any(e => e.Id == id);
        }
    }
}

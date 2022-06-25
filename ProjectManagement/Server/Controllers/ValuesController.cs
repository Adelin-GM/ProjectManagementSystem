using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManagement.Server.Data;
using ProjectManagement.Server.Models;
using ProjectManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<Models.ApplicationUser> userManager;

        public ValuesController(ApplicationDbContext context, UserManager<Models.ApplicationUser> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }


        // GET: api/Values
        [HttpGet]
        public ActionResult<IEnumerable<Models.ApplicationUser>> GetValue()
        {
            var users = userManager.Users;
            return users.ToList();
        }

        // GET: api/Values/name
        [HttpGet("{name}")]
        public async Task<ActionResult<Models.ApplicationUser>> GetValue(string name)
        {
            var applicationUser = userManager.FindByNameAsync(name);
            return applicationUser.Result;
        }

    }
}

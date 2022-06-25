using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProjectManagement.Server.Models;
using ProjectManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<Models.ApplicationUser>
    {
        public DbSet<Company> Company { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<UserProject> UserProject { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<UserTicket> UserTicket { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<Line> Line { get; set; }


        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
    }
}

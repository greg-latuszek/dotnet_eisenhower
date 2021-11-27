using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MvcEisenhower.Models;

namespace MvcEisenhower.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MvcEisenhower.Models.Task> Task { get; set; }
        public DbSet<MvcEisenhower.Models.User> User { get; set; }
    }
}

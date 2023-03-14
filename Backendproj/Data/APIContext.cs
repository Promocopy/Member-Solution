using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backendproj.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backendproj.Data
{
    public class APIContext : DbContext
    {
        public APIContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users {get; set;}
        public Dbset<Location> Location{get; set;}
    }
}
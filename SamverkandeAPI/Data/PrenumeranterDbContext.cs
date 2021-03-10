using Microsoft.EntityFrameworkCore;
using SamverkandeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamverkandeAPI.Data
{
    public class PrenumeranterDbContext : DbContext
    {
        public PrenumeranterDbContext(DbContextOptions<PrenumeranterDbContext> options) : base(options)
        {

        }
        public DbSet<Prenumeranter> Prenumeranter { get; set; }
    }
}

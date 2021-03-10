using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SamverkandeAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamverkandeAPI.Data
{
    public class AnnonsDbContext : DbContext 
    {
        public AnnonsDbContext(DbContextOptions<AnnonsDbContext> options) : base(options)
        {

        }

        public DbSet<Ads> Ads { get; set; }
        public DbSet<Annonsorer> Annonsorer { get; set; }
    }
}

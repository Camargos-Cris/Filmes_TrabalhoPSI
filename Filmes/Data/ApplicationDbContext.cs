using System;
using System.Collections.Generic;
using System.Text;
using Filmes.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Filmes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Series> Series { get; set; }
    }
}

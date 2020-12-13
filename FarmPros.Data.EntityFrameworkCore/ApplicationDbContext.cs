using System;
using System.Collections.Generic;
using System.Text;
using FarmPros.Domain.EntityFrameworkCore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FarmPros.Data.EntityFrameworkCore
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Farm> Farms { get; set; }
    }
}

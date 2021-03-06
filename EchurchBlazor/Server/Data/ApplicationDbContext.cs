using echurch.Models;
using EchurchBlazor.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EchurchBlazor.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }

        public DbSet<Arange> Arange { get; set; }
        public DbSet<Checkin> Checkin { get; set; }
        public DbSet<Church> Church { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Result> Result { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<SecretToken> SecretToken { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arange>().ToTable("Arange");
            modelBuilder.Entity<Checkin>().ToTable("Checkin");
            modelBuilder.Entity<Church>().ToTable("Church");
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<Result>().ToTable("Result");
            modelBuilder.Entity<Review>().ToTable("Review");
            modelBuilder.Entity<SecretToken>().ToTable("SecretToken");
        }
    }
}

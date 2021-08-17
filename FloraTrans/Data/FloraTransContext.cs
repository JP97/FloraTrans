using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FloraTrans.Models;

namespace FloraTrans.Data
{
    public class FloraTransContext : DbContext
    {
        public FloraTransContext (DbContextOptions<FloraTransContext> options)
            : base(options)
        {
        }

        public DbSet<FloraTrans.Models.Container> Container { get; set; }

        public DbSet<FloraTrans.Models.Contact> Contact { get; set; }

        public DbSet<FloraTrans.Models.Client> Client { get; set; }

        public DbSet<FloraTrans.Models.Warehouse> Warehouse { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Warehouse>().ToTable("Warhouse");
            modelBuilder.Entity<Contact>().ToTable("Contacts");
            modelBuilder.Entity<Container>().ToTable("Container");
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<ContainerAssignment>().ToTable("ContainerAssignment");

            modelBuilder.Entity<ContainerAssignment>().HasKey(c => new { c.ContainerID, c.ClientID });
        }
    }
}

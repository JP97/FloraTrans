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
    }
}

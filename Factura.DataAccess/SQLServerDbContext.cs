using Factura.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Factura.DataAccess
{
    public class SQLServerDbContext: DbContext
    {
        public SQLServerDbContext(DbContextOptions<SQLServerDbContext> options) : base(options)
        {

        }

        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<Productos> Productos { get; set; }
    }
}

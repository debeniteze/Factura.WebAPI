using Factura.Abstractions;
using Factura.DataAccess;
using Factura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Factura.Repository
{
    public class FacturasRepository : IFacturas
    {
        private readonly SQLServerDbContext _sQLServerDbContext;

        public FacturasRepository(SQLServerDbContext sQLServerDbContext)
        {
            _sQLServerDbContext = sQLServerDbContext;
        }

        public Facturas GetForId(long id)
        {
            return (Facturas)_sQLServerDbContext.Facturas.Where(x => x.Idfactura.Equals(id)).FirstOrDefault();
        }

        public long Save(Facturas facturas)
        {
            _sQLServerDbContext.Facturas.Add(facturas);
            _sQLServerDbContext.SaveChanges();
            return facturas.Idfactura;
        }

        public void Delete(long id)
        {
            var item = _sQLServerDbContext.Facturas.Find(id);
            _sQLServerDbContext.Remove(item);
            _sQLServerDbContext.SaveChanges();
        }
    }
}

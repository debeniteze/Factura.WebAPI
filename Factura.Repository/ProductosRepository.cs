using Factura.Abstractions;
using Factura.DataAccess;
using Factura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Factura.Repository
{
    public class ProductosRepository : IProducto
    {
        private readonly SQLServerDbContext _sQLServerDbContext;
        
        public ProductosRepository(SQLServerDbContext sQLServerDbContext)
        {
            _sQLServerDbContext = sQLServerDbContext;
        }

        public IList<Productos> GetAllProductos()
        {
            return _sQLServerDbContext.Productos.ToList();
        }
    }
}

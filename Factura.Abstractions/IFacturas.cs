using Factura.Entities;
using System;
using System.Collections.Generic;

namespace Factura.Abstractions
{
    public interface IFacturas
    {
        long Save(Facturas employees);
        Facturas GetForId(long id);
        void Delete(long id);
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Factura.Entities
{
    public class Facturas
    {
        [Key]
        public long Idfactura { get; set; }
        public long Numerofactura { get; set; }
        public DateTime Fecha { get; set; }
        public int Tipodepago { get; set; }
        public long Documentocliente { get; set; }
        public string Nombrecliente { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Iva { get; set; }
        public decimal Totaldescuento { get; set; }
        public decimal Totalimpuesto { get; set; }
        public decimal Total { get; set; }

    }
}

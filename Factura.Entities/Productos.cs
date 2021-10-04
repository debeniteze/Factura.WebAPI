using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.Entities
{
    public class Productos
    {
        [Key]
        public long IdProducto { get; set; }
        public string Producto { get; set; }
    }
}

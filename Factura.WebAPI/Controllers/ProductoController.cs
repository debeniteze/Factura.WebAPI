using Factura.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factura.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProducto _iProducto;
        public ProductoController(IProducto iProducto)
        {
            _iProducto = iProducto;
        }

        [HttpGet]
        public IActionResult GetListAll() => Ok(_iProducto.GetAllProductos());
    }
}

using Factura.Abstractions;
using Factura.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Factura.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasController : ControllerBase
    {
        private readonly IFacturas _iFacturas;
        public FacturasController(IFacturas iFacturas)
        {
            _iFacturas = iFacturas;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetForId(long id) => Ok(_iFacturas.GetForId(id));

        [HttpPost]
        public IActionResult SaveFacturas(Facturas facturas) => Ok(_iFacturas.Save(facturas));

        [HttpDelete]
        [Route("{id}")]
        public void DeleteFacturas(long id) => _iFacturas.Delete(id);


    }
}

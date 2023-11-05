using Examen_final_DW.Services;
using Microsoft.AspNetCore.Mvc;

namespace Examen_final_DW.Controllers
{
    [Route("api/expedientes/detalles")]
    [ApiController]
    public class DetalleController : ControllerBase
    {
        private readonly IDetalle _detalle;

        public DetalleController(IDetalle detalle)
        {
            _detalle = detalle;
        }

        [HttpGet]
        public IActionResult GetDetalles()
        {
            return Ok(_detalle.listDetalles());
        }
    }
}

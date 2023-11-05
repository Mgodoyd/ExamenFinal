using Examen_final_DW.Models;
using Examen_final_DW.Services;
using Microsoft.AspNetCore.Mvc;

namespace Examen_final_DW.Controllers
{

    [Route("api/expedientes")]
    [ApiController]
    public class ExpedienteController :ControllerBase
    {
        private readonly IExpediente _expediente;

        public ExpedienteController(IExpediente expediente)
        {
            _expediente = expediente;
        }

        [HttpGet]
        public IActionResult GetExpedientes()
        {
            return Ok(_expediente.listExpedientes());
        }

        [HttpPost]
        public IActionResult PostExpediente(Expediente expediente)
        {
            _expediente.CrearExpediente(expediente);
            return Ok(expediente);
        }
    }
}

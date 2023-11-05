using Examen_final_DW.Data;
using Examen_final_DW.Models;
using Microsoft.EntityFrameworkCore;

namespace Examen_final_DW.Services
{
    public class ServiceDetalle : IDetalle
    {
        private readonly ApplicationDBContext _context;

        public ServiceDetalle(ApplicationDBContext context)
        {
            _context = context;
        }

        public List<DetalleExpediente> listDetalles()
        {
            return _context.Detalles.Include(dt => dt.expediente).ToList();
        }

    }
}

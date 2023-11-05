using Examen_final_DW.Data;
using Examen_final_DW.Models;
using Microsoft.EntityFrameworkCore;

namespace Examen_final_DW.Services
{
    public class ServiceExpediente : IExpediente
    {
        private readonly ApplicationDBContext _context;

        public ServiceExpediente(ApplicationDBContext context)
        {
            _context = context;
        }

        public Expediente CrearExpediente(Expediente expediente)
        {
            _context.Expedientes.Add(expediente);
            _context.SaveChanges();
            return expediente;
        }

        public List<Expediente> listExpedientes()
        {
            return _context.Expedientes.Include(de => de.detalleExpediente).ToList();
        }
    }
}

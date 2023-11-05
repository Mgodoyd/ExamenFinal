using Examen_final_DW.Models;
using Microsoft.EntityFrameworkCore;

namespace Examen_final_DW.Data
{
    public class ApplicationDBContext :DbContext
    {
        public DbSet<Expediente> Expedientes { get; set; }
        public DbSet<DetalleExpediente> Detalles { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace RegistroDTickets.Models
{
    public class Tickets
    {
        [Key]
        public int TicketsId { get; set; }
        public int ClientesId { get; set; }
        public int SistemaId { get; set; }
        public int PrioridadId { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Today;
        public string SolicitadoPor { get; set; }
        public string Asunto { get; set; }
        public string Descripcion { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;

namespace RegistroDTickets.Models
{
    public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }
        public string Descripcion { get; set; }
        public int DiasCompromiso { get; set; }
    }
}

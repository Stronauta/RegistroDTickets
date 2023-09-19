using Microsoft.EntityFrameworkCore;
using RegistroDTickets.Models;

namespace RegistroDTickets.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Tickets> Tickets { get; set; }

        public Contexto(DbContextOptions <Contexto> options): base(options)
        {
        }
    }
}

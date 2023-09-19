using Microsoft.EntityFrameworkCore;
using RegistroDTickets.Models;

namespace RegistroDTickets.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        public Contexto(DbContextOptions <Contexto> options)    { }
    }
}

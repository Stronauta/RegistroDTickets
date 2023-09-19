using Microsoft.EntityFrameworkCore;
using RegistroDTickets.DAL;
using RegistroDTickets.Models;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace RegistroDTickets.BLL
{
    public class TicketsBLL
    {
        public Contexto _contexto;

        public TicketsBLL(Contexto contexto)
        {
            _contexto = contexto;

        }
        public bool Existe(int ticketId)
        {
            return _contexto.Tickets.Any(o => o.TicketsId == ticketId);
        }

        private bool Insertar(Tickets tickets)
        {
            _contexto.Tickets.Add(tickets);
            return _contexto.SaveChanges() > 0;
        }

        private bool Modificar(Tickets tickets)
        {
            _contexto.Entry(tickets).State = EntityState.Modified;
            return _contexto.SaveChanges() > 0;
        }

        public bool Guardar(Tickets tickets)
        {
            if(!Existe(tickets.TicketsId))
                return Insertar(tickets); 
            else 
                return Modificar(tickets);
        }

        public bool Eliminar(Tickets tickets)
        {
            _contexto.Entry(tickets).State |= EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }

        public Tickets? Buscar(int ticketId)
        {
            return _contexto.Tickets
                .Where(t => t.TicketsId == ticketId)
                .AsNoTracking()
                .SingleOrDefault();      
        }

        public List<Tickets> GetList(Expression<Func<Tickets, bool>> expression)
        {
            return _contexto.Tickets.AsNoTracking()
                .Where(expression)
                .ToList();
        }

        public List<Tickets> BuscarPorId(int ticketId)
        {
            return _contexto.Tickets.AsNoTracking()
                .Where(t => t.TicketsId == ticketId).ToList();
        }
    }
}

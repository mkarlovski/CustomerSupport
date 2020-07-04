using CustomerSupport.Models;
using CustomerSupport.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupport.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly CustomerSupportDbContext context;

        public TicketRepository(CustomerSupportDbContext context)
        {
            this.context = context;
        }

        public List<Ticket> GetAll()
        {
            return context.Tickets.ToList();
        }

        public Ticket GetById(int id)
        {
            return context.Tickets.FirstOrDefault(x => x.Id == id);
        }
    }
}

using CustomerSupport.Models;
using CustomerSupport.Repositories.Interfaces;
using CustomerSupport.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupport.Services
{
    public class TicketService: ITicketService
    {
        private readonly ITicketRepository repository;

        public TicketService(ITicketRepository repository)
        {
            this.repository = repository;
        }

        public void Create(string title, string message, string userId)
        {
            var ticket = new Ticket()
            {
                Title=title,
                Message=message,
                DateCreated=DateTime.Now,
                ClientId=userId
            };
        }

        public List<Ticket> GetAll()
        {
            return repository.GetAll();
        }

        public Ticket GetById(int id)
        {
            return repository.GetById(id);
        }
    }
}

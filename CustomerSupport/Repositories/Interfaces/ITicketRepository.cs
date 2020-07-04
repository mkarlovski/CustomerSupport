using CustomerSupport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupport.Repositories.Interfaces
{
    public interface ITicketRepository
    {
        List<Ticket> GetAll();
        Ticket GetById(int id);
    }
}

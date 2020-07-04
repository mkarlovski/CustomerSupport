using CustomerSupport.Models;
using CustomerSupport.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupport.Helpers
{
    public static class ModelConverter
    {
        public static TicketViewModel ConvertToTicketViewModel(Ticket ticket)
        {
            return new TicketViewModel
            {
                Id=ticket.Id,
                Message=ticket.Message,
                Title=ticket.Title,
                DateClosed=ticket.DateClosed,
                DateCreated=ticket.DateCreated,
                ClientId=ticket.ClientId,
                Status=ticket.Status
            };
        }
    }
}

using CustomerSupport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupport.ViewModels
{
    public class TicketViewModel

    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        [Required]
        public DateTime? DateClosed { get; set; }
        [Required]
        public StatusEnum Status { get; set; }
        
        public string ClientId { get; set; }
        public string UserEmail { get; set; }
        public List<Comment> Comments { get; set; }

    }
}

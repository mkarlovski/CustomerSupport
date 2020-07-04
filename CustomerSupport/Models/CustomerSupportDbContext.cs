using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupport.Models
{
    public class CustomerSupportDbContext : IdentityDbContext
    {
        public CustomerSupportDbContext(DbContextOptions<CustomerSupportDbContext> options) :base(options)
        {

        }

        public DbSet<Ticket> Tickets { get; set; }

    }
}

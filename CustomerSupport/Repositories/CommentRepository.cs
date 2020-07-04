using CustomerSupport.Models;
using CustomerSupport.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSupport.Repositories
{
    public class CommentRepository :ICommentRepository
    {
        private readonly CustomerSupportDbContext context;

        public CommentRepository(CustomerSupportDbContext context)
        {
            this.context = context;
        }
    }
}

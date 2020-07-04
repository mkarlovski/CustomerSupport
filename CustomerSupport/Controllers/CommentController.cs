using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerSupport.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerSupport.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService service;

        public CommentController(ICommentService service)
        {
            this.service = service;
        }
        public void Add()
        {

            
        }
    }
}
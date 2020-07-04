using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CustomerSupport.Models;
using CustomerSupport.Services.Interfaces;
using CustomerSupport.Helpers;
using CustomerSupport.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace CustomerSupport.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketService ticketService;
        private readonly UserManager<IdentityUser> userManager;

        public TicketController(ITicketService ticketService,UserManager<IdentityUser> userManager)
        {
            this.ticketService = ticketService;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            var tickets = ticketService.GetAll();
            var ticketViewModel = tickets.Select(x => ModelConverter.ConvertToTicketViewModel(x)).ToList();

            return View(ticketViewModel);
        }

        public IActionResult Detail(int id)
        {
            var dbTicket = ticketService.GetById(id);
            var ticket = ModelConverter.ConvertToTicketViewModel(dbTicket);
            return View(ticket);
        }

        public IActionResult AddTicket()
        {
            var ticket = new CreateViewModel();
            return View(ticket);
        }

        [HttpPost]
        public IActionResult AddTicket(CreateViewModel ticketModel)
        {
            if (ModelState.IsValid)
            {
                var userId = userManager.GetUserId(User);
                ticketService.Create(ticketModel.Title, ticketModel.Message,userId);
                return RedirectToAction("Index", "Ticket");
            }

            return View(ticketModel);
        }







        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}

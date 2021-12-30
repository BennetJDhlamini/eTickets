using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _service;

        public ActorsController(AppDbContext service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var data = _service.Actors.ToList();
            return View(data);
        }
    }
}

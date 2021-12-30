using eTickets.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _service;

        public CinemasController(AppDbContext service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allCinemas = await _service.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}

﻿using eTickets.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _service;

        public MoviesController(AppDbContext service)
        {
            _service = service;
        }

        //[AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.Movies.Include(n => n.Cinema).OrderBy(n => n.Name).ToListAsync();
            return View(allMovies);
        }
    }
}

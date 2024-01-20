﻿using AmadoApp.Business.Services.Interfaces;
using AmadoApp.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AmadoApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _service;

        public HomeController(IProductService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
        public async Task<IActionResult> AccessDeniedCustom()
        {
            return View();
        }

    }
}

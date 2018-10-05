using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Lab4NewsApp.Domain;
using Microsoft.AspNetCore.Mvc;
using Lab4NewsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab4NewsApp.Controllers
{
    public class HomeController : Controller
    {
        private static int NEWS_COUNT = 3;
        private NewsContext context;

        public HomeController(NewsContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            var model = await context.News.OrderByDescending(i => i.PublishTime)
                .Take(NEWS_COUNT)
                .ToListAsync();

            return View(model);
        }
    }
}

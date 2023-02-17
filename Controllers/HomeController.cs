using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using Widgets.Data.Models;
using Widgets.Models;
using Widgets.Services;

namespace Widgets.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WidgetService _widgetService;

        public HomeController(ILogger<HomeController> logger, WidgetService widgetService)
        {
            _logger = logger;
            _widgetService = widgetService;
        }


        public IActionResult Index()
        {
            object getAllWidgets = _widgetService.GetAllWidgets();
            return View(getAllWidgets);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
            var listOfWidgets = _widgetService.GetAllWidgets();
            return View(listOfWidgets);
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

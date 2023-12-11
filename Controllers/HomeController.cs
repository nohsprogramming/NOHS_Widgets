using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
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

        [HttpPost]
        public ActionResult UpdateSelectedModel(int widgetId)
        {
            var clickedModel = _widgetService.GetWidgetById(widgetId);
            return Json(clickedModel);
        }

        public IActionResult Index()
        {
            return View(_widgetService.GetAllWidgets());
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

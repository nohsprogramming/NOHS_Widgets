using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
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

            // Fetch widget data from the service
            var widgetData = _widgetService.GetAllWidgets(); // Example method

           
            return View(widgetData);
        }


    }

        

       // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
       
}

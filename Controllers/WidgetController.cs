using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Widgets.Data;
using Widgets.Data.Models;

namespace Widgets.Controllers
{
    public class WidgetController : Controller
    {
        private readonly ILogger<WidgetController> logger;
        private readonly WidgetRepository _widgetRepository;

        public WidgetController(WidgetRepository widgetRepository)
        {
            //_logger = logger;
            _widgetRepository = widgetRepository;
        }
        public async Task<IActionResult> Index()
        {
            return View(_widgetRepository.GetAll);
        }

        private IActionResult View(Func<IEnumerable<Widget>> getAll)
        {
            throw new NotImplementedException();
        }
    }
}

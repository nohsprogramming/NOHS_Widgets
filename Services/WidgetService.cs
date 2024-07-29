using System.Collections.Generic;
using Widgets.Data;
using Widgets.Data.Models;

namespace Widgets.Services
{
    //interface IWidgetService
    //{
    //    public IEnumerable<Widget> GetAllWidgets();
    //}
    public class WidgetService
    {
        private readonly WidgetRepository _widgetRepository;

        public WidgetService(WidgetRepository widgetRepository) => _widgetRepository = widgetRepository;

        public IEnumerable<Widget> GetAllWidgets() => _widgetRepository.GetAll();
    }
}

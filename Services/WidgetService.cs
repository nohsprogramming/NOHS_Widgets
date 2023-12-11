using System.Collections.Generic;
using Widgets.Data;
using Widgets.Data.Models;

namespace Widgets.Services
{
    public class WidgetService
    {
        private readonly WidgetRepository _widgetRepository;

        public WidgetService(WidgetRepository widgetRepository) => _widgetRepository = widgetRepository;

        public IEnumerable<Widget> GetAllWidgets() => _widgetRepository.GetAll();

        public Widget GetWidgetById(int widgetId)
        {
            return _widgetRepository.GetWidgetById(widgetId);
        }
    }
}

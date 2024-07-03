using System.Collections.Generic;
using Widgets.Data.Models;

namespace Widgets.Services
{
    public interface Interface
    {
        IEnumerable<Widget> GetAllWidgets();
    }
}

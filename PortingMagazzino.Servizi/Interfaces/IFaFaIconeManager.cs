using System;
using System.Collections.Generic;
using System.Text;

namespace PortingMagazzino.Servizi.Interfaces
{
    public interface IFaFaIconeManager
    {
        string GetControllerIcon(string key);

        string GetGenericIcon(string key);
    }
}

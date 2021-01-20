using System;
using System.Collections.Generic;
using System.Text;

namespace PortingMagazzino.Servizi.Interfaces
{
    public interface ITranslate
    {
        string TranslateGen(string label, string controller);

    }
}

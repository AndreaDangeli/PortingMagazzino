using PortingMagazzino.Servizi.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortingMagazzino.Servizi.Implementations
{
    public class FaFaIconeManager : IFaFaIconeManager
    {
        public string GetControllerIcon(string key)
        {
            switch (key)
            {
                case "Home":
                    return "fa fa-bar-chart";
                case "CausaleMovimentiMagazzino":
                    return "fa fa-clipboard";
                case "Warehouse":
                    return "fa fa-cubes";
                case "VMStock":
                    return "fa fa-cube";
                case "PurchaseOrder":
                    return "fa fa-file-text";
                case "Receiving":
                    return "fa fa-truck";
                case "SalesOrder":
                    return "fa fa-cart-plus";
                case "Shipment":
                    return "fa fa-plane";
                case "TransferOrder":
                    return "fa fa-recycle";
                case "Responsabili":
                    return "fa fa-address-book";
                case "Tracciabilita":
                    return "fa fa-ship";
                default:
                    return "";
            }
        }

        public string GetGenericIcon(string key)
        {
            switch (key)
            {
                case "Storico":
                    return "fa fa-book";
                case "Ritorna":
                    return "fa fa-reply";
                default:
                    return "";
            }
        }
    }
}

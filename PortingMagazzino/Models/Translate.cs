using PortingMagazzino.Servizi.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using System.Text;

namespace PortingMagazzino
{
    public class Translate : ITranslate
    {
        string translatePath = "PortingMagazzino.Resources.Controllers.Invent";
        public string TranslateGen(string label, string controller)
        {
            switch (controller)
            {
                case "CausaleMovimentiMagazzino":
                    return TranslateCausaleMovMagazCtrl(label);

                case "Clienti":                                     //NON PRESENTE NEI RESX, LASCIATO COMUNQUE
                    return TranslateClientiCtrl(label);

                case "TabProdotto":                                 //COME PRIMA
                    return TranslateProductCtrl(label);

                case "PurchaseOrder":
                    return TranslatePurchaseOrderCtrl(label);

                case "Receiving":
                    return TranslateReceivingCtrl(label);

                case "SalesOrder":
                    return TranslateSalesOrderCtrl(label);

                case "Shipment":
                    return TranslateShipmentCtrl(label);

                case "TransferOrder":
                    return TranslateTransferOrderCtrl(label);

                case "Warehouse":
                    return TranslateWareHouseCtrl(label);

                case "General":
                    return TranslateGeneral(label);

                case "Account":
                    return TranslateAccount(label);

                case "Home":
                    return TranslateHome(label);

                case "VMStock":
                    return TranslateStock(label);

                case "Responsabili":
                    return TranslateResponsabili(label);

                case "Tracciabilita":
                    return TranslateTracciabilita(label);

                default:
                    return "";
            }

        }
        private string TranslateCausaleMovMagazCtrl(string key)
        {
            ResourceManager rm = new ResourceManager("PortingMagazzino.Resources.Controllers.Invent.CausaleMovimentiMagazzinoController", Assembly.GetExecutingAssembly());
            String Testo = rm.GetString(key);
            return Testo;

        }

        private string TranslateClientiCtrl(string key)
        {
            ResourceManager rm = new ResourceManager("PortingMagazzino.Resources.Controllers.Invent.CustomerController", Assembly.GetExecutingAssembly());
            String Testo = rm.GetString(key);
            return Testo;

        }

        private string TranslateProductCtrl(string key)
        {
            ResourceManager rm = new ResourceManager("PortingMagazzino.Resources.Controllers.Invent.ProductController", Assembly.GetExecutingAssembly());
            String Testo = rm.GetString(key);
            return Testo;

        }

        private string TranslatePurchaseOrderCtrl(string key)
        {
            ResourceManager rm = new ResourceManager("PortingMagazzino.Resources.Controllers.Invent.PurchaseOrderController", Assembly.GetExecutingAssembly());
            String Testo = rm.GetString(key);

            return Testo;

        }

        private string TranslateReceivingCtrl(string key)
        {
            ResourceManager rm = new ResourceManager("PortingMagazzino.Resources.Controllers.Invent.ReceivingController", Assembly.GetExecutingAssembly());
            String Testo = rm.GetString(key);
            return Testo;

        }

        private string TranslateSalesOrderCtrl(string key)
        {
            ResourceManager rm = new ResourceManager("PortingMagazzino.Resources.Controllers.Invent.SalesOrderController", Assembly.GetExecutingAssembly());
            String Testo = rm.GetString(key);
            String TestGenesi = Testo.Replace("@", "<br/>");
            return TestGenesi;

        }

        private string TranslateShipmentCtrl(string key)
        {
            ResourceManager rm = new ResourceManager($"{translatePath}.ShipmentController", Assembly.GetExecutingAssembly());
            String Testo = rm.GetString(key);
            return Testo;

        }

        private string TranslateTransferOrderCtrl(string key)
        {
            ResourceManager rm = new ResourceManager("PortingMagazzino.Resources.Controllers.Invent.TransferOrderController", Assembly.GetExecutingAssembly());
            String Testo = rm.GetString(key);
            return Testo;

        }

        private string TranslateWareHouseCtrl(string key)
        {
            ResourceManager rm = new ResourceManager("PortingMagazzino.Resources.Controllers.Invent.WarehouseController", Assembly.GetExecutingAssembly());
            String Testo = rm.GetString(key);
            return Testo;

        }

        private string TranslateGeneral(string key)
        {
            ResourceManager rm = new ResourceManager("PortingMagazzino.Resources.Controllers.Invent.GeneralUse", Assembly.GetExecutingAssembly());
            String Testo = rm.GetString(key);
            return Testo;

        }

        private string TranslateAccount(string key)
        {
            ResourceManager rm = new ResourceManager("PortingMagazzino.Resources.Controllers.AccountController", Assembly.GetExecutingAssembly());
            String Testo = rm.GetString(key);
            return Testo;

        }

        private string TranslateHome(string key)
        {
            ResourceManager rm = new ResourceManager("PortingMagazzino.Resources.Controllers.HomeController", Assembly.GetExecutingAssembly());
            String Testo = rm.GetString(key);
            return Testo;

        }

        private string TranslateStock(string key)
        {
            ResourceManager rm = new ResourceManager("PortingMagazzino.Resources.Controllers.Invent.VMStockController", Assembly.GetExecutingAssembly());
            String Testo = rm.GetString(key);
            return Testo;

        }

        private string TranslateResponsabili(string key)
        {
            ResourceManager rm = new ResourceManager("PortingMagazzino.Resources.Controllers.Invent.ResponsabiliController", Assembly.GetExecutingAssembly());
            String Testo = rm.GetString(key);
            return Testo;
        }

        private string TranslateTracciabilita(string key)
        {
            ResourceManager rm = new ResourceManager("PortingMagazzino.Resources.Controllers.Invent.TracciabilitaController", Assembly.GetExecutingAssembly());
            String Testo = rm.GetString(key);
            return Testo;
        }
    }
}


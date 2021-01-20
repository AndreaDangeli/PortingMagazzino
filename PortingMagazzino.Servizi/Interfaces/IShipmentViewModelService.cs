using PortingMagazzino.Data.Models;
using PortingMagazzino.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PortingMagazzino.Servizi.Interfaces
{
    public interface IShipmentViewModelService
    {
        Task<ShipmentViewModel> CreaScaricoDaTesis(string id);

        Task<ShipmentViewModel> GetCreate();

        Task<ShipmentViewModel> GetDelete(string id);

        Task<ShipmentViewModel> GetDetails(string id);

        Task<ShipmentViewModel> GetEdit(string id);

        Task<ShipmentViewModel> GetIndex();

        Task<ShipmentViewModel> GetIndexHistory();

        Task<Shipment> PostCreate(Shipment shipment);

        Task<Shipment> PostDelete(string id);

        Task PostEdit(Shipment shipment);

        Task<ShipmentViewModel> Reopen(string id);

        ShipmentViewModel Scarico(string id);

        bool ShipmentExists(string id);

        ShipmentViewModel PrintDeliveryOrder(string id);
        Task<ShipmentViewModel> AnnullaDDT(string shipmentId, string CausaleAnnullamentoId, string NoteAnnullamento);
    }
}

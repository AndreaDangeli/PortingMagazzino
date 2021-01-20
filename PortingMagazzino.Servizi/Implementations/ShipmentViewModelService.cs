using Microsoft.EntityFrameworkCore;
using PortingMagazzino.Data.Models;
using PortingMagazzino.Data.ViewModels;
using PortingMagazzino.Servizi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortingMagazzino.Servizi.Implementations
{
    public class ShipmentViewModelService : IShipmentViewModelService
    {
        private readonly MagazzinoContext _magazzinoContext;

        public ShipmentViewModelService(MagazzinoContext magazzinoContext)
        {
            _magazzinoContext = magazzinoContext;
        }

        public Task<ShipmentViewModel> AnnullaDDT(string shipmentId, string CausaleAnnullamentoId, string NoteAnnullamento)
        {
            throw new NotImplementedException();
        }

        public Task<ShipmentViewModel> CreaScaricoDaTesis(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ShipmentViewModel> GetCreate()
        {
            throw new NotImplementedException();
        }

        public Task<ShipmentViewModel> GetDelete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ShipmentViewModel> GetDetails(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ShipmentViewModel> GetEdit(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<ShipmentViewModel> GetIndex()
        {
            return new ShipmentViewModel()
            {
                Shipments = await _magazzinoContext.Shipment.Where(x => !x.Completato).OrderByDescending(x => x.ShipmentDate).Include(s => s.CausaleMovimentiMagazzino)./*Include(s => s.salesOrder).*/ToListAsync(),
                Warehouse = await _magazzinoContext.Warehouse.Where(x => x.Valido).ToListAsync(),
                VW_Ubicazioni = await _magazzinoContext.VwUbicazioni.ToListAsync(),
                OrdineDiVendita = new SalesOrder()
            };
        }

        public Task<ShipmentViewModel> GetIndexHistory()
        {
            throw new NotImplementedException();
        }

        public Task<Shipment> PostCreate(Shipment shipment)
        {
            throw new NotImplementedException();
        }

        public Task<Shipment> PostDelete(string id)
        {
            throw new NotImplementedException();
        }

        public Task PostEdit(Shipment shipment)
        {
            throw new NotImplementedException();
        }

        public ShipmentViewModel PrintDeliveryOrder(string id)
        {
            throw new NotImplementedException();
        }

        public Task<ShipmentViewModel> Reopen(string id)
        {
            throw new NotImplementedException();
        }

        public ShipmentViewModel Scarico(string id)
        {
            throw new NotImplementedException();
        }

        public bool ShipmentExists(string id)
        {
            throw new NotImplementedException();
        }
    }
}

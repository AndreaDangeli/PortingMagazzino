using PortingMagazzino.Data.Models;
using PortingMagazzino.TesisData.TesisModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortingMagazzino.Data.ViewModels
{
    public class ShipmentViewModel
    {
        public List<SalesOrder> SalesOrder { get; set; }

        public SalesOrder OrdineDiVendita { get; set; }

        public List<CausaleMovimentiMagazzino> Causale { get; set; }

        public List<Fornitori> Fornitori { get; set; }

        public Fornitori Fornitore { get; set; }

        public List<VwUbicazioni> VW_Ubicazioni { get; set; }

        public VwUbicazioni VW_Ubicazione { get; set; }

        public List<Warehouse> Warehouse { get; set; }

        public Shipment Shipment { get; set; }

        public List<Shipment> Shipments { get; set; }

        public List<VwProdottiCaricoScarico> Prodotti { get; set; }

        public List<VwProdottiCaricoScarico> ProdottiSelect { get; set; }

        public List<TabTrasportatori> Vettori { get; set; }

        public TabTrasportatori Vettore { get; set; }

        public List<Clienti> Clienti { get; set; }

        public Clienti Cliente { get; set; }

        public List<ShipmentLine> ShipmentLines { get; set; }

        public List<MatricoleScarico> Matricole { get; set; }

        public List<TabCostruttore> Costruttori { get; set; }

        public List<VwFornitoriUbicazioni> VW_FornitoriUbicazioni { get; set; }

        public VwFornitoriUbicazioni VW_FornitoreUbicazione { get; set; }

        public List<NoteDdt> NoteDDT { get; set; }

        public NoteDdt NotaDDT { get; set; }

        public VwDatiRichiestaDelivery DatiRichiestaDelivery { get; set; }

        public List<Colli> Colli { get; set; }
        public List<CausaleAnnullamento> CausaliAnnullamenti { get; set; }
        public CausaleAnnullamento CausaleAnnullamento { get; set; }
        public string NoteAnnullamento { get; set; }
        public bool Annullato { get; set; }
        public List<Incoterms> ListIncoterms { get; set; }
        public Incoterms Incoterms { get; set; }
        public bool DaStampare { get; set; }
        public string Note { get; set; }
    }
}

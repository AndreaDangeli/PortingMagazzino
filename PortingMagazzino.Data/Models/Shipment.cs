﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PortingMagazzino.Data.Models
{
    public partial class Shipment
    {
        public Shipment()
        {
            ColliNavigation = new HashSet<Colli>();
            SalesOrderShipment = new HashSet<SalesOrderShipment>();
            ShipmentLine = new HashSet<ShipmentLine>();
        }

        public string ShipmentId { get; set; }
        public string SalesOrderId { get; set; }
        public string ShipmentNumber { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string WarehouseId { get; set; }
        public int ExpeditionType { get; set; }
        public int ExpeditionMode { get; set; }
        public string CausaleMovimentiMagazzinoId { get; set; }
        public decimal IdUbicazione { get; set; }
        public long IdFornitoreUbicazione { get; set; }
        public int Colli { get; set; }
        public string AspettoBeni { get; set; }
        public string TrackingNumber { get; set; }
        public bool Completato { get; set; }
        public bool Valido { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        public int FirstUser { get; set; }
        public int LastUser { get; set; }
        public long? VettoreId { get; set; }
        public string NoteDdtid { get; set; }
        public decimal? IdEvento { get; set; }
        public bool Annullato { get; set; }
        public string CausaleAnnullamentoId { get; set; }
        public string NoteAnnullamento { get; set; }
        public bool Fatturato { get; set; }
        public string IncotermsId { get; set; }
        public long? NumeroDdt { get; set; }
        public bool DaStampare { get; set; }
        public string Note { get; set; }

        public virtual CausaleAnnullamento CausaleAnnullamento { get; set; }
        public virtual CausaleMovimentiMagazzino CausaleMovimentiMagazzino { get; set; }
        public virtual Incoterms Incoterms { get; set; }
        public virtual ICollection<Colli> ColliNavigation { get; set; }
        public virtual ICollection<SalesOrderShipment> SalesOrderShipment { get; set; }
        public virtual ICollection<ShipmentLine> ShipmentLine { get; set; }
    }
}
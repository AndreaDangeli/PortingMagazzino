﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PortingMagazzino.Data.Models
{
    public partial class Incoterms
    {
        public Incoterms()
        {
            SalesOrder = new HashSet<SalesOrder>();
            Shipment = new HashSet<Shipment>();
        }

        public string Codice { get; set; }
        public string Descrizione { get; set; }

        public virtual ICollection<SalesOrder> SalesOrder { get; set; }
        public virtual ICollection<Shipment> Shipment { get; set; }
    }
}
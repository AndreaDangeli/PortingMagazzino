﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PortingMagazzino.Data.Models
{
    public partial class Colli
    {
        public string ColliId { get; set; }
        public decimal Peso { get; set; }
        public decimal Profondita { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        public int FirstUser { get; set; }
        public int LastUser { get; set; }
        public decimal Altezza { get; set; }
        public decimal Lunghezza { get; set; }
        public string ShipmentId { get; set; }

        public virtual Shipment Shipment { get; set; }
    }
}
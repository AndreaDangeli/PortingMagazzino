﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PortingMagazzino.Data.Models
{
    public partial class VwProdottiCaricoScarico
    {
        public string Id { get; set; }
        public string LineId { get; set; }
        public string WarehouseId { get; set; }
        public decimal? IdProdotto { get; set; }
        public string CodCostruttore { get; set; }
        public string Costruttore { get; set; }
        public string CategoriaMerci { get; set; }
        public string Modello { get; set; }
        public string Tipo { get; set; }
        public string Descrizione { get; set; }
        public bool? RichiedeMatricola { get; set; }
        public int Qty { get; set; }
        public int? QtyHandle { get; set; }
        public int QtyHandled { get; set; }
        public bool RigaCompleta { get; set; }
        public int Carico { get; set; }
        public int Scarico { get; set; }
    }
}
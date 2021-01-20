﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PortingMagazzino.Data.Models
{
    public partial class MatricoleStoricoTrasferimenti
    {
        public string MatricoleStoricoTrasferimentiId { get; set; }
        public string Matricola { get; set; }
        public string Cespite { get; set; }
        public string TransferOrderLineId { get; set; }
        public string MatricoleId { get; set; }
        public string WarehouseFromId { get; set; }
        public string WarehouseToId { get; set; }
        public decimal IdProdotto { get; set; }
        public string CodCostruttore { get; set; }
        public string TransferOrderId { get; set; }
        public bool UltimoTrasferimento { get; set; }

        public virtual Matricole Matricole { get; set; }
        public virtual TransferOrder TransferOrder { get; set; }
        public virtual TransferOrderLine TransferOrderLine { get; set; }
        public virtual Warehouse WarehouseFrom { get; set; }
        public virtual Warehouse WarehouseTo { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PortingMagazzino.Data.Models
{
    public partial class TransferOrderLine
    {
        public TransferOrderLine()
        {
            MatricoleStoricoTrasferimenti = new HashSet<MatricoleStoricoTrasferimenti>();
        }

        public string TransferOrderLineId { get; set; }
        public string TransferOrderId { get; set; }
        public decimal IdProdotto { get; set; }
        public int Qty { get; set; }
        public bool Valido { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        public int FirstUser { get; set; }
        public int LastUser { get; set; }

        public virtual TransferOrder TransferOrder { get; set; }
        public virtual ICollection<MatricoleStoricoTrasferimenti> MatricoleStoricoTrasferimenti { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace PortingMagazzino.Data.Models
{
    public partial class PurchaseOrderReceiving
    {
        public string Id { get; set; }
        public string PurchaseOrderId { get; set; }
        public string ReceivingId { get; set; }
        public int QtyArrived { get; set; }
        public string PurchaseOrderLineId { get; set; }
        public string ReceivingLineId { get; set; }
        public int QtyTot { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }
        public virtual PurchaseOrderLine PurchaseOrderLine { get; set; }
        public virtual Receiving Receiving { get; set; }
        public virtual ReceivingLine ReceivingLine { get; set; }
    }
}
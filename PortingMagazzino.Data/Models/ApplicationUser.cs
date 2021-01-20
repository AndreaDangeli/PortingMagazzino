using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PortingMagazzino.Data.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public partial class ApplicationUser : IdentityUser
    {
        public string profilePictureUrl { get; set; } = "~/images/empty_profile.png";

        public bool isSuperAdmin { get; set; } = true;

        [Display(Name = "Ruoli")]
        public bool ApplicationUserRole { get; set; } = false;

        [Display(Name = "Causali")]
        public bool CausaleMovimentiMagazzinoRole { get; set; } = true;

        [Display(Name = "PurchaseOrder")]
        public bool PurchaseOrderRole { get; set; } = true;

        [Display(Name = "Receiving")]
        public bool ReceivingRole { get; set; } = true;

        [Display(Name = "PurchaseOrderLine")]
        public bool PurchaseOrderLineRole { get; set; } = true;

        [Display(Name = "ReceivingLine")]
        public bool ReceivingLineRole { get; set; } = true;

        [Display(Name = "SalesOrder")]
        public bool SalesOrderRole { get; set; } = true;

        [Display(Name = "SalesOrderLine")]
        public bool SalesOrderLineRole { get; set; } = true;

        [Display(Name = "Shipment")]
        public bool ShipmentRole { get; set; } = true;

        [Display(Name = "ShipmentLine")]
        public bool ShipmentLineRole { get; set; } = true;

        [Display(Name = "VMStock")]
        public bool VMStockRole { get; set; } = true;

        [Display(Name = "TransferOrder")]
        public bool TransferOrderRole { get; set; } = true;

        [Display(Name = "TransferOrderLine")]
        public bool TransferOrderLineRole { get; set; } = true;

        [Display(Name = "Warehouse")]
        public bool WarehouseRole { get; set; } = true;

        [Display(Name = "Home")]
        public bool HomeRole { get; set; } = true;

        [Display(Name = "Responsabili")]
        public bool ResponsabiliRole { get; set; } = true;

        [Display(Name = "Tracciabilita")]
        public bool TracciabilitaRole { get; set; } = true;
    }
}

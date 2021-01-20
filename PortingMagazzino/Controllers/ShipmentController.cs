using Microsoft.AspNetCore.Mvc;
using PortingMagazzino.Servizi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortingMagazzino.Controllers
{
    public class ShipmentController : Controller
    {
        private readonly IShipmentViewModelService _shipmentViewModelService;

        public ShipmentController(IShipmentViewModelService shipmentViewModelService)
        {
            _shipmentViewModelService = shipmentViewModelService;
        }

        // GET: Shipment
        public async Task<IActionResult> Index()
        {
            return View(await _shipmentViewModelService.GetIndex());
        }
    }
}

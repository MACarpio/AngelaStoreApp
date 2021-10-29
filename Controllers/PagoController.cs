using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngelaStoreApp.Data;
using AngelaStoreApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngelaStoreApp.Controllers
{
    public class PagoController: Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public PagoController(ApplicationDbContext context,
            UserManager<IdentityUser> userManager)
            {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Create(Decimal monto)
        {
             Pago pago = new Pago();
            pago.UserID = _userManager.GetUserName(User);
            pago.MontoTotal = monto;
            return View(pago);
        }

        [HttpPost]
        public IActionResult Pagar(Pago pago)
        {
            pago.PaymentDate = DateTime.Now;
             _context.Add(pago);
            _context.SaveChanges();
            ViewData["Message"] = "El pago se ha registrado";
            return View("Create");
        }

    }
}
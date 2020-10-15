using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LeapWeb.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ILogger<ServiceController> _logger;

        public ServiceController(ILogger<ServiceController> logger)
        {
            _logger = logger;
        }

        public IActionResult Epayment()
        {
            return View();
        }

        public IActionResult LineAccount()
        {
            return View();
        }

        public IActionResult CreditCard()
        {
            return View();
        }

        public IActionResult OnlineCard()
        {
            return View();
        }

        public IActionResult GiftCertificate()
        {
            return View();
        }

        public IActionResult POS()
        {
            return View();
        }

        public IActionResult SelfOrderMachine()
        {
            return View();
        }

        public IActionResult Unmanned()
        {
            return View();
        }
    }
}

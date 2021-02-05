using FutboClub.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FutboClub.web.Controllers
{
    public class EntradasController : Controller
    {
        // GET: Entradas
        public ActionResult Index()
        {
            var entrada1 = new EntradasModel();
            entrada1.Id = 1;
            entrada1.Descripcion = "VIP";

            var entrada2 = new EntradasModel();
            entrada2.Id = 2;
            entrada2.Descripcion = "Palco";

            var entrada3 = new EntradasModel();
            entrada3.Id = 3;
            entrada3.Descripcion = "Silla";

            var entrada4 = new EntradasModel();
            entrada4.Id = 4;
            entrada4.Descripcion = "Sol";

            var listadeentradas = new List<EntradasModel>();
            listadeentradas.Add(entrada1);
            listadeentradas.Add(entrada2);
            listadeentradas.Add(entrada3);
            listadeentradas.Add(entrada4);

            return View(listadeentradas);
        }
    }
}
using FutboClub.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FutboClub.web.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult Index()
        {
            var tienda1 = new TiendaModel();
            tienda1.Id = 1;
            tienda1.Descripcion = "Hombre";

            var tienda2 = new TiendaModel();
            tienda2.Id = 2;
            tienda2.Descripcion = "Mujer";

            var tienda3 = new TiendaModel();
            tienda3.Id = 3;
            tienda3.Descripcion = "Niño";

            var tienda4 = new TiendaModel();
            tienda4.Id = 4;
            tienda4.Descripcion = "Niña";

            var listadetienda = new List<TiendaModel>();
            listadetienda.Add(tienda1);
            listadetienda.Add(tienda2);
            listadetienda.Add(tienda3);
            listadetienda.Add(tienda4);

            return View(listadetienda);
        }
    }
}
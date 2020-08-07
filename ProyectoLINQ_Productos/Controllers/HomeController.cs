using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoLINQ_Productos.Controllers
{
    
    public class HomeController : Controller
    {
        //public var productos = new List<Models.Producto>();
        //var productos = new List<Models.Producto>();
        //public List<Models.Producto> productos = new List<Models.Producto>();
        public ActionResult Index()
        {
              return View();
        }
        
        public ActionResult ListarConI()
        {
            List<Models.Producto> productos = CargaDatos();
            var resultado = from Producto in productos
                            where Producto.Descripcion.Contains("I") || Producto.Descripcion.Contains("i")
                            select Producto;
            return View(resultado);
        }

        public ActionResult ListarInicioC()
        {
            List<Models.Producto> productos = CargaDatos();
            var resultado = from Producto in productos
                            where Producto.Descripcion.StartsWith("C") || Producto.Descripcion.StartsWith("c")
                            select Producto;
            return View(resultado);
        }

        public ActionResult ListarFinalO()
        {
            List<Models.Producto> productos = CargaDatos();
            var resultado = from Producto in productos
                            where Producto.Descripcion.EndsWith("O") || Producto.Descripcion.EndsWith("o")
                            select Producto;
            return View(resultado);
        }
        public ActionResult ListarMayor20()
        {
            List<Models.Producto> productos = CargaDatos();
            var resultado = from Producto in productos
                            where Producto.Precio > 20
                            select Producto;
            return View(resultado);
        }
        public ActionResult ListarMenor70()
        {
            List<Models.Producto> productos = CargaDatos();
            var resultado = from Producto in productos
                            where Producto.Precio < 70
                            select Producto;
            return View(resultado);
        }

        public List<Models.Producto> CargaDatos()
        {
            var productos = new List<Models.Producto>
            {
                new Models.Producto { Id = 1, Descripcion = "Bolígrafo", Precio = 8.35 },
                new Models.Producto { Id = 2, Descripcion = "Cuaderno Grande", Precio = 21.5 },
                new Models.Producto { Id = 3, Descripcion = "Cuaderno Pequeño", Precio = 10 },
                new Models.Producto { Id = 4, Descripcion = "Folios 500 Uds.", Precio = 550.55 },
                new Models.Producto { Id = 5, Descripcion = "Grapadora", Precio = 85.25 },
                new Models.Producto { Id = 6, Descripcion = "Tijeras", Precio = 62 },
                new Models.Producto { Id = 7, Descripcion = "Cinta Adhesiva", Precio = 45.10 },
                new Models.Producto { Id = 8, Descripcion = "Rotulador", Precio = 20.75 },
                new Models.Producto { Id = 9, Descripcion = "Mochila Escolar", Precio = 800.90 },
                new Models.Producto { Id = 10, Descripcion = "Pegamento Barra", Precio = 30.15 },
                new Models.Producto { Id = 11, Descripcion = "Lapicero", Precio = 15.55 },
                new Models.Producto { Id = 12, Descripcion = "Grapas", Precio = 40.90 }
            };
            return productos;
        }
    }
}
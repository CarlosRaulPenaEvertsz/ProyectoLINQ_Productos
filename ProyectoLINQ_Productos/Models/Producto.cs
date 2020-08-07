using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoLINQ_Productos.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }

}
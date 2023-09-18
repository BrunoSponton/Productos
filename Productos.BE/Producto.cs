using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.BE
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public string Listar()
        {
            string respuesta = Codigo + " - " + Nombre + " - " + Precio.ToString();
            return respuesta;
        }
    }
}

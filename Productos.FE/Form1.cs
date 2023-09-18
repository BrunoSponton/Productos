using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Productos.BE;

namespace Productos.FE
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            //instanciar el objeto producto de la clase Producto
            Producto producto;
            //inicializar el objeto producto
            producto = new Producto();

            producto.Codigo = txtcodigo.Text;
            producto.Nombre = txtnombre.Text;
            producto.Precio = Convert.ToDecimal(txtprecio.Text);

            lblresultado.Text = producto.Listar();

        }
    }
}

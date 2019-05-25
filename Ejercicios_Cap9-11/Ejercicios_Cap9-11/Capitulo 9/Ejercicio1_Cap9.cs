using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Cap9_11.Capitulo_9
{
    public partial class Ejercicio1_Cap9 : Form
    {
        public Ejercicio1_Cap9()
        {
            InitializeComponent();
        }

        public struct Productos
        {
            public string Nombre;
            public int Precio;
            public int Cantidad;


            public Productos(string pNombre, int pPrecio, int pCantidad)
            {
                Nombre = pNombre;
                Precio = pPrecio;
                Cantidad = pCantidad;
            }
        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            if(NombreProducto_textBox.Text == string.Empty|| PrecioProducto_numericUpDown.Value <= 0|| CantidadProducto_numericUpDown.Value <= 0)
            {
                MessageBox.Show("No puede dejar campos Vacios","Fallo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string nombre = Convert.ToString(NombreProducto_textBox.Text);
                int precio = Convert.ToInt32(PrecioProducto_numericUpDown.Value);
                int cantidad = Convert.ToInt32(CantidadProducto_numericUpDown.Value);

                Productos producto = new Productos(nombre, precio, cantidad);
                MessageBox.Show("El producto se guardo correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        //Productos[] Producto = new Productos[];
    }
}

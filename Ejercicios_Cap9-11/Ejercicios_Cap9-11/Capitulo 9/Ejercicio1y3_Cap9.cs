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
    public partial class Ejercicio1y3_Cap9 : Form
    {
        public Ejercicio1y3_Cap9()
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

        public struct Mascotas
        {
            public string NombreMascota;
            public string Especie;

            public string NombreD;
            public string Edad;
            public string Cedula;

            public Mascotas(string pNombreMascota,string pEspecie,string pNombreD,string pEdad,string pCedula)
            {
                NombreMascota = pNombreMascota;
                Especie = pEspecie;
                NombreD = pNombreD;
                Edad = pEdad;
                Cedula = pCedula;
            }
        }

 
        
        private void Limpiar1()
        {
            NombreProducto_textBox.Text = string.Empty;
            PrecioProducto_numericUpDown.Value = 0;
            CantidadProducto_numericUpDown.Value = 0;
        }

        private void Limpiar2()
        {
            mNombre_textBox.Text = string.Empty;
            mEspecie_textBox.Text = string.Empty;
            dNombre_textBox.Text = string.Empty;
            dEdad_textBox.Text = string.Empty;
            dCedula_maskedTextBox.Text = string.Empty;
        }

        private void Nuevo1_button_Click(object sender, EventArgs e)
        {
            Limpiar1();
        }

        private void Nuevo2_button_Click(object sender, EventArgs e)
        {
            Limpiar2();
        }

        private void Guardar1_button_Click(object sender, EventArgs e)
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
                Limpiar1();
                MessageBox.Show("El producto se guardo correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Guardar2_button_Click(object sender, EventArgs e)
        {
            if (mNombre_textBox.Text == string.Empty || mEspecie_textBox.Text == string.Empty|| dNombre_textBox.Text == string.Empty|| dEdad_textBox.Text == string.Empty|| string.IsNullOrWhiteSpace(dCedula_maskedTextBox.Text))
            {
                MessageBox.Show("No puede dejar campos Vacios", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                //utilizo M o D para indicar que dicho campo pertenece al dueño o la mascota
                string nombreM = Convert.ToString(mNombre_textBox.Text);
                string especieM = Convert.ToString(mEspecie_textBox.Text);
                string nombreD = Convert.ToString(dNombre_textBox.Text);
                string edadD = Convert.ToString(dEdad_textBox.Text);
                string cedulaD = Convert.ToString(dCedula_maskedTextBox.Text);

                Mascotas mascota = new Mascotas(nombreM,especieM,nombreD,edadD,cedulaD);
                Limpiar2();
                MessageBox.Show("La Mascota y su Dueño se guardaron correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

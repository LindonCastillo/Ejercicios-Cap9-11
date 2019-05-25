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

        int cont1 = 0;
        int cont2 = 0;
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
        Productos[] Producto = new Productos[50];

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
        Mascotas[] Mascota = new Mascotas[50];

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

                Producto[cont1].Nombre = nombre;
                Producto[cont1].Precio = precio;
                Producto[cont1].Cantidad = cantidad;
                cont1++;
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

                Mascota[cont2].NombreMascota = nombreM;
                Mascota[cont2].Especie = especieM;
                Mascota[cont2].NombreD = nombreD;
                Mascota[cont2].Edad = edadD;
                Mascota[cont2].Cedula = cedulaD;
                cont2++;
                Limpiar2();
                MessageBox.Show("La Mascota y su Dueño se guardaron correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void LlenarCampos1(int indice)
        {
            NombreProducto_textBox.Text = Producto[indice].Nombre;
            PrecioProducto_numericUpDown.Value = Producto[indice].Precio;
            CantidadProducto_numericUpDown.Value = Producto[indice].Cantidad;
        }

        private void LlenarCampos2(int indice)
        {
            mNombre_textBox.Text = Mascota[indice].NombreMascota;
            mEspecie_textBox.Text = Mascota[indice].Especie;
            dNombre_textBox.Text = Mascota[indice].NombreD;
            dEdad_textBox.Text = Mascota[indice].Edad;
            dCedula_maskedTextBox.Text = Mascota[indice].Cedula;
        }

        private void Buscar1_button_Click(object sender, EventArgs e)
        {
            bool existe = false;
            int ind = 0;
            string nombreP = Convert.ToString(NombreProducto_textBox.Text); 
           for(int i=0; i<cont1; i++)
           {
                if(nombreP == Producto[i].Nombre)
                {
                    existe = true;
                    ind = i;
                    break;
                }
           }

           if(existe == false)
           {
                MessageBox.Show("Este producto no existe", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           else
           {
                LlenarCampos1(ind);
                MessageBox.Show("Se encontro el producto", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

        }

        private void Buscar2_button_Click(object sender, EventArgs e)
        {
            bool existe = false;
            int ind = 0;
            string nombreM = Convert.ToString(mNombre_textBox.Text);
            for (int i = 0; i < cont1; i++)
            {
                if (nombreM == Mascota[i].NombreMascota)
                {
                    existe = true;
                    ind = i;
                    break;
                }
            }

            if (existe == false)
            {
                MessageBox.Show("Este dueño y mascota no existe", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LlenarCampos2(ind);
                MessageBox.Show("Se encontro el dueño y mascota", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

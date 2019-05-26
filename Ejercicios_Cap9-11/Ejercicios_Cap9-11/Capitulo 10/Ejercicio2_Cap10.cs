using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Cap9_11.Capitulo_10
{
    public partial class Ejercicio2_Cap10 : Form
    {
        public Ejercicio2_Cap10()
        {
            InitializeComponent();
        }

        int cont = 0;

        class Estudiante
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Matricula { get; set; }
            public string Carrera { get; set; }

            public Estudiante()
            {
                Nombre = string.Empty;
                Edad = 0;
                Matricula = string.Empty;
                Carrera = string.Empty;
            }
        }

        Estudiante[] estudiantes = new Estudiante[50];

        private void Limpiar()
        {
            Nombre_textBox.Text = string.Empty;
            Edad_numericUpDown.Value = 0;
            Matricula_maskedTextBox.Text = string.Empty;
            Carrera_textBox.Text = string.Empty;
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Guardar_button_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(Matricula_maskedTextBox.Text)|| string.IsNullOrEmpty(Nombre_textBox.Text)|| Edad_numericUpDown.Value <=0 || string.IsNullOrEmpty(Carrera_textBox.Text))
            {
                MessageBox.Show("No puede dejar campos Vacios", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nombre = Convert.ToString(Nombre_textBox.Text);
                int edad = Convert.ToInt16(Edad_numericUpDown.Value);
                string matricula = Convert.ToString(Matricula_maskedTextBox.Text);
                string carrera = Convert.ToString(Carrera_textBox.Text);

                

                Estudiante obj = new Estudiante();
                obj.Nombre = nombre;
                obj.Edad = edad;
                obj.Matricula = matricula;
                obj.Carrera = carrera;

                estudiantes[cont] = obj;
                Limpiar();
                cont++;
                MessageBox.Show("El estudiante se guardo correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LlenarCampos(int indice)
        {
            Matricula_maskedTextBox.Text = estudiantes[indice].Matricula;
            Nombre_textBox.Text = estudiantes[indice].Nombre;
            Edad_numericUpDown.Value = estudiantes[indice].Edad;
            Carrera_textBox.Text = estudiantes[indice].Carrera;
        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty( Matricula_maskedTextBox.Text))
            {
                MessageBox.Show("Inserte la matricula del estudiante", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Estudiante est;
                bool existe = false;
                int ind = 0;
                string matricula = Convert.ToString(Matricula_maskedTextBox.Text);
                for (int i = 0; i < cont; i++)
                {
                    if (matricula == estudiantes[i].Matricula)
                    {
                        existe = true;
                        ind = i;
                        break;
                    }
                }

                if (existe == false)
                {
                    MessageBox.Show("Este estudiante no existe", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LlenarCampos(ind);
                    MessageBox.Show("Se encontro el estudiante", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }


}

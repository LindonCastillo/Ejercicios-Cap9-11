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

        }
        private void Nuevo_button_Click(object sender, EventArgs e)
        {

        }
        private void Guardar_button_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {

        }
    }


}

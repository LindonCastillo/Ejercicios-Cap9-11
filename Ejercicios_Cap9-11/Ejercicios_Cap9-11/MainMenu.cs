using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicios_Cap9_11.Capitulo_9;

namespace Ejercicios_Cap9_11
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio1_Cap9 Ej1_Cap9 = new Ejercicio1_Cap9();
            Ej1_Cap9.Show();
        }

    }
}

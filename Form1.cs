using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionLibrosWinForms;

namespace DAS_Def_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PrestDevol_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Prestadevo
            GestionLibrosWinForms.Form1 formularioForm1 = new GestionLibrosWinForms.Form1();

            // Mostrar el nuevo formulario
            formularioForm1.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

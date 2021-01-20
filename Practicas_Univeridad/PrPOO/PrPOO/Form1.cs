using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnobj1_Click(object sender, EventArgs e)
        {
            perro perrito = new perro();
            perrito.Nombre = "Chizu";
            perrito.Raza = "Pastor Aleman";
            perrito.Altura = "0.50.cm";

            txtresultado.Text= perrito.comer("carne");

        }

        private void btnobj2_Click(object sender, EventArgs e)
        {
            perro perrito = new perro();
            perrito.Nombre = "Lazy";
            perrito.Raza = "";
            perrito.Altura = "0.70.cm";

            txtresultado.Text = perrito.comer("Pollo");
        }

        private void btnobj_Click(object sender, EventArgs e)
        {
            perro perrito = new perro("Peluchin", "Poodle", "0.60 cm");
            txtresultado.Text = perrito.comer("Pan");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRArraysVector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncvector_Click(object sender, EventArgs e)
        {
            //Declaracion de Variables
            int[] notas = new int[5];
            //Especificamos las notas
            notas[0] = 15;
            notas[1] = 13;
            notas[2] = 11;
            notas[3] = 16;
            notas[4] = 18;
            int suma = 0;
            double promedio;
            //Proceso
            cbonotas.Items.Clear();
            //Recorrer el vector
            for(int i=0;i<=4;i++)
            {
                //Mostrar las notas en el combobox
                cbonotas.Items.Add(notas[i]);
                suma += notas[i];
            }
            promedio = suma / 5;
            //Salida de la informacion
            txtpromedio.Text = Convert.ToString(promedio);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtpromedio.Clear();
            cbonotas.Items.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

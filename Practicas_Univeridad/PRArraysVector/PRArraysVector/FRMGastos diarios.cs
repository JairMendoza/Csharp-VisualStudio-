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
    public partial class FRMGastos_diarios : Form
    {
        public FRMGastos_diarios()
        {
            InitializeComponent();
        }

        private void FRMGastos_diarios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaracuon de variables
            double[] vgastos;
            double gasto, tgasto = 0, diamayor = 1, gastomayor = 0;
            int cantdias;
            //Empezamosa leer los gastos
            cantdias = Convert.ToInt32(txtdias.Text);
            vgastos = new double[cantdias];//Aqui le decimos la cantidad de vectores que tendra la matriz
            for (int dia = 1; dia <= cantdias; dia++)
            {
                gasto = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el Gasto del dia " + dia, "Gastos"));
                vgastos[dia - 1] = gasto;
            }
            for (int i = 0; i < cantdias; i++)
            {
                //Evaluamos el gasto mayor
                if (vgastos[i] > gastomayor)
                {
                    gastomayor = vgastos[i];
                    diamayor = i + 1;
                }
                //Calculamos el total
                tgasto += vgastos[i];
                //Mostrar los gastos en el combobox
                cbogastos.Items.Add("Dia " + (i + 1) + "Total " + vgastos[i]);
            }
            //Mostrar la informacion
            txtgastomayor.Text = Convert.ToString(gastomayor);
            txtdiamayor.Text = Convert.ToString(diamayor);
            txttotalgastos.Text = Convert.ToString(tgasto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txttotalgastos.Clear();
            txtgastomayor.Clear();
            txtdias.Clear();
            txtdiamayor.Clear();
            cbogastos.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

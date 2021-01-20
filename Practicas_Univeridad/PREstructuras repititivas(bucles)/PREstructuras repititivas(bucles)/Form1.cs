using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PREstructuras_repititivas_bucles_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            double numero, suma, resta, multiplicacion, divicion;
            //Entrada de datos
            numero = Convert.ToDouble(txtnumero.Text);
            //Proceso
            //Dejamos en blanco los combobox
            cbodivis.Items.Clear();
            cbomulti.Items.Clear();
            cboresta.Items.Clear();
            cbosuma.Items.Clear();
            //Creamos Bucle para poder crear la tabla
            for(int i=1;i<=12;i++)
            {
                suma = numero + i;
                resta = numero - i;
                multiplicacion = numero * i;
                divicion = numero / i;
                //Agregamos los resultados a las combobox
                cbosuma.Items.Add( numero+" + "+i+" = " + suma);
                cboresta.Items.Add(numero + " - " + i + " = " + resta);
                cbomulti.Items.Add(numero + " x " + i + " = " + multiplicacion);
                cbodivis.Items.Add(numero + " / " + i + " = " + divicion);

            }


        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            cbodivis.Items.Clear();
            cbomulti.Items.Clear();
            cboresta.Items.Clear();
            cbosuma.Items.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrGestionAhorros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            desactivarcontroles();
        }
        private Double monto;
        private void activarcontroles()
        {
            txtCliente.Enabled = false;
            txtmonto.Enabled = false;
            btnabrir.Enabled = false;

            btndeposito.Enabled = true;
            btnretiro.Enabled = true;
        }
        private void desactivarcontroles()
        {
            txtCliente.Enabled = true;
            txtmonto.Enabled = true;
            btnabrir.Enabled = true;

            btndeposito.Enabled = false;
            btnretiro.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            string cliente;
            //Leer Datos
            cliente = txtCliente.Text;
            monto = Convert.ToDouble(txtmonto.Text);
            if(monto>0)
            {
                activarcontroles();
            }
            else
            {
                MessageBox.Show("El Monto debe ser mayor o igual que cero.", "Gestion de Ahorros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double leer(string mensaje)
        {
            double cantidad;
            cantidad = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese monto a " + mensaje, "Gestion de Ahorros", "0", 100, 0));
            return cantidad;
            
        }

        private void btndeposito_Click(object sender, EventArgs e)
        {
            Double deposito;
            deposito = leer("Depositar");
            monto += deposito;
            lstdepositos.Items.Add(deposito);
            mostrar();
        }
        private void mostrar()
        {
            txtsaldo.Text = Convert.ToString(monto);
        }

        private void btnretiro_Click(object sender, EventArgs e)
        {
            double retiro;
            retiro = leer("Retirar");
            //Evaluamos
            if(retiro<=monto)
            {
                monto -= retiro;
                lstretiros.Items.Add(retiro);
                mostrar();
            }
            else
            {
                MessageBox.Show("La cantidad de retiro es mayor al monto disponible.", "Gestion de Ahorros.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtmonto.Clear();
            txtsaldo.Clear();
            lstdepositos.Items.Clear();
            lstretiros.Items.Clear();
            desactivarcontroles();
        }
    }
}

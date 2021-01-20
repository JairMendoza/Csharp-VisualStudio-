using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRCuadro_de_mensaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            //Declaracio de variables 
            string nombre;
            //Entrada de datos
            nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nombre: ","Registro de Datos","Juan Carlos",100,0);
            MessageBox.Show("Bienvenido Usuario: " + nombre, "Sistema Administrativo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Realmente Desea Salir del Programa?","Salir Del Programa",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(opcion==DialogResult.OK)
            {
                Close();
            }

        }
    }
}

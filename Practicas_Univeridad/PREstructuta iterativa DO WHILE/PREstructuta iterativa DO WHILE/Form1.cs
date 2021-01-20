using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PREstructuta_iterativa_DO_WHILE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int cantalumnos, nota;
            double promedio = 0;
            //Entrada de datos
            cantalumnos = Convert.ToInt32(txtcalumnos.Text);
            //Proceso
            //Implementar un bucle for para pedir la nota de los alumnos
            for(int i=1;i<=cantalumnos;i++)
            {
                //Leer la nota del alumno i
                do
                {
                    nota = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nota del Alumno "+i,"Registro Notas"));

                } while (nota < 0 || nota > 20);
                promedio += nota;
            }
            //Salida de la informacion
            txtpromedio.Text =Convert.ToString (promedio / cantalumnos);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtpromedio.Clear();
            txtcalumnos.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

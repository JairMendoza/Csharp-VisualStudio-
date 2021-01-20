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
    public partial class FRMNOTAS : Form
    {
        public FRMNOTAS()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de Variables
            int numalumnos;
            double promedio, nbaja,sumanotas,nota;
            if(txtnalumnos.Text!="")
            {
                //Entrada de datos
                numalumnos = Convert.ToInt32(txtnalumnos.Text);
                //Inicializar las variables
                sumanotas = 0.0;
                nbaja = 20.0;
                for(int i=1;i<=numalumnos;i+=1)
                {
                    nota = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nota del Alumno" +i,"Promedio Notas","16",100,100));
                    sumanotas += nota;
                    if(nota<nbaja)
                    {
                        nbaja = nota;
                    }
                }
                promedio = sumanotas / numalumnos;
                //Salida de la informacion
                txtpromedio.Text = Convert.ToString(promedio);
                txtnbaja.Text = Convert.ToString(nbaja);
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido","Promedio de Notas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnalumnos.Clear();
            txtnbaja.Clear();
            txtpromedio.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

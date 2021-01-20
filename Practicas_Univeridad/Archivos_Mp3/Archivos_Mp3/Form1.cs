using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WMPLib;
using System.Media;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using AxWMPLib;

namespace Archivos_Mp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtartista.ReadOnly = true;
            txtaño.ReadOnly = true;
            txttitulo.ReadOnly = true;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtaño.Clear();
            txtartista.Clear();
            txtbartista.Clear();
            txtbaño.Clear();
            txtbtitulo.Clear();
            txttitulo.Clear();
            txtbtitulo.Clear();
            axWindowsMediaPlayer2.close();
        }

        public void btnbuscar_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();//Conectamos con la DB
            String btitulo, bartista,baño;
            if (txtbtitulo.Text==""&&txtbaño.Text==""&&txtbartista.Text=="")
            {
                MessageBox.Show("No has Ingresado ningun Metodo de Busqueda. "  ,"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btitulo = txtbtitulo.Text;
                bartista = txtbartista.Text;
                baño = txtbaño.Text;
                MySqlDataReader reader;
                //Comandos Para las Busquedas
                MySqlCommand comandot = new MySqlCommand(string.Format("select * from archivos_mp3_v2.canciones where Titulo='{0}';", btitulo), Conexion.ObtenerConexion());
                MySqlCommand comandoa = new MySqlCommand(string.Format("select * from archivos_mp3_v2.canciones where Nombre_Artista='{0}';", bartista), Conexion.ObtenerConexion());
                MySqlCommand comandol = new MySqlCommand(string.Format("select * from archivos_mp3_v2.canciones where Año_Lanzamiento='{0}';", baño), Conexion.ObtenerConexion());
                if (txtbaño.Text == "" && txtbartista.Text == "")
                {
                    reader = comandot.ExecuteReader();
                    while (reader.Read())
                    {
                        txttitulo.Text = reader.GetString(1);
                        txtartista.Text = reader.GetString(2);
                        txtaño.Text = Convert.ToString(reader.GetString(3));
                        axWindowsMediaPlayer2.URL = reader.GetString(4);
                    }
                }
                if (txtbtitulo.Text == "" && txtbaño.Text =="")
                {
                    reader = comandoa.ExecuteReader();
                    while (reader.Read())
                    {
                        txttitulo.Text = reader.GetString(1);
                        txtartista.Text = reader.GetString(2);
                        txtaño.Text = Convert.ToString(reader.GetString(3));
                        axWindowsMediaPlayer2.URL = reader.GetString(4);
                    }
                }
                if(txtbartista.Text==""&&txtbtitulo.Text=="")
                {
                    reader = comandol.ExecuteReader();
                    while (reader.Read())
                    {
                        txttitulo.Text = reader.GetString(1);
                        txtartista.Text = reader.GetString(2);
                        txtaño.Text = Convert.ToString(reader.GetString(3));
                        axWindowsMediaPlayer2.URL = reader.GetString(4);
                    }
                }
                if(txtbtitulo.Text!=""&&txtbartista.Text!=""&&txtbaño.Text!=""||txtbtitulo.Text!=""&&txtbartista.Text!=""||txtbtitulo.Text!=""&&txtbaño.Text!=""||txtbaño.Text!=""&&txtbartista.Text!="")
                {
                    MessageBox.Show("No puedes agregar mas de un metodo de busqueda.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {
           
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}

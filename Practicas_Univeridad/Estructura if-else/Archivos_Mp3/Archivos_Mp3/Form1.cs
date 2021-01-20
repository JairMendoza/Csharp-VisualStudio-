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
        WindowsMediaPlayer audio;
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
            //Limpiar boton de musica
        }

        public void btnbuscar_Click(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();//Conectamos con la DB
            String btitulo, bartista,baño;
            if (txtbtitulo.Text==""&&txtbaño.Text==""&&txtbartista.Text=="")
            {
                MessageBox.Show("No has Ingresado ningun Metodo de Busqueda: "  ,"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btitulo = txtbtitulo.Text;
                bartista = txtbartista.Text;
                baño = txtbaño.Text;
                DataSet ds = new DataSet();
                
                byte [] datos = new byte[0];
                MySqlDataReader reader;
                //Comandos Para las Busquedas
                DataRow dr;
                MySqlCommand comandot = new MySqlCommand(string.Format("select * from archivos_mp3_v2.canciones where Titulo='{0}';", btitulo), Conexion.ObtenerConexion());
                MySqlCommand comandoa = new MySqlCommand(string.Format("select * from archivos_mp3_v2.canciones where Nombre_Artista='{0}';", bartista), Conexion.ObtenerConexion());
                MySqlCommand comandol = new MySqlCommand(string.Format("select * from archivos_mp3_v2.canciones where Año_Lanzamiento='{0}';", baño), Conexion.ObtenerConexion());
                //MySqlCommand comandomp3 = new MySqlCommand(string.Format("select Cancion from archivos_mp3_v2.canciones where Titulo='{0}';", btitulo), Conexion.ObtenerConexion());
                //MySqlCommand comandomp32 = new MySqlCommand(string.Format("select Cancion from archivos_mp3_v2.canciones where Nombre_Artista='{0}';", bartista), Conexion.ObtenerConexion());
                //MySqlCommand comandomp33 = new MySqlCommand(string.Format("select Cancion from archivos_mp3_v2.canciones where Año_Lanzamiento='{0}';", baño), Conexion.ObtenerConexion());
                //MySqlCommand mp3 = new MySqlCommand(string.Format("select Cancion from archivos_mp3_v2.canciones where Cancion='{0}';"));
                //Comandos para el archivo mp3
                //MySqlDataAdapter mp3_adap = new MySqlDataAdapter(comandomp3);
                //mp3_adap.Fill(ds, "canciones");
                //dr = ds.Tables["canciones"].Rows[0];
                //datos = (byte[])dr["Cancion"];
                //MySqlDataReader dataReader;
                //System.IO.MemoryStream ms = new System.IO.MemoryStream( datos);
                if (txtbaño.Text == "" && txtbartista.Text == "")
                {
                    reader = comandot.ExecuteReader();
                    //dataReader = comandomp3.ExecuteReader();
                    while (reader.Read())
                    {
                        txttitulo.Text = reader.GetString(1);
                        txtartista.Text = reader.GetString(2);
                        txtaño.Text = Convert.ToString(reader.GetString(3));
                        //txtgenero.Text = reader.GetString(4);
                        //turl.Text = reader.GetString(5);
                        axWindowsMediaPlayer2.URL = reader.GetString(4);
                        //btnplay.Equals(ms);
                        //axWindowsMediaPlayer2.=  ms;
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
                        axWindowsMediaPlayer2.URL= reader.GetString(4);
                        //ptbfoto.Image = System.Drawing.Bitmap.FromStream(ms);
                    }
                }
                else
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
            }
        }

        private void btnreproducir_Click(object sender, EventArgs e)
        {
            MySqlCommand comandomp3 = new MySqlCommand(string.Format("select Cancion from archivos_mp3_v2.canciones where Titulo='{0}';", txttitulo.Text), Conexion.ObtenerConexion());
            WindowsMediaPlayer cancion = new WindowsMediaPlayer();
            cancion.URL = Application.StartupPath + Convert.ToString( comandomp3);
            cancion.controls.play();
            //System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            //WindowsMediaPlayer wplayer = new WindowsMediaPlayer();


            //wplayer.URL = "My MP3 file.mp3";
            //wplayer.controls.play();



        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {
            //audio.URL = txturl.Text;
            axWindowsMediaPlayer2.Ctlcontrols.play();
      
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}

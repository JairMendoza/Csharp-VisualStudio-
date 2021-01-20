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
namespace Amigos_Fb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtbuscar.Clear();
            txtnombre.Clear();
            txturl.Clear();
            txtmail.Clear();
            txtedad.Clear();
            txtciudad.Clear();
            txtap.Clear();
            txtam.Clear();
            ptbfoto.Image = null;
        }

        public void btnbuscar_Click(object sender, EventArgs e)
        {
            string nombre;
            DataSet ds = new DataSet();
            byte[] datos = new byte[0];
            DataRow dr;
            Conexion.ObtenerConexion();
            nombre = txtbuscar.Text;
            MySqlCommand comando = new MySqlCommand(string.Format("select * from BD_Amigos.amigo where Nombre='{0}';",nombre),Conexion.ObtenerConexion());
            MySqlDataReader reader = comando.ExecuteReader();
            MySqlCommand comandofoto = new MySqlCommand(string.Format("select Foto from BD_Amigos.amigo where Nombre='{0}';", nombre), Conexion.ObtenerConexion());
            MySqlDataAdapter foto_adap = new MySqlDataAdapter(comandofoto);
            foto_adap.Fill(ds, "amigo");
            dr = ds.Tables["amigo"].Rows[0];
            datos = (byte[])dr["Foto"];
            System.IO.MemoryStream ms = new System.IO.MemoryStream(datos);
            while (reader.Read())
            {
                txtnombre.Text = reader.GetString(1);
                txtap.Text = reader.GetString(2);
                txtam.Text = reader.GetString(3);
                txtmail.Text = reader.GetString(4);
                txtedad.Text = Convert.ToString( reader.GetInt32(5));
                txtciudad.Text = reader.GetString(6);
                txturl.Text = reader.GetString(7);
                ptbfoto.Image = System.Drawing.Bitmap.FromStream(ms);
            }

        }
    }
}

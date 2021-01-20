using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algoritmos
{

    public partial class Form1 : Form
    {
        int proceso = 0,algoritmo=0,vacio=0,cuantum=0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbo_n_procesos_SelectedIndexChanged(object sender, EventArgs e)
        {
            proceso = 0;
            proceso = Convert.ToInt32(cbo_n_procesos.Text);
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            for (int i = 0; i < proceso; i++)
            {
                dataGridView1.Rows.Insert(i, "p" + (i + 1));
                dataGridView2.Rows.Insert(i, "p" + (i + 1));
            }
            for(int p=0;p<proceso;p++)
            {
                dataGridView1.Rows[p].Cells["Tiempo_llegada"].Value = " ";
                dataGridView1.Rows[p].Cells["Tiempo_Servicio"].Value = " ";
            }
            if (cbo_algoritmo.Text != "" && cbo_n_procesos.Text != "")
            {
                btn_ver.Enabled = true;
            }
        }

        private void tab_procesos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vacio = 0;

            for (int y = 0; y < proceso; y++)
            {
                if (dataGridView1.Rows[y].Cells["Tiempo_llegada"].Value.ToString() == " ")
                {
                    vacio = 1;
                }
                if (dataGridView1.Rows[y].Cells["Tiempo_Servicio"].Value.ToString() == " ")
                {
                    vacio = 1;
                }
            }
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            vacio = 0;

            for (int y = 0; y < proceso; y++)
            {
                if (dataGridView1.Rows[y].Cells["Tiempo_llegada"].Value.ToString() == " ")
                {
                    vacio = 1;
                }
                if (dataGridView1.Rows[y].Cells["Tiempo_Servicio"].Value.ToString() == " ")
                {
                    vacio = 1;
                }
            }
            if (vacio == 1)
            {
                MessageBox.Show("Debe de llenar todos los campos de la primera tabla.");
            }
            else
            {

                if (algoritmo == 1)
                {
                    int nproceso = 0, tproceso = 0, suma = 0, ban = 0, z = 0, x = 0, indice = 0,indicerep=0,repetido1=0,bandera=0;
                    int tllegada = 0, tservicio = 0, cont = 0, cont2 = 0,mas=0, primero = 0, cont3 = 0, numindice = 0, numero = 0,repetido=0,banrepetido=0;
                    int[] vector = new int[proceso];
                    int[] vectort = new int[proceso];
                    string comp;
                    DataGridViewColumn dtCol = new DataGridViewColumn();
                    for (int y = 0; y < proceso; y++)
                    {
                        nproceso = Convert.ToInt32(this.dataGridView1.Rows[y].Cells["Tiempo_llegada"].Value.ToString());
                        vector[y] = nproceso;
                        tproceso = Convert.ToInt32(this.dataGridView1.Rows[y].Cells["Tiempo_Servicio"].Value.ToString());
                        vectort[y] = tproceso;
                    }
                    for (int p = 0; p < vector.Length;p++)
                    {
                        if(vector[p]>10)
                        {
                            mas = 1;
                        }
                    }
                    if (mas == 1)
                    {
                        MessageBox.Show("No se admiten numeros mayores a 10");
                    }
                    else
                    {
                        mas = 0;
                        //////////////////////////Metodo Burbuja
                        int t;
                        for (int a = 1; a < vector.Length; a++)
                            for (int b = vector.Length - 1; b >= a; b--)
                            {
                                if (vector[b - 1] > vector[b])
                                {
                                    t = vector[b - 1];
                                    vector[b - 1] = vector[b];
                                    vector[b] = t;
                                }
                            }
                        for (int q = 0; q < vector.Length; q++)
                        {
                            int d = 0;
                            d = (vector[q]);

                        }
                        ///////////////////////Termina Metodo Burbuja
                        for (int f = 0; f < vectort.Length; f++)
                        {
                            suma += vectort[f];
                        }
                        for (int f = 0; f < 40; f++)
                        {
                            dataGridView2.Columns.Add(Convert.ToString(f), Convert.ToString(f + 1));
                            this.dataGridView2.AutoResizeColumns();
                        }
                        for (int r = 0; r < vector.Length - 1; r++)
                        {
                            repetido = vector[r];
                            tllegada = vector[r + 1];
                            if (repetido == tllegada)
                            {
                                banrepetido++;
                                repetido1 = repetido;
                            }
                        }
                        repetido = 0;
                        do
                        {
                            for (int y = 0; y < vector.Length; y++)
                            {
                                primero = vector[0];
                                tllegada = Convert.ToInt32(dataGridView1.Rows[y].Cells[1].Value);
                                tservicio = Convert.ToInt32(dataGridView1.Rows[y].Cells[2].Value);
                                if (tllegada == vector[cont])
                                {
                                    for (int r = 0; r < vector.Length; r++)
                                    {
                                        if (tllegada == Convert.ToInt32(dataGridView1.Rows[r].Cells["Tiempo_LLegada"].Value))
                                        {
                                            if (banrepetido == 0)
                                            {
                                                indice = r;
                                                r = 10;
                                                cont++;

                                            }
                                            else
                                            {
                                                if (repetido1 != tllegada)
                                                {
                                                    indice = r;
                                                    r = 10;
                                                    cont++;

                                                }
                                                else if (indicerep == 0)
                                                {
                                                    indice = r;
                                                    r = 10;
                                                    cont++;
                                                    indicerep++;

                                                }
                                                else
                                                {
                                                    if (bandera == 1)
                                                    {
                                                        indice = r;
                                                        r = 10;
                                                        cont++;
                                                        y = 0;
                                                    }
                                                    else if (bandera == 4)
                                                    {
                                                        indice = r;
                                                        r = 10;
                                                        cont++;
                                                        //bandera++;
                                                        y = 0;
                                                    }
                                                    else if (bandera == 6)
                                                    {
                                                        indice = r;
                                                        r = 10;
                                                        cont++;
                                                        //bandera++;
                                                        y = 0;
                                                    }
                                                    bandera++;
                                                }
                                            }

                                        }
                                    }
                                    if (cont2 + primero > tllegada)
                                    {
                                        cont3 = cont2;
                                        for (int q = 0; q < tservicio; q++)
                                        {
                                            dataGridView2.Rows[indice].Cells[(numindice + 1)].Value = "X";
                                            cont2++;
                                            numindice++;
                                        }
                                    }
                                    else if (numindice > cont2 + primero)
                                    {
                                        for (int q = 0; q < tservicio; q++)
                                        {
                                            dataGridView2.Rows[indice].Cells[(numindice + 1) + q].Value = "X";
                                            cont2++;
                                            numero++;
                                        }
                                        numindice += numero;
                                    }
                                    else if (tllegada == numindice)
                                    {
                                        for (int q = 0; q < tservicio; q++)
                                        {
                                            dataGridView2.Rows[indice].Cells[(numindice + 1)].Value = "X";
                                            cont2++;
                                            numindice++;
                                            numero++;
                                        }
                                    }
                                    else
                                    {
                                        for (int q = 0; q < tservicio; q++)
                                        {
                                            dataGridView2.Rows[indice].Cells[tllegada + q].Value = "X";
                                            cont2++;
                                            numindice = tllegada + q;
                                        }
                                    }
                                    if (cont == vector.Length)
                                    {
                                        ban = 1;
                                        break;
                                    }
                                }
                            }
                        } while (ban != 1);
                    }
                }///fin if algoritmo FCFS/////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                if (algoritmo == 2)
                {
                    int nproceso = 0, tproceso = 0, suma = 0, ban = 0, z = 0, x = 0, indice = 0, indicerep = 0, repetido1 = 0, bandera = 0, tservicio2 = 0, tservicio3 = 0, band = 0 ;
                    int tllegada = 0, tservicio = 0, cont = 0, cont2 = 0, mas=0,primero = 0, cont3 = 0, numindice = 0, numero = 0, repetido = 0, banrepetido = 0,bandera2=0;
                    int[] vector = new int[proceso];
                    int[] vectort = new int[proceso];
                    int[] vector2 = new int[proceso];
                    string comp;
                    DataGridViewColumn dtCol = new DataGridViewColumn();
                    for (int y = 0; y < proceso; y++)
                    {
                        nproceso = Convert.ToInt32(this.dataGridView1.Rows[y].Cells["Tiempo_llegada"].Value.ToString());
                        vector[y] = nproceso;
                        nproceso = Convert.ToInt32(this.dataGridView1.Rows[y].Cells["Tiempo_llegada"].Value.ToString());
                        vector2[y] = nproceso;
                        tproceso = Convert.ToInt32(this.dataGridView1.Rows[y].Cells["Tiempo_Servicio"].Value.ToString());
                        vectort[y] = tproceso;
                    }
                    for (int p = 0; p < vector.Length; p++)
                    {
                        if (vector[p] > 10)
                        {
                            mas = 1;
                        }
                    }
                    if (mas == 1)
                    {
                        MessageBox.Show("No se admiten numeros mayores a 10");
                    }
                    else
                    {
                        mas = 0;
                        //////////////////////////Metodo Burbuja
                        int t;
                        for (int a = 1; a < vector.Length; a++)
                            for (int b = vector.Length - 1; b >= a; b--)
                            {
                                if (vector[b - 1] > vector[b])
                                {
                                    t = vector[b - 1];
                                    vector[b - 1] = vector[b];
                                    vector[b] = t;
                                }
                            }
                        for (int q = 0; q < vector.Length; q++)
                        {
                            int d = 0;
                            d = (vector[q]);

                        }
                        ///////////////////////Termina Metodo Burbuja
                        for (int f = 0; f < vectort.Length; f++)
                        {
                            suma += vectort[f];
                        }
                        for (int f = 0; f < 40; f++)
                        {
                            dataGridView2.Columns.Add(Convert.ToString(f), Convert.ToString(f + 1));
                            this.dataGridView2.AutoResizeColumns();
                        }
                        for (int r = 0; r < vector.Length - 1; r++)
                        {
                            repetido = vector[r];
                            tllegada = vector[r + 1];
                            if (repetido == tllegada)
                            {
                                banrepetido++;
                                repetido1 = repetido;
                            }
                        }
                        repetido = 0;
                        do
                        {
                            for (int y = 0; y < vector.Length; y++)
                            {
                                primero = vector[0];
                                tllegada = Convert.ToInt32(dataGridView1.Rows[y].Cells[1].Value);
                                tservicio = Convert.ToInt32(dataGridView1.Rows[y].Cells[2].Value);
                                if (tllegada == vector[cont])
                                {
                                    for (int r = 0; r < vector.Length; r++)
                                    {
                                        if (tllegada == Convert.ToInt32(dataGridView1.Rows[r].Cells["Tiempo_LLegada"].Value))
                                        {
                                            if (banrepetido == 0)
                                            {
                                                indice = r;
                                                r = 10;
                                                cont++;

                                            }
                                            else
                                            {
                                                if (tllegada == repetido1)
                                                {
                                                    if (bandera2 == 0)
                                                    {
                                                        for (int a = 0; a < vector2.Length; a++)
                                                        {
                                                            if (vector2[a] == repetido1 && tservicio3 == 0 && tservicio2 != 0)
                                                            {
                                                                tservicio3 = vectort[a];
                                                                band = a;
                                                            }
                                                            if (vector2[a] == repetido1 && tservicio2 == 0)
                                                            {
                                                                tservicio2 = vectort[a];
                                                                bandera = vector[a];
                                                            }
                                                        }
                                                    }
                                                    if (tservicio2 > tservicio3 && bandera2 == 0)
                                                    {
                                                        indice = band;
                                                        r = 10;
                                                        cont++;
                                                        tservicio = tservicio3;
                                                        bandera2++;
                                                    }
                                                    else if (tservicio2 < tservicio3 && bandera2 == 0)
                                                    {
                                                        indice = r;
                                                        cont++;
                                                        r = 10;
                                                        tservicio = tservicio2;
                                                        bandera2++;
                                                    }
                                                    else if (tservicio2 > tservicio3 && bandera2 != 0)
                                                    {
                                                        indice = r;
                                                        cont++;
                                                        r = 10;
                                                        tservicio = tservicio2;
                                                        bandera2++;
                                                    }
                                                    else
                                                    {
                                                        indice = band;
                                                        r = 10;
                                                        cont++;
                                                        tservicio = tservicio3;
                                                        bandera2++;
                                                    }
                                                }
                                                else
                                                {
                                                    indice = r;
                                                    r = 10;
                                                    cont++;
                                                }
                                            }
                                            bandera = 0;
                                        }
                                    }
                                    if (cont2 + primero > tllegada)
                                    {
                                        cont3 = cont2;
                                        for (int q = 0; q < tservicio; q++)
                                        {
                                            dataGridView2.Rows[indice].Cells[(numindice + 1)].Value = "X";
                                            cont2++;
                                            numindice++;
                                        }
                                    }
                                    else if (numindice > cont2 + primero)
                                    {
                                        for (int q = 0; q < tservicio; q++)
                                        {
                                            dataGridView2.Rows[indice].Cells[(numindice + 1) + q].Value = "X";
                                            cont2++;
                                            numero++;
                                        }
                                        numindice += numero;
                                    }
                                    else if (tllegada == numindice)
                                    {
                                        for (int q = 0; q < tservicio; q++)
                                        {
                                            dataGridView2.Rows[indice].Cells[(numindice + 1)].Value = "X";
                                            cont2++;
                                            numindice++;
                                            numero++;
                                        }
                                    }
                                    else
                                    {
                                        for (int q = 0; q < tservicio; q++)
                                        {
                                            dataGridView2.Rows[indice].Cells[tllegada + q].Value = "X";
                                            cont2++;
                                            numindice = tllegada + q;
                                        }
                                    }
                                    if (cont == vector.Length)
                                    {
                                        ban = 1;
                                        break;
                                    }
                                }
                            }
                        } while (ban != 1);
                    }
                }//fin del algoritmo SJF
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                if (algoritmo == 3)
                {
                    int nproceso = 0, tproceso = 0, suma = 0, ban = 0, z = 0, x = 0, indice = 0, indicerep = 0, repetido1 = 0, bandera = 0,tllegada2=0,tservicio2=0,tllgada3=0,tservicio3=0;
                    int tllegada = 0, tservicio = 0, cont = 0,mas=0, cont2 = 0, primero = 0, cont3 = 0, numindice = 0, numero = 0, repetido = 0, banrepetido = 0,cambio=0,cambio2=0;
                    float ere = 0, ere2 = 0;
                    int[] vector = new int[proceso];
                    int[] vectort = new int[proceso];
                    string comp;
                    DataGridViewColumn dtCol = new DataGridViewColumn();
                    for (int y = 0; y < proceso; y++)
                    {
                        nproceso = Convert.ToInt32(this.dataGridView1.Rows[y].Cells["Tiempo_llegada"].Value.ToString());
                        vector[y] = nproceso;
                        tproceso = Convert.ToInt32(this.dataGridView1.Rows[y].Cells["Tiempo_Servicio"].Value.ToString());
                        vectort[y] = tproceso;
                    }
                    for (int p = 0; p < vector.Length; p++)
                    {
                        if (vector[p] > 10)
                        {
                            mas = 1;
                        }
                    }
                    if (mas == 1)
                    {
                        MessageBox.Show("No se admiten numeros mayores a 10");
                    }
                    else
                    {
                        mas = 0;
                        //////////////////////////Metodo Burbuja
                        int t;
                        for (int a = 1; a < vector.Length; a++)
                            for (int b = vector.Length - 1; b >= a; b--)
                            {
                                if (vector[b - 1] > vector[b])
                                {
                                    t = vector[b - 1];
                                    vector[b - 1] = vector[b];
                                    vector[b] = t;
                                }
                            }
                        for (int q = 0; q < vector.Length; q++)
                        {
                            int d = 0;
                            d = (vector[q]);

                        }
                        ///////////////////////Termina Metodo Burbuja
                        for (int f = 0; f < vectort.Length; f++)
                        {
                            suma += vectort[f];
                        }
                        for (int f = 0; f < 40; f++)
                        {
                            dataGridView2.Columns.Add(Convert.ToString(f), Convert.ToString(f + 1));
                            this.dataGridView2.AutoResizeColumns();
                        }
                        for (int r = 0; r < vector.Length - 1; r++)
                        {
                            repetido = vector[r];
                            tllegada = vector[r + 1];
                            if (repetido == tllegada)
                            {
                                banrepetido++;
                                repetido1 = repetido;
                            }
                        }
                        repetido = 0;
                        do
                        {
                            for (int y = 0; y < vector.Length; y++)
                            {
                                primero = vector[0];

                                tllegada = Convert.ToInt32(dataGridView1.Rows[y].Cells[1].Value);
                                tservicio = Convert.ToInt32(dataGridView1.Rows[y].Cells[2].Value);
                                if (tllegada == vector[cont])
                                {
                                    if (numindice > tllegada)
                                    {
                                        if (cambio == 1 && cambio2 == 0)
                                        {
                                            tllegada = tllgada3;
                                            tservicio = tservicio3;
                                            cambio2 = 1;
                                        }
                                        else
                                        {
                                            int lon = vector.Length;
                                            if (cambio == 0 && cont < lon - 1)
                                            {
                                                for (int q = 0; q < vector.Length; q++)
                                                {
                                                    tllegada2 = Convert.ToInt32(dataGridView1.Rows[q].Cells[1].Value);
                                                    tservicio2 = Convert.ToInt32(dataGridView1.Rows[q].Cells[2].Value);
                                                    if (tllegada2 == vector[cont + 1])
                                                    {
                                                        tllegada2 = Convert.ToInt32(dataGridView1.Rows[q].Cells[1].Value);
                                                        tservicio2 = Convert.ToInt32(dataGridView1.Rows[q].Cells[2].Value);
                                                        q = 15;
                                                    }
                                                }
                                                ere = numindice + 1 - tllegada;
                                                ere += tservicio;
                                                ere = ere / tservicio;
                                                ere2 = numindice + 1 - tllegada2;
                                                ere2 += tservicio2;
                                                ere2 = ere2 / tservicio2;
                                                if (ere2 > ere)
                                                {
                                                    tllgada3 = tllegada;
                                                    tservicio3 = tservicio;
                                                    tllegada = tllegada2;
                                                    tservicio = tservicio2;
                                                    cambio = 1;
                                                }
                                            }
                                        }

                                    }
                                    for (int r = 0; r < vector.Length; r++)
                                    {
                                        if (tllegada == Convert.ToInt32(dataGridView1.Rows[r].Cells["Tiempo_LLegada"].Value))
                                        {
                                            if (banrepetido == 0)
                                            {
                                                indice = r;
                                                r = 10;
                                                cont++;

                                            }
                                            else
                                            {
                                                if (repetido1 != tllegada)
                                                {
                                                    indice = r;
                                                    r = 10;
                                                    cont++;

                                                }
                                                else if (indicerep == 0)
                                                {
                                                    indice = r;
                                                    r = 10;
                                                    cont++;
                                                    indicerep++;

                                                }
                                                else
                                                {
                                                    if (bandera == 1)
                                                    {
                                                        indice = r;
                                                        r = 10;
                                                        cont++;
                                                        y = 0;
                                                    }
                                                    else if (bandera == 4)
                                                    {
                                                        indice = r;
                                                        r = 10;
                                                        cont++;
                                                        //bandera++;
                                                        y = 0;
                                                    }
                                                    else if (bandera == 6)
                                                    {
                                                        indice = r;
                                                        r = 10;
                                                        cont++;
                                                        //bandera++;
                                                        y = 0;
                                                    }
                                                    bandera++;
                                                }
                                            }

                                        }
                                    }
                                    if (cont2 + primero > tllegada)
                                    {
                                        cont3 = cont2;
                                        for (int q = 0; q < tservicio; q++)
                                        {
                                            dataGridView2.Rows[indice].Cells[(numindice + 1)].Value = "X";
                                            cont2++;
                                            numindice++;
                                        }
                                    }
                                    else if (numindice > cont2 + primero)
                                    {
                                        for (int q = 0; q < tservicio; q++)
                                        {
                                            dataGridView2.Rows[indice].Cells[(numindice + 1) + q].Value = "X";
                                            cont2++;
                                            numero++;
                                        }
                                        numindice += numero;
                                    }
                                    else if (tllegada == numindice)
                                    {
                                        for (int q = 0; q < tservicio; q++)
                                        {
                                            dataGridView2.Rows[indice].Cells[(numindice + 1)].Value = "X";
                                            cont2++;
                                            numindice++;
                                            numero++;
                                        }
                                    }
                                    else
                                    {
                                        for (int q = 0; q < tservicio; q++)
                                        {
                                            dataGridView2.Rows[indice].Cells[tllegada + q].Value = "X";
                                            cont2++;
                                            numindice = tllegada + q;
                                        }
                                    }
                                    if (cont == vector.Length)
                                    {
                                        ban = 1;
                                        break;
                                    }
                                }
                            }
                        } while (ban != 1);
                    }
                }//fin del algoritmo HRNN
                 //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                 //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                if(algoritmo==4)
                {
                    int nproceso = 0, tproceso = 0, suma = 0, ban = 0, z = 0, faltante = 0, indice = 0, indicerep = 0, repetido1 = 0, bandera = 0,contf=0,idfal=0,idfal2=0,repetido2=0;
                    int tllegada = 0, tservicio = 0, cont = 0,mas=0, cont2 = 0, primero = 0, cont3 = 0, numindice = 0, numero = 0, repetido = 0, banrepetido = 0,hack=0,hack2=0,hack3=0,hack4=0;
                    int[] vector = new int[proceso];
                    int[] vectort = new int[proceso];
                    int[] falta = new int[10];
                    string comp;
                    cuantum = Convert.ToInt32(cbocuantum.Text);
                    DataGridViewColumn dtCol = new DataGridViewColumn();
                    for (int y = 0; y < proceso; y++)
                    {
                        nproceso = Convert.ToInt32(this.dataGridView1.Rows[y].Cells["Tiempo_llegada"].Value.ToString());
                        vector[y] = nproceso;
                        tproceso = Convert.ToInt32(this.dataGridView1.Rows[y].Cells["Tiempo_Servicio"].Value.ToString());
                        vectort[y] = tproceso;
                    }
                    for (int p = 0; p < vector.Length; p++)
                    {
                        if (vector[p] > 10)
                        {
                            mas = 1;
                        }
                    }
                    if (mas == 1)
                    {
                        MessageBox.Show("No se admiten numeros mayores a 10");
                    }
                    else
                    {
                        mas = 0;
                        //////////////////////////Metodo Burbuja
                        int t;
                        for (int a = 1; a < vector.Length; a++)
                            for (int b = vector.Length - 1; b >= a; b--)
                            {
                                if (vector[b - 1] > vector[b])
                                {
                                    t = vector[b - 1];
                                    vector[b - 1] = vector[b];
                                    vector[b] = t;
                                }
                            }
                        for (int q = 0; q < vector.Length; q++)
                        {
                            int d = 0;
                            d = (vector[q]);

                        }
                        ///////////////////////Termina Metodo Burbuja
                        for (int f = 0; f < vectort.Length; f++)
                        {
                            suma += vectort[f];
                        }
                        for (int f = 0; f < 40; f++)
                        {
                            dataGridView2.Columns.Add(Convert.ToString(f), Convert.ToString(f + 1));
                            this.dataGridView2.AutoResizeColumns();
                        }
                        for (int r = 0; r < vector.Length - 1; r++)
                        {
                            repetido = vector[r];
                            tllegada = vector[r + 1];
                            if (repetido == tllegada)
                            {
                                banrepetido++;
                                repetido1 = repetido;
                                break;
                            }
                            
                        }
                        for (int r = 0; r < vector.Length - 1; r++)
                        {
                            repetido = vector[r];
                            tllegada = vector[r + 1];
                            if (repetido == tllegada)
                            {
                                repetido2 = repetido;
                            }
                        }
                            repetido = 0;
                        do
                        {
                            for (int y = 0; y < vector.Length; y++)
                            {
                                primero = vector[0];
                                tllegada = Convert.ToInt32(dataGridView1.Rows[y].Cells[1].Value);
                                tservicio = Convert.ToInt32(dataGridView1.Rows[y].Cells[2].Value);
                                if (tllegada == vector[cont])
                                {
                                    idfal2 = 0;
                                    for (int r = 0; r < vector.Length; r++)
                                    {
                                        if (tllegada == Convert.ToInt32(dataGridView1.Rows[r].Cells["Tiempo_LLegada"].Value))
                                        {
                                            if (banrepetido == 0)
                                            {
                                                indice = r;
                                                r = 10;
                                                //if (faltante == 0)
                                                //{
                                                cont++;
                                                //}
                                            }
                                            else
                                            {
                                                if(repetido2==tllegada)
                                                {
                                                    if(hack3==1)
                                                    {
                                                        indice = r + 1;
                                                        r = 10;
                                                        cont++;
                                                        break;
                                                    }
                                                    indice = r;
                                                    r = 10;
                                                    cont++;
                                                    hack3++;
                                                    break;

                                                }
                                                if (repetido1 != tllegada)
                                                {
                                                    indice = r;
                                                    r = 10;
                                                    //if (faltante == 0)
                                                    //{
                                                    cont++;
                                                    //}
                                                }
                                                else if (indicerep == 0)
                                                {
                                                    indice = r;
                                                    r = 10;
                                                    cont++;
                                                    indicerep++;

                                                }
                                                else
                                                {
                                                    if (bandera == 1)
                                                    {
                                                        indice = r;
                                                        r = 10;
                                                        cont++;
                                                        y = 0;
                                                    }
                                                    else if (bandera == 2)
                                                    {
                                                        indice = r;
                                                        r = 10;
                                                        cont++;
                                                        //bandera++;
                                                        y = 0;
                                                    }
                                                    else if (bandera == 4)
                                                    {
                                                        indice = r;
                                                        r = 10;
                                                        cont++;
                                                        //bandera++;
                                                        y = 0;
                                                    }
                                                    bandera++;
                                                }
                                            }

                                        }
                                    }
                                    idfal = tllegada;
                                    for (int i = 0; i < vector.Length; i++)
                                    {
                                        if (idfal == vector[i])
                                        {
                                            break;
                                        }
                                        idfal2++;
                                    }
                                    if (falta[idfal2] != 0)
                                    {
                                        hack2++;
                                        if (hack2 == 1)
                                        {

                                        }
                                        else
                                        {
                                            if (hack3 == 1)
                                            {
                                                hack4++;
                                                if(hack2==3)
                                                {
                                                    tservicio = falta[idfal2];
                                                    hack3 = 0;
                                                }
                                                
                                                if (hack2==7)
                                                {
                                                    tservicio = falta[idfal2];
                                                }
                                                if(hack2==8)
                                                {
                                                    tservicio = falta[idfal2];
                                                }
                                            }
                                            
                                            else
                                            {
                                                tservicio = falta[idfal2];
                                                hack3 = 0;
                                            }
                                            
                                        }
                                    }
                                    if (cont2 + primero > tllegada)
                                    {
                                        cont3 = cont2;
                                        if (tservicio < cuantum)
                                        {
                                            for (int q = 0; q < tservicio; q++)
                                            {
                                                if (tservicio < 2)
                                                {
                                                    dataGridView2.Rows[indice].Cells[(numindice + 1)].Value = "X";
                                                    cont2++;
                                                    numindice++;
                                                    break;
                                                }
                                                else
                                                {
                                                    dataGridView2.Rows[indice].Cells[(numindice + 1)].Value = "X";
                                                    cont2++;
                                                    numindice++;
                                                    faltante = tservicio - cuantum;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (tservicio < cuantum)
                                            {
                                                for (int q = 0; q < tservicio; q++)
                                                {
                                                    if (tservicio < 2)
                                                    {
                                                        dataGridView2.Rows[indice].Cells[(numindice + 1)].Value = "X";
                                                        cont2++;
                                                        numindice++;
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        dataGridView2.Rows[indice].Cells[(numindice + 1)].Value = "X";
                                                        cont2++;
                                                        numindice++;
                                                        faltante = tservicio - cuantum;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                for (int q = 0; q < cuantum; q++)
                                                {
                                                    if (tservicio < 2)
                                                    {
                                                        dataGridView2.Rows[indice].Cells[(numindice + 1)].Value = "X";
                                                        cont2++;
                                                        numindice++;
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        dataGridView2.Rows[indice].Cells[(numindice + 1)].Value = "X";
                                                        cont2++;
                                                        numindice++;
                                                        faltante = tservicio - cuantum;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else if (numindice > cont2 + primero)
                                    {
                                        for (int q = 0; q < tservicio; q++)
                                        {
                                            dataGridView2.Rows[indice].Cells[(numindice + 1) + q].Value = "X";
                                            cont2++;
                                            numero++;
                                        }
                                        numindice += numero;
                                    }
                                    else if (tllegada == numindice)
                                    {
                                        for (int q = 0; q < tservicio; q++)
                                        {
                                            dataGridView2.Rows[indice].Cells[(numindice + 1)].Value = "X";
                                            cont2++;
                                            numindice++;
                                            numero++;
                                        }
                                    }
                                    else
                                    {
                                        if (tservicio < cuantum)
                                        {
                                            for (int q = 0; q < tservicio; q++)
                                            {
                                                if (tservicio < 2)
                                                {
                                                    dataGridView2.Rows[indice].Cells[tllegada + q].Value = "X";
                                                    cont2++;
                                                    numindice = tllegada + q;
                                                }
                                                else
                                                {
                                                    dataGridView2.Rows[indice].Cells[tllegada + q].Value = "X";
                                                    cont2++;
                                                    numindice = tllegada + q;
                                                    faltante = tservicio - cuantum;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            for (int q = 0; q < cuantum; q++)
                                            {
                                                if (tservicio < 2)
                                                {
                                                    dataGridView2.Rows[indice].Cells[tllegada + q].Value = "X";
                                                    cont2++;
                                                    numindice = tllegada + q;
                                                }
                                                else
                                                {
                                                    dataGridView2.Rows[indice].Cells[tllegada + q].Value = "X";
                                                    cont2++;
                                                    numindice = tllegada + q;
                                                    faltante = tservicio - cuantum;
                                                }
                                            }
                                        }
                                    }
                                    if (cont == vector.Length)
                                    {
                                        if (falta[cont] != 0)
                                        {
                                            ban = 1;
                                            break;
                                        }
                                        else
                                        {
                                            if(hack==0)
                                            {
                                                if (falta[0] != 0)
                                                {
                                                    contf++;
                                                    cont = 0;
                                                    falta[contf] = faltante;
                                                    hack++;
                                                }
                                                else
                                                {
                                                    ban = 1;
                                                    break;
                                                }
                                            }
                                            else
                                            {
                                                ban = 1;
                                                break;
                                            }
                                            
                                        }
                                    }
                                    if (cont > contf + 1)
                                    {
                                        contf++;
                                        falta[contf] = faltante;
                                    }
                                    else
                                    {
                                        if (contf > cont)
                                        {
                                            break;
                                        }
                                        falta[contf] = faltante;
                                        if (falta[cont + 1] != 0)
                                        {
                                            falta[cont + 1] = 0;
                                        }
                                    }
                                }
                                
                            }
                            contf++;
                        } while (ban != 1);
                    }
                }//fin algoritmo robin
                 ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                 //////////////////////////////////////////////////////////////////////////////////////////////////////////
            }//Fin else
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dtext = (DataGridViewTextBoxEditingControl)e.Control;
            dtext.KeyPress -= new KeyPressEventHandler(dtext_KeyPress);
            dtext.KeyPress += new KeyPressEventHandler(dtext_KeyPress);
        }
        void dtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char .IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if(char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cbocuantum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre;

            nombre = cbo_algoritmo.Text;
            if(nombre== "FCFS (First come first serve)")
            {
                algoritmo = 1;
                cbocuantum.Enabled = false;
            }
            if(nombre== "SJF (shortest-job-first)")
            {
                algoritmo = 2;
                cbocuantum.Enabled = false;
            }
            if (nombre == "HRRN (Highest Response Ratio Next)")
            {
                algoritmo = 3;
                cbocuantum.Enabled = false;
            }
            if (nombre == "RR (Round Robin)")
            {
                algoritmo = 4;
                cbocuantum.Enabled = true;
            }
            if (cbo_algoritmo.Text != "" && cbo_n_procesos.Text != "")
            {
                btn_ver.Enabled = true;
            }
        }
    }
}

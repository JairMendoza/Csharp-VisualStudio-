using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Speech.AudioFormat;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string[] adjetivosU = { "TODOS ", "TODAS ","TODO ","TODA "};
        string[] adjetivosUN = { "NINGUN ", "NINGUNA ", "NINGUN ", "NINGUNA " };
        string[] adjetivosP = { "ALGUNAS ", "ALGUNOS ", "ALGUNA ", "ALGUN " };
        string[] vervosp = {" ESTA ", " ESTAN ", " ES ", " SON " };
        string[] vervosn = { " NO ES ", " NO SON ", " NO ESTA ", " NO ESTAN " };
        string t1, t2, t3, t4,t5,terminomedio ,terminoM,terminom,conclusion,ter1,ter2,ter3,ter4,pmaytermina,pmaytermina2;
        char silogismo1, silogismo2,vocal,silogismo1P,silogismo2P,vocal2,puntero,vocal3;
        bool dentro4;
        int indice = 0,figura=0,sindice=0,elim=0;
        //SpeechRecognitionEngine escucha = new  SpeechRecognitionEngine();
        //SpeechRecognitionEngine escucha = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("es-MX"));

        private void Detection(object sender, SpeechRecognizedEventArgs e)
        {
            pmayor_tbox.Text = e.Result.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pmayor,pmenor;
            bool dentro,dentro2;
            int bandera = 0,bandera2=0,contador=0,contador2=0;
            
            pmayor = pmayor_tbox.Text.ToUpper();
            pmayor= pmayor.TrimEnd();
            for(int i=0;i<4;i++)
            {
                dentro = pmayor.Contains(adjetivosU[i]);
                if (dentro == true)
                {
                    silogismo1 = 'U';
                    ter1 = adjetivosU[i];
                    bandera = 1;
                    break;
                }
                dentro = pmayor.Contains(adjetivosUN[i]);
                if(dentro==true)
                {
                    silogismo1 = 'U';
                    ter1 = adjetivosUN[i];
                    silogismo2 = 'N';
                    bandera = 1;
                    break;
                }
            }
            if (bandera==0)
            {
                for (int i = 0; i <= 3; i++)
                {
                    dentro = pmayor.Contains(adjetivosP[i]);
                    if (dentro == true)
                    {
                        silogismo1 = 'P';
                        ter1 = adjetivosP[i];
                        break;
                    }
                }
            }
            dentro = false;
            if (silogismo2 != 'N')
            {
                bandera = 0;
                for (int i = 0; i <= 3; i++)
                {
                    dentro = pmayor.Contains(vervosn[i]);
                    if (dentro == true)
                    {
                        silogismo2 = 'N';
                        ter2 = vervosn[i];
                        bandera = 1;
                        break;
                    }
                }
                if (bandera == 0)
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        dentro = pmayor.Contains(vervosp[i]);
                        if (dentro == true)
                        {
                            silogismo2 = 'A';
                            ter2 = vervosp[i];
                            break;
                        }
                    }
                }
            }
            if (silogismo1 == 'U'&&silogismo2=='\0')
                silogismo2 = 'A';
            if(silogismo1=='U'&&silogismo2=='A')
            {
                vocal = 'A';
            }
            if (silogismo1 == 'U' && silogismo2 == 'N')
            {
                vocal = 'E';
            }
            if (silogismo1 == 'P' && silogismo2 == 'A')
            {
                vocal = 'I';
            }
            if (silogismo1 == 'P' && silogismo2 == 'N')
            {
                vocal = 'O';
            }
            /////////////////////////////////////////////////////////////////////////////////////
            pmenor = pmenor_tbox.Text.ToUpper();
            pmenor = pmenor.TrimEnd();
            for (int i = 0; i < 3; i++)
            {
                dentro2 = pmenor.Contains(adjetivosU[i]);
                if (dentro2 == true)
                {
                    silogismo1P = 'U';
                    ter3 = adjetivosU[i];
                    bandera2 = 1;
                    break;
                }
                dentro2 = pmenor.Contains(adjetivosUN[i]);
                if (dentro2 == true)
                {
                    silogismo1P = 'U';
                    ter3 = adjetivosUN[i];
                    silogismo2P = 'N';
                    bandera2 = 1;
                    break;
                }
            }
            if (bandera2 == 0)
            {
                for (int i = 0; i <= 3; i++)
                {
                    dentro2 = pmenor.Contains(adjetivosP[i]);
                    if (dentro2 == true)
                    {
                        silogismo1P = 'P';
                        ter3 = adjetivosP[i];
                        break;
                    }
                }
            }
            if (silogismo2P != 'N')
            {
                bandera2 = 0;
                for (int i = 0; i <=3; i++)
                {
                    dentro2 = pmenor.Contains(vervosn[i]);
                    if (dentro2 == true)
                    {
                        silogismo2P = 'N';
                        ter4 = vervosn[i];
                        bandera2 = 1;
                        break;
                    }
                }
                if (bandera2 == 0)
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        dentro2 = pmenor.Contains(vervosp[i]);
                        if (dentro2 == true)
                        {
                            silogismo2P = 'A';
                            ter4 = vervosp[i];
                            break;
                        }
                    }
                }
            }
            if (silogismo1P == 'U' && silogismo2P == 'A')
            {
                vocal2 = 'A';
            }
            if (silogismo1P == 'U' && silogismo2P == 'N')
            {
                vocal2 = 'E';
            }
            if (silogismo1P == 'P' && silogismo2P == 'A')
            {
                vocal2 = 'I';
            }
            if (silogismo1P == 'P' && silogismo2P == 'N')
            {
                vocal2 = 'O';
            }
            if (ter2 ==null)
            {
                ter2 = ter4;
            }
            tmayor_tbox.Text = Convert.ToString(vocal);
            tmenor_tbox.Text = Convert.ToString(vocal2);
            for(int z=pmayor.Length;z>0;z--)
            {
                pmaytermina += Convert.ToString(pmayor[z-1]);
                if (pmaytermina[contador] == ' ')
                {
                    break;
                }
                contador++;
            }
            for(int q=pmaytermina.Length;q>0;q--)
            {
                pmaytermina2 += Convert.ToString( pmaytermina[q-1]);
            }
            contador = 0;
            for(int w=0;w<pmayor.Length;w++)
            {
                puntero = pmayor[w];
                if(puntero==' '&&contador==0)
                {
                    for(int y=w;y<pmayor.Length;y++)
                    {
                        t1 +=Convert.ToString(pmayor[y + 1]);
                        if (silogismo2 == 'A' || silogismo1 == 'U' && silogismo2 == 'N')
                        {
                            dentro4 = t1.Contains(vervosp[contador2]);
                            if (contador2 == 0)
                                indice = t1.IndexOf(" ESTA ");
                            if (contador2 == 1)
                                indice = t1.IndexOf(" ESTAN ");
                            if (contador2 == 2)
                                indice = t1.IndexOf(" ES ");
                            if (contador2 == 3)
                                indice = t1.IndexOf(" SON ");
                        }
                        else
                        {
                            dentro4 = t1.Contains(vervosn[contador2]);
                            if (contador2 == 0)
                                indice = t1.IndexOf(" NO ES ");
                            if (contador2 == 1)
                                indice = t1.IndexOf(" NO SON ");
                            if (contador2 == 2)
                                indice = t1.IndexOf(" NO ESTA ");
                            if (contador2 == 3)
                                indice = t1.IndexOf(" NO ESTAN ");
                        }
                        if (dentro4 == true)
                            break;
                        if (contador2 == 3)
                            contador2 = -1;
                        contador++;
                        contador2++;
                        if (t1.EndsWith(pmaytermina2)==true)
                        {
                            elim = t1.IndexOf(pmaytermina2);
                            t1=t1.Remove(elim);
                            sindice = 1;
                            break;
                        }
                    }
                    if (sindice == 0)
                    {
                        t1 = t1.Remove(indice);
                    }
                    for(int t=pmayor.Length;t>=1;t--)
                    {
                        puntero = pmayor[t-1];
                        if (puntero == ' ')
                            break;
                        t2 = t2 + pmayor[t-1];
                    }
                    for (int t = t2.Length; t >= 1; t--)
                    {
                        t3 = t3 + t2[t-1];
                    }
                    t2 = t3;
                }
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////
            puntero = ' ';
            contador = 0;
            t3 = "";
            contador2 = 0;
            indice = ' ';
            pmaytermina = "";
            pmaytermina2 = "";
            sindice = 0;
            for (int z = pmenor.Length; z > 0; z--)
            {
                pmaytermina += Convert.ToString(pmenor[z - 1]);
                if (pmaytermina[contador] == ' ')
                {
                    break;
                }
                contador++;
            }
            for (int q = pmaytermina.Length; q > 0; q--)
            {
                pmaytermina2 += Convert.ToString(pmaytermina[q - 1]);
            }
            contador = 0;
            for (int w = 0; w < pmenor.Length; w++)
            {
                puntero = pmenor[w];
                if (puntero == ' ' && contador == 0)
                {
                    for (int y = w; y < pmenor.Length; y++)
                    {
                        t3 += Convert.ToString(pmenor[y + 1]);
                        if (silogismo2P == 'A' || silogismo1P == 'U' && silogismo2 == 'N' || silogismo1P == 'U' && silogismo2 == 'A')
                        {
                            dentro4 = t3.Contains(vervosp[contador2]);
                            if (contador2 == 0)
                                indice = t3.IndexOf(" ESTA ");
                            if (contador2 == 1)
                                indice = t3.IndexOf(" ESTAN ");
                            if (contador2 == 2)
                                indice = t3.IndexOf(" ES ");
                            if (contador2 == 3)
                                indice = t3.IndexOf(" SON ");
                        }
                        else
                        {
                            dentro4 = t3.Contains(vervosn[contador2]);
                            if (contador2 == 0)
                                indice = t3.IndexOf(" NO ES ");
                            if (contador2 == 1)
                                indice = t3.IndexOf(" NO SON ");
                            if (contador2 == 2)
                                indice = t3.IndexOf(" NO ESTA ");
                            if (contador2 == 3)
                                indice = t3.IndexOf(" NO ESTAN ");
                        }
                        if (dentro4 == true)
                            break;
                        if (contador2 == 3)
                            contador2 = -1;
                        contador++;
                        contador2++;
                        if (t3.EndsWith(pmaytermina2) == true)
                        {
                            elim = t3.IndexOf(pmaytermina2);
                            t3 = t3.Remove(elim);
                            sindice = 1;
                            break;
                        }
                    }
                    if (sindice == 0)
                    {
                        t3 = t3.Remove(indice);
                    }
                    for (int t = pmenor.Length; t >= 1; t--)
                    {
                        puntero = pmenor[t - 1];
                        if (puntero == ' ')
                            break;
                        t4 = t4 + pmenor[t - 1];
                    }
                    for (int t = t4.Length; t >= 1; t--)
                    {
                        t5 = t5 + t4[t - 1];
                    }
                    t4 = t5;
                }
            }
            if (t1.Contains(t3) == true||t3.Contains(t1)==true)
            {
                terminomedio = t1;
                terminoM = t2;
                terminom = t4;
            }
            else if (t1.Contains(t4) == true|| t4.Contains(t1) == true)
            {
                terminomedio = t1;
                terminoM = t2;
                terminom = t3;
            }
            else if (t2.Contains(t3.Remove(t3.Length-1)) == true|| t3.Contains(t2) == true)
            {
                terminomedio = t2;
                terminoM = t1;
                terminom = t4;
            }
            else if (t2.Contains(t4.Remove(t4.Length-1)) == true|| t4.Contains(t2) == true)
            {
                terminomedio = t2;
                terminoM = t1;
                terminom = t3;
            }
            if((t1.Contains(terminomedio)==true||terminomedio.Contains(t1)==true)&&(t2.Contains(terminoM)==true||terminoM.Contains(t2)==true)&&(t3.Contains(terminom)==true||terminom.Contains(t3)==true))
            {
                figura = 1;
            }
            else if((t1.Contains(terminoM)==true||terminoM.Contains(t1)==true)&&(t2.Contains(terminomedio)==true||terminomedio.Contains(t2)==true )&&( t3.Contains(terminom)==true||terminom.Contains(t3)==true))
            {
                figura = 2;
            }
            else if((t1.Contains(terminomedio)==true||terminomedio.Contains(t1)==true) && (t2.Contains(terminoM)==true||terminoM.Contains(t2)==true) && (t3.Contains(terminomedio)==true||terminomedio.Contains(t3)==true))
            {
                figura = 3;
            }
            if (figura == 0)
            {
                conclucion_tbox.Text = " No hay Conclusion.";
            }
            else
            {
                //conclusion += terminom;
                if (vocal == 'A' && vocal2 != 'A')
                    vocal3 = vocal2;
                else if (vocal != 'A' && vocal2 == 'A')
                    vocal3 = vocal;
                else if (vocal == 'E' && vocal2 == 'I')
                    vocal3 = 'O';
                else if (vocal2 == 'E' && vocal == 'I')
                    vocal3 = 'O';
                else if (vocal2 == 'A' && vocal == 'A')
                    vocal3 = 'A';
                else
                {
                    conclucion_tbox.Text = " No hay conclusion.";
                }
            }
            terminom = terminom.Insert(terminom.Length," ");
            if (vocal == '\0' && vocal2 == '\0' && vocal3 == '\0')
            {
                conclucion_tbox.Text = " No hay conclusion.";
            }
            else
            {
                if (vocal3 != ' ')
                {
                    if ((dentro = ter1.Contains("TOD")) == true && (dentro2 = ter3.Contains("ALGUN")) == true)
                    {
                        conclusion = ter3;
                        conclusion += terminom;
                        conclusion += ter2;
                        conclusion += terminoM;
                    }
                    else if ((dentro = ter1.Contains("TOD")) == true && (dentro2 = ter3.Contains("NINGUN")) == true)
                    {
                        conclusion = ter3;
                        conclusion += terminom;
                        conclusion += ter2;
                        conclusion += terminoM;
                    }
                    else if (sindice == 1)
                    {
                        conclusion = ter3;
                        conclusion += terminom;
                        conclusion += ter2;
                        conclusion += terminoM;
                    }
                    else
                    {
                        conclusion = ter1;
                        conclusion += terminom;
                        conclusion += ter2;
                        conclusion += terminoM;
                    }
                }

                if (figura != 0)
                {
                    tmedio_tbox.Text = Convert.ToString(vocal3);
                    conclucion_tbox.Text = conclusion;
                    figura_tbox.Text = "F " + Convert.ToString(figura);
                    if (figura == 1)
                    {
                        if (vocal == 'A' && vocal2 == 'A' && vocal3 == 'A')
                        {
                            modo_tbox.Text = "BARBARA";
                        }
                        if (vocal == 'E' && vocal2 == 'A' && vocal3 == 'E')
                        {
                            modo_tbox.Text = "CELARENT";
                        }
                        if (vocal == 'A' && vocal2 == 'I' && vocal3 == 'I')
                        {
                            modo_tbox.Text = "DARII";
                        }
                        if (vocal == 'E' && vocal2 == 'I' && vocal3 == 'O')
                        {
                            modo_tbox.Text = "FERIO";
                        }
                    }
                    if (figura == 2)
                    {
                        if (vocal == 'E' && vocal2 == 'A' && vocal3 == 'E')
                        {
                            modo_tbox.Text = "CESARE";
                        }
                        if (vocal == 'A' && vocal2 == 'E' && vocal3 == 'E')
                        {
                            modo_tbox.Text = "CAMESTRES";
                        }
                        if (vocal == 'E' && vocal2 == 'I' && vocal3 == 'O')
                        {
                            modo_tbox.Text = "FESTINO";
                        }
                        if (vocal == 'A' && vocal2 == 'O' && vocal3 == 'O')
                        {
                            modo_tbox.Text = "BAROCO";
                        }
                    }
                    if (figura == 3)
                    {
                        if (vocal == 'A' && vocal2 == 'A' && vocal3 == 'I')
                        {
                            modo_tbox.Text = "DARAPTI";
                        }
                        if (vocal == 'A' && vocal2 == 'I' && vocal3 == 'I')
                        {
                            modo_tbox.Text = "DATISI";
                        }
                        if (vocal == 'I' && vocal2 == 'A' && vocal3 == 'I')
                        {
                            modo_tbox.Text = "DISAMIS";
                        }
                        if (vocal == 'E' && vocal2 == 'A' && vocal3 == 'O')
                        {
                            modo_tbox.Text = "FELAPTON";
                        }
                        if (vocal == 'E' && vocal2 == 'I' && vocal3 == 'O')
                        {
                            modo_tbox.Text = "FERISON";
                        }
                        if (vocal == 'O' && vocal2 == 'A' && vocal3 == 'O')
                        {
                            modo_tbox.Text = "BOCARDO";
                        }
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            /*escucha.SetInputToDefaultAudioDevice();
            escucha.LoadGrammar(new DictationGrammar());
            escucha.SpeechRecognized += Detection;
            escucha.RecognizeAsync(RecognizeMode.Multiple);*/
        }

        /*private void pmenor_tbox_TextChanged(object sender, EventArgs e)
        {
            string pmenor;
            pmenor = pmenor_tbox.Text;

        }
        SpeechRecognitionEngine rec = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-EN"));*/
    }
}

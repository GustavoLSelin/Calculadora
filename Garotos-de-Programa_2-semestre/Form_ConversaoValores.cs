using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garotos_de_Programa_2_semestre
{
    public partial class Form_ConversaoValores : Form
    {
        public Form_ConversaoValores()
        {
            InitializeComponent();
        }
        /*------------------        Km/h <-> M/s    --------------------------------*/
        double kmh = 0, ms = 0;
        /*------------------        Horas - Minutos - Segundos    --------------------------------*/
        double hora = 0, segundo = 0, minuto = 0;
        /*------------------        Distancias       --------------------------------*/
        double valordistancia = 0;
        /*------------------       Àreas       --------------------------------*/
        double kmq = 0, doismq = 0, tresftq = 0, quatromiq = 0, cincoacre = 0;
        private void Txt_ConversaoValores_hms_horas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hora = Convert.ToDouble(Txt_ConversaoValores_hms_horas.Text);
                minuto = hora * 60;
                segundo = hora * 3600;
                Txt_ConversaoValores_hms_minutos.Text = Convert.ToString(minuto);
                Txt_ConversaoValores_hms_segundos.Text = Convert.ToString(segundo);
            }
            catch
            {
                ;
            }
            
        }
        private void Btn_ConversaoValores_hms_Limpar_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_ConversaoValores_hms_horas.Text = null;
                Txt_ConversaoValores_hms_minutos.Text = null;
                Txt_ConversaoValores_hms_segundos.Text = null;
            }
            catch
            {

            }
        }
        private void Txt_ConversaoValores_hms_minutos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                minuto = Convert.ToDouble(Txt_ConversaoValores_hms_minutos.Text);
                hora = minuto / 60;
                segundo = minuto * 60;
                Txt_ConversaoValores_hms_horas.Text = Convert.ToString(hora);
                Txt_ConversaoValores_hms_segundos.Text = Convert.ToString(segundo);
            }
            catch
            {
                ;
            }
        }
        private void Btn_Fis_Cinematica_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }
        private void Btn_ConversaoValores_Distancia_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cob_ConversaoValores_Distancias_medidas.Text == "Kilômetro")
                {
                    valordistancia = Convert.ToDouble(Txt_ConversaoValores_Distancias_Valor.Text);
                    Txt_ConversaoValores_Distancias_kilometro.Text = Convert.ToString(valordistancia + "km");
                    Txt_ConversaoValores_Distancias_hectometro.Text = Convert.ToString(valordistancia * 10 + "hm");
                    Txt_ConversaoValores_Distancias_decametro.Text = Convert.ToString(valordistancia * 100 + "dam");
                    Txt_ConversaoValores_Distancias_metro.Text = Convert.ToString(valordistancia * 1000 + "m");
                    Txt_ConversaoValores_Distancias_decimetro.Text = Convert.ToString(valordistancia * 10000 + "dm");
                    Txt_ConversaoValores_Distancias_centimetro.Text = Convert.ToString(valordistancia * 100000 + "cm");
                    Txt_ConversaoValores_Distancias_milimetro.Text = Convert.ToString(valordistancia * 1000000 + "mm");
                }
                else if (Cob_ConversaoValores_Distancias_medidas.Text == "Hectômetro")
                {
                    valordistancia = Convert.ToDouble(Txt_ConversaoValores_Distancias_Valor.Text);
                    Txt_ConversaoValores_Distancias_kilometro.Text = Convert.ToString(valordistancia / 10 + "km");
                    Txt_ConversaoValores_Distancias_hectometro.Text = Convert.ToString(valordistancia + "hm");
                    Txt_ConversaoValores_Distancias_decametro.Text = Convert.ToString(valordistancia * 10 + "dam");
                    Txt_ConversaoValores_Distancias_metro.Text = Convert.ToString(valordistancia * 100 + "m");
                    Txt_ConversaoValores_Distancias_decimetro.Text = Convert.ToString(valordistancia * 1000 + "dm");
                    Txt_ConversaoValores_Distancias_centimetro.Text = Convert.ToString(valordistancia * 10000 + "cm");
                    Txt_ConversaoValores_Distancias_milimetro.Text = Convert.ToString(valordistancia * 100000 + "mm");
                }
                else if (Cob_ConversaoValores_Distancias_medidas.Text == "Decâmetro")
                {
                    valordistancia = Convert.ToDouble(Txt_ConversaoValores_Distancias_Valor.Text);
                    Txt_ConversaoValores_Distancias_kilometro.Text = Convert.ToString(valordistancia / 100 + "km");
                    Txt_ConversaoValores_Distancias_hectometro.Text = Convert.ToString(valordistancia / 10 + "hm");
                    Txt_ConversaoValores_Distancias_decametro.Text = Convert.ToString(valordistancia + "dam");
                    Txt_ConversaoValores_Distancias_metro.Text = Convert.ToString(valordistancia * 10 + "m");
                    Txt_ConversaoValores_Distancias_decimetro.Text = Convert.ToString(valordistancia * 100 + "dm");
                    Txt_ConversaoValores_Distancias_centimetro.Text = Convert.ToString(valordistancia * 1000 + "cm");
                    Txt_ConversaoValores_Distancias_milimetro.Text = Convert.ToString(valordistancia * 10000 + "mm");
                }
                else if (Cob_ConversaoValores_Distancias_medidas.Text == "Metro")
                {
                    valordistancia = Convert.ToDouble(Txt_ConversaoValores_Distancias_Valor.Text);
                    Txt_ConversaoValores_Distancias_kilometro.Text = Convert.ToString(valordistancia / 1000 + "km");
                    Txt_ConversaoValores_Distancias_hectometro.Text = Convert.ToString(valordistancia / 100 + "hm");
                    Txt_ConversaoValores_Distancias_decametro.Text = Convert.ToString(valordistancia / 10 + "dam");
                    Txt_ConversaoValores_Distancias_metro.Text = Convert.ToString(valordistancia + "m");
                    Txt_ConversaoValores_Distancias_decimetro.Text = Convert.ToString(valordistancia * 10 + "dm");
                    Txt_ConversaoValores_Distancias_centimetro.Text = Convert.ToString(valordistancia * 100 + "cm");
                    Txt_ConversaoValores_Distancias_milimetro.Text = Convert.ToString(valordistancia * 1000 + "mm");
                }
                else if (Cob_ConversaoValores_Distancias_medidas.Text == "Decimetro")
                {
                    valordistancia = Convert.ToDouble(Txt_ConversaoValores_Distancias_Valor.Text);
                    Txt_ConversaoValores_Distancias_kilometro.Text = Convert.ToString(valordistancia / 10000 + "km");
                    Txt_ConversaoValores_Distancias_hectometro.Text = Convert.ToString(valordistancia / 1000 + "hm");
                    Txt_ConversaoValores_Distancias_decametro.Text = Convert.ToString(valordistancia / 100 + "dam");
                    Txt_ConversaoValores_Distancias_metro.Text = Convert.ToString(valordistancia / 10 + "m");
                    Txt_ConversaoValores_Distancias_decimetro.Text = Convert.ToString(valordistancia + "dm");
                    Txt_ConversaoValores_Distancias_centimetro.Text = Convert.ToString(valordistancia * 10 + "cm");
                    Txt_ConversaoValores_Distancias_milimetro.Text = Convert.ToString(valordistancia * 100 + "mm");
                }
                else if (Cob_ConversaoValores_Distancias_medidas.Text == "Centímetro")
                {
                    valordistancia = Convert.ToDouble(Txt_ConversaoValores_Distancias_Valor.Text);
                    Txt_ConversaoValores_Distancias_kilometro.Text = Convert.ToString(valordistancia / 100000 + "km");
                    Txt_ConversaoValores_Distancias_hectometro.Text = Convert.ToString(valordistancia / 10000 + "hm");
                    Txt_ConversaoValores_Distancias_decametro.Text = Convert.ToString(valordistancia / 1000 + "dam");
                    Txt_ConversaoValores_Distancias_metro.Text = Convert.ToString(valordistancia / 100 + "m");
                    Txt_ConversaoValores_Distancias_decimetro.Text = Convert.ToString(valordistancia / 10 + "dm");
                    Txt_ConversaoValores_Distancias_centimetro.Text = Convert.ToString(valordistancia + "cm");
                    Txt_ConversaoValores_Distancias_milimetro.Text = Convert.ToString(valordistancia * 10 + "mm");
                }
                else if (Cob_ConversaoValores_Distancias_medidas.Text == "Milímetro")
                {
                    valordistancia = Convert.ToDouble(Txt_ConversaoValores_Distancias_Valor.Text);
                    Txt_ConversaoValores_Distancias_kilometro.Text = Convert.ToString(valordistancia / 1000000 + "Km");
                    Txt_ConversaoValores_Distancias_hectometro.Text = Convert.ToString(valordistancia / 100000 + "hm");
                    Txt_ConversaoValores_Distancias_decametro.Text = Convert.ToString(valordistancia / 10000 + "dam");
                    Txt_ConversaoValores_Distancias_metro.Text = Convert.ToString(valordistancia / 1000 + "m");
                    Txt_ConversaoValores_Distancias_decimetro.Text = Convert.ToString(valordistancia / 100 + "dm");
                    Txt_ConversaoValores_Distancias_centimetro.Text = Convert.ToString(valordistancia / 10 + "cm");
                    Txt_ConversaoValores_Distancias_milimetro.Text = Convert.ToString(valordistancia + "mm");
                }
            }
            catch
            {
                ;
            }
        }
        private void Btn_ConversaoValores_Distancia_Limpar_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Distancias_Valor.Text = null;
            Txt_ConversaoValores_Distancias_milimetro.Text = null;
            Txt_ConversaoValores_Distancias_metro.Text = null;
            Txt_ConversaoValores_Distancias_kilometro.Text = null;
            Txt_ConversaoValores_Distancias_hectometro.Text = null;
            Txt_ConversaoValores_Distancias_decimetro.Text = null;
            Txt_ConversaoValores_Distancias_decametro.Text = null;
            Txt_ConversaoValores_Distancias_centimetro.Text = null;
            Cob_ConversaoValores_Distancias_medidas.Text = null;
        }
        private void Btn_ConversaoValores_Areas_umCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                kmq = Convert.ToDouble(Txt_ConversaoValores_Areas_umkmq.Text);
                Txt_ConversaoValores_Areas_ummq.Text = Convert.ToString(kmq * 1000000);
                Txt_ConversaoValores_Areas_ummiq.Text = Convert.ToString(kmq * 0.386);
                Txt_ConversaoValores_Areas_umacres.Text = Convert.ToString(kmq * 247);
            }
            catch
            {
                ;
            } 
        }
        private void Btn_ConversaoValores_Areas_doisCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                doismq = Convert.ToDouble(Txt_ConversaoValores_Areas_doismq.Text);
                Txt_ConversaoValores_Areas_doiscmq.Text = Convert.ToString(doismq * 10000);
                Txt_ConversaoValores_Areas_doisftq.Text = Convert.ToString(doismq * 10.76);
            }
            catch
            {
                ;
            }
        }
        private void Btn_ConversaoValores_Areas_doisLimpar_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Areas_doiscmq.Text = null;
            Txt_ConversaoValores_Areas_doisftq.Text = null;
            Txt_ConversaoValores_Areas_doismq.Text = null;
        }
        private void Btn_ConversaoValores_Areas_tresLimpar_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Areas_trescmq.Text = null;
            Txt_ConversaoValores_Areas_tresftq.Text = null;
            Txt_ConversaoValores_Areas_tresmq.Text = null;
        }
        private void Btn_ConversaoValores_Areas_quatroLimpar_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Areas_quatroacres.Text = null;
            Txt_ConversaoValores_Areas_quatrokmq.Text = null;
            Txt_ConversaoValores_Areas_quatromiq.Text = null;
        }
        private void Btn_ConversaoValores_Areas_cincoLimpar_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Areas_cincoacre.Text = null;
            Txt_ConversaoValores_Areas_cincoftq.Text = null;
            Txt_ConversaoValores_Areas_cincomq.Text = null;
        }
        private void Btn_ConversaoValores_Sair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnConversaoValores_Sair2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_ConversaoValores_ProximaPaginaUm_Click(object sender, EventArgs e)
        {
            Form_ConversaoValores_Dois objformconversaodevaloresdois = new Form_ConversaoValores_Dois();
            objformconversaodevaloresdois.Show();
            this.Hide();
        }
        private void Btn_ConversaoValores_ProximaPaginaDois_Click(object sender, EventArgs e)
        {
            Form_ConversaoValores_Dois objformconversaodevaloresdois = new Form_ConversaoValores_Dois();
            objformconversaodevaloresdois.Show();
            this.Hide();
        }
        private void Btn_ConversaoValores_Areas_cincoCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                cincoacre = Convert.ToDouble(Txt_ConversaoValores_Areas_cincoacre.Text);
                Txt_ConversaoValores_Areas_cincoftq.Text = Convert.ToString(cincoacre * 43560);
                Txt_ConversaoValores_Areas_cincomq.Text = Convert.ToString(cincoacre * 4047);
            }
            catch
            {
                ;
            }
        }
        private void Btn_ConversaoValores_Areas_quatroCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                quatromiq = Convert.ToDouble(Txt_ConversaoValores_Areas_quatromiq.Text);
                Txt_ConversaoValores_Areas_quatroacres.Text = Convert.ToString(quatromiq * 640);
                Txt_ConversaoValores_Areas_quatrokmq.Text = Convert.ToString(quatromiq * 2.59);
            }
            catch
            {
                ;
            }
        }
        private void Btn_ConversaoValores_Areas_tresCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                tresftq = Convert.ToDouble(Txt_ConversaoValores_Areas_tresftq.Text);
                Txt_ConversaoValores_Areas_trescmq.Text = Convert.ToString(tresftq * 929);
                Txt_ConversaoValores_Areas_tresmq.Text = Convert.ToString(tresftq * 0.093);
            }
            catch
            {
                ;
            }
        }
        private void Btn_ConversaoValores_Areas_umLimpar_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Areas_umacres.Text = null;
            Txt_ConversaoValores_Areas_umkmq.Text = null;
            Txt_ConversaoValores_Areas_ummiq.Text = null;
            Txt_ConversaoValores_Areas_ummq.Text = null;
        }
        private void Txt_ConversaoValores_kmm_ms_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ms = Convert.ToDouble(Txt_ConversaoValores_kmm_ms.Text);
                kmh = ms * 3.6;
                Txt_ConversaoValores_kmm_kmh.Text = Convert.ToString(kmh);
            }
            catch
            {
                ;
            }
        }
        private void Btn_ConversaoValores_kmm_Limpar_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_kmm_kmh.Text = null;
            Txt_ConversaoValores_kmm_ms.Text = null;
        }
        private void Txt_ConversaoValores_kmm_kmh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                kmh = Convert.ToDouble(Txt_ConversaoValores_kmm_kmh.Text);
                ms = kmh / 3.6;
                Txt_ConversaoValores_kmm_ms.Text = Convert.ToString(ms);
            }
            catch
            {
                ;
            }
        }
    }
}

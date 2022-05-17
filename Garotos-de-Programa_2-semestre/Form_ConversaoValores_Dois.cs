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
    public partial class Form_ConversaoValores_Dois : Form
    {
        public Form_ConversaoValores_Dois()
        {
            InitializeComponent();
        }
        /*--------------------------------- Volume ----------------------------------------------*/
        double ummt = 0, umcmt = 0, doislitro = 0, tresga = 0, tresl = 0, quatrogi = 0, quatrol = 0, cincobp = 0, seispt = 0;
        /*--------------------------------- Massa ----------------------------------------------*/
        double umkg = 0;
        /*--------------------------------- Forca ----------------------------------------------*/
        double newton = 0;
        /*--------------------------------- Temperatura ----------------------------------------------*/
        double c = 0;
        private void Txt_ConversaoValores_Dois_Volume_umcmt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                umcmt = Convert.ToDouble(Txt_ConversaoValores_Dois_Volume_umcmt.Text);
                Txt_ConversaoValores_Dois_Volume_ummt.Text = Convert.ToString(umcmt / 1000000);
            }
            catch
            {
                ;
            }
        }
        private void Txt_ConversaoValores_Dois_Volume_tresl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tresl = Convert.ToDouble(Txt_ConversaoValores_Dois_Volume_tresl.Text);
                Txt_ConversaoValores_Dois_Volume_tresga.Text = Convert.ToString(tresl / 3.78);
            }
            catch
            {
                ;
            }
        }
        private void Btn_ConversaoValores_Dois_Volume_Limpar2_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Dois_Volume_tresga.Text = null;
            Txt_ConversaoValores_Dois_Volume_tresl.Text = null;
        }
        private void Txt_ConversaoValores_Dois_Volume_quatrogi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                quatrogi = Convert.ToDouble(Txt_ConversaoValores_Dois_Volume_quatrogi.Text);
                Txt_ConversaoValores_Dois_Volume_quatrol.Text = Convert.ToString(quatrogi * 4.54);
            }
            catch
            {
                ;
            }
        }
        private void Txt_ConversaoValores_Dois_Volume_quatrol_TextChanged(object sender, EventArgs e)
        {
            try
            {
                quatrol = Convert.ToDouble(Txt_ConversaoValores_Dois_Volume_quatrol.Text);
                Txt_ConversaoValores_Dois_Volume_quatrogi.Text = Convert.ToString(quatrol / 4.54);
            }
            catch
            {
                ;
            }
        }
        private void Btn_ConversaoValores_Dois_Volume_Limpar3_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Dois_Volume_quatrogi.Text = null;
            Txt_ConversaoValores_Dois_Volume_quatrol.Text = null;
        }
        private void Btn_ConversaoValores_Dois_Volume_Calcular3_Click(object sender, EventArgs e)
        {
            try
            {
                seispt = Convert.ToDouble(Txt_ConversaoValores_Dois_Volume_seispt.Text);
                Txt_ConversaoValores_Dois_Volume_seiscmt.Text = Convert.ToString(seispt * 16.39);
            }
            catch
            {
                ;
            }
        }
        private void Btn_ConversaoValores_Dois_Volume_Limpar5_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Dois_Volume_seispt.Text = null;
            Txt_ConversaoValores_Dois_Volume_seiscmt.Text = null;
        }
        private void Btn_ConversaoValores_Dois_Massa_Calcular1_Click(object sender, EventArgs e)
        {
            try
            {
                umkg = Convert.ToDouble(Txt_ConversaoValores_Dois_Massa_umkg.Text);
                Txt_ConversaoValores_Dois_Massa_umgr.Text = Convert.ToString(umkg * 1000);
                Txt_ConversaoValores_Dois_Massa_umlb.Text = Convert.ToString(umkg * 2.2);
                Txt_ConversaoValores_Dois_Massa_umton.Text = Convert.ToString(umkg / 1000);
            }
            catch
            {
                ;
            }
        }
        private void Btn_ConversaoValores_Dois_Massa_Limpar1_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Dois_Massa_umgr.Text = null;
            Txt_ConversaoValores_Dois_Massa_umkg.Text = null;
            Txt_ConversaoValores_Dois_Massa_umlb.Text = null;
            Txt_ConversaoValores_Dois_Massa_umton.Text = null;
        }
        private void Btn_ConversaoValores_Dois_Forca_Calcular1_Click(object sender, EventArgs e)
        {
            try
            {
                newton = Convert.ToDouble(Txt_ConversaoValores_Dois_Forca_newton.Text);
                Txt_ConversaoValores_Dois_Forca_dynas.Text = Convert.ToString(newton * 100000);
                Txt_ConversaoValores_Dois_Forca_lbf.Text = Convert.ToString(newton * 0.255);
            }
            catch
            {
                ;
            }
        }
        private void Btn_ConversaoValores_Dois_Forca_Limpar1_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Dois_Forca_dynas.Text = null;
            Txt_ConversaoValores_Dois_Forca_lbf.Text = null;
            Txt_ConversaoValores_Dois_Forca_newton.Text = null;
        }
        private void Btn_ConversaoValores_Dois_Temperatura_Calcular1_Click(object sender, EventArgs e)
        {
            try
            {
                c = Convert.ToDouble(Txt_ConversaoValores_Dois_Temperatura_c.Text);
                Txt_ConversaoValores_Dois_Temperatura_f.Text = Convert.ToString((c * 0.566)+32);
                Txt_ConversaoValores_Dois_Temperatura_k.Text = Convert.ToString(c + 273);
            }
            catch
            {
                ;
            }
        }
        private void Btn_ConversaoValores_Dois_Temperatura_Limpar1_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Dois_Temperatura_c.Text = null;
            Txt_ConversaoValores_Dois_Temperatura_f.Text = null;
            Txt_ConversaoValores_Dois_Temperatura_k.Text = null;
        }
        private void Btn_ConversaoValores_Dois_Voltarapaginaum_Click(object sender, EventArgs e)
        {
            Form_ConversaoValores objconversaodevalores = new Form_ConversaoValores();
            objconversaodevalores.Show();
            this.Close();
        }
        private void Btn_ConversaoValores_Dois_Voltarapaginadois_Click(object sender, EventArgs e)
        {
            Form_ConversaoValores objconversaodevalores = new Form_ConversaoValores();
            objconversaodevalores.Show();
            this.Close();
        }

        private void Btn_ConversaoValores_Dois_Sair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ConversaoValores_Dois_Sair2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ConversaoValores_Dois_ProximaPaginaUm_Click(object sender, EventArgs e)
        {
            Form_ConversaoValores_Tres objformconversaovalorestres = new Form_ConversaoValores_Tres();
            objformconversaovalorestres.Show();
            this.Close();
        }

        private void Btn_ConversaoValores_Dois_ProximaPaginaDois_Click(object sender, EventArgs e)
        {
            Form_ConversaoValores_Tres objformconversaovalorestres = new Form_ConversaoValores_Tres();
            objformconversaovalorestres.Show();
            this.Close();
        }

        private void Btn_ConversaoValores_Dois_Volume_Limpar4_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Dois_Volume_cincobp.Text = null;
            Txt_ConversaoValores_Dois_Volume_cincomt.Text = null;
        }
        private void Btn_ConversaoValores_Dois_Volume_Calcular2_Click(object sender, EventArgs e)
        {
            try
            {
                cincobp = Convert.ToDouble(Txt_ConversaoValores_Dois_Volume_cincobp.Text);
                Txt_ConversaoValores_Dois_Volume_cincomt.Text = Convert.ToString(cincobp * 0.16);
            }
            catch
            {
                ;
            }
        }
        private void Btn_ConversaoValores_Dois_Volume_1_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Dois_Volume_umcmt.Text = null;
            Txt_ConversaoValores_Dois_Volume_ummt.Text = null;
        }
        private void Btn_Fis_Cinematica_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }
        private void Btn_ConversaoValores_Dois_Volume_Limpar1_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Dois_Volume_doiscmt.Text = null;
            Txt_ConversaoValores_Dois_Volume_doisdmt.Text = null;
            Txt_ConversaoValores_Dois_Volume_doislitro.Text = null;
            Txt_ConversaoValores_Dois_Volume_doismt.Text = null;
        }
        private void Txt_ConversaoValores_Dois_Volume_tresga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tresga = Convert.ToDouble(Txt_ConversaoValores_Dois_Volume_tresga.Text);
                Txt_ConversaoValores_Dois_Volume_tresl.Text = Convert.ToString(tresga * 3.78);
            }
            catch
            {
                ;
            }
            
        }
        private void Btn_ConversaoValores_Dois_Volume_Calcular1_Click(object sender, EventArgs e)
        {
            try
            {
                doislitro = Convert.ToDouble(Txt_ConversaoValores_Dois_Volume_doislitro.Text);
                Txt_ConversaoValores_Dois_Volume_doiscmt.Text = Convert.ToString(doislitro * 1000);
                Txt_ConversaoValores_Dois_Volume_doisdmt.Text = Convert.ToString(doislitro);
                Txt_ConversaoValores_Dois_Volume_doismt.Text = Convert.ToString(doislitro * 0.001);
            }
            catch
            {
                ;
            }
        }
        private void Txt_ConversaoValores_Dois_Volume_ummt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ummt = Convert.ToDouble(Txt_ConversaoValores_Dois_Volume_ummt.Text);
                Txt_ConversaoValores_Dois_Volume_umcmt.Text = Convert.ToString(ummt * 1000000);
            }
            catch
            {
                ;
            }
        }
    }
}

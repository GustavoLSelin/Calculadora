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
    public partial class Form_ConversaoValores_Tres : Form
    {
        public Form_ConversaoValores_Tres()
        {
            InitializeComponent();
        }
        /*---------------------------------------- Energia ---------------------------*/
        double watts = 0, caloria = 0, treskwh = 0, quatrobtu = 0;
        /*---------------------------------------- Potencia ---------------------------*/
        double hp = 0, btuh = 0, tresbtuh = 0, quatrobtui = 0;
        private void Btn_ConversaoValores_Tres_Energia_Calcular1_Click(object sender, EventArgs e)
        {
            try
            {
                watts = Convert.ToDouble(Txt_ConversaoValores_Tres_Energia_Watts.Text);
                Txt_ConversaoValores_Tres_Energia_nm.Text = Txt_ConversaoValores_Tres_Energia_Watts.Text;
                Txt_ConversaoValores_Tres_Energia_j.Text = Txt_ConversaoValores_Tres_Energia_Watts.Text;
                Txt_ConversaoValores_Tres_Energia_erg.Text = Convert.ToString(watts * 10000000);
            }
            catch
            {
                ;
            }
        }
        private void Btn_ConversaoValores_Tres_Energia_Limpar1_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Tres_Energia_j.Text = null;
            Txt_ConversaoValores_Tres_Energia_nm.Text = null;
            Txt_ConversaoValores_Tres_Energia_Watts.Text = null;
            Txt_ConversaoValores_Tres_Energia_erg.Text = null;
        }
        private void Btn_ConversaoValores_Tres_Energia_Limpar3_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Tres_Energia_Tres_joule.Text = null;
            Txt_ConversaoValores_Tres_Energia_Tres_kwh.Text = null;
        }

        private void Btn_ConversaoValores_Dois_Voltarapaginaum_Click(object sender, EventArgs e)
        {
            Form_ConversaoValores_Dois objformconversaovaloresdois = new Form_ConversaoValores_Dois();
            objformconversaovaloresdois.Show();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form_ConversaoValores_Dois objformconversaovaloresdois = new Form_ConversaoValores_Dois();
            objformconversaovaloresdois.Show();
            this.Close();
        }

        private void Btn_ConversaoValores_Tres_Energia_Limpar4_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Tres_Energia_Quatro_Btu.Text = null;
            Txt_ConversaoValores_Tres_Energia_Quatro_ftlb.Text = null;
            Txt_ConversaoValores_Tres_Energia_Quatro_J.Text = null;
        }

        private void Btn_ConversaoValores_Tres_Potencia_Calcular1_Click(object sender, EventArgs e)
        {
            try
            {
                hp = Convert.ToDouble(Txt_ConversaoValores_Tres_Potencia_umhp.Text);
                Txt_ConversaoValores_Tres_Potencia_umwatts.Text = Convert.ToString(hp * 745.7);
            }
            catch
            {
                ;
            }
        }

        private void Btn_ConversaoValores_Tres_Potencia_Limpar1_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Tres_Potencia_umhp.Text = null;
            Txt_ConversaoValores_Tres_Potencia_umwatts.Text = null;
        }

        private void Btn_ConversaoValores_Tres_Potencia_Limpar2_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Tres_Potencia_doisbtuh.Text = null;
            Txt_ConversaoValores_Tres_Potencia_doiswatts.Text = null;
        }

        private void Btn_ConversaoValores_Tres_Potencia_Limpar3_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Tres_Potencia_tresbtuh.Text = null;
            Txt_ConversaoValores_Tres_Potencia_treswatts.Text = null;
        }

        private void Btn_ConversaoValores_Sair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ConversaoValores_Tres_Potencia_Limpar4_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Tres_Potencia_quatrobtuh.Text = null;
            Txt_ConversaoValores_Tres_Potencia_quatrowatts.Text = null;
        }

        private void Btn_ConversaoValores_Tres_Energia_Limpar2_Click(object sender, EventArgs e)
        {
            Txt_ConversaoValores_Tres_Energia_Dois_C.Text = null;
            Txt_ConversaoValores_Tres_Energia_Dois_Joule.Text = null;
            Txt_ConversaoValores_Tres_Energia_Dois_Btu.Text = null;
        }

        private void Btn_ConversaoValores_Tres_Potencia_Calcular4_Click(object sender, EventArgs e)
        {
            try
            {
                quatrobtui = Convert.ToDouble(Txt_ConversaoValores_Tres_Potencia_quatrobtuh.Text);
                Txt_ConversaoValores_Tres_Potencia_quatrowatts.Text = Convert.ToString(quatrobtui * 1055);
            }
            catch
            {
                ;
            }
        }

        private void Btn_ConversaoValores_Tres_Potencia_Calcular3_Click(object sender, EventArgs e)
        {
            try
            {
                tresbtuh = Convert.ToDouble(Txt_ConversaoValores_Tres_Potencia_tresbtuh.Text);
                Txt_ConversaoValores_Tres_Potencia_treswatts.Text = Convert.ToString(tresbtuh * 17.58);
            }
            catch
            {
                ;
            }
        }

        private void Btn_ConversaoValores_Tres_Potencia_Calcular2_Click(object sender, EventArgs e)
        {
            try
            {
                btuh = Convert.ToDouble(Txt_ConversaoValores_Tres_Potencia_doisbtuh.Text);
                Txt_ConversaoValores_Tres_Potencia_doiswatts.Text = Convert.ToString(btuh * 0.29);
            }
            catch
            {
                ;
            }
        }

        private void Btn_ConversaoValores_Tres_Energia_Calcular4_Click(object sender, EventArgs e)
        {
            try
            {
                quatrobtu = Convert.ToDouble(Txt_ConversaoValores_Tres_Energia_Quatro_Btu.Text);
                Txt_ConversaoValores_Tres_Energia_Quatro_ftlb.Text = Convert.ToString(quatrobtu * 778);
                Txt_ConversaoValores_Tres_Energia_Quatro_J.Text = Convert.ToString(quatrobtu * 1055);
            }
            catch
            {
                ;
            }
        }

        private void Btn_ConversaoValores_Tres_Energia_Calcular3_Click(object sender, EventArgs e)
        {
            try
            {
                treskwh = Convert.ToDouble(Txt_ConversaoValores_Tres_Energia_Tres_kwh.Text);
                Txt_ConversaoValores_Tres_Energia_Tres_joule.Text = Convert.ToString(treskwh * 3600000);
            }
            catch
            {
                ;
            }
        }
        private void Btn_ConversaoValores_Tres_Energia_Calcular2_Click(object sender, EventArgs e)
        {
            try
            {
                caloria = Convert.ToDouble(Txt_ConversaoValores_Tres_Energia_Dois_C.Text);
                Txt_ConversaoValores_Tres_Energia_Dois_Joule.Text = Convert.ToString(caloria * 4.18);
                Txt_ConversaoValores_Tres_Energia_Dois_Btu.Text = Convert.ToString(caloria * 0.004);
            }
            catch
            {
                ;
            }
        }
    }
}

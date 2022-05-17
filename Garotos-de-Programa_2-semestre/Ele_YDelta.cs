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
    public partial class Ele_YDelta : Form
    {
        public Ele_YDelta()
        {
            InitializeComponent();
        }
        double ra = 0, rb = 0, rc = 0, r1 = 0, r2 = 0, r3 = 0;

        private void Cob_Ele_YDelta_Operacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cob_Ele_YDelta_Operacao.Text == "Calcular RA, RB e RC")
            {
                Txt_Ele_YDelta_Ra.Text = "X";
                Txt_Ele_YDelta_Rb.Text = "X";
                Txt_Ele_YDelta_Rc.Text = "X";
            }
            if(Cob_Ele_YDelta_Operacao.Text == "Calcular R1, R2 e R3")
            {
                Txt_Ele_YDelta_R1.Text = "X";
                Txt_Ele_YDelta_R2.Text = "X";
                Txt_Ele_YDelta_R3.Text = "X";
            }
        }

        private void Btn_Ele_YDelta_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Ele_YDelta_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Ele_YDelta_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Ele_YDelta_R1.Text = null;
            Txt_Ele_YDelta_R2.Text = null;
            Txt_Ele_YDelta_R3.Text = null;
            Txt_Ele_YDelta_Ra.Text = null;
            Txt_Ele_YDelta_Rb.Text = null;
            Txt_Ele_YDelta_Rc.Text = null;
            L_Ele_YDelta_Resposta_Rum.Text = "R";
            L_Ele_YDelta_Resposta_Rdois.Text = "R";
            L_Ele_YDelta_Resposta_Rtres.Text = "R";
            Cob_Ele_YDelta_Operacao.Text = null;

        }

        private void Btn_Ele_YDelta_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if(Cob_Ele_YDelta_Operacao.Text == "Calcular RA, RB e RC")
                {
                    r1 = Convert.ToDouble(Txt_Ele_YDelta_R1.Text);
                    r2 = Convert.ToDouble(Txt_Ele_YDelta_R2.Text);
                    r3 = Convert.ToDouble(Txt_Ele_YDelta_R3.Text);
                    Txt_Ele_YDelta_Ra.Text = Convert.ToString(((r1 * r2) + (r2 * r3) + (r3 * r1)) / r1);
                    Txt_Ele_YDelta_Rb.Text = Convert.ToString(((r1 * r2) + (r2 * r3) + (r3 * r1)) / r2);
                    Txt_Ele_YDelta_Rc.Text = Convert.ToString(((r1 * r2) + (r2 * r3) + (r3 * r1)) / r3);
                    L_Ele_YDelta_Resposta_Rum.Text = "RA = " + Txt_Ele_YDelta_Ra.Text;
                    L_Ele_YDelta_Resposta_Rdois.Text = "RB = " + Txt_Ele_YDelta_Rb.Text;
                    L_Ele_YDelta_Resposta_Rtres.Text = "RC = " + Txt_Ele_YDelta_Rc.Text;
                }
                if(Cob_Ele_YDelta_Operacao.Text == "Calcular R1, R2 e R3")
                {
                    ra = Convert.ToDouble(Txt_Ele_YDelta_Ra.Text);
                    rb = Convert.ToDouble(Txt_Ele_YDelta_Rb.Text);
                    rc = Convert.ToDouble(Txt_Ele_YDelta_Rc.Text);
                    Txt_Ele_YDelta_R1.Text = Convert.ToString((rb * rc) / (ra + rb + rc));
                    Txt_Ele_YDelta_R2.Text = Convert.ToString((ra * rc) / (ra + rb + rc));
                    Txt_Ele_YDelta_R3.Text = Convert.ToString((ra * rb) / (ra + rb + rc));
                    L_Ele_YDelta_Resposta_Rum.Text = "R1 = " + Txt_Ele_YDelta_R1.Text;
                    L_Ele_YDelta_Resposta_Rdois.Text = "R2 = " + Txt_Ele_YDelta_R2.Text;
                    L_Ele_YDelta_Resposta_Rtres.Text = "R3 = " + Txt_Ele_YDelta_R3.Text;
                }
            }
            catch
            {
                ;
            }
        }
    }
}

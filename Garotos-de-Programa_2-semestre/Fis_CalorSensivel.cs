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
    public partial class Fis_CalorSensivel : Form
    {
        public Fis_CalorSensivel()
        {
            InitializeComponent();
        }
        //--------//
        double calorespecifico = 0, massacorpo = 0, temperatura = 0;

        private void Btn_Fis_CalorSensivel_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                massacorpo = Convert.ToDouble(Txt_Fis_CalorSensivel_MassaCorpo.Text);
                temperatura = Convert.ToDouble(Txt_Fis_CalorSensivel_Temperatura.Text);
                Txt_Fis_CalorSensivel_QuantidadeCalor.Text = Convert.ToString(calorespecifico * massacorpo * temperatura) + "Kcal";
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_CalorSensivel_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Fis_CalorSensivel_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Fis_CalorSensivel_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Fis_CalorSensivel_CalorEspecifico.Text = null;
            Txt_Fis_CalorSensivel_MassaCorpo.Text = null;
            Txt_Fis_CalorSensivel_QuantidadeCalor.Text = null;
            Txt_Fis_CalorSensivel_Temperatura.Text = null;
        }

        private void Txt_Fis_CalorSensivel_CalorEspecifico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Txt_Fis_CalorSensivel_CalorEspecifico.Text == "Alumínio  =  0.219 cal/g°C")
            {
                calorespecifico = 0.219;
            }
            if(Txt_Fis_CalorSensivel_CalorEspecifico.Text == "Água  =  1.000 cal/g°C")
            {
                calorespecifico = 1.000;
            }
            if (Txt_Fis_CalorSensivel_CalorEspecifico.Text == "Álcool  =   0.590 cal/g°C")
            {
                calorespecifico = 0.590;
            }
            if (Txt_Fis_CalorSensivel_CalorEspecifico.Text == "Cobre  =  0.093 cal/g°C")
            {
                calorespecifico = 0.093;
            }
            if (Txt_Fis_CalorSensivel_CalorEspecifico.Text == "Chumbo  =  0.031 cal/g°C")
            {
                calorespecifico = 0.031;
            }
            if (Txt_Fis_CalorSensivel_CalorEspecifico.Text == "Estanho  =  0.055 cal/g°C")
            {
                calorespecifico = 0.055;
            }
            if (Txt_Fis_CalorSensivel_CalorEspecifico.Text == "Ferro  =  0.119 cal/g°C")
            {
                calorespecifico = 0.119;
            }
            if (Txt_Fis_CalorSensivel_CalorEspecifico.Text == "Gelo  =  0.550 cal/g°C")
            {
                calorespecifico = 0.550;
            }
            if (Txt_Fis_CalorSensivel_CalorEspecifico.Text == "Mercúrio  =  0.033 cal/g°C")
            {
                calorespecifico = 0.033;
            }
            if (Txt_Fis_CalorSensivel_CalorEspecifico.Text == "Ouro  =  0.031 cal/g°C")
            {
                calorespecifico = 0.031;
            }
            if (Txt_Fis_CalorSensivel_CalorEspecifico.Text == "Prata  =  0.056 cal/g°C")
            {
                calorespecifico = 0.056;
            }
            if (Txt_Fis_CalorSensivel_CalorEspecifico.Text == "Vapor de Água  =  0.480 cal/g°C")
            {
                calorespecifico = 0.480;
            }
            if (Txt_Fis_CalorSensivel_CalorEspecifico.Text == "Zinco  =  0.093 cal/g°C")
            {
                calorespecifico = 0.093;
            }
        }
    }
}

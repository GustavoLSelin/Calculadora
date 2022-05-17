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
    public partial class Fis_Forcas : Form
    {
        public Fis_Forcas()
        {
            InitializeComponent();
        }
        //--------- Um --------//
        double massaum = 0, aceleracaoum = 0;
        //--------- Dois ------//
        double massadois = 0, gravidadedois = 0;
        //-------- Tres -------//
        double atritotres = 0, normaltres = 0;
        //-------- Quatro -----//
        double molaquatro = 0, deformacaoquatro = 0;
        //-------- Cinco ------//
        double distanciacinco = 0, velocidadecinco = 0, raiocinco = 0;
        private void Btn_Fis_Forcas_Limpar_Um_Click(object sender, EventArgs e)
        {
            Txt_Fis_Forcas_Aceleracao_Um.Text = null;
            Txt_Fis_Forcas_Forca_Um.Text = null;
            Txt_Fis_Forcas_Massa_Um.Text = null;
        }

        private void Btn_Fis_Forcas_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Fis_Forcas_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Fis_Forcas_Calcular_Dois_Click(object sender, EventArgs e)
        {
            try
            {
                massadois = Convert.ToDouble(Txt_Fis_Forcas_Massa_Dois.Text);
                gravidadedois = Convert.ToDouble(Txt_Fis_Forcas_Gravidade_Dois.Text);
                Txt_Fis_Forcas_Peso_Dois.Text = Convert.ToString(massadois * gravidadedois) + "N";
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_Forcas_Limpar_Tres_Click(object sender, EventArgs e)
        {
            Txt_Fis_Forcas_Atrito_Tres.Text = null;
            Txt_Fis_Forcas_CoeAtrito_Tres.Text = null;
            Txt_Fis_Forcas_Normal_Tres.Text = null;
        }

        private void Btn_Fis_Forcas_Calcular_Cinco_Click(object sender, EventArgs e)
        {
            distanciacinco = Convert.ToDouble(Txt_Fis_Forcas_Distancia_Cinco.Text);
            velocidadecinco = Convert.ToDouble(Txt_Fis_Forcas_Velocidade_Cinco.Text);
            raiocinco = Convert.ToDouble(Txt_Fis_Forcas_Raio_Cinco.Text);
            velocidadecinco = Math.Pow(velocidadecinco, 2);
            Txt_Fis_Forcas_Centripeta_Cinco.Text = Convert.ToString(distanciacinco * (velocidadecinco / raiocinco));
        }

        private void Btn_Fis_Forcas_Calcular_Quatro_Click(object sender, EventArgs e)
        {
            try
            {
                molaquatro = Convert.ToDouble(Txt_Fis_Forcas_Elastica_Quatro.Text);
                deformacaoquatro = Convert.ToDouble(Txt_Fis_Forcas_Mola_Quatro.Text);
                Txt_Fis_Forcas_Forca_Quatro.Text = Convert.ToString(molaquatro * deformacaoquatro) + "N";
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_Forcas_Limpar_Cinco_Click(object sender, EventArgs e)
        {
            Txt_Fis_Forcas_Centripeta_Cinco.Text = null;
            Txt_Fis_Forcas_Distancia_Cinco.Text = null;
            Txt_Fis_Forcas_Raio_Cinco.Text = null;
            Txt_Fis_Forcas_Velocidade_Cinco.Text = null;
        }

        private void Btn_Fis_Forcas_Limpar_Quatro_Click(object sender, EventArgs e)
        {
            Txt_Fis_Forcas_Elastica_Quatro.Text = null;
            Txt_Fis_Forcas_Forca_Quatro.Text = null;
            Txt_Fis_Forcas_Mola_Quatro.Text = null;
        }

        private void Btn_Fis_Forcas_Calcular_Tres_Click(object sender, EventArgs e)
        {
            try
            {
                atritotres = Convert.ToDouble(Txt_Fis_Forcas_CoeAtrito_Tres.Text);
                normaltres = Convert.ToDouble(Txt_Fis_Forcas_Normal_Tres.Text);
                Txt_Fis_Forcas_Atrito_Tres.Text = Convert.ToString(atritotres * normaltres);
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_Forcas_Limpar_Dois_Click(object sender, EventArgs e)
        {
            Txt_Fis_Forcas_Gravidade_Dois.Text = null;
            Txt_Fis_Forcas_Massa_Dois.Text = null;
            Txt_Fis_Forcas_Peso_Dois.Text = null;
        }

        private void Btn_Fis_Forcas_Calcular_Um_Click(object sender, EventArgs e)
        {
            try
            {
                if(Txt_Fis_Forcas_Forca_Um.Text == "")
                {
                    massaum = Convert.ToDouble(Txt_Fis_Forcas_Massa_Um.Text);
                    aceleracaoum = Convert.ToDouble(Txt_Fis_Forcas_Aceleracao_Um.Text);
                    Txt_Fis_Forcas_Forca_Um.Text = Convert.ToString(massaum * aceleracaoum) + "N";
                }
                if(Txt_Fis_Forcas_Aceleracao_Um.Text == "")
                {
                    massaum = Convert.ToDouble(Txt_Fis_Forcas_Massa_Um.Text);
                    aceleracaoum = Convert.ToDouble(Txt_Fis_Forcas_Forca_Um.Text);
                    Txt_Fis_Forcas_Aceleracao_Um.Text = Convert.ToString(aceleracaoum / massaum) + "m/s²";
                }
            }
                
            catch
            {
                ;
            }
        }
    }
}

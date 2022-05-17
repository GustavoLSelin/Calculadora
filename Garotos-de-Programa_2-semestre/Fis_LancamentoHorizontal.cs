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
    public partial class Fis_LancamentoHorizontal : Form
    {
        public Fis_LancamentoHorizontal()
        {
            InitializeComponent();
        }
        //--------------- Um -------------------//
        double gravidadeum = 0, tempoum = 0;
        //--------------- Dois -----------------//
        double velocidadeinicialdois = 0, alturadois = 0, gravidadedois = 0;
        //--------------- Tres -----------------//
        double vxtres = 0, vytres = 0;
        //--------------- Quatro --------------//
        double gravidadequatro = 0, tempoquatro = 0;
        //-------------- Cinco ----------------//
        double alturacinco = 0, gravidadecinco = 0;

        private void Btn_Fis_LancamentoHorizontal_Limpar_Tres_Click(object sender, EventArgs e)
        {
            Txt_Fis_LancamentoHorizontal_Vx_Tres.Text = null;
            Txt_Fis_LancamentoHorizontal_Vy_Tres.Text = null;
            Txt_Fis_LancamentoHorizontal_Velocidade_Tres.Text = null;
        }

        private void Btn_Fis_LancamentoHorizontal_Calcular_Tres_Click(object sender, EventArgs e)
        {
            try
            {
                vxtres = Convert.ToDouble(Txt_Fis_LancamentoHorizontal_Vx_Tres.Text);
                vytres = Convert.ToDouble(Txt_Fis_LancamentoHorizontal_Vy_Tres.Text);
                vxtres = Math.Pow(vxtres, 2);
                vytres = Math.Pow(vytres, 2);
                Txt_Fis_LancamentoHorizontal_Velocidade_Tres.Text = Convert.ToString(Math.Sqrt(vxtres + vytres));
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_LancamentoHorizontal_Limpar_Quatro_Click(object sender, EventArgs e)
        {
            Txt_Fis_LancamentoHorizontal_DerivadaAltura_Quatro.Text = null;
            Txt_Fis_LancamentoHorizontal_Gravidade_Quatro.Text = null;
            Txt_Fis_LancamentoHorizontal_Tempo_Quatro.Text = null;
        }

        private void Btn_Fis_LancamentoHorizontal_Limpar_Cinco_Click(object sender, EventArgs e)
        {
            Txt_Fis_LancamentoHorizontal_DerivadaAltura_Cinco.Text = null;
            Txt_Fis_LancamentoHorizontal_Tempo_Cinco.Text = null;
        }

        private void Btn_Fis_LancamentoHorizontal_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Fis_LancamentoHorizontal_Voltar1_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Fis_LancamentoHorizontal_Voltar2_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Fis_LancamentoHorizontal_Calcular_Cinco_Click(object sender, EventArgs e)
        {
            try
            {
                alturacinco = Convert.ToDouble(Txt_Fis_LancamentoHorizontal_DerivadaAltura_Cinco.Text);
                gravidadecinco = Convert.ToDouble(Txt_Fis_LancamentoHorizontal_Gravidade_Cinco.Text);
                Txt_Fis_LancamentoHorizontal_Tempo_Cinco.Text = Convert.ToString((2 * alturacinco) / gravidadecinco);
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_LancamentoHorizontal_Calcular_Quatro_Click(object sender, EventArgs e)
        {
            try
            {
                gravidadequatro = Convert.ToDouble(Txt_Fis_LancamentoHorizontal_Gravidade_Quatro.Text);
                tempoquatro = Convert.ToDouble(Txt_Fis_LancamentoHorizontal_Tempo_Quatro.Text);
                tempoquatro = Math.Pow(tempoquatro, 2);
                Txt_Fis_LancamentoHorizontal_DerivadaAltura_Quatro.Text = Convert.ToString((gravidadequatro * tempoquatro)/2);
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_LancamentoHorizontal_Calcular_Um_Click(object sender, EventArgs e)
        {
            try
            {
                gravidadeum = Convert.ToDouble(Txt_Fis_LancamentoHorizontal_Gravidade_Um.Text);
                tempoum = Convert.ToDouble(Txt_Fis_LancamentoHorizontal_Tempo_Um.Text);
                Txt_Fis_LancamentoHorizontal_Vy_Um.Text = Convert.ToString(gravidadeum * tempoum);
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_LancamentoHorizontal_Limpar_Dois_Click(object sender, EventArgs e)
        {
            Txt_Fis_LancamentoHorizontal_DerivadaEspaco_Dois.Text = null;
            Txt_Fis_LancamentoHorizontal_VelocidadeInicial_Dois.Text = null;
            Txt_Fis_LancamentoHorizontal_DerivadaAltura_Dois.Text = null;
            Txt_Fis_LancamentoHorizontal_Gravidade_Dois.Text = null;
        }

        private void Btn_Fis_LancamentoHorizontal_Calcular_Dois_Click(object sender, EventArgs e)
        {
            try
            {
                velocidadeinicialdois = Convert.ToDouble(Txt_Fis_LancamentoHorizontal_VelocidadeInicial_Dois.Text);
                alturadois = Convert.ToDouble(Txt_Fis_LancamentoHorizontal_DerivadaAltura_Dois.Text);
                gravidadedois = Convert.ToDouble(Txt_Fis_LancamentoHorizontal_Gravidade_Dois.Text);
                Txt_Fis_LancamentoHorizontal_DerivadaEspaco_Dois.Text = Convert.ToString(velocidadeinicialdois * (Math.Sqrt((2 * alturadois)/ gravidadedois)));
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_LancamentoHorizontal_Limpar_Um_Click(object sender, EventArgs e)
        {
            Txt_Fis_LancamentoHorizontal_Vy_Um.Text = null;
            Txt_Fis_LancamentoHorizontal_Tempo_Um.Text = null;
            Txt_Fis_LancamentoHorizontal_Gravidade_Um.Text = null;
        }
    }
}

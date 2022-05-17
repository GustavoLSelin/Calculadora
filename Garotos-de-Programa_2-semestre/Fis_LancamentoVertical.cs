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
    public partial class Fis_LancamentoVertical : Form
    {
        public Fis_LancamentoVertical()
        {
            InitializeComponent();
        }
        //----------------- Primeira Conta -------------------//
        double velocidadeinicialum = 0, gravidadeum = 0, tempoum = 0;
        //----------------- Segunda Conta --------------------//
        double gravidadedois = 0, tempodois = 0;
        //---------------- Terceira Conta --------------------//
        double alturainicialtres = 0, velocidadeinicialtres = 0, tempotres = 0, gravidadetres = 0;

        private void Btn_Fis_LancamentoVertical_Calcular_Tres_Click(object sender, EventArgs e)
        {
            alturainicialtres = Convert.ToDouble(Txt_Fis_LancamentoVertical_AlturaInicial_Tres.Text);
            velocidadeinicialtres = Convert.ToDouble(Txt_Fis_LancamentoVertical_VelocidadeInicial_Tres.Text);
            tempotres = Convert.ToDouble(Txt_Fis_LancamentoVertical_Tempo_Tres.Text);
            gravidadetres = Convert.ToDouble(Txt_Fis_LancamentoVertical_Gravidade_Tres.Text);
            Txt_Fis_LancamentoVertical_AlturaFinal_Tres.Text = Convert.ToString(alturainicialtres + velocidadeinicialtres * tempotres + (((gravidadetres * (tempotres * tempotres)) / 2))) + "m";
        }

        private void Btn_Fis_LancamentoVertical_Limpar_Tres_Click(object sender, EventArgs e)
        {
            Txt_Fis_LancamentoVertical_VelocidadeInicial_Tres.Text = null;
            Txt_Fis_LancamentoVertical_Tempo_Tres.Text = null;
            Txt_Fis_LancamentoVertical_TempoQuadrado_Tres.Text = null;
            Txt_Fis_LancamentoVertical_AlturaFinal_Tres.Text = null;
            Txt_Fis_LancamentoVertical_AlturaInicial_Tres.Text = null;
            Txt_Fis_LancamentoVertical_Gravidade_Tres.Text = null;
        }

        private void Btn_Fis_LancamentoVertical_Calcular_Um_Click(object sender, EventArgs e)
        {
            try
            {
                velocidadeinicialum = Convert.ToDouble(Txt_Fis_LancamentoVertical_VelocidadeInical_Um.Text);
                gravidadeum = Convert.ToDouble(Txt_Fis_LancamentoVertical_Gravidade_Um.Text);
                tempoum = Convert.ToDouble(Txt_Fis_LancamentoVertical_Tempo_Um.Text);
                Txt_Fis_LancamentoVertical_VelocidadeFinal_Um.Text = Convert.ToString(velocidadeinicialum + (gravidadeum * tempoum)) + "m/s";
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_LancamentoVertical_Limpar_Dois_Click(object sender, EventArgs e)
        {
            Txt_Fis_LancamentoVertical_Tempo_Dois.Text = null;
            Txt_Fis_LancamentoVertical_Velocidade_Dois.Text = null;
            Txt_Fis_LancamentoVertical_Gravidade_Dois.Text = null;
        }

        private void Btn_Fis_LancamentoVertical_Calcular_Dois_Click(object sender, EventArgs e)
        {
            try
            {
                gravidadedois = Convert.ToDouble(Txt_Fis_LancamentoVertical_Gravidade_Dois.Text);
                tempodois = Convert.ToDouble(Txt_Fis_LancamentoVertical_Tempo_Dois.Text);
                Txt_Fis_LancamentoVertical_Velocidade_Dois.Text = Convert.ToString(Math.Sqrt(2 * (gravidadedois * tempodois)));
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_LancamentoVertical_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Fis_LancamentoVertical_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Fis_LancamentoVertical_Limpar_Um_Click(object sender, EventArgs e)
        {
            Txt_Fis_LancamentoVertical_Gravidade_Um.Text = null;
            Txt_Fis_LancamentoVertical_Tempo_Um.Text = null;
            Txt_Fis_LancamentoVertical_VelocidadeFinal_Um.Text = null;
            Txt_Fis_LancamentoVertical_VelocidadeInical_Um.Text = null;
        }
    }
}

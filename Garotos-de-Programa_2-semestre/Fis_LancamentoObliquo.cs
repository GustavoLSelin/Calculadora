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
    public partial class Fis_LancamentoObliquo : Form
    {
        public Fis_LancamentoObliquo()
        {
            InitializeComponent();
        }
        //------------------ Um ----------------//
        double velocidadeinicial = 0, senum = 0, gravidadeum = 0;
        //----------------- Dois ---------------//
        double velocidadeinicialdois = 0, gravidadedois = 0, sendois = 0;
        //----------------- Tres --------------//
        double velocidadeinicialtres = 0, sentres = 0, tempotres = 0, gravidadetres = 0, tempoquadrado = 0;
        //----------------- Quatro ------------//
        double velocidadeinicialquatro = 0, gravidadequatro = 0, senquatro = 0;
        //----------------- Cinco -------------//
        double vxcinco = 0, vycinco = 0;

        private void Btn_Fis_LancamentoObliquo_Limpar_Seis_Click(object sender, EventArgs e)
        {
            Txt_Fis_LancamentoObliquo_VelocidadeInicial_Seis.Text = null;
            Txt_Fis_LancamentoObliquo_SenAngulo_Seis.Text = null;
            Txt_Fis_LancamentoObliquo_Gravidade_Seis.Text = null;
            Txt_Fis_LancamentoObliquo_Tempo_Seis.Text = null;
            Txt_Fis_LancamentoObliquo_Vy_Seis.Text = null;
        }

        private void Btn_Fis_LancamentoObliquo_Calcular_Seis_Click(object sender, EventArgs e)
        {
            try
            {
                velocidadeinicialseis = Convert.ToDouble(Txt_Fis_LancamentoObliquo_VelocidadeInicial_Seis.Text);
                gravidadeseis = Convert.ToDouble(Txt_Fis_LancamentoObliquo_Gravidade_Seis.Text);
                temposeis = Convert.ToDouble(Txt_Fis_LancamentoObliquo_Tempo_Seis.Text);
                senseis = Convert.ToDouble(Txt_Fis_LancamentoObliquo_SenAngulo_Seis.Text);
                senseis = senseis * 0.0174533;
                senseis = Math.Sin(senseis);
                Txt_Fis_LancamentoObliquo_Vy_Seis.Text = Convert.ToString((velocidadeinicialseis * senseis) - (gravidadeseis * temposeis));
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_LancamentoObliquo_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Fis_LancamentoObliquo_Voltar_Um_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Fis_LancamentoObliquo_Voltar_Dois_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        //---------------- Seis ---------------//
        double velocidadeinicialseis = 0, senseis = 0, gravidadeseis = 0, temposeis = 0;

        private void Btn_Fis_LancamentoObliquo_Calcular_Cinco_Click(object sender, EventArgs e)
        {
            try
            {
                vxcinco = Convert.ToDouble(Txt_Fis_LancamentoObliquo_Vx_Cinco.Text);
                vycinco = Convert.ToDouble(Txt_Fis_LancamentoObliquo_Vy_Cinco.Text);
                vxcinco = Math.Pow(vxcinco, 2);
                vycinco = Math.Pow(vycinco, 2);
                Txt_Fis_LancamentoObliquo_Velocidade_Cinco.Text = Convert.ToString(Math.Sqrt(vxcinco + vycinco));
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_LancamentoObliquo_Limpar_Cinco_Click(object sender, EventArgs e)
        {
            Txt_Fis_LancamentoObliquo_Velocidade_Cinco.Text = null;
            Txt_Fis_LancamentoObliquo_Vx_Cinco.Text = null;
            Txt_Fis_LancamentoObliquo_Vy_Cinco.Text = null;
        }

        private void Btn_Fis_LancamentoObliquo_Calcular_Quatro_Click(object sender, EventArgs e)
        {
            try
            {
                velocidadeinicialquatro = Convert.ToDouble(Txt_Fis_LancamentoObliquo_VelocidadeInicial_Quatro.Text);
                gravidadequatro = Convert.ToDouble(Txt_Fis_LancamentoObliquo_Gravidade_Quatro.Text);
                senquatro = Convert.ToDouble(Txt_Fis_LancamentoObliquo_senquadradoAngulo_Quatro.Text);
                velocidadeinicialquatro = Math.Pow(velocidadeinicialquatro, 2);
                gravidadequatro = 2 * gravidadequatro; 
                senquatro = senquatro * 0.0174533;
                senquatro = Math.Sin(senquatro) * Math.Sin(senquatro);
                Txt_Fis_LancamentoObliquo_AlturaMaxima_Quatro.Text = Convert.ToString((velocidadeinicialquatro * senquatro) / gravidadequatro);
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_LancamentoObliquo_Limpar_Quatro_Click(object sender, EventArgs e)
        {
            Txt_Fis_LancamentoObliquo_AlturaMaxima_Quatro.Text = null;
            Txt_Fis_LancamentoObliquo_VelocidadeInicial_Quatro.Text = null;
            Txt_Fis_LancamentoObliquo_Gravidade_Quatro.Text = null;
            Txt_Fis_LancamentoObliquo_senquadradoAngulo_Quatro.Text = null;
        }

       
        private void Btn_Fis_LancamentoObliquo_Calcular_Tres_Click(object sender, EventArgs e)
        {
            try
            {
                velocidadeinicialtres = Convert.ToDouble(Txt_Fis_LancamentoObliquo_VelocidadeInicial_Tres.Text);
                sentres = Convert.ToDouble(Txt_Fis_LancamentoObliquo_senAngulo_Tres.Text);
                tempotres = Convert.ToDouble(Txt_Fis_LancamentoObliquo_Tempo_Tres.Text);
                gravidadetres = Convert.ToDouble(Txt_Fis_LancamentoObliquo_Gravidade_Tres.Text);
                tempoquadrado = Convert.ToDouble(Txt_Fis_LancamentoObliquo_TempoQuadrado_Tres.Text);
                sentres = sentres * 0.0174533;
                sentres = Math.Sin(sentres);
                tempoquadrado = Math.Pow(tempoquadrado, 2);
                Txt_Fis_LancamentoObliquo_DerivadaAltura_Tres.Text = Convert.ToString(velocidadeinicialtres * sentres * tempotres - 0.5 * gravidadetres * tempoquadrado);
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_LancamentoObliquo_Limpar_Tres_Click(object sender, EventArgs e)
        {
            Txt_Fis_LancamentoObliquo_DerivadaAltura_Tres.Text = null;
            Txt_Fis_LancamentoObliquo_VelocidadeInicial_Tres.Text = null;
            Txt_Fis_LancamentoObliquo_senAngulo_Tres.Text = null;
            Txt_Fis_LancamentoObliquo_TempoQuadrado_Tres.Text = null;
            Txt_Fis_LancamentoObliquo_Tempo_Tres.Text = null;
            Txt_Fis_LancamentoObliquo_Gravidade_Tres.Text = null;
        }

        private void Btn_Fis_LancamentoObliquo_Limpar_Dois_Click(object sender, EventArgs e)
        {
            Txt_Fis_LancamentoObliquo_DerivadaEspaco_Dois.Text = null;
            Txt_Fis_LancamentoObliquo_VelocidadeInicial_Dois.Text = null;
            Txt_Fis_LancamentoObliquo_Gravidade_Dois.Text = null;
            Txt_Fis_LancamentoObliquo_sendoisAngulo_Dois.Text = null;
        }

        private void Btn_Fis_LancamentoObliquo_Calcular_Dois_Click(object sender, EventArgs e)
        {
            velocidadeinicialdois = Convert.ToDouble(Txt_Fis_LancamentoObliquo_VelocidadeInicial_Dois.Text);
            gravidadedois = Convert.ToDouble(Txt_Fis_LancamentoObliquo_Gravidade_Dois.Text);
            sendois = Convert.ToDouble(Txt_Fis_LancamentoObliquo_sendoisAngulo_Dois.Text);
            sendois = sendois * 0.0174533;
            velocidadeinicialdois = Math.Pow(velocidadeinicialdois, 2);
            sendois = Math.Sin(sendois) * Math.Sin(sendois);
            Txt_Fis_LancamentoObliquo_DerivadaEspaco_Dois.Text = Convert.ToString((velocidadeinicialdois * sendois)/gravidadedois);
        }

        private void Btn_Fis_LancamentoObliquo_Limpar_Um_Click(object sender, EventArgs e)
        {
            Txt_Fis_LancamentoObliquo_TempoSubida_Um.Text = null;
            Txt_Fis_LancamentoObliquo_VelocidadeInicial_Um.Text = null;
            Txt_Fis_LancamentoObliquo_Gravidade_Um.Text = null;
            Txt_Fis_LancamentoObliquo_senAngulo_Um.Text = null;
        }

        private void Btn_Fis_LancamentoObliquo_Calcular_Um_Click(object sender, EventArgs e)
        {
            try
            {
                velocidadeinicial = Convert.ToDouble(Txt_Fis_LancamentoObliquo_VelocidadeInicial_Um.Text);
                gravidadeum = Convert.ToDouble(Txt_Fis_LancamentoObliquo_Gravidade_Um.Text);
                senum = Convert.ToDouble(Txt_Fis_LancamentoObliquo_senAngulo_Um.Text);
                senum = senum * 0.0174533;
                senum = Math.Sin(senum);
                Txt_Fis_LancamentoObliquo_TempoSubida_Um.Text = Convert.ToString((velocidadeinicial * senum)/gravidadeum);
            }
            catch
            {
                ;
            }
        }
    }
}

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
    public partial class Fis_QuedaLivre : Form
    {
        public Fis_QuedaLivre()
        {
            InitializeComponent();
        }
        //-------------------- Primeira Conta -------------//
        double velocidadeum = 0, gravidadeum = 0, tempoum = 0;
        //-------------------- Segunda Conta --------------//
        double velocidadedois = 0, gravidadedois = 0, tempodois = 0;
        //-------------------- Terceira conta ------------//
        double alturafinaltres = 0, alturainicialtres = 0, tempotres = 0, gravidadetres = 0;

        private void Btn_Fis_QuedaLivre_Calcular_Tres_Click(object sender, EventArgs e)
        {
            try
            {
                alturainicialtres = Convert.ToDouble(Txt_Fis_QuedaLivre_AlturaInicial_tres.Text);
                tempotres = Convert.ToDouble(Txt_Fis_QuedaLivre_Tempo_tres.Text);
                gravidadetres = Convert.ToDouble(Txt_Fis_QuedaLivre_Gravidade_tres.Text);
                Txt_Fis_QuedaLivre_AlturaFinal_tres.Text = Convert.ToString(alturainicialtres + ((gravidadetres * (tempotres * tempotres)/ 2))) + "m";
            }
            catch
            {
                ;
            }
            
        }

        private void Btn_Fis_QuedaLivre_Limpar_Tres_Click(object sender, EventArgs e)
        {
            Txt_Fis_QuedaLivre_Tempo_tres.Text = null;
            Txt_Fis_QuedaLivre_Gravidade_tres.Text = null;
            Txt_Fis_QuedaLivre_AlturaFinal_tres.Text = null;
            Txt_Fis_QuedaLivre_AlturaInicial_tres.Text = null;
        }

        private void Btn_Fis_QuedaLivre_Limpar_Dois_Click(object sender, EventArgs e)
        {
            Txt_Fis_QuedaLivre_Gravidade_Dois.Text = null;
            Txt_Fis_QuedaLivre_Tempo_Dois.Text = null;
            Txt_Fis_QuedaLivre_Velocidade_Dois.Text = null;
        }

        private void Btn_Fis_QuedaLivre_Calcular_Dois_Click(object sender, EventArgs e)
        {
            try
            {
                gravidadedois = Convert.ToDouble(Txt_Fis_QuedaLivre_Gravidade_Dois.Text);
                tempodois = Convert.ToDouble(Txt_Fis_QuedaLivre_Tempo_Dois.Text);
                Txt_Fis_QuedaLivre_Velocidade_Dois.Text = Convert.ToString(Math.Sqrt(2 * (gravidadedois * tempodois)));
            }
            catch
            {
                ;
            }
            
        }

        private void Btn_Fis_QuedaLivre_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Fis_QuedaLivre_Limpar_Um_Click(object sender, EventArgs e)
        {
            Txt_Fis_QuedaLivre_Tempo_um.Text = null;
            Txt_Fis_QuedaLivre_Velocidade_um.Text = null;
            Txt_Fis_QuedaLivre_Gravidade_um.Text = null;
        }

        private void Btn_Fis_QuedaLivre_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Fis_QuedaLivre_Calcular_Um_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Fis_QuedaLivre_Velocidade_um.Text == "")
                {
                    gravidadeum = Convert.ToDouble(Txt_Fis_QuedaLivre_Gravidade_um.Text);
                    tempoum = Convert.ToDouble(Txt_Fis_QuedaLivre_Tempo_um.Text);
                    Txt_Fis_QuedaLivre_Velocidade_um.Text = Convert.ToString(gravidadeum * tempoum) + "m/s";
                }
                if(Txt_Fis_QuedaLivre_Tempo_um.Text == "")
                {
                    velocidadeum = Convert.ToDouble(Txt_Fis_QuedaLivre_Velocidade_um.Text);
                    gravidadeum = Convert.ToDouble(Txt_Fis_QuedaLivre_Gravidade_um.Text);
                    Txt_Fis_QuedaLivre_Tempo_um.Text = Convert.ToString(velocidadeum / gravidadeum) + "s";
                }
            }
            catch
            {
                ;
            }
        }
    }
}

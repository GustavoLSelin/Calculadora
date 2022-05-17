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
    public partial class Fis_Toriccelli : Form
    {
        public Fis_Toriccelli()
        {
            InitializeComponent();
        }
        double velocidadefinal = 0, aceleracao = 0, tempo = 0;
        private void Btn_Fis_Toriccelli_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Fis_Toriccelli_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                velocidadefinal = Convert.ToDouble(Txt_Fis_Toriccelli_VelocidadeInicial.Text);
                aceleracao = Convert.ToDouble(Txt_Fis_Toriccelli_Aceleracao.Text);
                tempo = Convert.ToDouble(Txt_Fis_Toriccelli_Tempo.Text);
                Txt_Fis_Toriccelli_VelocidadeFinal.Text = Convert.ToString(velocidadefinal + (2 * (aceleracao * tempo)));
                Txt_Fis_Toriccelli_VelocidadeFinal.Text += "m/s";
            }
            catch
            {
                ;
            }
            
        }

        private void Btn_Fis_Toriccelli_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Fis_Toriccelli_Limpar_Click(object sender, EventArgs e)
        {
            try
            {
                Txt_Fis_Toriccelli_Aceleracao.Text = null;
                Txt_Fis_Toriccelli_Tempo.Text = null;
                Txt_Fis_Toriccelli_VelocidadeFinal.Text = null;
                Txt_Fis_Toriccelli_VelocidadeInicial.Text = null;
            }
            catch
            {
                ;
            }
            
        }
    }
}

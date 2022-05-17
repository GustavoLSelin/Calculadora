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
    public partial class Fis_Velocidade_Instantanea : Form
    {
        public Fis_Velocidade_Instantanea()
        {
            InitializeComponent();
        }
        double velocidadeinstantanea = 0, velocidadeinicial = 0, aceleracao = 0, tempo = 0;

        private void Btn_Fis_Limpar_VelocidadeMedia_Click(object sender, EventArgs e)
        {
            Txt_Fis_VelocidadeInstantanea.Text = null;
            Txt_Fis_VelocidadeInstantanea_Aceleracao.Text = null;
            Txt_Fis_VelocidadeInstantanea_Tempo.Text = null;
            Txt_Fis_VelocidadeInstantanea_VelocidadeInicial.Text = null;
        }

        private void Btn_Fis_VelocidadeMedia_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Fis_VelocidadeMedia_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Fis_Calcular_VelocidadeMedia_Click(object sender, EventArgs e)
        {
            try
            {
                velocidadeinicial = Convert.ToDouble(Txt_Fis_VelocidadeInstantanea_VelocidadeInicial.Text);
                aceleracao = Convert.ToDouble(Txt_Fis_VelocidadeInstantanea_Aceleracao.Text);
                tempo = Convert.ToDouble(Txt_Fis_VelocidadeInstantanea_Tempo.Text);
                velocidadeinstantanea = velocidadeinicial + (aceleracao * tempo);
                Txt_Fis_VelocidadeInstantanea.Text = Convert.ToString(velocidadeinstantanea) + "m/s";
            }
            catch
            {
                ;
            }
            
        }
    }
}

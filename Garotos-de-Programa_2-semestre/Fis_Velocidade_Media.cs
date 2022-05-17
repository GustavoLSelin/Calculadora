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
    public partial class Fis_Velocidade_Media : Form
    {
        public Fis_Velocidade_Media()
        {
            InitializeComponent();
        }
        double velocidademedia_velocidade = 0, tf_velocidademedia = 0, ti_velocidademedia = 0, ef_velocidademedia = 0, ei_velocidademedia = 0;
        private void Btn_Fis_Limpar_VelocidadeMedia_Click(object sender, EventArgs e)
        {
            Txt_Fis_VelocidadeMedia.Text = null;
            Txt_Fis_VelocidadeMedia_EF.Text = null;
            Txt_Fis_VelocidadeMedia_EI.Text = null;
            Txt_Fis_VelocidadeMedia_TF.Text = null;
            Txt_Fis_VelocidadeMedia_TI.Text = null;
        }

        private void Btn_Fis_VelocidadeMedia_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Fis_VelocidadeMedia_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Fis_Calcular_VelocidadeMedia_Click(object sender, EventArgs e)
        {
            try
            {
                tf_velocidademedia = Convert.ToDouble(Txt_Fis_VelocidadeMedia_TF.Text);
                ti_velocidademedia = Convert.ToDouble(Txt_Fis_VelocidadeMedia_TI.Text);
                ef_velocidademedia = Convert.ToDouble(Txt_Fis_VelocidadeMedia_EF.Text);
                ei_velocidademedia = Convert.ToDouble(Txt_Fis_VelocidadeMedia_EI.Text);
                velocidademedia_velocidade = ((ef_velocidademedia - ei_velocidademedia) / (tf_velocidademedia - ti_velocidademedia));
                if (Cob_Fis_VelocidadeMeida.Text == "Km/h")
                {
                    Txt_Fis_VelocidadeMedia.Text = Convert.ToString(velocidademedia_velocidade) + Cob_Fis_VelocidadeMeida.Text;
                }
                else if (Cob_Fis_VelocidadeMeida.Text == "m/s")
                {
                    Txt_Fis_VelocidadeMedia.Text = Convert.ToString(velocidademedia_velocidade) + Cob_Fis_VelocidadeMeida.Text;
                }
            }
            catch
            {
                ;
            }
        }
    }
}

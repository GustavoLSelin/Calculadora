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
    public partial class Fis_Velocidade : Form
    {
        public Fis_Velocidade()
        {
            InitializeComponent();
        }
        double velocidade_velocidade = 0, tempo_velocidade = 0, distancia_velocidade = 0;
        private void Btn_Fis_Velocidade_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                tempo_velocidade = Convert.ToDouble(Txt_Fis_Velocidade_Tempo.Text);
                distancia_velocidade = Convert.ToDouble(Txt_Fis_Velocidade_Espaco.Text);
                velocidade_velocidade = (distancia_velocidade / tempo_velocidade);
                if (Cob_Fis_Velocidade.Text == "Km/h")
                {
                    Txt_Fis_Velocidade.Text = Convert.ToString(velocidade_velocidade) + Cob_Fis_Velocidade.Text;
                }
                else if (Cob_Fis_Velocidade.Text == "m/s")
                {
                    Txt_Fis_Velocidade.Text = Convert.ToString(velocidade_velocidade) + Cob_Fis_Velocidade.Text;
                }
            }
            catch
            {
                ;
            }
        }
        private void Btn_Fis_Velocidade_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Fis_Velocidade.Text = null;
            Txt_Fis_Velocidade_Espaco.Text = null;
            Txt_Fis_Velocidade_Tempo.Text = null;
        }
        private void Btn_Fis_Cinematica_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }
        private void Btn_Fis_Cinematica_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }
    }
}

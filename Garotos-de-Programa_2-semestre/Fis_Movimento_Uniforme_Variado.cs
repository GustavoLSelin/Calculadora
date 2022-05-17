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
    public partial class Fis_Movimento_Uniforme_Variado : Form
    {
        public Fis_Movimento_Uniforme_Variado()
        {
            InitializeComponent();
        }
        double velocidadeinicial = 0, aceleracao = 0, tempo = 0;
        private void Btn_Fis_Movimento_Uniforme_Variado_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Fis_Movimento_Uniforme_Variado_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Fis_Movimento_Uniforme_Variado_Aceleracao.Text = null;
            Txt_Fis_Movimento_Uniforme_Variado_Tempo.Text = null;
            Txt_Fis_Movimento_Uniforme_Variado_VelocidadeFinal.Text = null;
            Txt_Fis_Movimento_Uniforme_Variado_VelocidadeInicial.Text = null;

        }

        private void Btn_Fis_Movimento_Uniforme_Variado_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Fis_Movimento_Uniforme_Variado_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                velocidadeinicial = Convert.ToDouble(Txt_Fis_Movimento_Uniforme_Variado_VelocidadeInicial.Text);
                aceleracao = Convert.ToDouble(Txt_Fis_Movimento_Uniforme_Variado_Aceleracao.Text);
                tempo = Convert.ToDouble(Txt_Fis_Movimento_Uniforme_Variado_Tempo.Text);
                Txt_Fis_Movimento_Uniforme_Variado_VelocidadeFinal.Text = Convert.ToString(velocidadeinicial + (aceleracao * tempo));
            }
            catch
            {
                ;
            }
        }
    }
}

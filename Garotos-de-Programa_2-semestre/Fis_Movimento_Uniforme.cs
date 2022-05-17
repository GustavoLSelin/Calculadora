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
    public partial class Fis_Movimento_Uniforme : Form
    {
        public Fis_Movimento_Uniforme()
        {
            InitializeComponent();
        }
        double posicaoinicial = 0, velocidade = 0, tempo = 0;

        private void Btn_Fis_Cinematica_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Fis_Cinematica_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Fis_MovimentoUniforme_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Fis_MovimentoUniforme_Posicao_Final.Text = null;
            Txt_Fis_MovimentoUniforme_Posicao_Inicial.Text = null;
            Txt_Fis_MovimentoUniforme_Tempo.Text = null;
            Txt_Fis_MovimentoUniforme_Velocidade.Text = null;
        }

        private void Btn_Fis_MovimentoUniforme_Calcular_Click(object sender, EventArgs e)
        {
            posicaoinicial = Convert.ToDouble(Txt_Fis_MovimentoUniforme_Posicao_Inicial.Text);
            velocidade = Convert.ToDouble(Txt_Fis_MovimentoUniforme_Velocidade.Text);
            tempo = Convert.ToDouble(Txt_Fis_MovimentoUniforme_Tempo.Text);
            posicaoinicial = posicaoinicial + (velocidade * tempo);
            Txt_Fis_MovimentoUniforme_Posicao_Final.Text = Convert.ToString(posicaoinicial);
        }
    }
}

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
    public partial class Ele_ForcaEletromotriz : Form
    {
        public Ele_ForcaEletromotriz()
        {
            InitializeComponent();
        }
        double fluxo = 0, tempo = 0;
        private void Btn_Ele_ForcaEletromotriz_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Ele_ForcaEletromotriz_Calcular_Click(object sender, EventArgs e)
        {
            fluxo = Convert.ToDouble(Txt_Ele_ForcaEletromotriz_Fluxo.Text);
            tempo = Convert.ToDouble(Txt_Ele_ForcaEletromotriz_Tempo.Text);
            Txt_Ele_ForcaEletromotriz_ForcaEletromotiz.Text = Convert.ToString(fluxo / tempo);
        }

        private void Btn_Ele_ForcaEletromotriz_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Ele_ForcaEletromotriz_Fluxo.Text = null;
            Txt_Ele_ForcaEletromotriz_ForcaEletromotiz.Text = null;
            Txt_Ele_ForcaEletromotriz_Tempo.Text = null;
        }

        private void Btn_Ele_ForcaEletromotriz_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }
    }
}

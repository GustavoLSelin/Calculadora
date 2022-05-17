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
    public partial class Ele_AssociacaodeResistores : Form
    {
        public Ele_AssociacaodeResistores()
        {
            InitializeComponent();
        }
        double RUmEquivalente = 0, RDoisEquivalente = 0, RUmParalelo = 0, RDoisParalelo = 0;

        private void Btn_Ele_AssociacaodeResistores_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Ele_Tensao_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Ele_AssociacaodeResistores_CalcularPararelo_Click(object sender, EventArgs e)
        {
            try
            {
                RUmParalelo = Convert.ToDouble(Txt_Ele_AssociacaodeResistores_ResistorUmParalelo.Text);
                RDoisParalelo = Convert.ToDouble(Txt_Ele_AssociacaodeResistores_ResistorDoisParalelo.Text);
                Txt_Ele_AssociacaodeResistores_ResistorEquivalenteParalelo.Text = Convert.ToString(1 / ((1 / RUmParalelo) + (1 / RDoisParalelo)));
                Txt_Ele_AssociacaodeResistores_ResistorUmParalelo.Text = Convert.ToString(1 / ((1 / RUmParalelo) + (1 / RDoisParalelo)));
                Txt_Ele_AssociacaodeResistores_ResistorDoisParalelo.Text = null;
            }
            catch
            {
                ;
            }
        }

        private void Btn_Ele_AssociacaodeResistores_CalcularEquivalente_Click(object sender, EventArgs e)
        {
            try
            {
                RUmEquivalente = Convert.ToDouble(Txt_Ele_AssociacaodeResistores_ResistorUmEquivalente.Text);
                RDoisEquivalente = Convert.ToDouble(Txt_Ele_AssociacaodeResistores_ResistorDoisEquivalente.Text);
                Txt_Ele_AssociacaodeResistores_ResistorEquivalenteEquivalente.Text = Convert.ToString(RUmEquivalente + RDoisEquivalente);
                Txt_Ele_AssociacaodeResistores_ResistorUmEquivalente.Text = Convert.ToString(RUmEquivalente + RDoisEquivalente);
                Txt_Ele_AssociacaodeResistores_ResistorDoisEquivalente.Text = null;
            }
            catch
            {
                ;
            }
        }

        private void Btn_Ele_AssociacaodeResistores_LimparPararelo_Click(object sender, EventArgs e)
        {
            Txt_Ele_AssociacaodeResistores_ResistorEquivalenteParalelo.Text = null;
            Txt_Ele_AssociacaodeResistores_ResistorUmParalelo.Text = null;
            Txt_Ele_AssociacaodeResistores_ResistorDoisParalelo.Text = null;
        }

        private void Btn_Ele_AssociacaodeResistores_LimparEquivalente_Click(object sender, EventArgs e)
        {
            Txt_Ele_AssociacaodeResistores_ResistorEquivalenteEquivalente.Text = null;
            Txt_Ele_AssociacaodeResistores_ResistorUmEquivalente.Text = null;
            Txt_Ele_AssociacaodeResistores_ResistorDoisEquivalente.Text = null;
        }
    }
}

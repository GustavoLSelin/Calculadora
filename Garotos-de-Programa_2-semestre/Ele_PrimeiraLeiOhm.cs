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
    public partial class Ele_PrimeiraLeiOhm : Form
    {
        public Ele_PrimeiraLeiOhm()
        {
            InitializeComponent();
        }
        double volt = 0, ampere = 0;

        private void Btn_Ele_PrimeiraLeiOhm_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Ele_PrimeiraLeiOhm_Ampere.Text = null;
            Txt_Ele_PrimeiraLeiOhm_Resistencia.Text = null;
            Txt_Ele_PrimeiraLeiOhm_Volt.Text = null;
        }

        private void Btn_Ele_PrimeiraLeiOhm_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Ele_PrimeiraLeiOhm_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Ele_PrimeiraLeiOhm_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                volt = Convert.ToDouble(Txt_Ele_PrimeiraLeiOhm_Volt.Text);
                ampere = Convert.ToDouble(Txt_Ele_PrimeiraLeiOhm_Ampere.Text);
                Txt_Ele_PrimeiraLeiOhm_Resistencia.Text = Convert.ToString(volt / ampere) + "Ω";
            }
            catch
            {
                ;
            }
        }
    }
}

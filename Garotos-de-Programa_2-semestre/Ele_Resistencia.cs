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
    public partial class Ele_Resistencia : Form
    {
        public Ele_Resistencia()
        {
            InitializeComponent();
        }
        double resistenciaUm = 0, correnteUm = 0, resistenciaDois = 0, voltDois = 0;
        private void Btn_Ele_Resistencia_LimparUm_Click(object sender, EventArgs e)
        {
            Txt_Ele_Resistencia_CorrenteUm.Text = null;
            Txt_Ele_Resistencia_ResistenciaUm.Text = null;
            Txt_Ele_Resistencia_VoltUm.Text = null;
        }

        private void Btn_Ele_Resistencia_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Ele_Resistencia_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Ele_Resistencia_LimparDois_Click(object sender, EventArgs e)
        {
            Txt_Ele_Resistencia_CorrenteDois.Text = null;
            Txt_Ele_Resistencia_ResistenciaDois.Text = null;
            Txt_Ele_Resistencia_VoltDois.Text = null;
        }

        private void Btn_Ele_Resistencia_CalcularDois_Click(object sender, EventArgs e)
        {
            try
            {
                resistenciaDois = Convert.ToDouble(Txt_Ele_Resistencia_ResistenciaDois.Text);
                voltDois = Convert.ToDouble(Txt_Ele_Resistencia_VoltDois.Text);
                Txt_Ele_Resistencia_CorrenteDois.Text = Convert.ToString(voltDois / resistenciaDois) + " A";
            }
            catch
            {
                ;
            }
        }

        private void Btn_Ele_Resistencia_CalcularUm_Click(object sender, EventArgs e)
        {
            try
            {
                resistenciaUm = Convert.ToDouble(Txt_Ele_Resistencia_ResistenciaUm.Text);
                correnteUm = Convert.ToDouble(Txt_Ele_Resistencia_CorrenteUm.Text);
                Txt_Ele_Resistencia_VoltUm.Text = Convert.ToString(resistenciaUm * correnteUm) + " V";
            }
            catch
            {
                ;
            }
        }
    }
}

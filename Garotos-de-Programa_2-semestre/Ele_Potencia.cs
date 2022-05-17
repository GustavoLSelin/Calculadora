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
    public partial class Ele_Potencia : Form
    {
        public Ele_Potencia()
        {
            InitializeComponent();
        }
        double volt = 0, amperes = 0;
        private void Btn_Ele_Potencia_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Ele_Potencia_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Ele_Potencia_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Ele_Potencia_Amperes.Text = null;
            Txt_Ele_Potencia_Potencia.Text = null;
            Txt_Ele_Potencia_Volt.Text = null;
        }

        private void Btn_Ele_Potencia_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                volt = Convert.ToDouble(Txt_Ele_Potencia_Volt.Text);
                amperes = Convert.ToDouble(Txt_Ele_Potencia_Amperes.Text);
                Txt_Ele_Potencia_Potencia.Text = Convert.ToString(volt * amperes) + "W";
            }
            catch
            {
                ;
            }
        }
    }
}

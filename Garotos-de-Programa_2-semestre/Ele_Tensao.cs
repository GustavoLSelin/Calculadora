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
    public partial class Ele_Tensao : Form
    {
        public Ele_Tensao()
        {
            InitializeComponent();
        }
        double couloms = 0, jaules = 0;
        private void Btn_Ele_Tensao_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Ele_Tensao_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Ele_Tensao_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Ele_Tensao_Coulomb.Text = null;
            Txt_Ele_Tensao_Jaules.Text = null;
            Txt_Ele_Tensao_Volt.Text = null;
        }

        private void Btn_Ele_Tensao_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                couloms = Convert.ToDouble(Txt_Ele_Tensao_Coulomb.Text);
                jaules = Convert.ToDouble(Txt_Ele_Tensao_Jaules.Text);
                Txt_Ele_Tensao_Volt.Text = Convert.ToString(jaules / couloms);
            }
            catch
            {
                ;
            }
        }
    }
}

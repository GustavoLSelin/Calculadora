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
    public partial class Ele_Binario_Decimal : Form
    {
        public Ele_Binario_Decimal()
        {
            InitializeComponent();
            Web_Ele_Binario_Decimal.ScriptErrorsSuppressed = true;
        }

        private void Btn_Ele_Binario_Decimal_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Binario_Decimal_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }
    }
}

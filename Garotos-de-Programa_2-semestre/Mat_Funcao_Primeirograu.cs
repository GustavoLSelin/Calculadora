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
    public partial class Mat_Funcao_Primeirograu : Form
    {
        public Mat_Funcao_Primeirograu()
        {
            InitializeComponent();
            Web_Mat_Fracoes_Primeirograu.ScriptErrorsSuppressed = true;
        }
        
        double a = 0, b = 0, resultado = 0;
        private void Btn_Mat_Funcao_Primeirograu_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Txt_Mat_Funcao_Primeirograu_Resultado.Text = null;
            Txt_Mat_Funcao_Primeirograu_x.Text = null;
            Txt_Mat_Funcao_Primeirograu_y.Text = null;
        }

        private void Btn_Mat_Funcao_Primeirograu_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Mat_Funcao_Primeirograu_Calcular_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Txt_Mat_Funcao_Primeirograu_x.Text);
            b = Convert.ToDouble(Txt_Mat_Funcao_Primeirograu_y.Text);
            resultado = ((b * -1) / a);
            Txt_Mat_Funcao_Primeirograu_Resultado.Text = Convert.ToString(resultado);
        }
    }
}

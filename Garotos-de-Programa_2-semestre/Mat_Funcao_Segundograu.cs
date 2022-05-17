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
    public partial class Mat_Funcao_Segundograu : Form
    {
        public Mat_Funcao_Segundograu()
        {
            InitializeComponent();
            Web_Mat_Fracoes_Segundograu.ScriptErrorsSuppressed = true;
        }
        double xquadrado = 0, x = 0, c = 0, delta = 0, x1 = 0, x2 = 0, xv = 0, yv = 0;
        private void Btn_Mat_Funcao_Segundograu_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Mat_Funcao_Segundograu_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Mat_Bhaskara_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Funcao_Segundoograu_C.Text = null;
            Txt_Mat_Funcao_Segundoograu_RDelta.Text = null;
            Txt_Mat_Funcao_Segundoograu_RX1.Text = null;
            Txt_Mat_Funcao_Segundoograu_RX2.Text = null;
            Txt_Mat_Funcao_Segundoograu_RXV.Text = null;
            Txt_Mat_Funcao_Segundoograu_RYV.Text = null;
            Txt_Mat_Funcao_Segundoograu_X.Text = null;
            Txt_Mat_Funcao_Segundoograu_X_Quadrado.Text = null;

        }

        private void Btn_Mat_Bhaskara_Calcular_Click(object sender, EventArgs e)
        {
            xquadrado = Convert.ToDouble(Txt_Mat_Funcao_Segundoograu_X_Quadrado.Text);
            x = Convert.ToDouble(Txt_Mat_Funcao_Segundoograu_X.Text);
            c = Convert.ToDouble(Txt_Mat_Funcao_Segundoograu_C.Text);
            delta = ((x * x) - (4 * xquadrado * c));
            x1 = (((x * -1) + Math.Sqrt(delta)) / (2 * xquadrado));
            x2 = (((x * -1) - Math.Sqrt(delta)) / (2 * xquadrado));
            xv = ((x * -1) / (2 * xquadrado));
            yv = ((delta * -1) / (4 * xquadrado));
            Txt_Mat_Funcao_Segundoograu_RDelta.Text = Convert.ToString(delta);
            Txt_Mat_Funcao_Segundoograu_RX1.Text = Convert.ToString(x1);
            Txt_Mat_Funcao_Segundoograu_RX2.Text = Convert.ToString(x2);
            Txt_Mat_Funcao_Segundoograu_RXV.Text = Convert.ToString(xv);
            Txt_Mat_Funcao_Segundoograu_RYV.Text = Convert.ToString(yv);
        }
    }
}

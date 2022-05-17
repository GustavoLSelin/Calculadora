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
    public partial class Mat_Bhaskara : Form
    {
        public Mat_Bhaskara()
        {
            InitializeComponent();
        }

        double xquadrado = 0, x = 0, c = 0, delta = 0, x1 = 0, x2 = 0;

        private void Btn_Mat_Bhaskara_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Bhaskara_C.Text = null;
            Txt_Mat_Bhaskara_Delta.Text = null;
            Txt_Mat_Bhaskara_X.Text = null;
            Txt_Mat_Bhaskara_X1.Text = null;
            Txt_Mat_Bhaskara_X2.Text = null;
            Txt_Mat_Bhaskara_X_quadrado.Text = null;
        }

        private void Btn_Mat_Porcentagem_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Mat_Porcentagem_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Mat_Bhaskara_Calcular_Click(object sender, EventArgs e)
        {
            try { 
            xquadrado = Convert.ToDouble(Txt_Mat_Bhaskara_X_quadrado.Text);
            x = Convert.ToDouble(Txt_Mat_Bhaskara_X.Text);
            c = Convert.ToDouble(Txt_Mat_Bhaskara_C.Text);
            delta = ((x*x) - (4 * xquadrado * c));
                if(delta >= 0)
                {
                    x1 = (((x * -1) + Math.Sqrt(delta)) / (2 * xquadrado));
                    x2 = (((x * -1) - Math.Sqrt(delta)) / (2 * xquadrado));
                    Txt_Mat_Bhaskara_Delta.Text = Convert.ToString(delta);
                    Txt_Mat_Bhaskara_X1.Text = Convert.ToString(x1);
                    Txt_Mat_Bhaskara_X2.Text = Convert.ToString(x2);
                }
                else
                {
                    Txt_Mat_Bhaskara_Delta.Text = Convert.ToString(delta);
                    Txt_Mat_Bhaskara_X1.Text = null;
                    Txt_Mat_Bhaskara_X2.Text = null;
                    MessageBox.Show("O Delta é NEGATIVO", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            
            }
            catch
            {
                MessageBox.Show("Digite os 3 numeros para fazer a operação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}

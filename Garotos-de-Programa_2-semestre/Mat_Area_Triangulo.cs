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
    public partial class Mat_Area_Triangulo : Form
    {
        public Mat_Area_Triangulo()
        {
            InitializeComponent();
        }
        double b = 0, h = 0, a = 0, p = 0;
        private void Btn_Mat_Area_Triangulo_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Mat_Area_Triangulo_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Triangulo_Altura.Text = null;
            Txt_Mat_Area_Triangulo_Area.Text = null;
            Txt_Mat_Area_Triangulo_Base.Text = null;
        }

        private void Btn_Mat_Area_Triangulo_P_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Triangulo_P_Lado.Text = null;
            Txt_Mat_Area_Triangulo_P_Perimetro.Text = null;
        }

        private void Btn_Mat_Area_Triangulo_P_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                p = Convert.ToDouble(Txt_Mat_Area_Triangulo_P_Lado.Text);
                Txt_Mat_Area_Triangulo_P_Perimetro.Text = Convert.ToString(3 * p);
            }
            catch
            {
                ;
            }
        }

        private void Btn_Mat_Area_Triangulo_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Mat_Area_Triangulo_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(Txt_Mat_Area_Triangulo_Base.Text);
                h = Convert.ToDouble(Txt_Mat_Area_Triangulo_Altura.Text);
                a = ((b * h) / 2);
                Txt_Mat_Area_Triangulo_Area.Text = Convert.ToString(a);
            }
            catch
            {
                ;
            }
        }
    }
}

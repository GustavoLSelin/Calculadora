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
    public partial class Mat_Area_Quadrado : Form
    {
        public Mat_Area_Quadrado()
        {
            InitializeComponent();
        }
        double l = 0, p = 0;
        private void Btn_Mat_Area_Quadrado_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Mat_Area_Quadrado_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Mat_Area_Quadrado_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                l = Convert.ToDouble(Txt_Mat_Area_Quadrado_Lado.Text);
                Txt_Mat_Area_Quadrado_Area.Text = Convert.ToString(l * l);
            }
            catch
            {
                ;
            }
        }
        private void Btn_Mat_Area_Quadrado_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Quadrado_Area.Text = null;
            Txt_Mat_Area_Quadrado_Lado.Text = null;
        }

        private void Btn_Mat_Area_Quadrado_P_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Quadrado_P_Lado.Text = null;
            Txt_Mat_Area_Quadrado_P_Perimetro.Text = null;
        }

        private void Btn_Mat_Area_Quadrado_P_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                p = Convert.ToDouble(Txt_Mat_Area_Quadrado_P_Lado.Text);
                Txt_Mat_Area_Quadrado_P_Perimetro.Text = Convert.ToString(4 * p);
            }
            catch
            {
                ;
            }
        }
    }
}

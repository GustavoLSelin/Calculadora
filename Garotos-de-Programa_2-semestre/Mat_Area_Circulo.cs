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
    public partial class Mat_Area_Circulo : Form
    {
        public Mat_Area_Circulo()
        {
            InitializeComponent();
        }
        double r = 0, d = 0, p = 0;
        private void Btn_Mat_Area_Circulo_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                r = Convert.ToDouble(Txt_Mat_Area_Circulo_Raio.Text);
                Txt_Mat_Area_Circulo_Area.Text = Convert.ToString(3.1416 * (r * r));
            }
            catch
            {
                ;
            }
        }

        private void Btn_Mat_Area_Circulo_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Circulo_Area.Text = null;
            Txt_Mat_Area_Circulo_Raio.Text = null;
        }

        private void Btn_Mat_Area_Circulo_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Mat_Area_Circulo_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Mat_Area_Circulo_D_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Circulo_D_Diametro.Text = null; 
            Txt_Mat_Area_Circulo_D_Raio.Text = null;
        }

        private void Btn_Mat_Area_Circulo_P_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Circulo_P_Perimetro.Text = null;
            Txt_Mat_Area_Circulo_P_Raio.Text = null;
        }

        private void Btn_Mat_Area_Circulo_P_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                p = Convert.ToDouble(Txt_Mat_Area_Circulo_P_Raio.Text);
                Txt_Mat_Area_Circulo_P_Perimetro.Text = Convert.ToString((2 * 3.1416) * p);
            }
            catch
            {
                ;
            }

        }
        private void Btn_Mat_Area_Circulo_D_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                d = Convert.ToDouble(Txt_Mat_Area_Circulo_D_Raio.Text);
                Txt_Mat_Area_Circulo_D_Diametro.Text = Convert.ToString(d * 2);
            }
            catch
            {
                ;
            }
        }
    }
}

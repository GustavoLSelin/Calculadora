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
    public partial class Mat_Area_Paralelogramo : Form
    {
        public Mat_Area_Paralelogramo()
        {
            InitializeComponent();
        }
        double b = 0, a = 0, ladoa = 0, ladob = 0;
        private void Btn_Mat_Area_Paralelogramo_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Mat_Area_Paralelogramo_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Mat_Area_Paralelogramo_P_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Paralelogramo_P_LadoA.Text = null;
            Txt_Mat_Area_Paralelogramo_P_LadoB.Text = null;
            Txt_Mat_Area_Paralelogramo_P_Perimetro.Text = null;

        }

        private void Btn_Mat_Area_Paralelogramo_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Paralelogramo_Altura.Text = null;
            Txt_Mat_Area_Paralelogramo_Base.Text = null;
            Txt_Mat_Area_Paralelogramo_Area.Text = null;
        }

        private void Btn_Mat_Area_Paralelogramo_P_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                ladoa = Convert.ToDouble(Txt_Mat_Area_Paralelogramo_P_LadoA.Text);
                ladob = Convert.ToDouble(Txt_Mat_Area_Paralelogramo_P_LadoB.Text);
                Txt_Mat_Area_Paralelogramo_P_Perimetro.Text = Convert.ToString(2 * (ladoa + ladob));
            }
            catch
            {
                ;
            }
        }

        private void Btn_Mat_Area_Paralelogramo_Calcular_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(Txt_Mat_Area_Paralelogramo_Base.Text);
            a = Convert.ToDouble(Txt_Mat_Area_Paralelogramo_Altura.Text);
            Txt_Mat_Area_Paralelogramo_Area.Text = Convert.ToString(a * b);
        }
    }
}

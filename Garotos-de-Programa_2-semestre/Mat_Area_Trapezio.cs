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
    public partial class Mat_Area_Trapezio : Form
    {
        public Mat_Area_Trapezio()
        {
            InitializeComponent();
        }
        double basemenor = 0, basemaior = 0, altura = 0, bme = 0, bma = 0, l1 = 0, l2 = 0;

        private void Btn_Mat_Area_Trapezio_P_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Trapezio_P_BaseMaior.Text = null;
            Txt_Mat_Area_Trapezio_P_BaseMenor.Text = null;
            Txt_Mat_Area_Trapezio_P_Lado1.Text = null;
            Txt_Mat_Area_Trapezio_P_Lado2.Text = null;
            Txt_Mat_Area_Trapezio_P_Perimetro.Text = null;
        }

        private void Btn_Mat_Area_Trapezio_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Mat_Area_Trapezio_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Trapezio_Altura.Text = null;
            Txt_Mat_Area_Trapezio_Area.Text = null;
            Txt_Mat_Area_Trapezio_BaseMaior.Text = null;
            Txt_Mat_Area_Trapezio_BaseMenor.Text = null;
        }

        private void Btn_Mat_Area_Trapezio_P_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                bma = Convert.ToDouble(Txt_Mat_Area_Trapezio_P_BaseMaior.Text);
                bme = Convert.ToDouble(Txt_Mat_Area_Trapezio_P_BaseMenor.Text);
                l1 = Convert.ToDouble(Txt_Mat_Area_Trapezio_P_Lado1.Text);
                l2 = Convert.ToDouble(Txt_Mat_Area_Trapezio_P_Lado2.Text);
                Txt_Mat_Area_Trapezio_P_Perimetro.Text = Convert.ToString(bma + bme + l1 + l2);
            }
            catch
            {
                ;
            }
        }

        private void Btn_Mat_Area_Trapezio_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Mat_Area_Trapezio_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                basemaior = Convert.ToDouble(Txt_Mat_Area_Trapezio_BaseMaior.Text);
                basemenor = Convert.ToDouble(Txt_Mat_Area_Trapezio_BaseMenor.Text);
                altura = Convert.ToDouble(Txt_Mat_Area_Trapezio_Altura.Text);
                Txt_Mat_Area_Trapezio_Area.Text = Convert.ToString(((basemaior + basemenor) * altura)/2);
            }
            catch
            {
                ;
            }
        }
    }
}

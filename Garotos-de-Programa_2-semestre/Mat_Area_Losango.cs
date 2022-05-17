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
    public partial class Mat_Area_Losango : Form
    {
        public Mat_Area_Losango()
        {
            InitializeComponent();
        }
        double dmaior = 0, dmenor = 0, l = 0;

        private void Btn_Mat_Area_Losango_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Mat_Area_Losango_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Mat_Area_Losango_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Losango_Area.Text = null;
            Txt_Mat_Area_Losango_DiagonalMaior.Text = null;
            Txt_Mat_Area_Losango_DiagonalMenor.Text = null;

        }

        private void Btn_Mat_Area_Losango_P_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Losango_P_Lado.Text = null;
            Txt_Mat_Area_Losango_P_Preimetro.Text = null;
        }

        private void Btn_Mat_Area_Losango_P_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                l = Convert.ToDouble(Txt_Mat_Area_Losango_P_Lado.Text);
                Txt_Mat_Area_Losango_P_Preimetro.Text = Convert.ToString(4 * l);
            }
            catch
            {
                ;
            }
        }

        private void Btn_Mat_Area_Losango_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                dmaior = Convert.ToDouble(Txt_Mat_Area_Losango_DiagonalMaior.Text);
                dmenor = Convert.ToDouble(Txt_Mat_Area_Losango_DiagonalMenor.Text);
                Txt_Mat_Area_Losango_Area.Text = Convert.ToString((dmaior * dmenor) / 2);
            }
            catch
            {
                ;
            }
        }
    }
}

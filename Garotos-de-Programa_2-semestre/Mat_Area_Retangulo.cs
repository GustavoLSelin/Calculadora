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
    public partial class Mat_Area_Retangulo : Form
    {
        public Mat_Area_Retangulo()
        {
            InitializeComponent();
        }
        double  b = 0, h = 0, ba = 0, al = 0;
        private void Btn_Mat_Area_Retangulo_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Mat_Area_Retangulo_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Mat_Area_Retangulo_P_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Retangulo_P_Altura.Text = null;
            Txt_Mat_Area_Retangulo_P_Base.Text = null;
            Txt_Mat_Area_Retangulo_P_Perímetro.Text = null;
        }

        private void Btn_Mat_Area_Retangulo_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Retangulo_Altura.Text = null;
            Txt_Mat_Area_Retangulo_Area.Text = null;
            Txt_Mat_Area_Retangulo_Base.Text = null;
        }

        private void Btn_Mat_Area_Retangulo_P_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                ba = Convert.ToDouble(Txt_Mat_Area_Retangulo_P_Base.Text);
                al = Convert.ToDouble(Txt_Mat_Area_Retangulo_P_Altura.Text);
                Txt_Mat_Area_Retangulo_P_Perímetro.Text = Convert.ToString(2 * (ba + al));
            }
            catch
            {
                ;
            }
        }

        private void Btn_Mat_Area_Retangulo_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(Txt_Mat_Area_Retangulo_Base.Text);
                h = Convert.ToDouble(Txt_Mat_Area_Retangulo_Altura.Text);
                Txt_Mat_Area_Retangulo_Area.Text = Convert.ToString(b * h);
            }
            catch
            {
                ;
            }
        }
    }
}

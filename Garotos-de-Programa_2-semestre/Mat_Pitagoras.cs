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
    public partial class Mat_Pitagoras : Form
    {
        public Mat_Pitagoras()
        {
            InitializeComponent();
        }
        double catetoa = 0, catetob = 0, hipotenusa = 0;
        private void Btn_Mat_Area_Pitagoras_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Mat_Area_Pitagoras_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Area_Pitagoras_Caeto1.Text = null;
            Txt_Mat_Area_Pitagoras_Caeto2.Text = null;
            Txt_Mat_Area_Pitagoras_Hipotenusa.Text = null;
            Txt_Mat_Area_Pitagoras_Resposta.Text = null;
            L_Mat_Area_Pitagoras_Resposta.Text = "Resposta = ";
        }

        private void Btn_Mat_Area_Pitagoras_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Mat_Area_Pitagoras_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Mat_Area_Pitagoras_Hipotenusa.Text == "x" || Txt_Mat_Area_Pitagoras_Hipotenusa.Text == "X")
                {
                    catetoa = Convert.ToDouble(Txt_Mat_Area_Pitagoras_Caeto1.Text);
                    catetob = Convert.ToDouble(Txt_Mat_Area_Pitagoras_Caeto2.Text);//Math.Sqrt(delta)
                    hipotenusa = ((catetoa * catetoa) + (catetob * catetob));
                    Txt_Mat_Area_Pitagoras_Hipotenusa.Text = Convert.ToString(Math.Sqrt(hipotenusa));
                    L_Mat_Area_Pitagoras_Resposta.Text = "Hipotenusa =";
                    Txt_Mat_Area_Pitagoras_Resposta.Text = Convert.ToString(Math.Sqrt(hipotenusa));

                }
                else if(Txt_Mat_Area_Pitagoras_Caeto1.Text == "x" || Txt_Mat_Area_Pitagoras_Caeto1.Text == "X")
                {
                    catetob = Convert.ToDouble(Txt_Mat_Area_Pitagoras_Caeto2.Text);
                    hipotenusa = Convert.ToDouble(Txt_Mat_Area_Pitagoras_Hipotenusa.Text);
                    catetoa = (hipotenusa * hipotenusa) - (catetob * catetob);
                    Txt_Mat_Area_Pitagoras_Caeto1.Text = Convert.ToString(Math.Sqrt(catetoa));
                    L_Mat_Area_Pitagoras_Resposta.Text = "Cateto A =";
                    Txt_Mat_Area_Pitagoras_Resposta.Text = Convert.ToString(Math.Sqrt(catetoa));
                }
                else if(Txt_Mat_Area_Pitagoras_Caeto2.Text == "x" || Txt_Mat_Area_Pitagoras_Caeto2.Text == "X")
                {
                    catetoa = Convert.ToDouble(Txt_Mat_Area_Pitagoras_Caeto1.Text);
                    hipotenusa = Convert.ToDouble(Txt_Mat_Area_Pitagoras_Hipotenusa.Text);
                    catetob = (hipotenusa * hipotenusa) - (catetoa * catetoa);
                    Txt_Mat_Area_Pitagoras_Caeto2.Text = Convert.ToString(Math.Sqrt(catetob));
                    L_Mat_Area_Pitagoras_Resposta.Text = "Cateto B =";
                    Txt_Mat_Area_Pitagoras_Resposta.Text = Convert.ToString(Math.Sqrt(catetob));
                }
            }
            catch
            {
                ;
            }
        }
    }
}

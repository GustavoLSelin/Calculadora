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
    public partial class Ele_SegundaLeiOhm : Form
    {
        public Ele_SegundaLeiOhm()
        {
            InitializeComponent();
        }
        double area = 0, largura = 0, material = 0;
        private void Btn_Ele_SegundaLeiOhm_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Ele_SegundaLeiOhm_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if(Cob_Ele_SegundaLeiOhm_Materiais.Text == "Prata = 1,6 * 10‾⁸")
                {
                    area = Convert.ToDouble(Txt_Ele_SegundaLeiOhm_Area.Text);
                    largura = Convert.ToDouble(Txt_Ele_SegundaLeiOhm_Largura.Text);
                    Txt_Ele_SegundaLeiOhm_Resistencia.Text = Convert.ToString(0.000000016 * (area / largura));
                }else if(Cob_Ele_SegundaLeiOhm_Materiais.Text == "Cobre = 1,7 * 10‾⁸")
                {
                    area = Convert.ToDouble(Txt_Ele_SegundaLeiOhm_Area.Text);
                    largura = Convert.ToDouble(Txt_Ele_SegundaLeiOhm_Largura.Text);
                    Txt_Ele_SegundaLeiOhm_Resistencia.Text = Convert.ToString(0.000000017 * (area / largura));
                }
                else if(Cob_Ele_SegundaLeiOhm_Materiais.Text == "Ouro = 2,4 * 10‾⁸")
                {
                    area = Convert.ToDouble(Txt_Ele_SegundaLeiOhm_Area.Text);
                    largura = Convert.ToDouble(Txt_Ele_SegundaLeiOhm_Largura.Text);
                    Txt_Ele_SegundaLeiOhm_Resistencia.Text = Convert.ToString(0.000000024 * (area / largura));
                }
                else if(Cob_Ele_SegundaLeiOhm_Materiais.Text == "Alumínio = 2,8 * 10‾⁸")
                {
                    area = Convert.ToDouble(Txt_Ele_SegundaLeiOhm_Area.Text);
                    largura = Convert.ToDouble(Txt_Ele_SegundaLeiOhm_Largura.Text);
                    Txt_Ele_SegundaLeiOhm_Resistencia.Text = Convert.ToString(0.000000028 * (area / largura));
                }
                else if(Cob_Ele_SegundaLeiOhm_Materiais.Text == "Chumbo = 2,2 * 10‾⁷")
                {
                    area = Convert.ToDouble(Txt_Ele_SegundaLeiOhm_Area.Text);
                    largura = Convert.ToDouble(Txt_Ele_SegundaLeiOhm_Largura.Text);
                    Txt_Ele_SegundaLeiOhm_Resistencia.Text = Convert.ToString(0.00000022 * (area / largura));
                }
                else if(Cob_Ele_SegundaLeiOhm_Materiais.Text == "Tungstênio = 5,6 * 10‾⁸")
                {
                    area = Convert.ToDouble(Txt_Ele_SegundaLeiOhm_Area.Text);
                    largura = Convert.ToDouble(Txt_Ele_SegundaLeiOhm_Largura.Text);
                    Txt_Ele_SegundaLeiOhm_Resistencia.Text = Convert.ToString(0.000000056 * (area / largura));
                }
            }
            catch
            {
                ;
            }
        }

        private void Btn_Ele_SegundaLeiOhm_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Ele_SegundaLeiOhm_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Ele_SegundaLeiOhm_Area.Text = null;
            Txt_Ele_SegundaLeiOhm_Largura.Text = null;
            Txt_Ele_SegundaLeiOhm_Resistencia.Text = null;
            Cob_Ele_SegundaLeiOhm_Materiais.Text = null;
        }
    }
}

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
    public partial class Form_Mat_Fracoes : Form
    {
        public Form_Mat_Fracoes()
        {
            InitializeComponent();
        }
        /*    Soma                  */
        int soma1 = 0, soma2 = 0, soma3 = 0, soma4 = 0, somar1 = 0, somar2 = 0,x = 0, y = 0, z = 0, total= 0;
        /*    Subtracao              */
        int sub1 = 0, sub2 = 0, sub3 = 0, sub4 = 0, subr1 = 0, subr2 = 0, xx = 0, yy = 0, zz = 0, totall = 0;
        /*    Multiplicacao          */
        int mult1 = 0, mult2 = 0, mult3 = 0, mult4 = 0, multr1 = 0, multr2 = 0;
        /*    Divisao                */
        int div1 = 0, div2 = 0, div3 = 0, div4 = 0, divr1 = 0, divr2 = 0;
        private void Btn_Mat_Fracoes_Soma_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Fracoes_Soma1.Text = null;
            Txt_Mat_Fracoes_Soma2.Text = null;
            Txt_Mat_Fracoes_Soma3.Text = null;
            Txt_Mat_Fracoes_Soma4.Text = null;
            Txt_Mat_Fracoes_SomaR1.Text = null;
            Txt_Mat_Fracoes_SomaR2.Text = null;
        }
        private void Btn_Mat_Fracoes_Subtrair_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Fracoes_Subtracao1.Text = null;
            Txt_Mat_Fracoes_Subtracao2.Text = null;
            Txt_Mat_Fracoes_Subtracao3.Text = null;
            Txt_Mat_Fracoes_Subtracao4.Text = null;
            Txt_Mat_Fracoes_SubtracaoR1.Text = null;
            Txt_Mat_Fracoes_SubtracaoR2.Text = null;
        }
        private void Btn_Mat_Fracoes_Multiplicar_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Fracoes_Multiplicacao1.Text = null;
            Txt_Mat_Fracoes_Multiplicacao2.Text = null;
            Txt_Mat_Fracoes_Multiplicacao3.Text = null;
            Txt_Mat_Fracoes_Multiplicacao4.Text = null;
            Txt_Mat_Fracoes_MultiplicacaoR1.Text = null;
            Txt_Mat_Fracoes_MultiplicacaoR2.Text = null;
        }
        private void Btn_Mat_Fracoes_Dividir_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Mat_Fracoes_Divisao1.Text = null;
            Txt_Mat_Fracoes_Divisao2.Text = null;
            Txt_Mat_Fracoes_Divisao3.Text = null;
            Txt_Mat_Fracoes_Divisao4.Text = null;
            Txt_Mat_Fracoes_DivisaoR1.Text = null;
            Txt_Mat_Fracoes_DivisaoR2.Text = null;
        }
        private void Btn_Mat_Fracoes_Dividir_Click(object sender, EventArgs e)
        {
            try
            {
                div1 = Convert.ToInt32(Txt_Mat_Fracoes_Divisao1.Text);
                div2 = Convert.ToInt32(Txt_Mat_Fracoes_Divisao2.Text);
                div3 = Convert.ToInt32(Txt_Mat_Fracoes_Divisao3.Text);
                div4 = Convert.ToInt32(Txt_Mat_Fracoes_Divisao4.Text);
                Txt_Mat_Fracoes_DivisaoR1.Text = Convert.ToString(div1 * div4);
                Txt_Mat_Fracoes_DivisaoR2.Text = Convert.ToString(div2 * div3);
                Txt_Mat_Fracoes_Divisao1.Text = Convert.ToString(div1 * div4);
                Txt_Mat_Fracoes_Divisao2.Text = Convert.ToString(div2 * div3);
                Txt_Mat_Fracoes_Divisao3.Text = null;
                Txt_Mat_Fracoes_Divisao4.Text = null;
            }
            catch
            {
                MessageBox.Show("Digite todos os numeros para fazer a operação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Btn_Mat_Fracoes_Multiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                mult1 = Convert.ToInt32(Txt_Mat_Fracoes_Multiplicacao1.Text);
                mult2 = Convert.ToInt32(Txt_Mat_Fracoes_Multiplicacao2.Text);
                mult3 = Convert.ToInt32(Txt_Mat_Fracoes_Multiplicacao3.Text);
                mult4 = Convert.ToInt32(Txt_Mat_Fracoes_Multiplicacao4.Text);
                Txt_Mat_Fracoes_MultiplicacaoR1.Text = Convert.ToString(mult1 * mult3);
                Txt_Mat_Fracoes_MultiplicacaoR2.Text = Convert.ToString(mult2 * mult4);
                Txt_Mat_Fracoes_Multiplicacao1.Text = Convert.ToString(mult1 * mult3);
                Txt_Mat_Fracoes_Multiplicacao2.Text = Convert.ToString(mult2 * mult4);
                Txt_Mat_Fracoes_Multiplicacao3.Text = null;
                Txt_Mat_Fracoes_Multiplicacao4.Text = null;
            }
            catch
            {
                MessageBox.Show("Digite todos os numeros para fazer a operação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Btn_Mat_Fracoes_Subtracao_Click(object sender, EventArgs e)
        {
            try
            {
                sub1 = Convert.ToInt32(Txt_Mat_Fracoes_Subtracao1.Text);
                sub2 = Convert.ToInt32(Txt_Mat_Fracoes_Subtracao2.Text);
                sub3 = Convert.ToInt32(Txt_Mat_Fracoes_Subtracao3.Text);
                sub4 = Convert.ToInt32(Txt_Mat_Fracoes_Subtracao4.Text);
                xx = sub2;
                yy = sub4;
                while (sub2 != sub4)
                {
                    if (sub2 > sub4)
                    {
                        sub2 = sub2 - sub4;
                    }
                    else
                    {
                        sub4 = sub4 - sub2;
                    }
                }
                zz = (xx * yy) / sub2;
                Txt_Mat_Fracoes_SubtracaoR2.Text = Convert.ToString(zz);
                sub1 = ((zz / xx) * sub1);
                sub2 = ((zz / yy) * sub3);
                totall = sub1 - sub2;
                Txt_Mat_Fracoes_SubtracaoR1.Text = Convert.ToString(totall);
                Txt_Mat_Fracoes_Subtracao1.Text = Convert.ToString(totall);
                Txt_Mat_Fracoes_Subtracao2.Text = Convert.ToString(zz);
                Txt_Mat_Fracoes_Subtracao3.Text = null;
                Txt_Mat_Fracoes_Subtracao4.Text = null;
            }
            catch
            {
                MessageBox.Show("Digite todos os numeros para fazer a operação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Btn_Mat_Fracoes_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }
        private void Btn_Mat_Fracoes_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu obj_Form_Menu = new Form_Menu();
            obj_Form_Menu.Show();
            this.Close();
        }
        private void Btn_Mat_Fracoes_Soma_Click(object sender, EventArgs e)
        {
            try
            {
                soma1 = Convert.ToInt32(Txt_Mat_Fracoes_Soma1.Text);
                soma2 = Convert.ToInt32(Txt_Mat_Fracoes_Soma2.Text);
                soma3 = Convert.ToInt32(Txt_Mat_Fracoes_Soma3.Text);
                soma4 = Convert.ToInt32(Txt_Mat_Fracoes_Soma4.Text);
                x = soma2;
                y = soma4;
                while (soma2 != soma4)
                {
                    if (soma2 > soma4)
                    {
                        soma2 = soma2 - soma4;
                    }
                    else
                    {
                        soma4 = soma4 - soma2;
                    }
                }
                z = (x * y) / soma2;
                Txt_Mat_Fracoes_SomaR2.Text = Convert.ToString(z);
                somar1 = ((z / x) * soma1);
                somar2 = ((z / y) * soma3);
                total = somar1 + somar2;
                Txt_Mat_Fracoes_SomaR1.Text = Convert.ToString(total);
                Txt_Mat_Fracoes_Soma1.Text = Convert.ToString(total);
                Txt_Mat_Fracoes_Soma2.Text = Convert.ToString(z);
                Txt_Mat_Fracoes_Soma3.Text = null;
                Txt_Mat_Fracoes_Soma4.Text = null;
            }
            catch
            {
                MessageBox.Show("Digite todos os numeros para fazer a operação", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

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
    public partial class Fis_ErroProbabilistoco : Form
    {
        public Fis_ErroProbabilistoco()
        {
            InitializeComponent();
        }
        //-------------------------------------- Adicionar valores das experiencias ---------------//
        int controledevalorparaadicionar = 0;
        double quantidadevalor = 0, quantidadevalormenosum = 0;
        double entrada = 0, numerossomados = 0, numerossomadosaoquadrado = 0;
        //-------------------------------------- Matrix ---------------//
        double valormatrix = 0;
        //-------------------------------------- Variavel das contas ---------------//
        int x = 0;
        double mediadosvalores = 0, mediadosvaloresaoquadrado = 0, fazercontas = 0, valors = 0, teste = 0;
        //-------------------------------------- Variavel dos Resultado ---------------//
        double erro = 0;
        private void Btn_Fis_ErroProbabilistico_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu obj_Form_Menu = new Form_Menu();
            obj_Form_Menu.Show();
            this.Close();
        }

        private void Btn_Fis_ErroProbabilistico_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Cob_Fis_ErroProbabilistico_Porcentagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(Cob_Fis_ErroProbabilistico_Porcentagem.Text == "90%")//-------- Inicio if 90% ------//
                {
                    if(quantidadevalormenosum == 1)
                    {
                        valormatrix = 6.314;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 2)
                    {
                        valormatrix = 2.920;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 3)
                    {
                        valormatrix = 2.353;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 4)
                    {
                        valormatrix = 2.132;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 5)
                    {
                        valormatrix = 2.015;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 6)
                    {
                        valormatrix = 1.943;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 7)
                    {
                        valormatrix = 1.895;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 8)
                    {
                        valormatrix = 1.860;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 9)
                    {
                        valormatrix = 1.833;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 10)
                    {
                        valormatrix = 1.812;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 11)
                    {
                        valormatrix = 1.796;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 12)
                    {
                        valormatrix = 1.782;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 13)
                    {
                        valormatrix = 1.771;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 14)
                    {
                        valormatrix = 1.761;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 15)
                    {
                        valormatrix = 1.753;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 16)
                    {
                        valormatrix = 1.746;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 17)
                    {
                        valormatrix = 1.740;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 18)
                    {
                        valormatrix = 1.734;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 19)
                    {
                        valormatrix = 1.729;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 20)
                    {
                        valormatrix = 1.725;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 21)
                    {
                        valormatrix = 1.721;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 22)
                    {
                        valormatrix = 1.717;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 23)
                    {
                        valormatrix = 1.714;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 24)
                    {
                        valormatrix = 1.711;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 25)
                    {
                        valormatrix = 1.708;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 26)
                    {
                        valormatrix = 1.706;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 27)
                    {
                        valormatrix = 1.703;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 28)
                    {
                        valormatrix = 1.701;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 29)
                    {
                        valormatrix = 1.699;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 30)
                    {
                        valormatrix = 1.697;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 40)
                    {
                        valormatrix = 1.684;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 60)
                    {
                        valormatrix = 1.671;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 120)
                    {
                        valormatrix = 1.658;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }

                }//------- Fim if 90% --------//


                if (Cob_Fis_ErroProbabilistico_Porcentagem.Text == "95%")//-------- Inicio if 95% ------//
                {
                    if (quantidadevalormenosum == 1)
                    {
                        valormatrix = 12.706;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 2)
                    {
                        valormatrix = 4.303;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 3)
                    {
                        valormatrix = 3.182;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 4)
                    {
                        valormatrix = 2.776;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 5)
                    {
                        valormatrix = 2.571;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 6)
                    {
                        valormatrix = 2.447;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 7)
                    {
                        valormatrix = 2.365;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 8)
                    {
                        valormatrix = 2.306;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 9)
                    {
                        valormatrix = 2.262;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 10)
                    {
                        valormatrix = 2.228;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 11)
                    {
                        valormatrix = 2.201;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 12)
                    {
                        valormatrix = 2.179;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 13)
                    {
                        valormatrix = 2.160;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 14)
                    {
                        valormatrix = 2.145;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 15)
                    {
                        valormatrix = 2.131;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 16)
                    {
                        valormatrix = 2.120;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 17)
                    {
                        valormatrix = 2.110;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 18)
                    {
                        valormatrix = 2.101;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 19)
                    {
                        valormatrix = 2.093;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 20)
                    {
                        valormatrix = 2.086;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 21)
                    {
                        valormatrix = 2.080;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 22)
                    {
                        valormatrix = 2.074;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 23)
                    {
                        valormatrix = 2.069;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 24)
                    {
                        valormatrix = 2.064;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 25)
                    {
                        valormatrix = 2.060;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 26)
                    {
                        valormatrix = 2.056;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 27)
                    {
                        valormatrix = 2.052;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 28)
                    {
                        valormatrix = 2.048;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 29)
                    {
                        valormatrix = 2.045;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 30)
                    {
                        valormatrix = 2.042;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 40)
                    {
                        valormatrix = 2.021;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 60)
                    {
                        valormatrix = 2.000;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 120)
                    {
                        valormatrix = 1.982;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }

                }//------- Fim if 95% --------//




                if (Cob_Fis_ErroProbabilistico_Porcentagem.Text == "98%")//-------- Inicio if 98% ------//
                {
                    if (quantidadevalormenosum == 1)
                    {
                        valormatrix = 31.821;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 2)
                    {
                        valormatrix = 6.965;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 3)
                    {
                        valormatrix = 4.541;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 4)
                    {
                        valormatrix = 3.747;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 5)
                    {
                        valormatrix = 3.365;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 6)
                    {
                        valormatrix = 3.143;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 7)
                    {
                        valormatrix = 2.998;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 8)
                    {
                        valormatrix = 2.896;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 9)
                    {
                        valormatrix = 2.821;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 10)
                    {
                        valormatrix = 2.764;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 11)
                    {
                        valormatrix = 2.718;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 12)
                    {
                        valormatrix = 2.681;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 13)
                    {
                        valormatrix = 2.650;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 14)
                    {
                        valormatrix = 2.624;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 15)
                    {
                        valormatrix = 2.602;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 16)
                    {
                        valormatrix = 2.583;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 17)
                    {
                        valormatrix = 2.567;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 18)
                    {
                        valormatrix = 2.552;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 19)
                    {
                        valormatrix = 2.539;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 20)
                    {
                        valormatrix = 2.528;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 21)
                    {
                        valormatrix = 2.518;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 22)
                    {
                        valormatrix = 2.508;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 23)
                    {
                        valormatrix = 2.500;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 24)
                    {
                        valormatrix = 2.492;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 25)
                    {
                        valormatrix = 2.485;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 26)
                    {
                        valormatrix = 2.479;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 27)
                    {
                        valormatrix = 2.473;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 28)
                    {
                        valormatrix = 2.467;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 29)
                    {
                        valormatrix = 2.462;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 30)
                    {
                        valormatrix = 2.457;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 40)
                    {
                        valormatrix = 2.423;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 60)
                    {
                        valormatrix = 2.390;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 120)
                    {
                        valormatrix = 2.358;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }

                }//------- Fim if 98% --------//



                if (Cob_Fis_ErroProbabilistico_Porcentagem.Text == "99%")//-------- Inicio if 99% ------//
                {
                    if (quantidadevalormenosum == 1)
                    {
                        valormatrix = 63.657;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 2)
                    {
                        valormatrix = 9.925;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 3)
                    {
                        valormatrix = 5.841;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 4)
                    {
                        valormatrix = 4.605;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 5)
                    {
                        valormatrix = 4.032;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 6)
                    {
                        valormatrix = 3.707;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 7)
                    {
                        valormatrix = 3.449;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 8)
                    {
                        valormatrix = 3.355;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 9)
                    {
                        valormatrix = 3.250;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 10)
                    {
                        valormatrix = 3.169;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 11)
                    {
                        valormatrix = 3.106;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 12)
                    {
                        valormatrix = 3.055;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 13)
                    {
                        valormatrix = 3.012;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 14)
                    {
                        valormatrix = 2.977;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 15)
                    {
                        valormatrix = 2.947;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 16)
                    {
                        valormatrix = 2.921;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 17)
                    {
                        valormatrix = 2.898;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 18)
                    {
                        valormatrix = 2.878;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 19)
                    {
                        valormatrix = 2.861;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 20)
                    {
                        valormatrix = 2.845;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 21)
                    {
                        valormatrix = 2.831;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 22)
                    {
                        valormatrix = 2.819;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 23)
                    {
                        valormatrix = 2.807;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 24)
                    {
                        valormatrix = 2.797;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 25)
                    {
                        valormatrix = 2.787;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 26)
                    {
                        valormatrix = 2.779;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 27)
                    {
                        valormatrix = 2.771;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 28)
                    {
                        valormatrix = 2.763;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 29)
                    {
                        valormatrix = 2.756;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 30)
                    {
                        valormatrix = 2.750;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 40)
                    {
                        valormatrix = 2.704;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 60)
                    {
                        valormatrix = 2.660;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }
                    if (quantidadevalormenosum == 120)
                    {
                        valormatrix = 2.617;
                        L_Fis_ErroProbabilistico_Resultado_Matrix.Text = Convert.ToString(valormatrix);
                    }

                }//------- Fim if 99% --------//

            }
            catch
            {

            }  
        }

        private void Btn_Fis_ErroProbabilistico_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Fis_ErroProbabilistico_ValoresAdd.Text = null;
            Cob_Fis_ErroProbabilistico_Porcentagem.Text = null;
            Cob_Fis_ErroProbabilistico_QuantidadeValores.Text = null;
            L_Fis_ErroProbabilistico_Numero_ValoresAdd.Text = null;
            L_Fis_ErroProbabilistico_Resultado_Erro.Text = null;
            L_Fis_ErroProbabilistico_Resultado_ErroFinal.Text = null;
            L_Fis_ErroProbabilistico_Resultado_Matrix.Text = null;
            L_Fis_ErroProbabilistico_Resultado_Media.Text = null;
            L_Fis_ErroProbabilistico_Resultado_Media_Mais_Erro.Text = null;
            L_Fis_ErroProbabilistico_Resultado_Media_Menos_Erro.Text = null;
            L_Fis_ErroProbabilistico_Resultado_S.Text = null;
            L_Fis_ErroProbabilistico_Resultado_X.Text = null;
            controledevalorparaadicionar = 0;
            quantidadevalor = 0;
            quantidadevalormenosum = 0;
            x = 0;
            mediadosvalores = 0;
            mediadosvaloresaoquadrado = 0;
            erro = 0;
            teste = 0;
            valors = 0;
            fazercontas = 0;
            numerossomados = 0;
            numerossomadosaoquadrado = 0;
        }
        private void Btn_Fis_ErroProbabilistico_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                mediadosvalores = numerossomados / quantidadevalor;
                L_Fis_ErroProbabilistico_Resultado_X.Text = Convert.ToString(mediadosvalores);
                mediadosvaloresaoquadrado = numerossomadosaoquadrado / quantidadevalor;
                fazercontas = mediadosvalores * mediadosvalores;
                valors = mediadosvaloresaoquadrado - fazercontas;
                teste = valors * (quantidadevalor / quantidadevalormenosum);
                L_Fis_ErroProbabilistico_Resultado_S.Text = Convert.ToString(teste);

                erro = (valormatrix * Math.Sqrt(teste) / Math.Sqrt(quantidadevalor));
                L_Fis_ErroProbabilistico_Resultado_Erro.Text = Convert.ToString(erro);
                L_Fis_ErroProbabilistico_Resultado_ErroFinal.Text = Convert.ToString(erro);
                L_Fis_ErroProbabilistico_Resultado_Media.Text = Convert.ToString(mediadosvalores);
                L_Fis_ErroProbabilistico_Resultado_Media_Mais_Erro.Text = Convert.ToString(mediadosvalores + erro);
                L_Fis_ErroProbabilistico_Resultado_Media_Menos_Erro.Text = Convert.ToString(mediadosvalores - erro);
            }
            catch
            {
                ;
            }
        }
        private void Btn_Fis_ErroProbabilistico_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if(x < quantidadevalor)
                {
                    entrada = Convert.ToDouble(Txt_Fis_ErroProbabilistico_ValoresAdd.Text);
                    numerossomados += entrada;
                    numerossomadosaoquadrado += entrada * entrada;
                    Txt_Fis_ErroProbabilistico_ValoresAdd.Text = null;
                    x++;
                    L_Fis_ErroProbabilistico_Numero_ValoresAdd.Text = Convert.ToString(x);
                }
                if(x == quantidadevalor)
                {
                    Txt_Fis_ErroProbabilistico_ValoresAdd.Text = "Completo";
                }
            }
            catch
            {
                ;
            }
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                quantidadevalor = Convert.ToDouble(Cob_Fis_ErroProbabilistico_QuantidadeValores.Text);
                quantidadevalormenosum = quantidadevalor - 1;
            }
            catch
            {
                ;
            }
        }
    }
}

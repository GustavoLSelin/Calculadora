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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void Btn_Menu_Mat_Fracoes_Click(object sender, EventArgs e)
        {
            Form_Mat_Fracoes obj_Mat_Fracoes = new Form_Mat_Fracoes();
            obj_Mat_Fracoes.Show();
            this.Hide();
        }

        private void Btn_Menu_Mat_Porcentagem_Click(object sender, EventArgs e)
        {
            Mat_Porcentagem objporcentagem = new Mat_Porcentagem();
            objporcentagem.Show();
            this.Hide();
        }

        private void Btn_Menu_Produtos_Notaveis_Click(object sender, EventArgs e)
        {
            Mat_Produtos_Notaveis objprodutosnotaveis = new Mat_Produtos_Notaveis();
            objprodutosnotaveis.Show();
            this.Hide();
        }

        private void Btn_Menu_Mat_Bhaskara_Click(object sender, EventArgs e)
        {
            Mat_Bhaskara objmatbhaskara = new Mat_Bhaskara();
            objmatbhaskara.Show();
            this.Hide();
        }

        private void Btn_Menu_Mat_Funcao_Primeirograu_Click(object sender, EventArgs e)
        {
            Mat_Funcao_Primeirograu objmatfuncaoprimeirograu = new Mat_Funcao_Primeirograu();
            objmatfuncaoprimeirograu.Show();
            this.Hide();
        }

        private void Btn_Menu_Mat_Funcao_Segundograu_Click(object sender, EventArgs e)
        {
            Mat_Funcao_Segundograu objmatfuncaosegundograu = new Mat_Funcao_Segundograu();
            objmatfuncaosegundograu.Show();
            this.Hide();
        }

        private void Btn_Menu_Binario_Decimal_Click(object sender, EventArgs e)
        {
            Ele_Binario_Decimal objelebinariodecimal = new Ele_Binario_Decimal();
            objelebinariodecimal.Show();
            this.Hide();
        }

        private void Btn_Menu_Ele_Hexadecima_Decimal_Click(object sender, EventArgs e)
        {
            Ele_Hexadecimal_Decimal objelehexadecimaldecimal = new Ele_Hexadecimal_Decimal();
            objelehexadecimaldecimal.Show();
            this.Hide();
        }

        private void Btn_Menu_Binario_Octal_Click(object sender, EventArgs e)
        {
            Ele_Octal_Decimal objeleoctaldecimal = new Ele_Octal_Decimal();
            objeleoctaldecimal.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Fis_Velocidade_Media objvelocidademedia = new Fis_Velocidade_Media();
            objvelocidademedia.Show();
            this.Hide();
        }

        private void Btn_Menu_Fis_Velocidade_Click(object sender, EventArgs e)
        {
            Fis_Velocidade objfisvelocidade = new Fis_Velocidade();
            objfisvelocidade.Show();
            this.Hide();
        }

        private void Btn_Menu_Fis_VelocidadeInstantanea_Click(object sender, EventArgs e)
        {
            Fis_Velocidade_Instantanea objfisvelocidadeinstantanea = new Fis_Velocidade_Instantanea();
            objfisvelocidadeinstantanea.Show();
            this.Hide();
        }
        private void Btn_Form_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Form_ConversaodeValores_Click(object sender, EventArgs e)
        {
            Form_ConversaoValores objformconversaovalores = new Form_ConversaoValores();
            objformconversaovalores.Show();
        }

        private void Btn_Menu_Mat_Area_Triangulo_Click(object sender, EventArgs e)
        {
            Mat_Area_Triangulo objmatareatriangulo = new Mat_Area_Triangulo();
            objmatareatriangulo.Show();
            this.Close();
        }

        private void Btn_Menu_Mat_Area_Retangulo_Click(object sender, EventArgs e)
        {
            Mat_Area_Retangulo objmatarearetangulo = new Mat_Area_Retangulo();
            objmatarearetangulo.Show();
            this.Close();
        }

        private void Btn_Menu_Mat_Area_Quadrado_Click(object sender, EventArgs e)
        {
            Mat_Area_Quadrado objmatareaquadrado = new Mat_Area_Quadrado();
            objmatareaquadrado.Show();
            this.Hide();
        }

        private void Btn_Menu_Mat_Area_Trapezio_Click(object sender, EventArgs e)
        {
            Mat_Area_Trapezio objmatareatrapezio = new Mat_Area_Trapezio();
            objmatareatrapezio.Show();
            this.Hide();
        }

        private void Btn_Menu_Mat_Area_Losango_Click(object sender, EventArgs e)
        {
            Mat_Area_Losango objarealosango = new Mat_Area_Losango();
            objarealosango.Show();
            this.Hide();
        }

        private void Btn_Menu_Mat_Area_Circulo_Click(object sender, EventArgs e)
        {
            Mat_Area_Circulo objmatareacirculo = new Mat_Area_Circulo();
            objmatareacirculo.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Mat_Pitagoras objmatpitagoras = new Mat_Pitagoras();
            objmatpitagoras.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Mat_Area_Paralelogramo objmatareaparalelogramo = new Mat_Area_Paralelogramo();
            objmatareaparalelogramo.Show();
            this.Hide();
        }
        private void Btn_Menu_Fis_MovimentoUniforme_Click(object sender, EventArgs e)
        {
            Fis_Movimento_Uniforme objfismovimentouniforme = new Fis_Movimento_Uniforme();
            objfismovimentouniforme.Show();
            this.Hide();
        }

        private void Btn_Menu_Fis_MovimentoUniformeVaridado_Click(object sender, EventArgs e)
        {
            Fis_Movimento_Uniforme_Variado objfismovimentouniformevariado = new Fis_Movimento_Uniforme_Variado();
            objfismovimentouniformevariado.Show();
            this.Hide();
        }

        private void Btn_Menu_Ele_YDelta_Click(object sender, EventArgs e)
        {
            Ele_YDelta objeleydelta = new Ele_YDelta();
            objeleydelta.Show();
            this.Hide();
        }

        private void Btn_Menu_Ele_ForcaEletromotriz_Click(object sender, EventArgs e)
        {
            Ele_ForcaEletromotriz objeleforcaeletromotriz = new Ele_ForcaEletromotriz();
            objeleforcaeletromotriz.Show();
            this.Hide();
        }

        private void Btn_Menu_Ele_Tensao_Click(object sender, EventArgs e)
        {
            Ele_Tensao objeletensao = new Ele_Tensao();
            objeletensao.Show();
            this.Hide();
        }

        private void Btn_Menu_Ele_CargaEletrica_Click(object sender, EventArgs e)
        {
            Ele_CargaEletrica objelecargaeletrica = new Ele_CargaEletrica();
            objelecargaeletrica.Show();
            this.Hide();
        }

        private void Btn_Menu_Ele_IntensidadeCorrenteEletrica_Click(object sender, EventArgs e)
        {
            Ele_IntensidadeCorrenteEletrica objeleintensidadedecorrenteeletrica = new Ele_IntensidadeCorrenteEletrica();
            objeleintensidadedecorrenteeletrica.Show();
            this.Hide();
        }

        private void Btn_Menu_Ele_PrimeiraLeiOhm_Click(object sender, EventArgs e)
        {
            Ele_PrimeiraLeiOhm objeleprimeiraleiohm = new Ele_PrimeiraLeiOhm();
            objeleprimeiraleiohm.Show();
            this.Hide();
        }

        private void Btn_Menu_Ele_SegundaLeiOhm_Click(object sender, EventArgs e)
        {
            Ele_SegundaLeiOhm objelesegundaleideohm = new Ele_SegundaLeiOhm();
            objelesegundaleideohm.Show();
            this.Hide();
        }

        private void Btn_Menu_Ele_Resistencia_Click(object sender, EventArgs e)
        {
            Ele_Resistencia objeleresistencia = new Ele_Resistencia();
            objeleresistencia.Show();
            this.Hide();
        }

        private void Btn_Menu_Ele_Potencia_Click(object sender, EventArgs e)
        {
            Ele_Potencia objelepotencia = new Ele_Potencia();
            objelepotencia.Show();
            this.Hide();
        }

        private void Btn_Menu_Ele_AssociacaodeResistores_Click(object sender, EventArgs e)
        {
            Ele_AssociacaodeResistores objeleassociacaoderesistores = new Ele_AssociacaodeResistores();
            objeleassociacaoderesistores.Show();
            this.Hide();
        }

        private void Btn_Menu_Fis_ErrosProbabilisticos_Click(object sender, EventArgs e)
        {
            Fis_ErroProbabilistoco objfiserroprobabilistoco = new Fis_ErroProbabilistoco();
            objfiserroprobabilistoco.Show();
            this.Hide();
        }

        private void Btn_Menu_Fis_Toriccelli_Click(object sender, EventArgs e)
        {
            Fis_Toriccelli objfistoriccelli = new Fis_Toriccelli();
            objfistoriccelli.Show();
            this.Hide();
        }

        private void Btn_Menu_Fis_QuedaLivre_Click(object sender, EventArgs e)
        {
            Fis_QuedaLivre objfisquedalivre = new Fis_QuedaLivre();
            objfisquedalivre.Show();
            this.Hide();
        }

        private void Btn_Menu_Fis_LancamentoVertical_Click(object sender, EventArgs e)
        {
            Fis_LancamentoVertical objfislancamentovertcial = new Fis_LancamentoVertical();
            objfislancamentovertcial.Show();
            this.Hide();
        }

        private void Btn_Menu_Fis_LancamentoHorizontal_Click(object sender, EventArgs e)
        {
            Fis_LancamentoHorizontal objfislancamentohorizontal = new Fis_LancamentoHorizontal();
            objfislancamentohorizontal.Show();
            this.Close();
        }

        private void Btn_Menu_Fis_LancamentoObliquo_Click(object sender, EventArgs e)
        {
            Fis_LancamentoObliquo objfislancamentoobliquo = new Fis_LancamentoObliquo();
            objfislancamentoobliquo.Show();
            this.Hide();
        }

        private void Btn_Menu_Fis_Frocas_Click(object sender, EventArgs e)
        {
            Fis_Forcas objfisforcas = new Fis_Forcas();
            objfisforcas.Show();
            this.Hide();
        }

        private void Btn_Menu_Ele_Energia_Click(object sender, EventArgs e)
        {
            Ele_Energia objeleenergia = new Ele_Energia();
            objeleenergia.Show();
            this.Hide();
        }

        private void Btn_Menu_Fis_ForcaGravitacional_Click(object sender, EventArgs e)
        {
            Fis_ForcaGravitacional objfisforcagravitacional = new Fis_ForcaGravitacional();
            objfisforcagravitacional.Show();
            this.Hide();
        }

        private void Btn_Menu_Fis_CalorSensivel_Click(object sender, EventArgs e)
        {
            Fis_CalorSensivel objfiscalorsensivel = new Fis_CalorSensivel();
            objfiscalorsensivel.Show();
            this.Hide();

        }
    }
}

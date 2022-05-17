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
    public partial class Ele_IntensidadeCorrenteEletrica : Form
    {
        public Ele_IntensidadeCorrenteEletrica()
        {
            InitializeComponent();
        }
        double quantidadecargaeletrica = 0, tempo = 0;
        private void Btn_Ele_IntensidadedeCorrenteEletrica_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Ele_IntensidadedeCorrenteEletrica_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                quantidadecargaeletrica = Convert.ToDouble(Txt_Ele_IntensidadedeCorrenteEletrica_QuantidadeCargaEletrica.Text);
                tempo = Convert.ToDouble(Txt_Ele_Tensao_Coulomb.Text);
                Txt_Ele_IntensidadedeCorrenteEletrica_IntensidadeCorrenteEletrica.Text = Convert.ToString(quantidadecargaeletrica / tempo);
            }
            catch
            {
                ;
            }
        }

        private void Btn_Ele_IntensidadedeCorrenteEletrica_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Ele_IntensidadedeCorrenteEletrica_IntensidadeCorrenteEletrica.Text = null;
            Txt_Ele_IntensidadedeCorrenteEletrica_QuantidadeCargaEletrica.Text = null;
            Txt_Ele_IntensidadedeCorrenteEletrica_tempo.Text = null;
            Txt_Ele_Tensao_Coulomb.Text = null;
        }

        private void Btn_Ele_IntensidadedeCorrenteEletrica_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }
    }
}

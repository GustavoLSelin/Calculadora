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
    public partial class Mat_Porcentagem : Form
    {
        public Mat_Porcentagem()
        {
            InitializeComponent();
        }
        double valor = 0, valormais = 0, valormenos = 0, porcentagem = 0, valorporcentagem = 0;
        private void Btn_Mat_Porcentagem_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Mat_Porcentagem_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Txt_Mat_Porcentagem_Porcentagem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                valor = Convert.ToDouble(Txt_Mat_Porcentagem_Valor.Text);
                porcentagem = Convert.ToDouble(Txt_Mat_Porcentagem_Porcentagem.Text);

                porcentagem = (porcentagem / 100);

                valorporcentagem = valor * porcentagem;
                valormenos = valor - valorporcentagem;
                valormais = valor + valorporcentagem;

                Txt_Mat_Porcentagem_Valor_Porcentagem.Text = Convert.ToString(valorporcentagem);
                Txt_Mat_Porcentagem_Valor_Menos.Text = Convert.ToString(valormenos);
                Txt_Mat_Porcentagem_Valor_Mais.Text = Convert.ToString(valormais);
            }
            catch
            {
                ;
            }
        }
    }
}

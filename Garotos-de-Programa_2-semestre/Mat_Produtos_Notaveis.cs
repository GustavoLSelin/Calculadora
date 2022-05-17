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
    public partial class Mat_Produtos_Notaveis : Form
    {
        public Mat_Produtos_Notaveis()
        {
            InitializeComponent();
            WeB_Mat_Produtos_Notaveis.ScriptErrorsSuppressed = true;
        }   

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

        private void Btn_Limpar_Produtos_Notaveis_Click(object sender, EventArgs e)
        {
            WeB_Mat_Produtos_Notaveis.Url = new Uri("https://pt.symbolab.com/solver/step-by-step/%5Cleft(%201a%5E%7B1%7D%20%2B%201b%5E%7B1%7D%5Cright)");
        }
    }
}

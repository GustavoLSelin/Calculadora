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
    public partial class Ele_CargaEletrica : Form
    {
        public Ele_CargaEletrica()
        {
            InitializeComponent();
        }
        double neletrons = 0;
        private void Btn_Ele_CargaEletrica_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Ele_CargaEletrica_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Txt_Ele_CargaEletrica_NEletrons_TextChanged(object sender, EventArgs e)
        {
            try
            {
                neletrons = Convert.ToDouble(Txt_Ele_CargaEletrica_NEletrons.Text);
                Txt_Ele_CargaEletrica_QCarga.Text = Convert.ToString(neletrons * 0.00000000000000000016);
            }
            catch
            {
                ;
            }
        }

        private void Btn_Ele_CargaEletrica_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Ele_CargaEletrica_NEletrons.Text = null;
            Txt_Ele_CargaEletrica_QCarga.Text = null;
        }
    }
}

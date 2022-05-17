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
    public partial class Ele_Energia : Form
    {
        public Ele_Energia()
        {
            InitializeComponent();
        }
        //---//
        double potencia = 0, tempo = 0;
        private void Btn_Ele_Energia_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Ele_Energia_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Ele_Energia_Energia.Text = null;
            Txt_Ele_Energia_Potencia.Text = null;
            Txt_Ele_Energia_Tempo.Text = null;
        }

        private void Btn_Ele_Energia_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                potencia = Convert.ToDouble(Txt_Ele_Energia_Potencia.Text);
                tempo = Convert.ToDouble(Txt_Ele_Energia_Tempo.Text);
                Txt_Ele_Energia_Energia.Text = Convert.ToString((potencia * tempo) / 1000) + "Kwh";
            }
            catch
            {
                ;
            }
        }

        private void Btn_Ele_Energia_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }
    }
}

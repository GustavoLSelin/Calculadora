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
    public partial class Fis_ForcaGravitacional : Form
    {
        public Fis_ForcaGravitacional()
        {
            InitializeComponent();
        }
        //-----------//
        double contantegravitacional = 0, massaum = 0, massadois = 0, distancia = 0;
        
        private void Btn_Fis_ForcaGravitacional_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                contantegravitacional = 0.0000000000667;
                massaum = Convert.ToDouble(Txt_Fis_ForcaGravitacional_Massa_Um.Text);
                massadois = Convert.ToDouble(Txt_Fis_ForcaGravitacional_Massa_Dois.Text);
                distancia = Convert.ToDouble(Txt_Fis_ForcaGravitacional_Massa_Distancia.Text);
                Txt_Fis_ForcaGravitacional_Forca.Text = Convert.ToString(contantegravitacional * ((massaum * massadois)/ Math.Pow(distancia,2)));
                
            }
            catch
            {
                ;
            }
        }

        private void Btn_Fis_ForcaGravitacional_Voltar_Click(object sender, EventArgs e)
        {
            Form_Menu objformmenu = new Form_Menu();
            objformmenu.Show();
            this.Close();
        }

        private void Btn_Fis_ForcaGravitacional_Calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc");
        }

        private void Btn_Fis_ForcaGravitacional_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Fis_ForcaGravitacional_Forca.Text = null;
            Txt_Fis_ForcaGravitacional_Massa_Distancia.Text = null;
            Txt_Fis_ForcaGravitacional_Massa_Dois.Text = null;
            Txt_Fis_ForcaGravitacional_Massa_Um.Text = null;
        }
    }
}

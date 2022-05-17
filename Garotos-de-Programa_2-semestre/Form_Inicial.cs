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
    public partial class Form_Inicial : Form
    {
        public Form_Inicial()
        {
            InitializeComponent();
        }

        private void But_Inicial_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void But_Inicial_Iniciar_Click(object sender, EventArgs e)
        {
            Form_Menu obj_form_menu = new Form_Menu();
            obj_form_menu.Show();
            this.Hide();
        }
    }
}

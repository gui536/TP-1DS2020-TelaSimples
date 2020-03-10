using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telaSimples
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
    
        private void btnExibe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa aula foi muito legal :)");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo ao meu primeiro formulário");
        }
    }
}

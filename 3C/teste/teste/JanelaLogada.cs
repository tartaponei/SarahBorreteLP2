using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class JanelaLogada : Form
    {
        public JanelaLogada()
        {
            InitializeComponent();
        }

        private void ClickCadastrarCliente(object sender, EventArgs e)
        {
            JanelaCadastroCliente jcc = new JanelaCadastroCliente();
            jcc.Show();
        }

        private void ClickRegistrarVenda(object sender, EventArgs e)
        {

        }
    }
}

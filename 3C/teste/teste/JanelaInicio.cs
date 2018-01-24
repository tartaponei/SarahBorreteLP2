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
    public partial class JanelaInicio : Form
    {
        public JanelaInicio()
        {
            InitializeComponent();
        }

        private void CadastroRClick(object sender, EventArgs e)
        {
            JanelaCadastro jc = new JanelaCadastro();
            jc.Show();
        }

        private void LoginClick(object sender, EventArgs e)
        {
            JanelaLogin jl = new JanelaLogin();
            jl.Show();
        }

        private void ConsultarClick(object sender, EventArgs e)
        {
            JanelaConsulta con = new JanelaConsulta();
            con.Show();
        }

        private void ClickCadastroC(object sender, EventArgs e)
        {
            JanelaCadastroCliente jcc = new JanelaCadastroCliente();
            jcc.Show();
        }
    }
}

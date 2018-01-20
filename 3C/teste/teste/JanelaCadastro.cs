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
    public partial class JanelaCadastro : Form
    {
        public JanelaCadastro()
        {
            InitializeComponent();
        }

        private void ContinuarCadastroClick(object sender, EventArgs e)
        {
            
        }

        private void SerClienteClick(object sender, EventArgs e)
        {
            checkBoxSerRevendedor.CheckState = CheckState.Unchecked;
        }

        private void SerRevendedorClick(object sender, EventArgs e)
        {
            checkBoxSerCliente.CheckState = CheckState.Unchecked;
        }
    }
}

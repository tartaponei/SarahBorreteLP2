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
    public partial class JanelaLogin : Form
    {
        public JanelaLogin()
        {
            InitializeComponent();
        }

        private void ContinuarLogin(object sender, EventArgs e)
        {

        }

        private void SouClienteClick(object sender, EventArgs e)
        {
            checkBoxRevendedor.CheckState = CheckState.Unchecked;
        }

        private void SouRevendedorClick(object sender, EventArgs e)
        {
            checkBoxCliente.CheckState = CheckState.Unchecked;
        }
    }
}

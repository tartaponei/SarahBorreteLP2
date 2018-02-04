using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace teste
{
    public partial class JanelaDeletarCliente : Form
    {
        public JanelaDeletarCliente()
        {
            InitializeComponent();
        }

        private void ClickContinuarDelete(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=localhost; Initial Catalog=Loja_de_cosmeticos; Integrated Security=SSPI"),
                CommandText = @"DELETE FROM Cliente WHERE Cpf = @cpf;"
            };

            cmd.Parameters.AddWithValue("@cpf", textBoxCpf.Text);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cliente deletado!");
            cmd.Connection.Close();
        }
    }
}

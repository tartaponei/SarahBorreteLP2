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
    public partial class JanelaDeletarRevendedor : Form
    {
        public JanelaDeletarRevendedor()
        {
            InitializeComponent();
        }

        private void ContinuarDelete(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=localhost; Initial Catalog=Loja_de_cosmeticos; Integrated Security=SSPI"),
                CommandText = @"DELETE FROM Usuario WHERE Cpf_Revendedor = @cpf;"
            };

            cmd.Parameters.AddWithValue("@cpf", textBoxCpf.Text);
            cmd.Parameters.AddWithValue("@senha", textBoxSenha.Text);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Usuário deletado!");
            cmd.Connection.Close();
        }
    }
}

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
    public partial class JanelaCadastro : Form
    {
        public JanelaCadastro()
        {
            InitializeComponent();
        }

        private void ContinuarCadastroClick(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=localhost; Initial Catalog=Loja_de_cosmeticos; Integrated Security=SSPI"),
                CommandText = @"INSERT INTO Usuário(Nome, Cpf_Revendedor, Senha) VALUES(@nome, @cpf, @senha);"
            };

            cmd.Parameters.AddWithValue("@nome", textBoxNome.Text);
            cmd.Parameters.AddWithValue("@cpf", textBoxCpf.Text);
            cmd.Parameters.AddWithValue("@senha", textBoxNovaSenha.Text);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cadastrado!");
            cmd.Connection.Close();
        }
    }
}

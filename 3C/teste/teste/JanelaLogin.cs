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
    public partial class JanelaLogin : Form
    {
        public JanelaLogin()
        {
            InitializeComponent();
        }

        private void ContinuarLogin(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=localhost; Initial Catalog=Loja_de_cosmeticos; Integrated Security=SSPI"),
                CommandText = @"SELECT Senha FROM Usuario WHERE Cpf_Revendedor = @cpf;"
            };

            cmd.Parameters.AddWithValue("@cpf", textBoxUsuario.Text);

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            string senha;
            if (reader.HasRows)
            {
                reader.Read();
                senha = reader.GetString(0);
                MessageBox.Show("senha do banco =" + senha);

                if (textBoxSenha.Text == senha)
                {
                    JanelaLogada jl = new JanelaLogada();
                    jl.Show();
                }
            }

            else
                MessageBox.Show("CPF ou Senha inválidos.");
            cmd.Connection.Close();
        }
    }
}

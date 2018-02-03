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
    public partial class JanelaCadastroCliente : Form
    {
        public JanelaCadastroCliente()
        {
            InitializeComponent();
        }

        private void ContinuarCadClienteClick(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=localhost; Initial Catalog=Loja_de_cosmeticos; Integrated Security=SSPI"),
                CommandText = @"INSERT INTO Cliente(Cpf) VALUES(@cpf);"
            };

            cmd.Parameters.AddWithValue("@cpf", txtBoxCpf.Text);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cadastrado!");
            cmd.Connection.Close();

            this.Close();
        }
    }
}

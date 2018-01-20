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
    public partial class JanelaConsulta : Form
    {
        public JanelaConsulta()
        {
            InitializeComponent();
        }

        private void ClickConsulta(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtBoxCodigo.Text);

            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=localhost; Initial Catalog=Loja_de_cosmeticos; Integrated Security=SSPI"),
                CommandText = @"SELECT Nome, Quantidade, Preço FROM Perfume WHERE Id = @codigo();"
            };

            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txtBoxNomeProduto.Text = reader["Nome"].ToString();
                txtBoxNomeProduto.Text = reader["Quantidade"].ToString();
                txtBoxNomeProduto.Text = reader["Preço"].ToString();
            }
            cmd.Connection.Close();
        }
    }
}

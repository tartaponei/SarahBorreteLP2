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
    public partial class JanelaAdicionarAoEstoque : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection c = new SqlConnection("Data Source=localhost; Initial Catalog=Loja_de_cosmeticos; Integrated Security=SSPI");

        public JanelaAdicionarAoEstoque()
        {
            InitializeComponent();
        }

        private void ClickAdicionar(object sender, EventArgs e)
        {
            cmd.Connection = c;
            cmd.Parameters.AddWithValue("@codigo", textBoxCodigo.Text);

            int Qtd;
            int Qtd2 = 0;

            //SELECT

            c.Open();
            if (checkBoxCosmetico.Checked)
            {
                cmd.CommandText = @"SELECT Quantidade FROM Produtos WHERE Id = @codigo;";

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    Qtd = reader.GetInt32(0);

                    cmd.Parameters.AddWithValue("@qtd", Qtd - int.Parse(textBoxQtd.Text));
                    Qtd2 = Qtd + int.Parse(textBoxQtd.Text);
                }
            }

            else if (checkBoxBijuteria.Checked)
            {
                cmd.CommandText = @"SELECT Quantidade FROM Bijuteria WHERE Id = @codigo;";

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    Qtd = reader.GetInt32(0);

                    cmd.Parameters.AddWithValue("@qtd", Qtd - int.Parse(textBoxQtd.Text));
                    Qtd2 = Qtd + int.Parse(textBoxQtd.Text);
                }
            }

            else
                MessageBox.Show("Por favor, indique se o produto é um Cosmético ou uma Bijuteria.");

            c.Close();

            //UPDATE

            cmd.Parameters.AddWithValue("@qtd2", Qtd2);
            cmd.Parameters.AddWithValue("@codigo2", textBoxCodigo.Text);

            c.Open();

            if (checkBoxCosmetico.Checked)
            {
                cmd.CommandText = @"UPDATE Produtos SET Quantidade = @qtd2 WHERE Id = @codigo2;";
                cmd.ExecuteNonQuery();
            }

            else
            {
                cmd.CommandText = @"UPDATE Bijuteria SET Quantidade = @qtd2 WHERE Id = @codigo2;";
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Estoque atualizado com sucesso!");

            c.Close();
        }
    }
}

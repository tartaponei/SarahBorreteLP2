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
    public partial class JanelaRegistrarVenda : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection c = new SqlConnection("Data Source=localhost; Initial Catalog=Loja_de_cosmeticos; Integrated Security=SSPI");

        public JanelaRegistrarVenda()
        {
            InitializeComponent();
        }

        private void ClickAddProd(object sender, EventArgs e)
        {
            cmd.Connection = c;
            cmd.Parameters.AddWithValue("@codigo", textBoxCodigo.Text);
            cmd.Parameters.AddWithValue("@qtd", textBoxQtd.Text);

            c.Open();

            cmd.CommandText = @"SELECT Preço WHERE Id = @codigo;";
            double preco;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                preco = reader.GetDouble(0);
                double totalProd = preco * (int.Parse(textBoxQtd.Text));
                Venda.total = Venda.total + totalProd;
                labelTotal.Text = String.Format("R$ {0}", Venda.total);
            }

            cmd.CommandText = @"UPDATE Produto SET Quantidade = @qtd WHERE Id = @codigo;";
            cmd.ExecuteNonQuery();

            c.Close();
        }

        private void ClickFinalizar(object sender, EventArgs e)
        {
            JanelaFinalizarCompra jf = new JanelaFinalizarCompra();
            jf.Show();
        }
    }
}

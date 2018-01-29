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
        public double total = 0;

        public JanelaRegistrarVenda()
        {
            InitializeComponent();
        }

        private void ClickAddProd(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=localhost; Initial Catalog=Loja_de_cosmeticos; Integrated Security=SSPI"),
                CommandText = @"SELECT Preço WHERE Id = @codigo();"
            };
            cmd.Parameters.AddWithValue("codigo", textBoxCodigo.Text);

            cmd.Connection.Open();
            double preco = 0;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                preco = reader.GetDouble(0);
                double totalProd = preco * (int.Parse(textBoxQtd.Text));
                total = total + totalProd;
                labelTotal.Text = String.Format("R$ {0}", total);
            }
            cmd.Connection.Close();
        }

        private void ClickFinalizar(object sender, EventArgs e)
        {
            JanelaFinalizarCompra jf = new JanelaFinalizarCompra();
            jf.Show();
        }
    }
}

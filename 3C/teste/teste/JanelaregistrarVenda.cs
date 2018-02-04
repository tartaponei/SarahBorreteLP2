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
           
            //SELECT

            c.Open();

            cmd.CommandText = @"SELECT Preço, Quantidade FROM Produtos WHERE Id = @codigo;";
            int preco;
            int Qtd;
            int Qtd2=0;
           
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                
                preco = reader.GetInt32(0);
                Qtd = reader.GetInt32(1);
      
                double totalProd = preco * (int.Parse(textBoxQtd.Text));
                cmd.Parameters.AddWithValue("@qtd", Qtd-int.Parse(textBoxQtd.Text));
                Qtd2 = Qtd - int.Parse(textBoxQtd.Text);
               
                if (Qtd2 < 0)
                    MessageBox.Show("Não há mais este produto no estoque, Sorry");
                else
                {
                   
                    Venda.total = Venda.total + totalProd;
                    MessageBox.Show("Validado");
                    labelTotal.Text = String.Format("R$ {0}", Venda.total);
                }
            }
            c.Close();

            cmd.Parameters.AddWithValue("@qtd2", Qtd2 );
            cmd.Parameters.AddWithValue("@codigo2", textBoxCodigo.Text);

            //UPDATE

            c.Open();
            
            cmd.CommandText = @"UPDATE Produtos SET Quantidade = @qtd2 WHERE Id = @codigo2;";
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

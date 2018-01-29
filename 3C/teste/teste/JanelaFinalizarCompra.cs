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
    public partial class JanelaFinalizarCompra : Form
    {
        JanelaRegistrarVenda x = new JanelaRegistrarVenda();

        public JanelaFinalizarCompra()
        {
            InitializeComponent();
        }

        private void ClickFinalizar(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=localhost; Initial Catalog=Loja_de_cosmeticos; Integrated Security=SSPI"),
                CommandText = @"INSERT INTO Venda(Descrição, Cpf_Cliente) VALUES(@desc, @cpf-c, @cpf-rev)();"
            };

            cmd.Parameters.AddWithValue("desc", textBoxDesc.Text);
            cmd.Parameters.AddWithValue("cpf-c", textBoxCpf.Text);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

        private void JanelaFinalizarCompra_Load(object sender, EventArgs e)
        {
            labelTotal.Text = Convert.ToString(x.total);
        }
    }
}

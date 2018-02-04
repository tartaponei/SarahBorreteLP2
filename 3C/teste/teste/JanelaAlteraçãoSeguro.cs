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
    public partial class JanelaAlteraçãoSeguro : Form
    {
        public JanelaAlteraçãoSeguro()
        {
            InitializeComponent();
        }

        private void ClickColocar(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=localhost; Initial Catalog=Loja_de_cosmeticos; Integrated Security=SSPI"),
                CommandText = @"UPDATE Bijuteria SET Seguro = 'S' WHERE Id = @codigo;"
            };

            cmd.Parameters.AddWithValue("@codigo", textBoxCodigo.Text);

            cmd.Connection.Open();

            int retorno = cmd.ExecuteNonQuery();

            if (retorno == 1)
                MessageBox.Show("Atualizado!");
            else
                MessageBox.Show("Ocorreu um erro. O item já está no seguro, ou o código não é válido (somente bijuerias podem ser colocadas no seguro.)");

            cmd.Connection.Close();
        }

        private void ClickTirar(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=localhost; Initial Catalog=Loja_de_cosmeticos; Integrated Security=SSPI"),
                CommandText = @"UPDATE Bijuteria SET Seguro = 'N' WHERE Id = @codigo;"
            };

            cmd.Parameters.AddWithValue("@codigo", textBoxCodigo.Text);

            cmd.Connection.Open();

            int retorno = cmd.ExecuteNonQuery();

            if (retorno == 1)
                MessageBox.Show("Atualizado!");
            else
                MessageBox.Show("Ocorreu um erro. O item já não possui seguro, ou o código não é válido (somente bijuerias podem ser colocadas no seguro.)");

            cmd.Connection.Close();
        }
    }
}

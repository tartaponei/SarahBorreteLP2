namespace teste
{
    partial class JanelaInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnConsultarPreco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(12, 168);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(134, 46);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "Cadastro de Revendedor";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.CadastroRClick);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 89);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 46);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.LoginClick);
            // 
            // btnConsultarPreco
            // 
            this.btnConsultarPreco.Location = new System.Drawing.Point(12, 252);
            this.btnConsultarPreco.Name = "btnConsultarPreco";
            this.btnConsultarPreco.Size = new System.Drawing.Size(134, 46);
            this.btnConsultarPreco.TabIndex = 3;
            this.btnConsultarPreco.Text = "Consultar Preço";
            this.btnConsultarPreco.UseVisualStyleBackColor = true;
            this.btnConsultarPreco.Click += new System.EventHandler(this.ConsultarClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Já é revendedor nosso?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ainda não é cliente ou revendedor? Cadastre-se!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quer comparar os preços?";
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Location = new System.Drawing.Point(185, 168);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(134, 46);
            this.btnCadastroCliente.TabIndex = 7;
            this.btnCadastroCliente.Text = "Cadastro de Cliente";
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            this.btnCadastroCliente.Click += new System.EventHandler(this.ClickCadastroC);
            // 
            // JanelaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 320);
            this.Controls.Add(this.btnCadastroCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConsultarPreco);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCadastro);
            this.Name = "JanelaInicio";
            this.Text = "Início";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnConsultarPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastroCliente;
    }
}


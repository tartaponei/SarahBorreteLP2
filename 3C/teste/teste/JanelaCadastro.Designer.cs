namespace teste
{
    partial class JanelaCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnContinuarCadastro = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelNovaSenha = new System.Windows.Forms.Label();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxNovaSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnContinuarCadastro
            // 
            this.btnContinuarCadastro.Location = new System.Drawing.Point(125, 175);
            this.btnContinuarCadastro.Name = "btnContinuarCadastro";
            this.btnContinuarCadastro.Size = new System.Drawing.Size(100, 30);
            this.btnContinuarCadastro.TabIndex = 0;
            this.btnContinuarCadastro.Text = "Continuar";
            this.btnContinuarCadastro.UseVisualStyleBackColor = true;
            this.btnContinuarCadastro.Click += new System.EventHandler(this.ContinuarCadastroClick);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(9, 28);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(9, 81);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(27, 13);
            this.labelCpf.TabIndex = 4;
            this.labelCpf.Text = "CPF";
            // 
            // labelNovaSenha
            // 
            this.labelNovaSenha.AutoSize = true;
            this.labelNovaSenha.Location = new System.Drawing.Point(9, 133);
            this.labelNovaSenha.Name = "labelNovaSenha";
            this.labelNovaSenha.Size = new System.Drawing.Size(67, 13);
            this.labelNovaSenha.TabIndex = 6;
            this.labelNovaSenha.Text = "Nova Senha";
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(12, 97);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(212, 20);
            this.textBoxCpf.TabIndex = 7;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 44);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(212, 20);
            this.textBoxNome.TabIndex = 8;
            // 
            // textBoxNovaSenha
            // 
            this.textBoxNovaSenha.Location = new System.Drawing.Point(12, 149);
            this.textBoxNovaSenha.Name = "textBoxNovaSenha";
            this.textBoxNovaSenha.PasswordChar = '•';
            this.textBoxNovaSenha.Size = new System.Drawing.Size(212, 20);
            this.textBoxNovaSenha.TabIndex = 10;
            // 
            // JanelaCadastro
            // 
            this.ClientSize = new System.Drawing.Size(237, 217);
            this.Controls.Add(this.textBoxNovaSenha);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(this.labelNovaSenha);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.btnContinuarCadastro);
            this.Name = "JanelaCadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.CheckBox checkBoxCliente;
        private System.Windows.Forms.CheckBox checkBoxRevendedor;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnContinuarCadastro;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelNovaSenha;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxNovaSenha;
    }
}
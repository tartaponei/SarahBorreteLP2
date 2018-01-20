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
            this.checkBoxSerRevendedor = new System.Windows.Forms.CheckBox();
            this.checkBoxSerCliente = new System.Windows.Forms.CheckBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNovoUsuario = new System.Windows.Forms.Label();
            this.labelNovoEmail = new System.Windows.Forms.Label();
            this.labelNovaSenha = new System.Windows.Forms.Label();
            this.textBoxNovoUsuario = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxNovoEmail = new System.Windows.Forms.TextBox();
            this.textBoxNovaSenha = new System.Windows.Forms.TextBox();
            this.labelSobrenome = new System.Windows.Forms.Label();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnContinuarCadastro
            // 
            this.btnContinuarCadastro.Location = new System.Drawing.Point(347, 283);
            this.btnContinuarCadastro.Name = "btnContinuarCadastro";
            this.btnContinuarCadastro.Size = new System.Drawing.Size(100, 30);
            this.btnContinuarCadastro.TabIndex = 0;
            this.btnContinuarCadastro.Text = "Continuar";
            this.btnContinuarCadastro.UseVisualStyleBackColor = true;
            this.btnContinuarCadastro.Click += new System.EventHandler(this.ContinuarCadastroClick);
            // 
            // checkBoxSerRevendedor
            // 
            this.checkBoxSerRevendedor.AutoSize = true;
            this.checkBoxSerRevendedor.Location = new System.Drawing.Point(12, 267);
            this.checkBoxSerRevendedor.Name = "checkBoxSerRevendedor";
            this.checkBoxSerRevendedor.Size = new System.Drawing.Size(117, 17);
            this.checkBoxSerRevendedor.TabIndex = 1;
            this.checkBoxSerRevendedor.Text = "Quero ser revendor";
            this.checkBoxSerRevendedor.UseVisualStyleBackColor = true;
            this.checkBoxSerRevendedor.Click += new System.EventHandler(this.SerRevendedorClick);
            // 
            // checkBoxSerCliente
            // 
            this.checkBoxSerCliente.AutoSize = true;
            this.checkBoxSerCliente.Location = new System.Drawing.Point(12, 244);
            this.checkBoxSerCliente.Name = "checkBoxSerCliente";
            this.checkBoxSerCliente.Size = new System.Drawing.Size(106, 17);
            this.checkBoxSerCliente.TabIndex = 2;
            this.checkBoxSerCliente.Text = "Quero ser cliente";
            this.checkBoxSerCliente.UseVisualStyleBackColor = true;
            this.checkBoxSerCliente.Click += new System.EventHandler(this.SerClienteClick);
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
            // labelNovoUsuario
            // 
            this.labelNovoUsuario.AutoSize = true;
            this.labelNovoUsuario.Location = new System.Drawing.Point(9, 81);
            this.labelNovoUsuario.Name = "labelNovoUsuario";
            this.labelNovoUsuario.Size = new System.Drawing.Size(72, 13);
            this.labelNovoUsuario.TabIndex = 4;
            this.labelNovoUsuario.Text = "Novo Usuário";
            // 
            // labelNovoEmail
            // 
            this.labelNovoEmail.AutoSize = true;
            this.labelNovoEmail.Location = new System.Drawing.Point(9, 138);
            this.labelNovoEmail.Name = "labelNovoEmail";
            this.labelNovoEmail.Size = new System.Drawing.Size(32, 13);
            this.labelNovoEmail.TabIndex = 5;
            this.labelNovoEmail.Text = "Email";
            // 
            // labelNovaSenha
            // 
            this.labelNovaSenha.AutoSize = true;
            this.labelNovaSenha.Location = new System.Drawing.Point(9, 192);
            this.labelNovaSenha.Name = "labelNovaSenha";
            this.labelNovaSenha.Size = new System.Drawing.Size(67, 13);
            this.labelNovaSenha.TabIndex = 6;
            this.labelNovaSenha.Text = "Nova Senha";
            // 
            // textBoxNovoUsuario
            // 
            this.textBoxNovoUsuario.Location = new System.Drawing.Point(12, 97);
            this.textBoxNovoUsuario.Name = "textBoxNovoUsuario";
            this.textBoxNovoUsuario.Size = new System.Drawing.Size(435, 20);
            this.textBoxNovoUsuario.TabIndex = 7;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(12, 44);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(212, 20);
            this.textBoxNome.TabIndex = 8;
            // 
            // textBoxNovoEmail
            // 
            this.textBoxNovoEmail.Location = new System.Drawing.Point(12, 154);
            this.textBoxNovoEmail.Name = "textBoxNovoEmail";
            this.textBoxNovoEmail.Size = new System.Drawing.Size(435, 20);
            this.textBoxNovoEmail.TabIndex = 9;
            // 
            // textBoxNovaSenha
            // 
            this.textBoxNovaSenha.Location = new System.Drawing.Point(12, 208);
            this.textBoxNovaSenha.Name = "textBoxNovaSenha";
            this.textBoxNovaSenha.PasswordChar = '•';
            this.textBoxNovaSenha.Size = new System.Drawing.Size(435, 20);
            this.textBoxNovaSenha.TabIndex = 10;
            // 
            // labelSobrenome
            // 
            this.labelSobrenome.AutoSize = true;
            this.labelSobrenome.Location = new System.Drawing.Point(232, 28);
            this.labelSobrenome.Name = "labelSobrenome";
            this.labelSobrenome.Size = new System.Drawing.Size(61, 13);
            this.labelSobrenome.TabIndex = 11;
            this.labelSobrenome.Text = "Sobrenome";
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(235, 44);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(212, 20);
            this.textBoxSobrenome.TabIndex = 12;
            // 
            // JanelaCadastro
            // 
            this.ClientSize = new System.Drawing.Size(459, 326);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.labelSobrenome);
            this.Controls.Add(this.textBoxNovaSenha);
            this.Controls.Add(this.textBoxNovoEmail);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxNovoUsuario);
            this.Controls.Add(this.labelNovaSenha);
            this.Controls.Add(this.labelNovoEmail);
            this.Controls.Add(this.labelNovoUsuario);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.checkBoxSerCliente);
            this.Controls.Add(this.checkBoxSerRevendedor);
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
        private System.Windows.Forms.CheckBox checkBoxSerRevendedor;
        private System.Windows.Forms.CheckBox checkBoxSerCliente;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNovoUsuario;
        private System.Windows.Forms.Label labelNovoEmail;
        private System.Windows.Forms.Label labelNovaSenha;
        private System.Windows.Forms.TextBox textBoxNovoUsuario;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxNovoEmail;
        private System.Windows.Forms.TextBox textBoxNovaSenha;
        private System.Windows.Forms.Label labelSobrenome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
    }
}
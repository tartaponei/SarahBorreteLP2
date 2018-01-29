namespace teste
{
    partial class JanelaLogin
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
            this.btnContinuarLogin = new System.Windows.Forms.Button();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnContinuarLogin
            // 
            this.btnContinuarLogin.Location = new System.Drawing.Point(184, 124);
            this.btnContinuarLogin.Name = "btnContinuarLogin";
            this.btnContinuarLogin.Size = new System.Drawing.Size(88, 26);
            this.btnContinuarLogin.TabIndex = 0;
            this.btnContinuarLogin.Text = "Continuar";
            this.btnContinuarLogin.UseVisualStyleBackColor = true;
            this.btnContinuarLogin.Click += new System.EventHandler(this.ContinuarLogin);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(9, 72);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 3;
            this.labelSenha.Text = "Senha";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(9, 20);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(27, 13);
            this.labelUsuario.TabIndex = 4;
            this.labelUsuario.Text = "CPF";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(12, 36);
            this.textBoxUsuario.MaxLength = 11;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(252, 20);
            this.textBoxUsuario.TabIndex = 5;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(12, 88);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '•';
            this.textBoxSenha.Size = new System.Drawing.Size(252, 20);
            this.textBoxSenha.TabIndex = 6;
            // 
            // JanelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 158);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.btnContinuarLogin);
            this.Name = "JanelaLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinuarLogin;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
    }
}
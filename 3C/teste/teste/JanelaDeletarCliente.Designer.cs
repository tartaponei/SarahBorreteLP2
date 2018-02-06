namespace teste
{
    partial class JanelaDeletarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnContinuarCadastro
            // 
            this.btnContinuarCadastro.Location = new System.Drawing.Point(125, 79);
            this.btnContinuarCadastro.Name = "btnContinuarCadastro";
            this.btnContinuarCadastro.Size = new System.Drawing.Size(100, 30);
            this.btnContinuarCadastro.TabIndex = 5;
            this.btnContinuarCadastro.Text = "Continuar";
            this.btnContinuarCadastro.UseVisualStyleBackColor = true;
            this.btnContinuarCadastro.Click += new System.EventHandler(this.ClickContinuarDelete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CPF";
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(12, 43);
            this.textBoxCpf.MaxLength = 11;
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(212, 20);
            this.textBoxCpf.TabIndex = 8;
            // 
            // JanelaDeletarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 121);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnContinuarCadastro);
            this.Name = "JanelaDeletarCliente";
            this.Text = "Deletar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinuarCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCpf;
    }
}
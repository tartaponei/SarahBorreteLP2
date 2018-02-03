namespace teste
{
    partial class JanelaLogada
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
            this.btnRegistrarVenda = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarVenda
            // 
            this.btnRegistrarVenda.Location = new System.Drawing.Point(12, 12);
            this.btnRegistrarVenda.Name = "btnRegistrarVenda";
            this.btnRegistrarVenda.Size = new System.Drawing.Size(123, 48);
            this.btnRegistrarVenda.TabIndex = 0;
            this.btnRegistrarVenda.Text = "Registrar Venda";
            this.btnRegistrarVenda.UseVisualStyleBackColor = true;
            this.btnRegistrarVenda.Click += new System.EventHandler(this.ClickRegistrarVenda);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(12, 87);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(123, 48);
            this.btnCadastrarCliente.TabIndex = 1;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.ClickCadastrarCliente);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Colocar Item no Seguro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // JanelaLogada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnRegistrarVenda);
            this.Name = "JanelaLogada";
            this.Text = "Bem-vindo(a)!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarVenda;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button button1;
    }
}
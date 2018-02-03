namespace teste
{
    partial class JanelaConsulta
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
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.txtBoxPreco = new System.Windows.Forms.TextBox();
            this.txtBoxQtd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrecoProduto = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(12, 46);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(165, 20);
            this.txtBoxCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(10, 30);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(135, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Digite o código do produto:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 72);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.ClickConsulta);
            // 
            // txtBoxNomeProduto
            // 
            this.txtBoxNomeProduto.Location = new System.Drawing.Point(12, 153);
            this.txtBoxNomeProduto.Name = "txtBoxNomeProduto";
            this.txtBoxNomeProduto.Size = new System.Drawing.Size(175, 20);
            this.txtBoxNomeProduto.TabIndex = 3;
            // 
            // txtBoxPreco
            // 
            this.txtBoxPreco.Location = new System.Drawing.Point(196, 153);
            this.txtBoxPreco.Name = "txtBoxPreco";
            this.txtBoxPreco.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPreco.TabIndex = 4;
            // 
            // txtBoxQtd
            // 
            this.txtBoxQtd.Location = new System.Drawing.Point(302, 153);
            this.txtBoxQtd.Name = "txtBoxQtd";
            this.txtBoxQtd.Size = new System.Drawing.Size(77, 20);
            this.txtBoxQtd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // lblPrecoProduto
            // 
            this.lblPrecoProduto.AutoSize = true;
            this.lblPrecoProduto.Location = new System.Drawing.Point(196, 137);
            this.lblPrecoProduto.Name = "lblPrecoProduto";
            this.lblPrecoProduto.Size = new System.Drawing.Size(35, 13);
            this.lblPrecoProduto.TabIndex = 8;
            this.lblPrecoProduto.Text = "Preço";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(302, 137);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(116, 13);
            this.lblQtd.TabIndex = 9;
            this.lblQtd.Text = "Quantidade Disponível";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(13, 137);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(35, 13);
            this.lblNomeProduto.TabIndex = 10;
            this.lblNomeProduto.Text = "Nome";
            // 
            // JanelaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 195);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblPrecoProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxQtd);
            this.Controls.Add(this.txtBoxPreco);
            this.Controls.Add(this.txtBoxNomeProduto);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtBoxCodigo);
            this.Name = "JanelaConsulta";
            this.Text = "Consulta de Preços";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtBoxNomeProduto;
        private System.Windows.Forms.TextBox txtBoxPreco;
        private System.Windows.Forms.TextBox txtBoxQtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrecoProduto;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblNomeProduto;
    }
}
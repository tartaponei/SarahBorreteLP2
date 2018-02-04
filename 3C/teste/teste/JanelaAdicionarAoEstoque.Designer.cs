namespace teste
{
    partial class JanelaAdicionarAoEstoque
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.checkBoxCosmetico = new System.Windows.Forms.CheckBox();
            this.checkBoxBijuteria = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade a Adicionar";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(12, 47);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(93, 20);
            this.textBoxCodigo.TabIndex = 2;
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.Location = new System.Drawing.Point(13, 104);
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(158, 20);
            this.textBoxQtd.TabIndex = 3;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(208, 105);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(102, 34);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.ClickAdicionar);
            // 
            // checkBoxCosmetico
            // 
            this.checkBoxCosmetico.AutoSize = true;
            this.checkBoxCosmetico.Location = new System.Drawing.Point(235, 31);
            this.checkBoxCosmetico.Name = "checkBoxCosmetico";
            this.checkBoxCosmetico.Size = new System.Drawing.Size(75, 17);
            this.checkBoxCosmetico.TabIndex = 5;
            this.checkBoxCosmetico.Text = "Cosmético";
            this.checkBoxCosmetico.UseVisualStyleBackColor = true;
            // 
            // checkBoxBijuteria
            // 
            this.checkBoxBijuteria.AutoSize = true;
            this.checkBoxBijuteria.Location = new System.Drawing.Point(235, 50);
            this.checkBoxBijuteria.Name = "checkBoxBijuteria";
            this.checkBoxBijuteria.Size = new System.Drawing.Size(63, 17);
            this.checkBoxBijuteria.TabIndex = 6;
            this.checkBoxBijuteria.Text = "Bijuteria";
            this.checkBoxBijuteria.UseVisualStyleBackColor = true;
            // 
            // JanelaAdicionarAoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 151);
            this.Controls.Add(this.checkBoxBijuteria);
            this.Controls.Add(this.checkBoxCosmetico);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.textBoxQtd);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "JanelaAdicionarAoEstoque";
            this.Text = "Atualizar Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxQtd;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.CheckBox checkBoxCosmetico;
        private System.Windows.Forms.CheckBox checkBoxBijuteria;
    }
}
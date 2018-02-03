namespace teste
{
    partial class JanelaFinalizarCompra
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
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnFinalizarC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(12, 31);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(19, 13);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "    ";
            // 
            // btnFinalizarC
            // 
            this.btnFinalizarC.Location = new System.Drawing.Point(12, 164);
            this.btnFinalizarC.Name = "btnFinalizarC";
            this.btnFinalizarC.Size = new System.Drawing.Size(85, 27);
            this.btnFinalizarC.TabIndex = 2;
            this.btnFinalizarC.Text = "Finalizar";
            this.btnFinalizarC.UseVisualStyleBackColor = true;
            this.btnFinalizarC.Click += new System.EventHandler(this.ClickFinalizar);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF do Cliente";
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Location = new System.Drawing.Point(12, 74);
            this.textBoxCpf.MaxLength = 11;
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(151, 20);
            this.textBoxCpf.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(12, 124);
            this.textBoxDesc.MaxLength = 11;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(471, 20);
            this.textBoxDesc.TabIndex = 6;
            // 
            // JanelaFinalizarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 207);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFinalizarC);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Name = "JanelaFinalizarCompra";
            this.Text = "Finalizar?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnFinalizarC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDesc;
    }
}
namespace OneTimePad
{
    partial class Form1
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
            this.txtPlaintexti = new System.Windows.Forms.TextBox();
            this.txtCelesi = new System.Windows.Forms.TextBox();
            this.txtDekriptuar = new System.Windows.Forms.TextBox();
            this.txtCiphertexti = new System.Windows.Forms.TextBox();
            this.btnEnkripto = new System.Windows.Forms.Button();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPlaintexti
            // 
            this.txtPlaintexti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlaintexti.Location = new System.Drawing.Point(33, 27);
            this.txtPlaintexti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlaintexti.Multiline = true;
            this.txtPlaintexti.Name = "txtPlaintexti";
            this.txtPlaintexti.Size = new System.Drawing.Size(464, 19);
            this.txtPlaintexti.TabIndex = 0;
            // 
            // txtCelesi
            // 
            this.txtCelesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCelesi.Location = new System.Drawing.Point(33, 98);
            this.txtCelesi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCelesi.Multiline = true;
            this.txtCelesi.Name = "txtCelesi";
            this.txtCelesi.Size = new System.Drawing.Size(464, 19);
            this.txtCelesi.TabIndex = 1;
            // 
            // txtDekriptuar
            // 
            this.txtDekriptuar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDekriptuar.Location = new System.Drawing.Point(33, 226);
            this.txtDekriptuar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDekriptuar.Multiline = true;
            this.txtDekriptuar.Name = "txtDekriptuar";
            this.txtDekriptuar.Size = new System.Drawing.Size(464, 19);
            this.txtDekriptuar.TabIndex = 2;
            // 
            // txtCiphertexti
            // 
            this.txtCiphertexti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCiphertexti.Location = new System.Drawing.Point(33, 144);
            this.txtCiphertexti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCiphertexti.Multiline = true;
            this.txtCiphertexti.Name = "txtCiphertexti";
            this.txtCiphertexti.Size = new System.Drawing.Size(464, 19);
            this.txtCiphertexti.TabIndex = 3;
            // 
            // btnEnkripto
            // 
            this.btnEnkripto.Location = new System.Drawing.Point(419, 55);
            this.btnEnkripto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnkripto.Name = "btnEnkripto";
            this.btnEnkripto.Size = new System.Drawing.Size(77, 30);
            this.btnEnkripto.TabIndex = 4;
            this.btnEnkripto.Text = "Enkripto";
            this.btnEnkripto.UseVisualStyleBackColor = true;
            this.btnEnkripto.Click += new System.EventHandler(this.btnEnkripto_Click);
            // 
            // btnDekripto
            // 
            this.btnDekripto.Location = new System.Drawing.Point(419, 182);
            this.btnDekripto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(77, 30);
            this.btnDekripto.TabIndex = 5;
            this.btnDekripto.Text = "Dekripto";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.BtnDekripto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.btnEnkripto);
            this.Controls.Add(this.txtCiphertexti);
            this.Controls.Add(this.txtDekriptuar);
            this.Controls.Add(this.txtCelesi);
            this.Controls.Add(this.txtPlaintexti);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "One-Time Pad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaintexti;
        private System.Windows.Forms.TextBox txtCelesi;
        private System.Windows.Forms.TextBox txtDekriptuar;
        private System.Windows.Forms.TextBox txtCiphertexti;
        private System.Windows.Forms.Button btnEnkripto;
        private System.Windows.Forms.Button btnDekripto;
    }
}


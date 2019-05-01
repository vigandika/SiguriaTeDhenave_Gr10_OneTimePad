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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlaintexti
            // 
            this.txtPlaintexti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlaintexti.Location = new System.Drawing.Point(50, 42);
            this.txtPlaintexti.Multiline = true;
            this.txtPlaintexti.Name = "txtPlaintexti";
            this.txtPlaintexti.Size = new System.Drawing.Size(694, 27);
            this.txtPlaintexti.TabIndex = 0;
            // 
            // txtCelesi
            // 
            this.txtCelesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCelesi.Location = new System.Drawing.Point(50, 151);
            this.txtCelesi.Multiline = true;
            this.txtCelesi.Name = "txtCelesi";
            this.txtCelesi.Size = new System.Drawing.Size(694, 27);
            this.txtCelesi.TabIndex = 1;
            // 
            // txtDekriptuar
            // 
            this.txtDekriptuar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDekriptuar.Location = new System.Drawing.Point(50, 348);
            this.txtDekriptuar.Multiline = true;
            this.txtDekriptuar.Name = "txtDekriptuar";
            this.txtDekriptuar.Size = new System.Drawing.Size(694, 27);
            this.txtDekriptuar.TabIndex = 2;
            // 
            // txtCiphertexti
            // 
            this.txtCiphertexti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCiphertexti.Location = new System.Drawing.Point(50, 221);
            this.txtCiphertexti.Multiline = true;
            this.txtCiphertexti.Name = "txtCiphertexti";
            this.txtCiphertexti.Size = new System.Drawing.Size(694, 27);
            this.txtCiphertexti.TabIndex = 3;
            // 
            // btnEnkripto
            // 
            this.btnEnkripto.Location = new System.Drawing.Point(628, 84);
            this.btnEnkripto.Name = "btnEnkripto";
            this.btnEnkripto.Size = new System.Drawing.Size(116, 46);
            this.btnEnkripto.TabIndex = 4;
            this.btnEnkripto.Text = "Enkripto";
            this.btnEnkripto.UseVisualStyleBackColor = true;
            this.btnEnkripto.Click += new System.EventHandler(this.btnEnkripto_Click);
            // 
            // btnDekripto
            // 
            this.btnDekripto.Location = new System.Drawing.Point(628, 280);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(116, 46);
            this.btnDekripto.TabIndex = 5;
            this.btnDekripto.Text = "Dekripto";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Plain teksti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Celesi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Teksti i enkriptuar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Teksti i dekriptuar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.btnEnkripto);
            this.Controls.Add(this.txtCiphertexti);
            this.Controls.Add(this.txtDekriptuar);
            this.Controls.Add(this.txtCelesi);
            this.Controls.Add(this.txtPlaintexti);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


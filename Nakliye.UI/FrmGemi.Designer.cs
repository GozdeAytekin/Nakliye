
namespace Nakliye.UI
{
    partial class FrmGemi
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
            this.txtGemiAdi = new System.Windows.Forms.TextBox();
            this.txtTonaj = new System.Windows.Forms.TextBox();
            this.btnGec = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // txtGemiAdi
            // 
            this.txtGemiAdi.Location = new System.Drawing.Point(126, 95);
            this.txtGemiAdi.Name = "txtGemiAdi";
            this.txtGemiAdi.Size = new System.Drawing.Size(355, 22);
            this.txtGemiAdi.TabIndex = 2;
            // 
            // txtTonaj
            // 
            this.txtTonaj.Location = new System.Drawing.Point(126, 131);
            this.txtTonaj.Name = "txtTonaj";
            this.txtTonaj.Size = new System.Drawing.Size(355, 22);
            this.txtTonaj.TabIndex = 2;
            // 
            // btnGec
            // 
            this.btnGec.Location = new System.Drawing.Point(379, 178);
            this.btnGec.Name = "btnGec";
            this.btnGec.Size = new System.Drawing.Size(75, 23);
            this.btnGec.TabIndex = 3;
            this.btnGec.Text = ">>";
            this.btnGec.UseVisualStyleBackColor = true;
            this.btnGec.Click += new System.EventHandler(this.btnGec_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(251, 178);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "+";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FrmGemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 253);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGec);
            this.Controls.Add(this.txtTonaj);
            this.Controls.Add(this.txtGemiAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGemi";
            this.Text = "FrmGemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGemiAdi;
        private System.Windows.Forms.TextBox txtTonaj;
        private System.Windows.Forms.Button btnGec;
        private System.Windows.Forms.Button btnEkle;
    }
}
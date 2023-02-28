
namespace Nakliye.UI
{
    partial class FrmRota
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
            this.cmbGemi = new System.Windows.Forms.ComboBox();
            this.lblUgra = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKalkisLimani = new System.Windows.Forms.ComboBox();
            this.cmbUgranacakLiman = new System.Windows.Forms.ComboBox();
            this.cmbVarisLimani = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtKalkis = new System.Windows.Forms.DateTimePicker();
            this.dtVaris = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstRotalar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kalkış";
            // 
            // cmbGemi
            // 
            this.cmbGemi.FormattingEnabled = true;
            this.cmbGemi.Location = new System.Drawing.Point(205, 52);
            this.cmbGemi.Name = "cmbGemi";
            this.cmbGemi.Size = new System.Drawing.Size(285, 24);
            this.cmbGemi.TabIndex = 2;
            // 
            // lblUgra
            // 
            this.lblUgra.AutoSize = true;
            this.lblUgra.Location = new System.Drawing.Point(82, 141);
            this.lblUgra.Name = "lblUgra";
            this.lblUgra.Size = new System.Drawing.Size(96, 21);
            this.lblUgra.TabIndex = 1;
            this.lblUgra.Text = "Ugranacak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Varis";
            // 
            // cmbKalkisLimani
            // 
            this.cmbKalkisLimani.FormattingEnabled = true;
            this.cmbKalkisLimani.Items.AddRange(new object[] {
            "izmir",
            "istanbul",
            "adana",
            "iskenderun",
            "yunanistan"});
            this.cmbKalkisLimani.Location = new System.Drawing.Point(205, 96);
            this.cmbKalkisLimani.Name = "cmbKalkisLimani";
            this.cmbKalkisLimani.Size = new System.Drawing.Size(285, 24);
            this.cmbKalkisLimani.TabIndex = 2;
            // 
            // cmbUgranacakLiman
            // 
            this.cmbUgranacakLiman.FormattingEnabled = true;
            this.cmbUgranacakLiman.Items.AddRange(new object[] {
            "izmir",
            "istanbul",
            "adana",
            "iskenderun",
            "yunanistan"});
            this.cmbUgranacakLiman.Location = new System.Drawing.Point(205, 141);
            this.cmbUgranacakLiman.Name = "cmbUgranacakLiman";
            this.cmbUgranacakLiman.Size = new System.Drawing.Size(285, 24);
            this.cmbUgranacakLiman.TabIndex = 2;
            // 
            // cmbVarisLimani
            // 
            this.cmbVarisLimani.FormattingEnabled = true;
            this.cmbVarisLimani.Items.AddRange(new object[] {
            "izmir",
            "istanbul",
            "adana",
            "iskenderun",
            "yunanistan"});
            this.cmbVarisLimani.Location = new System.Drawing.Point(205, 179);
            this.cmbVarisLimani.Name = "cmbVarisLimani";
            this.cmbVarisLimani.Size = new System.Drawing.Size(285, 24);
            this.cmbVarisLimani.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtKalkis
            // 
            this.dtKalkis.Location = new System.Drawing.Point(67, 236);
            this.dtKalkis.Name = "dtKalkis";
            this.dtKalkis.Size = new System.Drawing.Size(200, 22);
            this.dtKalkis.TabIndex = 4;
            // 
            // dtVaris
            // 
            this.dtVaris.Location = new System.Drawing.Point(293, 236);
            this.dtVaris.Name = "dtVaris";
            this.dtVaris.Size = new System.Drawing.Size(200, 22);
            this.dtVaris.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Varis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kalkış";
            // 
            // lstRotalar
            // 
            this.lstRotalar.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstRotalar.FormattingEnabled = true;
            this.lstRotalar.ItemHeight = 16;
            this.lstRotalar.Location = new System.Drawing.Point(499, 0);
            this.lstRotalar.Name = "lstRotalar";
            this.lstRotalar.Size = new System.Drawing.Size(886, 347);
            this.lstRotalar.TabIndex = 5;
            // 
            // FrmRota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 347);
            this.Controls.Add(this.lstRotalar);
            this.Controls.Add(this.dtVaris);
            this.Controls.Add(this.dtKalkis);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUgra);
            this.Controls.Add(this.cmbVarisLimani);
            this.Controls.Add(this.cmbUgranacakLiman);
            this.Controls.Add(this.cmbKalkisLimani);
            this.Controls.Add(this.cmbGemi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRota";
            this.Text = "FrmRota";
            this.Load += new System.EventHandler(this.FrmRota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGemi;
        private System.Windows.Forms.Label lblUgra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKalkisLimani;
        private System.Windows.Forms.ComboBox cmbUgranacakLiman;
        private System.Windows.Forms.ComboBox cmbVarisLimani;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtKalkis;
        private System.Windows.Forms.DateTimePicker dtVaris;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstRotalar;
    }
}
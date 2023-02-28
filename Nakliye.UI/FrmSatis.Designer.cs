
namespace Nakliye.UI
{
    partial class FrmSatis
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblUgra = new System.Windows.Forms.Label();
            this.cmbVarisLimani = new System.Windows.Forms.ComboBox();
            this.cmbKalkisLimani = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbBulunanSeferler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYuklenecekMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMusteriUnvan = new System.Windows.Forms.TextBox();
            this.txtVDNumarasi = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGeç = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "TArih";
            // 
            // lblUgra
            // 
            this.lblUgra.AutoSize = true;
            this.lblUgra.Location = new System.Drawing.Point(43, 116);
            this.lblUgra.Name = "lblUgra";
            this.lblUgra.Size = new System.Drawing.Size(50, 21);
            this.lblUgra.TabIndex = 3;
            this.lblUgra.Text = "Varis";
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
            this.cmbVarisLimani.Location = new System.Drawing.Point(156, 116);
            this.cmbVarisLimani.Name = "cmbVarisLimani";
            this.cmbVarisLimani.Size = new System.Drawing.Size(295, 24);
            this.cmbVarisLimani.TabIndex = 5;
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
            this.cmbKalkisLimani.Location = new System.Drawing.Point(156, 71);
            this.cmbKalkisLimani.Name = "cmbKalkisLimani";
            this.cmbKalkisLimani.Size = new System.Drawing.Size(295, 24);
            this.cmbKalkisLimani.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kalkış";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(156, 159);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(295, 22);
            this.dtTarih.TabIndex = 7;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(376, 199);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 39);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbBulunanSeferler
            // 
            this.cmbBulunanSeferler.FormattingEnabled = true;
            this.cmbBulunanSeferler.Location = new System.Drawing.Point(724, 28);
            this.cmbBulunanSeferler.Name = "cmbBulunanSeferler";
            this.cmbBulunanSeferler.Size = new System.Drawing.Size(290, 24);
            this.cmbBulunanSeferler.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(575, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bulunan Seferler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kalkış";
            // 
            // txtYuklenecekMiktar
            // 
            this.txtYuklenecekMiktar.Location = new System.Drawing.Point(156, 31);
            this.txtYuklenecekMiktar.Name = "txtYuklenecekMiktar";
            this.txtYuklenecekMiktar.Size = new System.Drawing.Size(295, 22);
            this.txtYuklenecekMiktar.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Varis";
            // 
            // txtMusteriUnvan
            // 
            this.txtMusteriUnvan.Location = new System.Drawing.Point(724, 72);
            this.txtMusteriUnvan.Name = "txtMusteriUnvan";
            this.txtMusteriUnvan.Size = new System.Drawing.Size(290, 22);
            this.txtMusteriUnvan.TabIndex = 11;
            // 
            // txtVDNumarasi
            // 
            this.txtVDNumarasi.Location = new System.Drawing.Point(724, 113);
            this.txtVDNumarasi.Name = "txtVDNumarasi";
            this.txtVDNumarasi.Size = new System.Drawing.Size(290, 22);
            this.txtVDNumarasi.TabIndex = 11;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(724, 159);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(290, 22);
            this.txtAdres.TabIndex = 11;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(776, 199);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "++";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGeç
            // 
            this.btnGeç.Location = new System.Drawing.Point(927, 199);
            this.btnGeç.Name = "btnGeç";
            this.btnGeç.Size = new System.Drawing.Size(75, 23);
            this.btnGeç.TabIndex = 12;
            this.btnGeç.Text = ">>";
            this.btnGeç.UseVisualStyleBackColor = true;
            this.btnGeç.Click += new System.EventHandler(this.btnGeç_Click);
            // 
            // FrmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 363);
            this.Controls.Add(this.btnGeç);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtVDNumarasi);
            this.Controls.Add(this.txtMusteriUnvan);
            this.Controls.Add(this.txtYuklenecekMiktar);
            this.Controls.Add(this.cmbBulunanSeferler);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUgra);
            this.Controls.Add(this.cmbVarisLimani);
            this.Controls.Add(this.cmbKalkisLimani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "FrmSatis";
            this.Text = "FrmSatis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUgra;
        private System.Windows.Forms.ComboBox cmbVarisLimani;
        private System.Windows.Forms.ComboBox cmbKalkisLimani;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbBulunanSeferler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYuklenecekMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMusteriUnvan;
        private System.Windows.Forms.TextBox txtVDNumarasi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGeç;
    }
}
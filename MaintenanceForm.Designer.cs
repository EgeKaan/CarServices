namespace CarServices
{
    partial class MaintenanceForm
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
            this.dgBakım = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBakımID = new System.Windows.Forms.Label();
            this.dtGiris = new System.Windows.Forms.DateTimePicker();
            this.dtCıkıs = new System.Windows.Forms.DateTimePicker();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnYeniKayıt = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnDoldur = new System.Windows.Forms.Button();
            this.txtOdemeTuru = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBakım)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(129, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Bakım No";
            // 
            // dgBakım
            // 
            this.dgBakım.AllowUserToAddRows = false;
            this.dgBakım.AllowUserToDeleteRows = false;
            this.dgBakım.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBakım.Location = new System.Drawing.Point(154, 190);
            this.dgBakım.Name = "dgBakım";
            this.dgBakım.ReadOnly = true;
            this.dgBakım.Size = new System.Drawing.Size(551, 320);
            this.dgBakım.TabIndex = 48;
            this.dgBakım.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBakım_CellContentDoubleClick);
            this.dgBakım.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgBakım_CellMouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(465, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Çıkış";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.Location = new System.Drawing.Point(538, 82);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(208, 22);
            this.txtToplamTutar.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(444, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Toplam Tutar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(150, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 55;
            this.label4.Text = "Giriş";
            // 
            // lblBakımID
            // 
            this.lblBakımID.AutoSize = true;
            this.lblBakımID.Enabled = false;
            this.lblBakımID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakımID.ForeColor = System.Drawing.Color.Red;
            this.lblBakımID.Location = new System.Drawing.Point(220, 31);
            this.lblBakımID.Name = "lblBakımID";
            this.lblBakımID.Size = new System.Drawing.Size(0, 16);
            this.lblBakımID.TabIndex = 57;
            // 
            // dtGiris
            // 
            this.dtGiris.Location = new System.Drawing.Point(223, 136);
            this.dtGiris.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtGiris.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtGiris.Name = "dtGiris";
            this.dtGiris.Size = new System.Drawing.Size(200, 20);
            this.dtGiris.TabIndex = 58;
            // 
            // dtCıkıs
            // 
            this.dtCıkıs.Location = new System.Drawing.Point(538, 136);
            this.dtCıkıs.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtCıkıs.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtCıkıs.Name = "dtCıkıs";
            this.dtCıkıs.Size = new System.Drawing.Size(200, 20);
            this.dtCıkıs.TabIndex = 59;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(247, 552);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 35);
            this.btnTemizle.TabIndex = 63;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(321, 616);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(85, 35);
            this.btnIptal.TabIndex = 62;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnYeniKayıt
            // 
            this.btnYeniKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKayıt.Location = new System.Drawing.Point(498, 552);
            this.btnYeniKayıt.Name = "btnYeniKayıt";
            this.btnYeniKayıt.Size = new System.Drawing.Size(85, 35);
            this.btnYeniKayıt.TabIndex = 61;
            this.btnYeniKayıt.Text = "Yeni Kayıt";
            this.btnYeniKayıt.UseVisualStyleBackColor = true;
            this.btnYeniKayıt.Click += new System.EventHandler(this.btnYeniKayıt_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(380, 552);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 35);
            this.btnGuncelle.TabIndex = 60;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnDoldur
            // 
            this.btnDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoldur.Location = new System.Drawing.Point(439, 616);
            this.btnDoldur.Name = "btnDoldur";
            this.btnDoldur.Size = new System.Drawing.Size(85, 35);
            this.btnDoldur.TabIndex = 64;
            this.btnDoldur.Text = "Doldur";
            this.btnDoldur.UseVisualStyleBackColor = true;
            this.btnDoldur.Click += new System.EventHandler(this.btnDoldur_Click);
            // 
            // txtOdemeTuru
            // 
            this.txtOdemeTuru.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOdemeTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOdemeTuru.Location = new System.Drawing.Point(223, 82);
            this.txtOdemeTuru.Name = "txtOdemeTuru";
            this.txtOdemeTuru.Size = new System.Drawing.Size(200, 22);
            this.txtOdemeTuru.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(129, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 65;
            this.label5.Text = "Ödeme Türü";
            // 
            // MaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 755);
            this.ControlBox = false;
            this.Controls.Add(this.txtOdemeTuru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDoldur);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnYeniKayıt);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dtCıkıs);
            this.Controls.Add(this.dtGiris);
            this.Controls.Add(this.lblBakımID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgBakım);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MaintenanceForm";
            this.Text = "Bakım Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MaintenanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBakım)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgBakım;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBakımID;
        private System.Windows.Forms.DateTimePicker dtGiris;
        private System.Windows.Forms.DateTimePicker dtCıkıs;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnYeniKayıt;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnDoldur;
        private System.Windows.Forms.TextBox txtOdemeTuru;
        private System.Windows.Forms.Label label5;
    }
}
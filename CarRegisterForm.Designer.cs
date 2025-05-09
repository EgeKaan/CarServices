namespace CarServices
{
    partial class CarRegisterForm
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
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRuhsatNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgAraclar = new System.Windows.Forms.DataGridView();
            this.txtModelYılı = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaseNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMotorNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYakıt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMusteriAdSoyad = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTC = new System.Windows.Forms.RadioButton();
            this.rbTel = new System.Windows.Forms.RadioButton();
            this.rbAdSoyad = new System.Windows.Forms.RadioButton();
            this.btnMusteriSorgu = new System.Windows.Forms.Button();
            this.txtMusteriArama = new System.Windows.Forms.TextBox();
            this.dgMusteri = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAraclar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(482, 602);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(85, 35);
            this.btnTemizle.TabIndex = 27;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(615, 666);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(85, 35);
            this.btnIptal.TabIndex = 26;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(733, 602);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 35);
            this.btnKaydet.TabIndex = 25;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(615, 602);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 35);
            this.btnGuncelle.TabIndex = 24;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtModel
            // 
            this.txtModel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModel.Location = new System.Drawing.Point(601, 130);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(208, 22);
            this.txtModel.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(541, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Model";
            // 
            // txtMarka
            // 
            this.txtMarka.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarka.Location = new System.Drawing.Point(253, 130);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(208, 22);
            this.txtMarka.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(180, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Marka";
            // 
            // txtRuhsatNo
            // 
            this.txtRuhsatNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRuhsatNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRuhsatNo.Location = new System.Drawing.Point(601, 75);
            this.txtRuhsatNo.Name = "txtRuhsatNo";
            this.txtRuhsatNo.Size = new System.Drawing.Size(208, 22);
            this.txtRuhsatNo.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(516, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ruhsat No";
            // 
            // txtPlaka
            // 
            this.txtPlaka.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlaka.Location = new System.Drawing.Point(253, 75);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(208, 22);
            this.txtPlaka.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(180, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Plaka";
            // 
            // dgAraclar
            // 
            this.dgAraclar.AllowUserToAddRows = false;
            this.dgAraclar.AllowUserToDeleteRows = false;
            this.dgAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAraclar.Location = new System.Drawing.Point(187, 253);
            this.dgAraclar.Name = "dgAraclar";
            this.dgAraclar.ReadOnly = true;
            this.dgAraclar.Size = new System.Drawing.Size(943, 320);
            this.dgAraclar.TabIndex = 28;
            this.dgAraclar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAraclar_CellContentDoubleClick);
            // 
            // txtModelYılı
            // 
            this.txtModelYılı.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelYılı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtModelYılı.Location = new System.Drawing.Point(949, 130);
            this.txtModelYılı.Name = "txtModelYılı";
            this.txtModelYılı.Size = new System.Drawing.Size(208, 22);
            this.txtModelYılı.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(873, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Model Yılı";
            // 
            // txtSaseNo
            // 
            this.txtSaseNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSaseNo.Location = new System.Drawing.Point(949, 75);
            this.txtSaseNo.Name = "txtSaseNo";
            this.txtSaseNo.Size = new System.Drawing.Size(208, 22);
            this.txtSaseNo.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(879, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Şase No";
            // 
            // txtMotorNo
            // 
            this.txtMotorNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMotorNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMotorNo.Location = new System.Drawing.Point(949, 187);
            this.txtMotorNo.Name = "txtMotorNo";
            this.txtMotorNo.Size = new System.Drawing.Size(208, 22);
            this.txtMotorNo.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(877, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Motor No";
            // 
            // txtYakıt
            // 
            this.txtYakıt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYakıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYakıt.Location = new System.Drawing.Point(601, 185);
            this.txtYakıt.Name = "txtYakıt";
            this.txtYakıt.Size = new System.Drawing.Size(208, 22);
            this.txtYakıt.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(549, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Yakıt";
            // 
            // txtKm
            // 
            this.txtKm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKm.Location = new System.Drawing.Point(253, 185);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(208, 22);
            this.txtKm.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(196, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "Km";
            // 
            // lblMusteriAdSoyad
            // 
            this.lblMusteriAdSoyad.AutoSize = true;
            this.lblMusteriAdSoyad.Enabled = false;
            this.lblMusteriAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAdSoyad.ForeColor = System.Drawing.Color.Red;
            this.lblMusteriAdSoyad.Location = new System.Drawing.Point(190, 23);
            this.lblMusteriAdSoyad.Name = "lblMusteriAdSoyad";
            this.lblMusteriAdSoyad.Size = new System.Drawing.Size(0, 16);
            this.lblMusteriAdSoyad.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTC);
            this.groupBox1.Controls.Add(this.rbTel);
            this.groupBox1.Controls.Add(this.rbAdSoyad);
            this.groupBox1.Controls.Add(this.btnMusteriSorgu);
            this.groupBox1.Controls.Add(this.txtMusteriArama);
            this.groupBox1.Location = new System.Drawing.Point(1228, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 205);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Arama";
            // 
            // rbTC
            // 
            this.rbTC.AutoSize = true;
            this.rbTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTC.Location = new System.Drawing.Point(298, 100);
            this.rbTC.Name = "rbTC";
            this.rbTC.Size = new System.Drawing.Size(64, 20);
            this.rbTC.TabIndex = 7;
            this.rbTC.TabStop = true;
            this.rbTC.Text = "TC No";
            this.rbTC.UseVisualStyleBackColor = true;
            // 
            // rbTel
            // 
            this.rbTel.AutoSize = true;
            this.rbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTel.Location = new System.Drawing.Point(202, 100);
            this.rbTel.Name = "rbTel";
            this.rbTel.Size = new System.Drawing.Size(71, 20);
            this.rbTel.TabIndex = 6;
            this.rbTel.TabStop = true;
            this.rbTel.Text = "Telefon";
            this.rbTel.UseVisualStyleBackColor = true;
            // 
            // rbAdSoyad
            // 
            this.rbAdSoyad.AutoSize = true;
            this.rbAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAdSoyad.Location = new System.Drawing.Point(95, 98);
            this.rbAdSoyad.Name = "rbAdSoyad";
            this.rbAdSoyad.Size = new System.Drawing.Size(85, 20);
            this.rbAdSoyad.TabIndex = 5;
            this.rbAdSoyad.TabStop = true;
            this.rbAdSoyad.Text = "Ad Soyad";
            this.rbAdSoyad.UseVisualStyleBackColor = true;
            // 
            // btnMusteriSorgu
            // 
            this.btnMusteriSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriSorgu.Location = new System.Drawing.Point(171, 144);
            this.btnMusteriSorgu.Name = "btnMusteriSorgu";
            this.btnMusteriSorgu.Size = new System.Drawing.Size(100, 40);
            this.btnMusteriSorgu.TabIndex = 4;
            this.btnMusteriSorgu.Text = "Sorgu";
            this.btnMusteriSorgu.UseVisualStyleBackColor = true;
            this.btnMusteriSorgu.Click += new System.EventHandler(this.btnMusteriSorgu_Click);
            // 
            // txtMusteriArama
            // 
            this.txtMusteriArama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMusteriArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMusteriArama.Location = new System.Drawing.Point(125, 44);
            this.txtMusteriArama.Name = "txtMusteriArama";
            this.txtMusteriArama.Size = new System.Drawing.Size(208, 22);
            this.txtMusteriArama.TabIndex = 2;
            // 
            // dgMusteri
            // 
            this.dgMusteri.AllowUserToAddRows = false;
            this.dgMusteri.AllowUserToDeleteRows = false;
            this.dgMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMusteri.Location = new System.Drawing.Point(1228, 253);
            this.dgMusteri.Name = "dgMusteri";
            this.dgMusteri.ReadOnly = true;
            this.dgMusteri.Size = new System.Drawing.Size(443, 320);
            this.dgMusteri.TabIndex = 40;
            this.dgMusteri.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMusteri_CellContentDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(218, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(581, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "*";
            // 
            // CarRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 761);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgMusteri);
            this.Controls.Add(this.lblMusteriAdSoyad);
            this.Controls.Add(this.txtMotorNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtYakıt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtModelYılı);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSaseNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgAraclar);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRuhsatNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CarRegisterForm";
            this.Text = "Araç Kayıt Formu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CarRegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAraclar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMusteri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRuhsatNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgAraclar;
        private System.Windows.Forms.TextBox txtModelYılı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaseNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMotorNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYakıt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMusteriAdSoyad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTC;
        private System.Windows.Forms.RadioButton rbTel;
        private System.Windows.Forms.RadioButton rbAdSoyad;
        private System.Windows.Forms.Button btnMusteriSorgu;
        private System.Windows.Forms.TextBox txtMusteriArama;
        private System.Windows.Forms.DataGridView dgMusteri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
namespace CarServices
{
    partial class MainForm
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
            this.dgAraclar = new System.Windows.Forms.DataGridView();
            this.dgMusteri = new System.Windows.Forms.DataGridView();
            this.txtAracSorgu = new System.Windows.Forms.TextBox();
            this.btnAracSorgu = new System.Windows.Forms.Button();
            this.gbAracSorgu = new System.Windows.Forms.GroupBox();
            this.rbMotor = new System.Windows.Forms.RadioButton();
            this.rbSase = new System.Windows.Forms.RadioButton();
            this.rbRuhsat = new System.Windows.Forms.RadioButton();
            this.rbPlaka = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTC = new System.Windows.Forms.RadioButton();
            this.rbTel = new System.Windows.Forms.RadioButton();
            this.rbAdSoyad = new System.Windows.Forms.RadioButton();
            this.btnMusteriSorgu = new System.Windows.Forms.Button();
            this.txtMusteriArama = new System.Windows.Forms.TextBox();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAraclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMusteri)).BeginInit();
            this.gbAracSorgu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAraclar
            // 
            this.dgAraclar.AllowUserToAddRows = false;
            this.dgAraclar.AllowUserToDeleteRows = false;
            this.dgAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAraclar.Location = new System.Drawing.Point(168, 315);
            this.dgAraclar.Name = "dgAraclar";
            this.dgAraclar.ReadOnly = true;
            this.dgAraclar.Size = new System.Drawing.Size(943, 691);
            this.dgAraclar.TabIndex = 0;
            this.dgAraclar.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAraclar_CellContentDoubleClick);
            // 
            // dgMusteri
            // 
            this.dgMusteri.AllowUserToAddRows = false;
            this.dgMusteri.AllowUserToDeleteRows = false;
            this.dgMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMusteri.Location = new System.Drawing.Point(1164, 315);
            this.dgMusteri.Name = "dgMusteri";
            this.dgMusteri.ReadOnly = true;
            this.dgMusteri.Size = new System.Drawing.Size(591, 691);
            this.dgMusteri.TabIndex = 1;
            this.dgMusteri.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMusteri_CellContentDoubleClick);
            // 
            // txtAracSorgu
            // 
            this.txtAracSorgu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAracSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAracSorgu.Location = new System.Drawing.Point(145, 44);
            this.txtAracSorgu.Name = "txtAracSorgu";
            this.txtAracSorgu.Size = new System.Drawing.Size(208, 22);
            this.txtAracSorgu.TabIndex = 2;
            // 
            // btnAracSorgu
            // 
            this.btnAracSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAracSorgu.Location = new System.Drawing.Point(169, 164);
            this.btnAracSorgu.Name = "btnAracSorgu";
            this.btnAracSorgu.Size = new System.Drawing.Size(150, 50);
            this.btnAracSorgu.TabIndex = 4;
            this.btnAracSorgu.Text = "Sorgu";
            this.btnAracSorgu.UseVisualStyleBackColor = true;
            this.btnAracSorgu.Click += new System.EventHandler(this.btnAracSorgu_Click);
            // 
            // gbAracSorgu
            // 
            this.gbAracSorgu.Controls.Add(this.rbMotor);
            this.gbAracSorgu.Controls.Add(this.rbSase);
            this.gbAracSorgu.Controls.Add(this.rbRuhsat);
            this.gbAracSorgu.Controls.Add(this.rbPlaka);
            this.gbAracSorgu.Controls.Add(this.btnAracSorgu);
            this.gbAracSorgu.Controls.Add(this.txtAracSorgu);
            this.gbAracSorgu.Location = new System.Drawing.Point(383, 29);
            this.gbAracSorgu.Name = "gbAracSorgu";
            this.gbAracSorgu.Size = new System.Drawing.Size(513, 256);
            this.gbAracSorgu.TabIndex = 6;
            this.gbAracSorgu.TabStop = false;
            this.gbAracSorgu.Text = "Araç Arama";
            // 
            // rbMotor
            // 
            this.rbMotor.AutoSize = true;
            this.rbMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbMotor.Location = new System.Drawing.Point(375, 100);
            this.rbMotor.Name = "rbMotor";
            this.rbMotor.Size = new System.Drawing.Size(80, 20);
            this.rbMotor.TabIndex = 8;
            this.rbMotor.TabStop = true;
            this.rbMotor.Text = "Motor No";
            this.rbMotor.UseVisualStyleBackColor = true;
            // 
            // rbSase
            // 
            this.rbSase.AutoSize = true;
            this.rbSase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSase.Location = new System.Drawing.Point(265, 100);
            this.rbSase.Name = "rbSase";
            this.rbSase.Size = new System.Drawing.Size(78, 20);
            this.rbSase.TabIndex = 7;
            this.rbSase.TabStop = true;
            this.rbSase.Text = "Şase No";
            this.rbSase.UseVisualStyleBackColor = true;
            // 
            // rbRuhsat
            // 
            this.rbRuhsat.AutoSize = true;
            this.rbRuhsat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbRuhsat.Location = new System.Drawing.Point(152, 100);
            this.rbRuhsat.Name = "rbRuhsat";
            this.rbRuhsat.Size = new System.Drawing.Size(88, 20);
            this.rbRuhsat.TabIndex = 6;
            this.rbRuhsat.TabStop = true;
            this.rbRuhsat.Text = "Ruhsat No";
            this.rbRuhsat.UseVisualStyleBackColor = true;
            // 
            // rbPlaka
            // 
            this.rbPlaka.AutoSize = true;
            this.rbPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPlaka.Location = new System.Drawing.Point(62, 98);
            this.rbPlaka.Name = "rbPlaka";
            this.rbPlaka.Size = new System.Drawing.Size(60, 20);
            this.rbPlaka.TabIndex = 5;
            this.rbPlaka.TabStop = true;
            this.rbPlaka.Text = "Plaka";
            this.rbPlaka.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTC);
            this.groupBox1.Controls.Add(this.rbTel);
            this.groupBox1.Controls.Add(this.rbAdSoyad);
            this.groupBox1.Controls.Add(this.btnMusteriSorgu);
            this.groupBox1.Controls.Add(this.txtMusteriArama);
            this.groupBox1.Location = new System.Drawing.Point(1229, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 256);
            this.groupBox1.TabIndex = 7;
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
            this.btnMusteriSorgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriSorgu.Location = new System.Drawing.Point(152, 164);
            this.btnMusteriSorgu.Name = "btnMusteriSorgu";
            this.btnMusteriSorgu.Size = new System.Drawing.Size(150, 50);
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
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(12, 193);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(150, 50);
            this.btnListele.TabIndex = 9;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnAracSorgu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAracSorgu);
            this.Controls.Add(this.dgMusteri);
            this.Controls.Add(this.dgAraclar);
            this.Name = "MainForm";
            this.Text = "Cartest Computest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAraclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMusteri)).EndInit();
            this.gbAracSorgu.ResumeLayout(false);
            this.gbAracSorgu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAraclar;
        private System.Windows.Forms.DataGridView dgMusteri;
        private System.Windows.Forms.TextBox txtAracSorgu;
        private System.Windows.Forms.Button btnAracSorgu;
        private System.Windows.Forms.GroupBox gbAracSorgu;
        private System.Windows.Forms.RadioButton rbMotor;
        private System.Windows.Forms.RadioButton rbSase;
        private System.Windows.Forms.RadioButton rbRuhsat;
        private System.Windows.Forms.RadioButton rbPlaka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTC;
        private System.Windows.Forms.RadioButton rbTel;
        private System.Windows.Forms.RadioButton rbAdSoyad;
        private System.Windows.Forms.Button btnMusteriSorgu;
        private System.Windows.Forms.TextBox txtMusteriArama;
        private System.Windows.Forms.Button btnListele;
    }
}
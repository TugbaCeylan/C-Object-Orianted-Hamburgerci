namespace WFAHamburgerci
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMenuler = new System.Windows.Forms.ComboBox();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.grpExtralar = new System.Windows.Forms.GroupBox();
            this.chkHardal = new System.Windows.Forms.CheckBox();
            this.chkKetcap = new System.Windows.Forms.CheckBox();
            this.chkRanchSos = new System.Windows.Forms.CheckBox();
            this.chkBarbekuSos = new System.Windows.Forms.CheckBox();
            this.chkMayonez = new System.Windows.Forms.CheckBox();
            this.chkSogan = new System.Windows.Forms.CheckBox();
            this.chkTursu = new System.Windows.Forms.CheckBox();
            this.chkSarimsakliMeyonez = new System.Windows.Forms.CheckBox();
            this.chkBuffaloSos = new System.Windows.Forms.CheckBox();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btmSiparisTamamla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpExtralar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFAHamburgerci.Properties.Resources.hamburger;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBuyuk);
            this.groupBox1.Controls.Add(this.rbOrta);
            this.groupBox1.Controls.Add(this.rbKucuk);
            this.groupBox1.Location = new System.Drawing.Point(16, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boyut Seçin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menü Seçin";
            // 
            // cbMenuler
            // 
            this.cbMenuler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMenuler.FormattingEnabled = true;
            this.cbMenuler.Location = new System.Drawing.Point(12, 206);
            this.cbMenuler.Name = "cbMenuler";
            this.cbMenuler.Size = new System.Drawing.Size(337, 28);
            this.cbMenuler.TabIndex = 3;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Checked = true;
            this.rbKucuk.Location = new System.Drawing.Point(6, 33);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(76, 24);
            this.rbKucuk.TabIndex = 4;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // grpExtralar
            // 
            this.grpExtralar.Controls.Add(this.chkBuffaloSos);
            this.grpExtralar.Controls.Add(this.chkSogan);
            this.grpExtralar.Controls.Add(this.chkSarimsakliMeyonez);
            this.grpExtralar.Controls.Add(this.chkMayonez);
            this.grpExtralar.Controls.Add(this.chkRanchSos);
            this.grpExtralar.Controls.Add(this.chkTursu);
            this.grpExtralar.Controls.Add(this.chkBarbekuSos);
            this.grpExtralar.Controls.Add(this.chkKetcap);
            this.grpExtralar.Controls.Add(this.chkHardal);
            this.grpExtralar.Location = new System.Drawing.Point(16, 330);
            this.grpExtralar.Name = "grpExtralar";
            this.grpExtralar.Size = new System.Drawing.Size(333, 128);
            this.grpExtralar.TabIndex = 4;
            this.grpExtralar.TabStop = false;
            this.grpExtralar.Text = "Extralar";
            // 
            // chkHardal
            // 
            this.chkHardal.AutoSize = true;
            this.chkHardal.Location = new System.Drawing.Point(6, 36);
            this.chkHardal.Name = "chkHardal";
            this.chkHardal.Size = new System.Drawing.Size(81, 24);
            this.chkHardal.TabIndex = 5;
            this.chkHardal.Tag = "0,50";
            this.chkHardal.Text = "Hardal";
            this.chkHardal.UseVisualStyleBackColor = true;
            // 
            // chkKetcap
            // 
            this.chkKetcap.AutoSize = true;
            this.chkKetcap.Location = new System.Drawing.Point(98, 36);
            this.chkKetcap.Name = "chkKetcap";
            this.chkKetcap.Size = new System.Drawing.Size(84, 24);
            this.chkKetcap.TabIndex = 5;
            this.chkKetcap.Tag = "0,25";
            this.chkKetcap.Text = "Ketçap";
            this.chkKetcap.UseVisualStyleBackColor = true;
            // 
            // chkRanchSos
            // 
            this.chkRanchSos.AutoSize = true;
            this.chkRanchSos.Location = new System.Drawing.Point(225, 36);
            this.chkRanchSos.Name = "chkRanchSos";
            this.chkRanchSos.Size = new System.Drawing.Size(116, 24);
            this.chkRanchSos.TabIndex = 5;
            this.chkRanchSos.Tag = "0,75";
            this.chkRanchSos.Text = "Ranch Sos";
            this.chkRanchSos.UseVisualStyleBackColor = true;
            // 
            // chkBarbekuSos
            // 
            this.chkBarbekuSos.AutoSize = true;
            this.chkBarbekuSos.Location = new System.Drawing.Point(6, 66);
            this.chkBarbekuSos.Name = "chkBarbekuSos";
            this.chkBarbekuSos.Size = new System.Drawing.Size(65, 24);
            this.chkBarbekuSos.TabIndex = 5;
            this.chkBarbekuSos.Tag = "0,20";
            this.chkBarbekuSos.Text = "BBQ";
            this.chkBarbekuSos.UseVisualStyleBackColor = true;
            // 
            // chkMayonez
            // 
            this.chkMayonez.AutoSize = true;
            this.chkMayonez.Location = new System.Drawing.Point(98, 66);
            this.chkMayonez.Name = "chkMayonez";
            this.chkMayonez.Size = new System.Drawing.Size(99, 24);
            this.chkMayonez.TabIndex = 5;
            this.chkMayonez.Tag = "0,10";
            this.chkMayonez.Text = "Mayonez";
            this.chkMayonez.UseVisualStyleBackColor = true;
            // 
            // chkSogan
            // 
            this.chkSogan.AutoSize = true;
            this.chkSogan.Location = new System.Drawing.Point(225, 66);
            this.chkSogan.Name = "chkSogan";
            this.chkSogan.Size = new System.Drawing.Size(80, 24);
            this.chkSogan.TabIndex = 5;
            this.chkSogan.Tag = "1";
            this.chkSogan.Text = "Soğan";
            this.chkSogan.UseVisualStyleBackColor = true;
            // 
            // chkTursu
            // 
            this.chkTursu.AutoSize = true;
            this.chkTursu.Location = new System.Drawing.Point(6, 96);
            this.chkTursu.Name = "chkTursu";
            this.chkTursu.Size = new System.Drawing.Size(73, 24);
            this.chkTursu.TabIndex = 5;
            this.chkTursu.Tag = "0,50";
            this.chkTursu.Text = "Turşu";
            this.chkTursu.UseVisualStyleBackColor = true;
            // 
            // chkSarimsakliMeyonez
            // 
            this.chkSarimsakliMeyonez.AutoSize = true;
            this.chkSarimsakliMeyonez.Location = new System.Drawing.Point(98, 96);
            this.chkSarimsakliMeyonez.Name = "chkSarimsakliMeyonez";
            this.chkSarimsakliMeyonez.Size = new System.Drawing.Size(121, 24);
            this.chkSarimsakliMeyonez.TabIndex = 5;
            this.chkSarimsakliMeyonez.Tag = "0,60";
            this.chkSarimsakliMeyonez.Text = "S. Mayonez";
            this.chkSarimsakliMeyonez.UseVisualStyleBackColor = true;
            // 
            // chkBuffaloSos
            // 
            this.chkBuffaloSos.AutoSize = true;
            this.chkBuffaloSos.Location = new System.Drawing.Point(225, 96);
            this.chkBuffaloSos.Name = "chkBuffaloSos";
            this.chkBuffaloSos.Size = new System.Drawing.Size(86, 24);
            this.chkBuffaloSos.TabIndex = 5;
            this.chkBuffaloSos.Tag = "0,40";
            this.chkBuffaloSos.Text = "Buffalo";
            this.chkBuffaloSos.UseVisualStyleBackColor = true;
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(12, 501);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(337, 37);
            this.btnSiparisEkle.TabIndex = 5;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 20;
            this.lstSiparisler.Location = new System.Drawing.Point(365, 12);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(494, 464);
            this.lstSiparisler.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Toplam Tutar :";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(504, 501);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(44, 20);
            this.lblToplamTutar.TabIndex = 7;
            this.lblToplamTutar.Text = "0 TL";
            // 
            // btmSiparisTamamla
            // 
            this.btmSiparisTamamla.Location = new System.Drawing.Point(619, 500);
            this.btmSiparisTamamla.Name = "btmSiparisTamamla";
            this.btmSiparisTamamla.Size = new System.Drawing.Size(242, 36);
            this.btmSiparisTamamla.TabIndex = 8;
            this.btmSiparisTamamla.Text = "Siparişi Tamamla";
            this.btmSiparisTamamla.UseVisualStyleBackColor = true;
            this.btmSiparisTamamla.Click += new System.EventHandler(this.btmSiparisTamamla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adet :";
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(71, 467);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(278, 26);
            this.nmrAdet.TabIndex = 9;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(98, 33);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(62, 24);
            this.rbOrta.TabIndex = 5;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(174, 33);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(76, 24);
            this.rbBuyuk.TabIndex = 6;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 550);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.btmSiparisTamamla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.grpExtralar);
            this.Controls.Add(this.cbMenuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpExtralar.ResumeLayout(false);
            this.grpExtralar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMenuler;
        private System.Windows.Forms.GroupBox grpExtralar;
        private System.Windows.Forms.CheckBox chkBuffaloSos;
        private System.Windows.Forms.CheckBox chkSogan;
        private System.Windows.Forms.CheckBox chkSarimsakliMeyonez;
        private System.Windows.Forms.CheckBox chkMayonez;
        private System.Windows.Forms.CheckBox chkRanchSos;
        private System.Windows.Forms.CheckBox chkTursu;
        private System.Windows.Forms.CheckBox chkBarbekuSos;
        private System.Windows.Forms.CheckBox chkKetcap;
        private System.Windows.Forms.CheckBox chkHardal;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btmSiparisTamamla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbOrta;
    }
}


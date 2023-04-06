namespace Trple1._1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.radioNakit = new System.Windows.Forms.RadioButton();
            this.radiocredicart = new System.Windows.Forms.RadioButton();
            this.radiCari = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BARCOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URUNAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MİKTAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BFİYATİ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TUTAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(27, 51);
            this.maskedTextBox1.Mask = "0000000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Değiştir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 69);
            this.button3.TabIndex = 5;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(126, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 69);
            this.button4.TabIndex = 6;
            this.button4.Text = "Ürünü Sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioNakit
            // 
            this.radioNakit.AutoSize = true;
            this.radioNakit.Checked = true;
            this.radioNakit.Location = new System.Drawing.Point(5, 17);
            this.radioNakit.Name = "radioNakit";
            this.radioNakit.Size = new System.Drawing.Size(50, 17);
            this.radioNakit.TabIndex = 7;
            this.radioNakit.TabStop = true;
            this.radioNakit.Text = "Nakit";
            this.radioNakit.UseVisualStyleBackColor = true;
            // 
            // radiocredicart
            // 
            this.radiocredicart.AutoSize = true;
            this.radiocredicart.Location = new System.Drawing.Point(61, 17);
            this.radiocredicart.Name = "radiocredicart";
            this.radiocredicart.Size = new System.Drawing.Size(73, 17);
            this.radiocredicart.TabIndex = 8;
            this.radiocredicart.Text = "Kredi Kartı";
            this.radiocredicart.UseVisualStyleBackColor = true;
            // 
            // radiCari
            // 
            this.radiCari.AutoSize = true;
            this.radiCari.Location = new System.Drawing.Point(140, 17);
            this.radiCari.Name = "radiCari";
            this.radiCari.Size = new System.Drawing.Size(43, 17);
            this.radiCari.TabIndex = 9;
            this.radiCari.Text = "Cari";
            this.radiCari.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiCari);
            this.groupBox1.Controls.Add(this.radioNakit);
            this.groupBox1.Controls.Add(this.radiocredicart);
            this.groupBox1.Location = new System.Drawing.Point(19, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 34);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Şekli";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(11, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 47);
            this.button5.TabIndex = 11;
            this.button5.Text = "Satışı Yap";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 317);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 82);
            this.button6.TabIndex = 12;
            this.button6.Text = "İptal";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(120, 317);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 82);
            this.button7.TabIndex = 13;
            this.button7.Text = "İade";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Alınan Para";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox2.Location = new System.Drawing.Point(27, 84);
            this.maskedTextBox2.Mask = "00000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 26);
            this.maskedTextBox2.TabIndex = 15;
            this.maskedTextBox2.Text = "1";
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox3.Location = new System.Drawing.Point(101, 416);
            this.maskedTextBox3.Mask = "00000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(47, 26);
            this.maskedTextBox3.TabIndex = 16;
            this.maskedTextBox3.ValidatingType = typeof(int);
            this.maskedTextBox3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(68, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "₺ para üstü verilecek";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(159, 416);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 28);
            this.button8.TabIndex = 20;
            this.button8.Text = "tutar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(33, 464);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 16);
            this.label18.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BARCOD,
            this.URUNAD,
            this.MİKTAR,
            this.BFİYATİ,
            this.KDV,
            this.STOK,
            this.TUTAR});
            this.dataGridView1.Location = new System.Drawing.Point(294, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(802, 448);
            this.dataGridView1.TabIndex = 22;
            // 
            // BARCOD
            // 
            this.BARCOD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BARCOD.HeaderText = "";
            this.BARCOD.Name = "BARCOD";
            this.BARCOD.ReadOnly = true;
            // 
            // URUNAD
            // 
            this.URUNAD.HeaderText = "";
            this.URUNAD.Name = "URUNAD";
            this.URUNAD.ReadOnly = true;
            this.URUNAD.Width = 200;
            // 
            // MİKTAR
            // 
            this.MİKTAR.HeaderText = "";
            this.MİKTAR.Name = "MİKTAR";
            this.MİKTAR.ReadOnly = true;
            // 
            // BFİYATİ
            // 
            this.BFİYATİ.HeaderText = "";
            this.BFİYATİ.Name = "BFİYATİ";
            this.BFİYATİ.ReadOnly = true;
            // 
            // KDV
            // 
            this.KDV.HeaderText = "";
            this.KDV.Name = "KDV";
            this.KDV.ReadOnly = true;
            // 
            // STOK
            // 
            this.STOK.HeaderText = "";
            this.STOK.Name = "STOK";
            this.STOK.ReadOnly = true;
            // 
            // TUTAR
            // 
            this.TUTAR.HeaderText = "";
            this.TUTAR.Name = "TUTAR";
            this.TUTAR.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(280, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(789, 43);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "1.Satış Ekranı Ekle";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(672, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "TUTAR   |";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(571, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 25);
            this.label12.TabIndex = 5;
            this.label12.Text = "STOK     |";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "# |";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(35, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(255, 25);
            this.label16.TabIndex = 1;
            this.label16.Text = "ÜRÜN ADI                       |";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(286, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "MİKTAR |";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(489, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "KDV     |";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(383, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 25);
            this.label14.TabIndex = 3;
            this.label14.Text = "B.FİYATI |";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(181, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Kamera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(409, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(591, 366);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 659);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioNakit;
        private System.Windows.Forms.RadioButton radiocredicart;
        private System.Windows.Forms.RadioButton radiCari;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARCOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn URUNAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MİKTAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn BFİYATİ;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TUTAR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
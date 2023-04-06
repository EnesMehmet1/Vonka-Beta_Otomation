namespace Trple1._1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AnasayfaLabel = new System.Windows.Forms.Label();
            this.satis_btn = new System.Windows.Forms.Button();
            this.Stok_Btn = new System.Windows.Forms.Button();
            this.Rapor_btn = new System.Windows.Forms.Button();
            this.Cari_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altKategoriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altKategoriDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altKategoriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altKategoriSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıcıAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hızlıSatışıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışEkranıAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yedekAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interneteYedekAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgisayaraYedekAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.destekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamWiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anyDeskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alpemixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnasayfaLabel
            // 
            this.AnasayfaLabel.AutoSize = true;
            this.AnasayfaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnasayfaLabel.Location = new System.Drawing.Point(38, 71);
            this.AnasayfaLabel.Name = "AnasayfaLabel";
            this.AnasayfaLabel.Size = new System.Drawing.Size(175, 42);
            this.AnasayfaLabel.TabIndex = 0;
            this.AnasayfaLabel.Text = "Anasayfa";
            // 
            // satis_btn
            // 
            this.satis_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.satis_btn.Image = ((System.Drawing.Image)(resources.GetObject("satis_btn.Image")));
            this.satis_btn.Location = new System.Drawing.Point(34, 138);
            this.satis_btn.Name = "satis_btn";
            this.satis_btn.Size = new System.Drawing.Size(193, 188);
            this.satis_btn.TabIndex = 2;
            this.satis_btn.Text = "Satış Ekranı";
            this.satis_btn.UseVisualStyleBackColor = false;
            this.satis_btn.Click += new System.EventHandler(this.satis_btn_Click);
            // 
            // Stok_Btn
            // 
            this.Stok_Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Stok_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Stok_Btn.Image")));
            this.Stok_Btn.Location = new System.Drawing.Point(233, 138);
            this.Stok_Btn.Name = "Stok_Btn";
            this.Stok_Btn.Size = new System.Drawing.Size(193, 188);
            this.Stok_Btn.TabIndex = 3;
            this.Stok_Btn.Text = "Stok Ekranı";
            this.Stok_Btn.UseVisualStyleBackColor = false;
            this.Stok_Btn.Click += new System.EventHandler(this.Stok_Btn_Click);
            // 
            // Rapor_btn
            // 
            this.Rapor_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Rapor_btn.Image = ((System.Drawing.Image)(resources.GetObject("Rapor_btn.Image")));
            this.Rapor_btn.Location = new System.Drawing.Point(432, 138);
            this.Rapor_btn.Name = "Rapor_btn";
            this.Rapor_btn.Size = new System.Drawing.Size(193, 188);
            this.Rapor_btn.TabIndex = 4;
            this.Rapor_btn.Text = "Raporlar";
            this.Rapor_btn.UseVisualStyleBackColor = false;
            this.Rapor_btn.Click += new System.EventHandler(this.Rapor_btn_Click);
            // 
            // Cari_btn
            // 
            this.Cari_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cari_btn.Image = ((System.Drawing.Image)(resources.GetObject("Cari_btn.Image")));
            this.Cari_btn.Location = new System.Drawing.Point(631, 138);
            this.Cari_btn.Name = "Cari_btn";
            this.Cari_btn.Size = new System.Drawing.Size(193, 188);
            this.Cari_btn.TabIndex = 5;
            this.Cari_btn.Text = "Cari";
            this.Cari_btn.UseVisualStyleBackColor = false;
            this.Cari_btn.Click += new System.EventHandler(this.Cari_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1046, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2186, 1392);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.işlemlerToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.yedekAlToolStripMenuItem,
            this.destekToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1737, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışEkranıToolStripMenuItem,
            this.stokEkranıToolStripMenuItem,
            this.raporlarToolStripMenuItem,
            this.cariToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // satışEkranıToolStripMenuItem
            // 
            this.satışEkranıToolStripMenuItem.Name = "satışEkranıToolStripMenuItem";
            this.satışEkranıToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.satışEkranıToolStripMenuItem.Text = "Satış Ekranı";
            this.satışEkranıToolStripMenuItem.Click += new System.EventHandler(this.satışEkranıToolStripMenuItem_Click);
            // 
            // stokEkranıToolStripMenuItem
            // 
            this.stokEkranıToolStripMenuItem.Name = "stokEkranıToolStripMenuItem";
            this.stokEkranıToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.stokEkranıToolStripMenuItem.Text = "Stok Ekranı";
            this.stokEkranıToolStripMenuItem.Click += new System.EventHandler(this.stokEkranıToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            this.raporlarToolStripMenuItem.Click += new System.EventHandler(this.raporlarToolStripMenuItem_Click);
            // 
            // cariToolStripMenuItem
            // 
            this.cariToolStripMenuItem.Name = "cariToolStripMenuItem";
            this.cariToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.cariToolStripMenuItem.Text = "Cari";
            this.cariToolStripMenuItem.Click += new System.EventHandler(this.cariToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.kategoriİşlemleriToolStripMenuItem,
            this.altKategoriİşlemleriToolStripMenuItem,
            this.markaİşlemleriToolStripMenuItem,
            this.birimİşlemleriToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıDüzenlemeToolStripMenuItem,
            this.kullanıcıEklemeToolStripMenuItem,
            this.kullanıcıSilmeToolStripMenuItem});
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // kullanıcıDüzenlemeToolStripMenuItem
            // 
            this.kullanıcıDüzenlemeToolStripMenuItem.Name = "kullanıcıDüzenlemeToolStripMenuItem";
            this.kullanıcıDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.kullanıcıDüzenlemeToolStripMenuItem.Text = "Kullanıcı Düzenleme";
            this.kullanıcıDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıDüzenlemeToolStripMenuItem_Click);
            // 
            // kullanıcıEklemeToolStripMenuItem
            // 
            this.kullanıcıEklemeToolStripMenuItem.Name = "kullanıcıEklemeToolStripMenuItem";
            this.kullanıcıEklemeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.kullanıcıEklemeToolStripMenuItem.Text = "Kullanıcı Ekleme";
            this.kullanıcıEklemeToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEklemeToolStripMenuItem_Click);
            // 
            // kullanıcıSilmeToolStripMenuItem
            // 
            this.kullanıcıSilmeToolStripMenuItem.Name = "kullanıcıSilmeToolStripMenuItem";
            this.kullanıcıSilmeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.kullanıcıSilmeToolStripMenuItem.Text = "Kullanıcı Silme";
            this.kullanıcıSilmeToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıSilmeToolStripMenuItem_Click);
            // 
            // kategoriİşlemleriToolStripMenuItem
            // 
            this.kategoriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriDüzenlemeToolStripMenuItem,
            this.kategoriEklemeToolStripMenuItem,
            this.kategoriSilmeToolStripMenuItem});
            this.kategoriİşlemleriToolStripMenuItem.Name = "kategoriİşlemleriToolStripMenuItem";
            this.kategoriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.kategoriİşlemleriToolStripMenuItem.Text = "Kategori İşlemleri";
            // 
            // kategoriDüzenlemeToolStripMenuItem
            // 
            this.kategoriDüzenlemeToolStripMenuItem.Name = "kategoriDüzenlemeToolStripMenuItem";
            this.kategoriDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kategoriDüzenlemeToolStripMenuItem.Text = "Kategori Düzenleme";
            this.kategoriDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.kategoriDüzenlemeToolStripMenuItem_Click);
            // 
            // kategoriEklemeToolStripMenuItem
            // 
            this.kategoriEklemeToolStripMenuItem.Name = "kategoriEklemeToolStripMenuItem";
            this.kategoriEklemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kategoriEklemeToolStripMenuItem.Text = "Kategori Ekleme";
            this.kategoriEklemeToolStripMenuItem.Click += new System.EventHandler(this.kategoriEklemeToolStripMenuItem_Click);
            // 
            // kategoriSilmeToolStripMenuItem
            // 
            this.kategoriSilmeToolStripMenuItem.Name = "kategoriSilmeToolStripMenuItem";
            this.kategoriSilmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kategoriSilmeToolStripMenuItem.Text = "Kategori Silme";
            this.kategoriSilmeToolStripMenuItem.Click += new System.EventHandler(this.kategoriSilmeToolStripMenuItem_Click);
            // 
            // altKategoriİşlemleriToolStripMenuItem
            // 
            this.altKategoriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altKategoriDüzenlemeToolStripMenuItem,
            this.altKategoriEklemeToolStripMenuItem,
            this.altKategoriSilmeToolStripMenuItem});
            this.altKategoriİşlemleriToolStripMenuItem.Name = "altKategoriİşlemleriToolStripMenuItem";
            this.altKategoriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.altKategoriİşlemleriToolStripMenuItem.Text = "Alt Kategori İşlemleri";
            // 
            // altKategoriDüzenlemeToolStripMenuItem
            // 
            this.altKategoriDüzenlemeToolStripMenuItem.Name = "altKategoriDüzenlemeToolStripMenuItem";
            this.altKategoriDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.altKategoriDüzenlemeToolStripMenuItem.Text = "Alt Kategori Düzenleme";
            this.altKategoriDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.altKategoriDüzenlemeToolStripMenuItem_Click);
            // 
            // altKategoriEklemeToolStripMenuItem
            // 
            this.altKategoriEklemeToolStripMenuItem.Name = "altKategoriEklemeToolStripMenuItem";
            this.altKategoriEklemeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.altKategoriEklemeToolStripMenuItem.Text = "Alt Kategori Ekleme";
            this.altKategoriEklemeToolStripMenuItem.Click += new System.EventHandler(this.altKategoriEklemeToolStripMenuItem_Click);
            // 
            // altKategoriSilmeToolStripMenuItem
            // 
            this.altKategoriSilmeToolStripMenuItem.Name = "altKategoriSilmeToolStripMenuItem";
            this.altKategoriSilmeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.altKategoriSilmeToolStripMenuItem.Text = "Alt Kategori Silme";
            this.altKategoriSilmeToolStripMenuItem.Click += new System.EventHandler(this.altKategoriSilmeToolStripMenuItem_Click);
            // 
            // markaİşlemleriToolStripMenuItem
            // 
            this.markaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markaDüzenlemeToolStripMenuItem,
            this.markaEklemeToolStripMenuItem,
            this.markaSilmeToolStripMenuItem});
            this.markaİşlemleriToolStripMenuItem.Name = "markaİşlemleriToolStripMenuItem";
            this.markaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.markaİşlemleriToolStripMenuItem.Text = "Marka İşlemleri";
            // 
            // markaDüzenlemeToolStripMenuItem
            // 
            this.markaDüzenlemeToolStripMenuItem.Name = "markaDüzenlemeToolStripMenuItem";
            this.markaDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.markaDüzenlemeToolStripMenuItem.Text = "Marka Düzenleme";
            this.markaDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.markaDüzenlemeToolStripMenuItem_Click);
            // 
            // markaEklemeToolStripMenuItem
            // 
            this.markaEklemeToolStripMenuItem.Name = "markaEklemeToolStripMenuItem";
            this.markaEklemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.markaEklemeToolStripMenuItem.Text = "Marka Ekleme";
            this.markaEklemeToolStripMenuItem.Click += new System.EventHandler(this.markaEklemeToolStripMenuItem_Click);
            // 
            // markaSilmeToolStripMenuItem
            // 
            this.markaSilmeToolStripMenuItem.Name = "markaSilmeToolStripMenuItem";
            this.markaSilmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.markaSilmeToolStripMenuItem.Text = "Marka Silme";
            this.markaSilmeToolStripMenuItem.Click += new System.EventHandler(this.markaSilmeToolStripMenuItem_Click);
            // 
            // birimİşlemleriToolStripMenuItem
            // 
            this.birimİşlemleriToolStripMenuItem.Name = "birimİşlemleriToolStripMenuItem";
            this.birimİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.birimİşlemleriToolStripMenuItem.Text = "Birim İşlemleri";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazıcıAyarlarıToolStripMenuItem,
            this.hızlıSatışıKapatToolStripMenuItem,
            this.satışEkranıAçToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // yazıcıAyarlarıToolStripMenuItem
            // 
            this.yazıcıAyarlarıToolStripMenuItem.Name = "yazıcıAyarlarıToolStripMenuItem";
            this.yazıcıAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yazıcıAyarlarıToolStripMenuItem.Text = "Yazıcı Ayarları";
            // 
            // hızlıSatışıKapatToolStripMenuItem
            // 
            this.hızlıSatışıKapatToolStripMenuItem.Name = "hızlıSatışıKapatToolStripMenuItem";
            this.hızlıSatışıKapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hızlıSatışıKapatToolStripMenuItem.Text = "Hızlı Satışı Kapat";
            // 
            // satışEkranıAçToolStripMenuItem
            // 
            this.satışEkranıAçToolStripMenuItem.Name = "satışEkranıAçToolStripMenuItem";
            this.satışEkranıAçToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.satışEkranıAçToolStripMenuItem.Text = "2.Satış Ekranı Aç";
            // 
            // yedekAlToolStripMenuItem
            // 
            this.yedekAlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interneteYedekAlToolStripMenuItem,
            this.bilgisayaraYedekAlToolStripMenuItem});
            this.yedekAlToolStripMenuItem.Name = "yedekAlToolStripMenuItem";
            this.yedekAlToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.yedekAlToolStripMenuItem.Text = "Yedek al";
            // 
            // interneteYedekAlToolStripMenuItem
            // 
            this.interneteYedekAlToolStripMenuItem.Name = "interneteYedekAlToolStripMenuItem";
            this.interneteYedekAlToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.interneteYedekAlToolStripMenuItem.Text = "İnternete Yedek Al";
            this.interneteYedekAlToolStripMenuItem.Click += new System.EventHandler(this.interneteYedekAlToolStripMenuItem_Click);
            // 
            // bilgisayaraYedekAlToolStripMenuItem
            // 
            this.bilgisayaraYedekAlToolStripMenuItem.Name = "bilgisayaraYedekAlToolStripMenuItem";
            this.bilgisayaraYedekAlToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.bilgisayaraYedekAlToolStripMenuItem.Text = "Bilgisayara Yedek Al";
            this.bilgisayaraYedekAlToolStripMenuItem.Click += new System.EventHandler(this.bilgisayaraYedekAlToolStripMenuItem_Click);
            // 
            // destekToolStripMenuItem
            // 
            this.destekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamWiverToolStripMenuItem,
            this.anyDeskToolStripMenuItem,
            this.alpemixToolStripMenuItem});
            this.destekToolStripMenuItem.Name = "destekToolStripMenuItem";
            this.destekToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.destekToolStripMenuItem.Text = "Destek";
            // 
            // teamWiverToolStripMenuItem
            // 
            this.teamWiverToolStripMenuItem.Name = "teamWiverToolStripMenuItem";
            this.teamWiverToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.teamWiverToolStripMenuItem.Text = "TeamViwer";
            // 
            // anyDeskToolStripMenuItem
            // 
            this.anyDeskToolStripMenuItem.Name = "anyDeskToolStripMenuItem";
            this.anyDeskToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.anyDeskToolStripMenuItem.Text = "AnyDesk";
            // 
            // alpemixToolStripMenuItem
            // 
            this.alpemixToolStripMenuItem.Name = "alpemixToolStripMenuItem";
            this.alpemixToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.alpemixToolStripMenuItem.Text = "Alpemix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1737, 1061);
            this.Controls.Add(this.Cari_btn);
            this.Controls.Add(this.Rapor_btn);
            this.Controls.Add(this.Stok_Btn);
            this.Controls.Add(this.satis_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AnasayfaLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triple_Act Destek Hattı :5385908052";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AnasayfaLabel;
        private System.Windows.Forms.Button satis_btn;
        private System.Windows.Forms.Button Stok_Btn;
        private System.Windows.Forms.Button Rapor_btn;
        private System.Windows.Forms.Button Cari_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yedekAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem destekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altKategoriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altKategoriDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altKategoriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altKategoriSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıcıAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hızlıSatışıKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışEkranıAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interneteYedekAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgisayaraYedekAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamWiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anyDeskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alpemixToolStripMenuItem;
    }
}


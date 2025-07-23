
namespace bahar_odev1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.kesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.özelleştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seçeneklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kolayErişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yazıÇeşidiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metinRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeminRengiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.içindekilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem1,
            this.açToolStripMenuItem,
            this.toolStripSeparator,
            this.kaydetToolStripMenuItem,
            this.toolStripSeparator2,
            this.çıkışToolStripMenuItem2});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // yeniToolStripMenuItem1
            // 
            this.yeniToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("yeniToolStripMenuItem1.Image")));
            this.yeniToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yeniToolStripMenuItem1.Name = "yeniToolStripMenuItem1";
            this.yeniToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.yeniToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.yeniToolStripMenuItem1.Text = "Y&eni";
            this.yeniToolStripMenuItem1.Click += new System.EventHandler(this.yeniToolStripMenuItem1_Click);
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("açToolStripMenuItem.Image")));
            this.açToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.açToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açToolStripMenuItem.Text = "&Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kaydetToolStripMenuItem.Image")));
            this.kaydetToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kaydetToolStripMenuItem.Text = "&Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // çıkışToolStripMenuItem2
            // 
            this.çıkışToolStripMenuItem2.Name = "çıkışToolStripMenuItem2";
            this.çıkışToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.çıkışToolStripMenuItem2.Text = "Çı&kış";
            this.çıkışToolStripMenuItem2.Click += new System.EventHandler(this.çıkışToolStripMenuItem2_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geriAlToolStripMenuItem,
            this.toolStripSeparator3,
            this.kesToolStripMenuItem2,
            this.kopyalaToolStripMenuItem2,
            this.yapıştırToolStripMenuItem2});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.düzenToolStripMenuItem.Text = "D&üzen";
            // 
            // geriAlToolStripMenuItem
            // 
            this.geriAlToolStripMenuItem.Name = "geriAlToolStripMenuItem";
            this.geriAlToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.geriAlToolStripMenuItem.Text = "&Temizle";
            this.geriAlToolStripMenuItem.Click += new System.EventHandler(this.geriAlToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // kesToolStripMenuItem2
            // 
            this.kesToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("kesToolStripMenuItem2.Image")));
            this.kesToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kesToolStripMenuItem2.Name = "kesToolStripMenuItem2";
            this.kesToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.kesToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.kesToolStripMenuItem2.Text = "&Kes";
            // 
            // kopyalaToolStripMenuItem2
            // 
            this.kopyalaToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("kopyalaToolStripMenuItem2.Image")));
            this.kopyalaToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopyalaToolStripMenuItem2.Name = "kopyalaToolStripMenuItem2";
            this.kopyalaToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopyalaToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.kopyalaToolStripMenuItem2.Text = "K&opyala";
            // 
            // yapıştırToolStripMenuItem2
            // 
            this.yapıştırToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("yapıştırToolStripMenuItem2.Image")));
            this.yapıştırToolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yapıştırToolStripMenuItem2.Name = "yapıştırToolStripMenuItem2";
            this.yapıştırToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.yapıştırToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.yapıştırToolStripMenuItem2.Text = "&Yapıştır";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.özelleştirToolStripMenuItem,
            this.seçeneklerToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araçlarToolStripMenuItem.Text = "&Araçlar";
            // 
            // özelleştirToolStripMenuItem
            // 
            this.özelleştirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yazıÇeşidiToolStripMenuItem1,
            this.renkToolStripMenuItem1});
            this.özelleştirToolStripMenuItem.Name = "özelleştirToolStripMenuItem";
            this.özelleştirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.özelleştirToolStripMenuItem.Text = "&Özelleştir";
            // 
            // seçeneklerToolStripMenuItem
            // 
            this.seçeneklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem3,
            this.cToolStripMenuItem4,
            this.cToolStripMenuItem5});
            this.seçeneklerToolStripMenuItem.Name = "seçeneklerToolStripMenuItem";
            this.seçeneklerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seçeneklerToolStripMenuItem.Text = "&Şablon Ekle";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(575, 328);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem1,
            this.kopyalaToolStripMenuItem1,
            this.yapıştırToolStripMenuItem1,
            this.kolayErişimToolStripMenuItem,
            this.ayarlarToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 114);
            // 
            // kesToolStripMenuItem1
            // 
            this.kesToolStripMenuItem1.Name = "kesToolStripMenuItem1";
            this.kesToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.kesToolStripMenuItem1.Text = "Kes";
            // 
            // kopyalaToolStripMenuItem1
            // 
            this.kopyalaToolStripMenuItem1.Name = "kopyalaToolStripMenuItem1";
            this.kopyalaToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.kopyalaToolStripMenuItem1.Text = "Kopyala";
            // 
            // yapıştırToolStripMenuItem1
            // 
            this.yapıştırToolStripMenuItem1.Name = "yapıştırToolStripMenuItem1";
            this.yapıştırToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.yapıştırToolStripMenuItem1.Text = "Yapıştır";
            // 
            // kolayErişimToolStripMenuItem
            // 
            this.kolayErişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem,
            this.paintToolStripMenuItem});
            this.kolayErişimToolStripMenuItem.Name = "kolayErişimToolStripMenuItem";
            this.kolayErişimToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.kolayErişimToolStripMenuItem.Text = "Kolay Erişim";
            // 
            // hesapMakinesiToolStripMenuItem
            // 
            this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
            this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
            this.hesapMakinesiToolStripMenuItem.Click += new System.EventHandler(this.hesapMakinesiToolStripMenuItem_Click);
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.paintToolStripMenuItem.Text = "Paint";
            this.paintToolStripMenuItem.Click += new System.EventHandler(this.paintToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem1
            // 
            this.ayarlarToolStripMenuItem1.Name = "ayarlarToolStripMenuItem1";
            this.ayarlarToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.ayarlarToolStripMenuItem1.Text = "Ayarlar";
            // 
            // yazıÇeşidiToolStripMenuItem1
            // 
            this.yazıÇeşidiToolStripMenuItem1.Name = "yazıÇeşidiToolStripMenuItem1";
            this.yazıÇeşidiToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.yazıÇeşidiToolStripMenuItem1.Text = "Yazı Çeşidi";
            this.yazıÇeşidiToolStripMenuItem1.Click += new System.EventHandler(this.yazıÇeşidiToolStripMenuItem1_Click);
            // 
            // renkToolStripMenuItem1
            // 
            this.renkToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metinRengiToolStripMenuItem,
            this.zeminRengiToolStripMenuItem1});
            this.renkToolStripMenuItem1.Name = "renkToolStripMenuItem1";
            this.renkToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.renkToolStripMenuItem1.Text = "Renk";
            // 
            // metinRengiToolStripMenuItem
            // 
            this.metinRengiToolStripMenuItem.Name = "metinRengiToolStripMenuItem";
            this.metinRengiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.metinRengiToolStripMenuItem.Text = "Metin Rengi";
            this.metinRengiToolStripMenuItem.Click += new System.EventHandler(this.metinRengiToolStripMenuItem_Click);
            // 
            // zeminRengiToolStripMenuItem1
            // 
            this.zeminRengiToolStripMenuItem1.Name = "zeminRengiToolStripMenuItem1";
            this.zeminRengiToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.zeminRengiToolStripMenuItem1.Text = "Zemin Rengi";
            this.zeminRengiToolStripMenuItem1.Click += new System.EventHandler(this.zeminRengiToolStripMenuItem1_Click);
            // 
            // cToolStripMenuItem3
            // 
            this.cToolStripMenuItem3.Name = "cToolStripMenuItem3";
            this.cToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem3.Text = "c";
            this.cToolStripMenuItem3.Click += new System.EventHandler(this.cToolStripMenuItem3_Click);
            // 
            // cToolStripMenuItem4
            // 
            this.cToolStripMenuItem4.Name = "cToolStripMenuItem4";
            this.cToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem4.Text = "c++";
            this.cToolStripMenuItem4.Click += new System.EventHandler(this.cToolStripMenuItem4_Click);
            // 
            // cToolStripMenuItem5
            // 
            this.cToolStripMenuItem5.Name = "cToolStripMenuItem5";
            this.cToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.cToolStripMenuItem5.Text = "c#";
            this.cToolStripMenuItem5.Click += new System.EventHandler(this.cToolStripMenuItem5_Click);
            // 
            // içindekilerToolStripMenuItem
            // 
            this.içindekilerToolStripMenuItem.Name = "içindekilerToolStripMenuItem";
            this.içindekilerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.içindekilerToolStripMenuItem.Text = "&Hakkında...";
            this.içindekilerToolStripMenuItem.Click += new System.EventHandler(this.içindekilerToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hakkındaToolStripMenuItem.Text = "&Çıkış";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içindekilerToolStripMenuItem,
            this.toolStripSeparator5,
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "&Yardım";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 352);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Metin Düzenleyici";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kolayErişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem özelleştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seçeneklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazıÇeşidiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem metinRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zeminRengiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içindekilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
    }
}


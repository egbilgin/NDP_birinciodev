
/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: Esma Gülsüm BİLGİN
**				ÖĞRENCİ NUMARASI.......: B231210027
**              DERSİN ALINDIĞI GRUP...: B
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bahar_odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
        }

        private void Kaydet()
        {
           
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Metin Dosyası|.txt|Tüm Dosyalar|.*";
            saveFileDialog.InitialDirectory = "D://";
            saveFileDialog.OverwritePrompt = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
            }

           
            richTextBox1.Modified = false;
        }
        private bool SayfaKaydedilmeliMi()
        {
            
            if (!string.IsNullOrEmpty(richTextBox1.Text) && richTextBox1.Modified)
            {
                DialogResult result = MessageBox.Show("Üzerinde çalışılan sayfa kaydedilsin mi?", "Uyarı", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    Kaydet(); 
                }
                else if (result == DialogResult.Cancel)
                {
                    return false; 
                }
            }

            return true; 
        }

        string kaydetmeKonumu = "";
        private void dosyaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Dosya_Kaydetme = new
                SaveFileDialog();
            DialogResult result = Dosya_Kaydetme.ShowDialog();
            if (result == DialogResult.OK)
            {
                string dosya = Dosya_Kaydetme.FileName;
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SayfaKaydedilmeliMi())
            {
                richTextBox1.Clear();
            }
        }


        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Esma Gülsüm BİLGİN tarafından bahar dönemi uygulama ödevi amacıyla yapıldı.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (SayfaKaydedilmeliMi())
            {
                Application.Exit();
            }
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (SayfaKaydedilmeliMi())
                {
                    Application.Exit();
                }
           
            
        }

        private void yazıÇeşidiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void zeminRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog.Color;
            }
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string cppCode = @"#include <iostream>
                            int main() {
                            std::cout << ""Hello, World!"" << std::endl;
                            return 0;
                                }";

            richTextBox1.Text = cppCode;
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cCode = @"
#include <stdio.h>

int main() {
    printf(""Hello, World!\n"");
    return 0;
}";
            richTextBox1.Text = cCode;
        }

        private void cToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string csCode = @"using System;

namespace TemplateExample
    {
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine(Hello,World!);
            }
        }
    }";
            richTextBox1.Text = csCode;
        }

        private void metniTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void dosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"; 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                   
                    richTextBox1.Text = File.ReadAllText(filePath);
                    MessageBox.Show("Dosya başarıyla yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya yükleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void yeniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (SayfaKaydedilmeliMi())
            {
                richTextBox1.Clear();
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    
                    richTextBox1.Text = File.ReadAllText(filePath);
                    MessageBox.Show("Dosya başarıyla yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dosya yükleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Dosya_Kaydetme = new
               SaveFileDialog();
            DialogResult result = Dosya_Kaydetme.ShowDialog();
            if (result == DialogResult.OK)
            {
                string dosya = Dosya_Kaydetme.FileName;
            }
        }

        private void çıkışToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (SayfaKaydedilmeliMi())
            {
                Application.Exit();
            }

        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void metinRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void zeminRengiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog.Color;
            }
        }

        private void yazıÇeşidiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void cToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string cCode = @"
#include <stdio.h>

int main() {
    printf(""Hello, World!\n"");
    return 0;
}";
            richTextBox1.Text = cCode;
        }

        private void cToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string cppCode = @"#include <iostream>
                            int main() {
                            std::cout << ""Hello, World!"" << std::endl;
                            return 0;
                                }";

            richTextBox1.Text = cppCode;
        }

        private void cToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            string csCode = @"using System;

namespace TemplateExample
    {
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine(Hello,World!);
            }
        }
    }";
            richTextBox1.Text = csCode;
        }

        private void içindekilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Esma Gülsüm BİLGİN tarafından bahar dönemi Nesneye Dayalı Programlama ödevi amacıyla yapıldı.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SayfaKaydedilmeliMi())
            {
                Application.Exit();
            }
        }
    }
            
}

        
    


   


/****************************************************************************
**				         SAKARYA ÜNİVERSİTESİ
**			      BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**			          BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**			         NESNEYE DAYALI PROGRAMLAMA DERSİ
**				         2018-2019 BAHAR DÖNEMİ
**	    
**                  ÖDEV NUMARASI..........: 1
**				    ÖĞRENCİ ADI............: Bunyamin Sanli
**				    ÖĞRENCİ NUMARASI.......: b181210040 
**                  DERSİN ALINDIĞI GRUP...: 1B
****************************************************************************/


using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NdpOdev1._2
{
    public partial class Form1 : Form
    {
        OpenFileDialog dosya = new OpenFileDialog(); //kullanicinin dosya secimini saglar
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //kolon olusturma
        {
            CalisanView1.Columns.Add("TC Kimlik", 150);
            CalisanView1.Columns.Add("Adı", 150);
            CalisanView1.Columns.Add("Soyadı", 150);
            CalisanView1.Columns.Add("Yaş", 100);
            CalisanView1.Columns.Add("Çalışma süresi", 100);
            CalisanView1.Columns.Add("Medeni Durum", 100);
            CalisanView1.Columns.Add("Eşi Çalışıyor mu", 100);
            CalisanView1.Columns.Add("Çocuk Sayısı", 100);
            CalisanView1.Columns.Add("Taban Maaş", 150);
            CalisanView1.Columns.Add("Makam Tazminatı", 150);
            CalisanView1.Columns.Add("İdari Görev Tazminati", 150);
            CalisanView1.Columns.Add("Mesai Saati", 150);
            CalisanView1.Columns.Add("Mesai Ücreti", 150);
            CalisanView1.Columns.Add("Vergi Matrahı", 150);
            
        }

        private void SecButton_Click(object sender, EventArgs e)
        {
            if(dosya.ShowDialog() == DialogResult.OK)
            {
                StreamReader metin = new StreamReader(dosya.FileName, Encoding.GetEncoding("iso_8859-9")); //turkce karakter gosterimi icin eklenir
                CalisanTextBox.Text = metin.ReadToEnd(); //verilerin dosyadan okunmasi
                metin.Close();
                DosyaYolutextBox.Text = dosya.FileName;//dosya yolunu gösterir

                string[] satirlar;

                string hepsi = CalisanTextBox.Text; //CalisanTextBox'taki butun yaziyi hepsi degisknine aktaririz
                satirlar = hepsi.Split('\n'); //dosya satirlara ayrilir

                foreach(string kelime in satirlar) // satirlar ayristirilir
                {
                    string[] kelimeler = kelime.Split(' '); //bosluk karakterine kadar ayirarak elemanlara boler
                    CalisanView1.Items.Add(new ListViewItem(kelimeler));
                }


            }
        }

        private void CalisanTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalisanView1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
           

        }
        
        private void SorgulaButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CalisanView1.Items.Count; i++)
            {

               
                double brut;   //kullanilacak degiskenleri tanimladim
                double damga;
                double gelirVergisi = 0; 
                if (CalisanView1.Items[i].SubItems[0].Text == TctextBox.Text) //listview'daki tc noyu tcbox ile karsilastirir eger dogruysa calisir
                {
                  
                       brut = Convert.ToInt32(CalisanView1.Items[i].SubItems[10].Text) +    //brut maas hesaplanir
                              Convert.ToInt32(CalisanView1.Items[i].SubItems[8].Text) +
                              Convert.ToInt32(CalisanView1.Items[i].SubItems[7].Text)*30 +
                              Convert.ToInt32(CalisanView1.Items[i].SubItems[11].Text) *
                              Convert.ToInt32(CalisanView1.Items[i].SubItems[12].Text)+
                              Convert.ToInt32(CalisanView1.Items[i].SubItems[9].Text);
                
                      damga = brut * 10 / 100;  //damga vergisi hesaplanir
                    

                    if( Convert.ToInt32(CalisanView1.Items[i].SubItems[13].Text) <= 1000)   //bu 4 if blogunda gerekli karsilastirmalar ve onlara uyan islemler yapilir
                        {
                         gelirVergisi = brut * 15 / 100;
                        }

                    if (20000 > Convert.ToInt32(CalisanView1.Items[i].SubItems[13].Text) &&
                          10000 <= Convert.ToInt32(CalisanView1.Items[i].SubItems[13].Text))
                    {
                        gelirVergisi = brut * 20 / 100;
                    }

                    if (30000 > Convert.ToInt32(CalisanView1.Items[i].SubItems[13].Text) &&
                          20000 <= Convert.ToInt32(CalisanView1.Items[i].SubItems[13].Text))
                    {
                        gelirVergisi = brut * 25 / 100;
                    }

                    if (3000 <= Convert.ToInt32(CalisanView1.Items[i].SubItems[13].Text))
                    {
                        gelirVergisi = brut * 30 / 100;
                    }


                    double emekliKesintisi = brut * 15 / 100;  //emekli kesintisi hesaplanir

                    double netMaas = brut - (emekliKesintisi + gelirVergisi + damga);  //net maas hesaplanir



                    MessageBox.Show("1-Adı: " + CalisanView1.Items[i].SubItems[1].Text + "\n" + //degerler alt alta gelecek sekilde messagebox ile kullaniciya gosterilir 
                    "2-Soyadı: " + CalisanView1.Items[i].SubItems[2].Text + "\n" +
                    "3-Brüt Maaş: " + Convert.ToString(brut) + "\n" +
                    "4-Damga Vergisi: " + Convert.ToString(damga) + "\n" +
                    "5-Gelir Vergisi: " + Convert.ToString(gelirVergisi) + "\n" +
                    "6-Emekli Kesintisi: " + Convert.ToString(emekliKesintisi) + "\n" +
                    "7-Net Maaş: " + Convert.ToString(netMaas), "Personel Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }

            } 
        }
    }
}

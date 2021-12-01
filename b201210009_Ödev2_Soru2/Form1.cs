/*****************************************************************************************************************
 **                                                 SAKARYA ÜNİVERSİTESİ
 **                                      BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ 
 **                                            BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
 **                                           NESNEYE DAYALI PROGRAMLAMA DERSİ
 **                                                 2020-2021 BAHAR DÖNEMİ
 **
 **
 **
 **
 **
 **                 ÖDEV NUMARASI..........: 2 (Soru 2)
 **                 ÖĞRENCİ ADI............: MEHMET AKİF KAYA
 **                 ÖĞRENCİ NUMARASI.......: b201210009
 **                 DERSİN ALINDIĞI GRUP...: 1C
 **
 **
 ******************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace b201210009_Ödev2_Soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //  Form2 ye erişmek için nesne
        Form2 NesneEkran = new Form2();

        //  Form1 yüklendiğinde text doyasının içeriğini siler.
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"matris.txt");
            sw.Write("");
            sw.Close();
        }

        //  İşlemlerden herhangi birine basıldığında çalışan komutlar
        private void YazdirButon_Click(object sender, EventArgs e)
        {
            //  İşlemin numarası 2. forma gönderilir.
            NesneEkran.FormOlustur(1);
            //  Formun başlığı değiştirilir.
            NesneEkran.Text = YazdirButon.Text;
            //  Form ekranda gösterilir.
            NesneEkran.ShowDialog();
        }

        // Kalan işlemler diğer butonlar için yukarıda gösterildiği gibidir.
        private void ToplaButon_Click(object sender, EventArgs e)
        {
            NesneEkran.FormOlustur(2);
            NesneEkran.Text = ToplaButon.Text;
            NesneEkran.ShowDialog();
        }

        private void CarpButon_Click(object sender, EventArgs e)
        {
            NesneEkran.FormOlustur(3);
            NesneEkran.Text = CarpButon.Text;
            NesneEkran.ShowDialog();
        }

        private void OkuButon_Click(object sender, EventArgs e)
        {
            NesneEkran.FormOlustur(4);
            NesneEkran.Text = OkuButon.Text;
            NesneEkran.ShowDialog();
        }

        private void TersButon_Click(object sender, EventArgs e)
        {
            NesneEkran.FormOlustur(5);
            NesneEkran.Text = TersButon.Text;
            NesneEkran.ShowDialog();
        }

        private void İzButon_Click(object sender, EventArgs e)
        {
            NesneEkran.FormOlustur(6);
            NesneEkran.Text = İzButon.Text;
            NesneEkran.ShowDialog();
        }

        private void TranButon_Click(object sender, EventArgs e)
        {
            NesneEkran.FormOlustur(7);
            NesneEkran.Text = TranButon.Text;
            NesneEkran.ShowDialog();
        }

        private void TextDosyaButon_Click(object sender, EventArgs e)
        {
            NesneEkran.FormOlustur(8);
            NesneEkran.Text = TextDosyaButon.Text;
            NesneEkran.ShowDialog();
        }

    }
}

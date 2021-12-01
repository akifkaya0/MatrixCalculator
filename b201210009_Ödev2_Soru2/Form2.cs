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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //  Formdaki kontrollerin görünürlüğünü kapatan fonksiyon.
        private void FormSifirla()
        {
            aciklamaMetin.Visible = false;

            boyut1.Visible = false;
            boyut2.Visible = false;
            boyut2.Location = new Point(88,59);
            boyut3.Visible = false;
            boyut3.Location = new Point(140,59);
            boyut4.Visible = false;
            boyut5.Visible = false;
            boyut6.Visible = false;

            isaret.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;

            islemButon.Visible = false;

            aciklamaMetin2.Visible = false;
            
            richTextBox1.Visible = false;
        }

        //  Matrisin büyüklüğünü tutacak değişken
        static int boyut = 0;
        
        //  Yapılmak istenen işlemin numarasını tutacak değişken
        int islem = 0;

        //  Form1 tarafından çalıştırılan fonksiyon. İşlem numarasına göre ekrana hangi butonlar ve yazıların çıkacağını belirler.
        public void FormOlustur(int islem)
        {
            //  Önceden bir metot kullanıldıysa orada kullanılan kontrollerin hepsinin görünürlüğü kapatılır.
            FormSifirla();

            //  islem no ileride sınıf içi kullanılması için atama yapılır.
            this.islem = islem;

            //  İşlem numarasına göre çalışacak if blokları 

            if(islem == 1)
            {
                // İşlemler ilgili açıklama yazısı
                aciklamaMetin.Visible = true;
                aciklamaMetin.Text = "Matris Boyutu Seçiniz : (Satır x Sütun)";
                aciklamaMetin.Location = new Point(30,30);
                
                // İşlemde kullanılabilecek matris boyutlarını temsil eden butonların gösterimi
                boyut1.Visible = true;
                boyut2.Visible = true;
                boyut3.Visible = true;
                boyut4.Visible = true;
                boyut5.Visible = true;
                boyut6.Visible = true;

                //  Butonlara basılmadan önce panelin gözükmemesi için boyutu sıfırlanır.
                panel1.Visible = true;
                panel1.Size = new Size(0, 0);

                //  Toplama veya çarpma işlemi gerçekleştiğinde, toplama veya çarpma işaretini temsil eden değişken ataması
                isaret.Text = "";

                //  İşlemi temsil eden buton ataması
                islemButon.Text = "YAZDIR";
                islemButon.Size = new Size(84,46);
            }

            //  (Diğer bloklardaki işlemler islem 1 ile neredeyse aynıdır. Bu yüzden işlemlere ait açıklama satılarını sadece islem 1'e yazdım.)

            if (islem == 2)
            {
                aciklamaMetin.Visible = true;
                aciklamaMetin.Text = "Matris Boyutu Seçiniz : (Satır x Sütun)";
                aciklamaMetin.Location = new Point(30,30);

                boyut1.Visible = true;
                boyut2.Visible = true;
                boyut3.Visible = true;
                boyut4.Visible = true;
                boyut5.Visible = true;
                boyut6.Visible = true;

                panel1.Visible = true;
                panel1.Size = new Size(0, 0);

                panel2.Visible = true;
                panel2.Size = new Size(0, 0);

                isaret.Text = "+";

                islemButon.Text = "TOPLA";
                islemButon.Size = new Size(84, 46);                
            }

            if (islem == 3)
            {
                aciklamaMetin.Visible = true;
                aciklamaMetin.Text = "Matris Boyutu Seçiniz : (Satır x Sütun)";
                aciklamaMetin.Location = new Point(30, 30);

                boyut1.Visible = true;
                boyut2.Visible = true;
                boyut3.Visible = true;
                boyut4.Visible = true;
                boyut5.Visible = true;
                boyut6.Visible = true;

                panel1.Visible = true;
                panel1.Size = new Size(0, 0);

                panel2.Visible = true;
                panel2.Size = new Size(0, 0);

                isaret.Text = "x";

                islemButon.Text = "ÇARP";
                islemButon.Size = new Size(84, 46);
            }

            if (islem == 4)
            {
                aciklamaMetin.Visible = true;
                aciklamaMetin.Text = "İşlem numarası giriniz...";
                aciklamaMetin.Location = new Point(30, 30);

                text1Box11.Text = "0";
                panel1.Visible = true;
                panel1.Size = new Size(25, 25);
                panel1.Location = new Point(30, 50);

                islemButon.Visible = true;
                islemButon.Text = "BUL";
                islemButon.Size = new Size(50, 25);
                islemButon.Location = new Point(30,82);

            }

            if (islem == 5)
            {
                aciklamaMetin.Visible = true;
                aciklamaMetin.Text = "Matris Boyutu Seçiniz : (Satır x Sütun)";
                aciklamaMetin.Location = new Point(30, 30);

                boyut2.Visible = true;
                boyut2.Location = new Point(62,83);
                boyut3.Visible = true;
                boyut3.Location = new Point(114,83);

                panel1.Visible = true;
                panel1.Size = new Size(0, 0);

                isaret.Text = "";

                islemButon.Text = "TERSİNİ AL";
                islemButon.Size = new Size(84, 46);
            }

            if (islem == 6)
            {
                aciklamaMetin.Visible = true;
                aciklamaMetin.Text = "Matris Boyutu Seçiniz : (Satır x Sütun)";
                aciklamaMetin.Location = new Point(30, 30);

                boyut1.Visible = true;
                boyut2.Visible = true;
                boyut3.Visible = true;
                boyut4.Visible = true;
                boyut5.Visible = true;
                boyut6.Visible = true;

                panel1.Visible = true;
                panel1.Size = new Size(0, 0);

                isaret.Text = "";

                islemButon.Text = "İZİNİ BUL";
                islemButon.Size = new Size(84, 46);
            }

            if (islem == 7)
            {
                aciklamaMetin.Visible = true;
                aciklamaMetin.Text = "Matris Boyutu Seçiniz : (Satır x Sütun)";
                aciklamaMetin.Location = new Point(30, 30);

                boyut1.Visible = true;
                boyut2.Visible = true;
                boyut3.Visible = true;
                boyut4.Visible = true;
                boyut5.Visible = true;
                boyut6.Visible = true;

                panel1.Visible = true;
                panel1.Size = new Size(0, 0);

                isaret.Text = "";

                islemButon.Text = "TRANSPOZU";
                islemButon.Size = new Size(84, 46);
            }

            //  Sadece islem 8 diğerlerinden daha farklıdır.
            if (islem == 8)
            {
                //  Text dosyası richtextbox'ta gösterilir.
                richTextBox1.Visible = true;
                richTextBox1.Location = new Point(0, 0);
                richTextBox1.Size = new Size(462, 434);

                //  Dosyanın tamamı richtextbox'a aktarılır.
                StreamReader sr = new StreamReader(@"matris.txt");
                string metin = sr.ReadToEnd();
                richTextBox1.Text = metin;
                sr.Close();
            }

        }
        
        //  Matris oluşturmak için büyüklüklerden biri seçildiğinde çalışan fonksiyonlar
        private void boyut1_Click(object sender, EventArgs e)
        {
            //  Boyut değeri ataması yapılır.
            boyut = 1;
            //  Önceden textboxlar ile işlem yapıldıysa içeriği sıfırlanır. 
            TextBoxSifirla();

            //  İşlem butonu görünür hale gelir.
            islemButon.Visible = true;
            islemButon.Location = new Point(33,216);

            //  İşlemde işaret konulması gerekiyorsa konumu belirtilir.
            isaret.Visible = true;
            isaret.Location = new Point(65,177);

            //  Sonuç metninin konumu belirlenir.
            aciklamaMetin2.Location = new Point(33, 282);

            //  Matrisleri içinde tutan paneller seçilen büyüklüğün sayısı kadar textbox gösterecek şekilde boyutu yeniden ayarlanır.
            panel1.Location = new Point(33,170);    panel2.Location = new Point(88,170);
            panel1.Size = new Size(25, 25);         panel2.Size = new Size(25, 25);

            //  Gösterilen textboxların içeriği default değer yapılır.
            text1Box11.Text = "0";                  text2Box11.Text = "0";
        }

        //  Diğer butonlardaki işlemler boyut 1 ile neredeyse aynıdır. Değişen tek şey gösterilecek textbox sayısıdır.
        private void boyut2_Click(object sender, EventArgs e)
        {
            boyut = 2;
            TextBoxSifirla();

            islemButon.Visible = true;
            islemButon.Location = new Point(33,242);
            isaret.Visible = true;
            isaret.Location = new Point(91, 190);

            aciklamaMetin2.Location = new Point(33, 308);

            panel1.Location = new Point(33, 170);           panel2.Location = new Point(114,170);
            panel1.Size = new Size(50, 50);                 panel2.Size = new Size(50, 50);
            text1Box11.Text = "0"; text1Box12.Text = "0"; text1Box21.Text = "0"; text1Box22.Text = "0";
            text2Box11.Text = "0"; text2Box12.Text = "0"; text2Box21.Text = "0"; text2Box22.Text = "0";
        }

        private void boyut3_Click(object sender, EventArgs e)
        {
            boyut = 3;
            TextBoxSifirla();

            islemButon.Visible = true;
            islemButon.Location = new Point(33,268);
            isaret.Visible = true;
            isaret.Location = new Point(117, 203);

            aciklamaMetin2.Location = new Point(33, 334);

            panel1.Location = new Point(33, 170);       panel2.Location = new Point(140, 170);
            panel1.Size = new Size(75, 75);             panel2.Size = new Size(75, 75);
            text1Box11.Text = "0"; text1Box12.Text = "0"; text1Box13.Text = "0"; text1Box21.Text = "0"; text1Box22.Text = "0"; text1Box23.Text = "0";
            text1Box31.Text = "0"; text1Box32.Text = "0"; text1Box33.Text = "0";

            text2Box11.Text = "0"; text2Box12.Text = "0"; text2Box13.Text = "0"; text2Box21.Text = "0"; text2Box22.Text = "0"; text2Box23.Text = "0";
            text2Box31.Text = "0"; text2Box32.Text = "0"; text2Box33.Text = "0";
        }

        private void boyut4_Click(object sender, EventArgs e)
        {
            boyut = 4;
            TextBoxSifirla();

            islemButon.Visible = true;
            islemButon.Location = new Point(33,294);
            isaret.Visible = true;
            isaret.Location = new Point(143, 216);

            aciklamaMetin2.Location = new Point(33, 360);

            panel1.Location = new Point(33, 170); panel2.Location = new Point(166, 170);
            panel1.Size = new Size(105, 105); panel2.Size = new Size(105, 105);
            text1Box11.Text = "0"; text1Box12.Text = "0"; text1Box13.Text = "0"; text1Box14.Text = "0";
            text1Box21.Text = "0"; text1Box22.Text = "0"; text1Box23.Text = "0"; text1Box24.Text = "0";
            text1Box31.Text = "0"; text1Box32.Text = "0"; text1Box33.Text = "0"; text1Box34.Text = "0";
            text1Box41.Text = "0"; text1Box42.Text = "0"; text1Box43.Text = "0"; text1Box44.Text = "0";

            text2Box11.Text = "0"; text2Box12.Text = "0"; text2Box13.Text = "0"; text2Box14.Text = "0";
            text2Box21.Text = "0"; text2Box22.Text = "0"; text2Box23.Text = "0"; text2Box24.Text = "0";
            text2Box31.Text = "0"; text2Box32.Text = "0"; text2Box33.Text = "0"; text2Box34.Text = "0";
            text2Box41.Text = "0"; text2Box42.Text = "0"; text2Box43.Text = "0"; text2Box44.Text = "0";
        }

        private void boyut5_Click(object sender, EventArgs e)
        {
            boyut = 5;
            TextBoxSifirla();

            islemButon.Visible = true;
            islemButon.Location = new Point(33,320);
            isaret.Visible = true;
            isaret.Location = new Point(169, 229);

            aciklamaMetin2.Location = new Point(33, 386);

            panel1.Location = new Point(33, 170); panel2.Location = new Point(192, 170);
            panel1.Size = new Size(130, 130); panel2.Size = new Size(130, 130);
            text1Box11.Text = "0"; text1Box12.Text = "0"; text1Box13.Text = "0"; text1Box14.Text = "0"; text1Box15.Text = "0";
            text1Box21.Text = "0"; text1Box22.Text = "0"; text1Box23.Text = "0"; text1Box24.Text = "0"; text1Box25.Text = "0";
            text1Box31.Text = "0"; text1Box32.Text = "0"; text1Box33.Text = "0"; text1Box34.Text = "0"; text1Box35.Text = "0";
            text1Box41.Text = "0"; text1Box42.Text = "0"; text1Box43.Text = "0"; text1Box44.Text = "0"; text1Box45.Text = "0";
            text1Box51.Text = "0"; text1Box52.Text = "0"; text1Box53.Text = "0"; text1Box54.Text = "0"; text1Box55.Text = "0";

            text2Box11.Text = "0"; text2Box12.Text = "0"; text2Box13.Text = "0"; text2Box14.Text = "0"; text2Box15.Text = "0";
            text2Box21.Text = "0"; text2Box22.Text = "0"; text2Box23.Text = "0"; text2Box24.Text = "0"; text2Box25.Text = "0";
            text2Box31.Text = "0"; text2Box32.Text = "0"; text2Box33.Text = "0"; text2Box34.Text = "0"; text2Box35.Text = "0";
            text2Box41.Text = "0"; text2Box42.Text = "0"; text2Box43.Text = "0"; text2Box44.Text = "0"; text2Box45.Text = "0";
            text2Box51.Text = "0"; text2Box52.Text = "0"; text2Box53.Text = "0"; text2Box54.Text = "0"; text2Box55.Text = "0";
        }

        private void boyut6_Click(object sender, EventArgs e)
        {
            boyut = 6;
            TextBoxSifirla();

            islemButon.Visible = true;
            islemButon.Location = new Point(33,346);
            isaret.Visible = true;
            isaret.Location = new Point(195, 242);

            aciklamaMetin2.Location = new Point(33, 412);

            panel1.Location = new Point(33, 170);       panel2.Location = new Point(218, 170);
            panel1.Size = new Size(155, 155);           panel2.Size = new Size(155, 155);
            text1Box11.Text = "0"; text1Box12.Text = "0"; text1Box13.Text = "0"; text1Box14.Text = "0"; text1Box15.Text = "0"; text1Box16.Text = "0";
            text1Box21.Text = "0"; text1Box22.Text = "0"; text1Box23.Text = "0"; text1Box24.Text = "0"; text1Box25.Text = "0"; text1Box26.Text = "0";
            text1Box31.Text = "0"; text1Box32.Text = "0"; text1Box33.Text = "0"; text1Box34.Text = "0"; text1Box35.Text = "0"; text1Box36.Text = "0";
            text1Box41.Text = "0"; text1Box42.Text = "0"; text1Box43.Text = "0"; text1Box44.Text = "0"; text1Box45.Text = "0"; text1Box46.Text = "0";
            text1Box51.Text = "0"; text1Box52.Text = "0"; text1Box53.Text = "0"; text1Box54.Text = "0"; text1Box55.Text = "0"; text1Box56.Text = "0";
            text1Box61.Text = "0"; text1Box62.Text = "0"; text1Box63.Text = "0"; text1Box64.Text = "0"; text1Box65.Text = "0"; text1Box66.Text = "0";

            text2Box11.Text = "0"; text2Box12.Text = "0"; text2Box13.Text = "0"; text2Box14.Text = "0"; text2Box15.Text = "0"; text2Box16.Text = "0";
            text2Box21.Text = "0"; text2Box22.Text = "0"; text2Box23.Text = "0"; text2Box24.Text = "0"; text2Box25.Text = "0"; text2Box26.Text = "0";
            text2Box31.Text = "0"; text2Box32.Text = "0"; text2Box33.Text = "0"; text2Box34.Text = "0"; text2Box35.Text = "0"; text2Box36.Text = "0";
            text2Box41.Text = "0"; text2Box42.Text = "0"; text2Box43.Text = "0"; text2Box44.Text = "0"; text2Box45.Text = "0"; text2Box46.Text = "0";
            text2Box51.Text = "0"; text2Box52.Text = "0"; text2Box53.Text = "0"; text2Box54.Text = "0"; text2Box55.Text = "0"; text2Box56.Text = "0";
            text2Box61.Text = "0"; text2Box62.Text = "0"; text2Box63.Text = "0"; text2Box64.Text = "0"; text2Box65.Text = "0"; text2Box66.Text = "0";
        }

        //  Textboxların içeriğini sıfırlayan metot
        private void TextBoxSifirla()
        {
            aciklamaMetin2.Text = "";
            text1Box11.Text = ""; text1Box12.Text = ""; text1Box13.Text = ""; text1Box14.Text = ""; text1Box15.Text = ""; text1Box16.Text = "";
            text1Box21.Text = ""; text1Box22.Text = ""; text1Box23.Text = ""; text1Box24.Text = ""; text1Box25.Text = ""; text1Box26.Text = "";
            text1Box31.Text = ""; text1Box32.Text = ""; text1Box33.Text = ""; text1Box34.Text = ""; text1Box35.Text = ""; text1Box36.Text = "";
            text1Box41.Text = ""; text1Box42.Text = ""; text1Box43.Text = ""; text1Box44.Text = ""; text1Box45.Text = ""; text1Box46.Text = "";
            text1Box51.Text = ""; text1Box52.Text = ""; text1Box53.Text = ""; text1Box54.Text = ""; text1Box55.Text = ""; text1Box56.Text = "";
            text1Box61.Text = ""; text1Box62.Text = ""; text1Box63.Text = ""; text1Box64.Text = ""; text1Box65.Text = ""; text1Box66.Text = "";

            text2Box11.Text = ""; text2Box12.Text = ""; text2Box13.Text = ""; text2Box14.Text = ""; text2Box15.Text = ""; text2Box16.Text = "";
            text2Box21.Text = ""; text2Box22.Text = ""; text2Box23.Text = ""; text2Box24.Text = ""; text2Box25.Text = ""; text2Box26.Text = "";
            text2Box31.Text = ""; text2Box32.Text = ""; text2Box33.Text = ""; text2Box34.Text = ""; text2Box35.Text = ""; text2Box36.Text = "";
            text2Box41.Text = ""; text2Box42.Text = ""; text2Box43.Text = ""; text2Box44.Text = ""; text2Box45.Text = ""; text2Box46.Text = "";
            text2Box51.Text = ""; text2Box52.Text = ""; text2Box53.Text = ""; text2Box54.Text = ""; text2Box55.Text = ""; text2Box56.Text = "";
            text2Box61.Text = ""; text2Box62.Text = ""; text2Box63.Text = ""; text2Box64.Text = ""; text2Box65.Text = ""; text2Box66.Text = "";
        }

        //  İşlem butonuna basıldığında çalışan fonksiyon
        private void islemButon_Click(object sender, EventArgs e)
        {
            //  Belirlenen boyuta göre matris oluşturulur.
            int[,] matris1 = new int[boyut, boyut];
            int[,] matris2 = new int[boyut, boyut];

            //  Boyuta göre çalışacak if bloğu belirlenir ve textboxların içeriği matrislere aktarılır.
            if (boyut == 1)
            {
                matris1[0, 0] = Convert.ToInt32(text1Box11.Text); matris2[0, 0] = Convert.ToInt32(text2Box11.Text);
            }

            if (boyut == 2)
            {
                matris1[0, 0] = Convert.ToInt32(text1Box11.Text); matris2[0, 0] = Convert.ToInt32(text2Box11.Text);
                matris1[1, 0] = Convert.ToInt32(text1Box21.Text); matris2[1, 0] = Convert.ToInt32(text2Box21.Text);
                matris1[0, 1] = Convert.ToInt32(text1Box12.Text); matris2[0, 1] = Convert.ToInt32(text2Box12.Text);
                matris1[1, 1] = Convert.ToInt32(text1Box22.Text); matris2[1, 1] = Convert.ToInt32(text2Box22.Text);
            }

            if (boyut == 3)
            {
                matris1[0, 0] = Convert.ToInt32(text1Box11.Text); matris2[0, 0] = Convert.ToInt32(text2Box11.Text);
                matris1[1, 0] = Convert.ToInt32(text1Box21.Text); matris2[1, 0] = Convert.ToInt32(text2Box21.Text);
                matris1[0, 1] = Convert.ToInt32(text1Box12.Text); matris2[0, 1] = Convert.ToInt32(text2Box12.Text);
                matris1[1, 1] = Convert.ToInt32(text1Box22.Text); matris2[1, 1] = Convert.ToInt32(text2Box22.Text);
                matris1[0, 2] = Convert.ToInt32(text1Box13.Text); matris2[0, 2] = Convert.ToInt32(text2Box13.Text);
                matris1[1, 2] = Convert.ToInt32(text1Box23.Text); matris2[1, 2] = Convert.ToInt32(text2Box23.Text);
                matris1[2, 0] = Convert.ToInt32(text1Box31.Text); matris2[2, 0] = Convert.ToInt32(text2Box31.Text);
                matris1[2, 1] = Convert.ToInt32(text1Box32.Text); matris2[2, 1] = Convert.ToInt32(text2Box32.Text);
                matris1[2, 2] = Convert.ToInt32(text1Box33.Text); matris2[2, 2] = Convert.ToInt32(text2Box33.Text);
            }

            if (boyut == 4)
            {
                matris1[0, 0] = Convert.ToInt32(text1Box11.Text); matris2[0, 0] = Convert.ToInt32(text2Box11.Text);
                matris1[1, 0] = Convert.ToInt32(text1Box21.Text); matris2[1, 0] = Convert.ToInt32(text2Box21.Text);
                matris1[0, 1] = Convert.ToInt32(text1Box12.Text); matris2[0, 1] = Convert.ToInt32(text2Box12.Text);
                matris1[1, 1] = Convert.ToInt32(text1Box22.Text); matris2[1, 1] = Convert.ToInt32(text2Box22.Text);
                matris1[0, 2] = Convert.ToInt32(text1Box13.Text); matris2[0, 2] = Convert.ToInt32(text2Box13.Text);
                matris1[1, 2] = Convert.ToInt32(text1Box23.Text); matris2[1, 2] = Convert.ToInt32(text2Box23.Text);
                matris1[2, 0] = Convert.ToInt32(text1Box31.Text); matris2[2, 0] = Convert.ToInt32(text2Box31.Text);
                matris1[2, 1] = Convert.ToInt32(text1Box32.Text); matris2[2, 1] = Convert.ToInt32(text2Box32.Text);
                matris1[2, 2] = Convert.ToInt32(text1Box33.Text); matris2[2, 2] = Convert.ToInt32(text2Box33.Text);
                matris1[3, 0] = Convert.ToInt32(text1Box41.Text); matris2[3, 0] = Convert.ToInt32(text2Box41.Text);
                matris1[3, 1] = Convert.ToInt32(text1Box42.Text); matris2[3, 1] = Convert.ToInt32(text2Box42.Text);
                matris1[3, 2] = Convert.ToInt32(text1Box43.Text); matris2[3, 2] = Convert.ToInt32(text2Box43.Text);
                matris1[3, 3] = Convert.ToInt32(text1Box44.Text); matris2[3, 3] = Convert.ToInt32(text2Box44.Text);
                matris1[0, 3] = Convert.ToInt32(text1Box14.Text); matris2[0, 3] = Convert.ToInt32(text2Box14.Text);
                matris1[1, 3] = Convert.ToInt32(text1Box24.Text); matris2[1, 3] = Convert.ToInt32(text2Box24.Text);
                matris1[2, 3] = Convert.ToInt32(text1Box34.Text); matris2[2, 3] = Convert.ToInt32(text2Box34.Text);
            }

            if (boyut == 5)
            {
                matris1[0, 0] = Convert.ToInt32(text1Box11.Text); matris2[0, 0] = Convert.ToInt32(text2Box11.Text);
                matris1[1, 0] = Convert.ToInt32(text1Box21.Text); matris2[1, 0] = Convert.ToInt32(text2Box21.Text);
                matris1[0, 1] = Convert.ToInt32(text1Box12.Text); matris2[0, 1] = Convert.ToInt32(text2Box12.Text);
                matris1[1, 1] = Convert.ToInt32(text1Box22.Text); matris2[1, 1] = Convert.ToInt32(text2Box22.Text);
                matris1[0, 2] = Convert.ToInt32(text1Box13.Text); matris2[0, 2] = Convert.ToInt32(text2Box13.Text);
                matris1[1, 2] = Convert.ToInt32(text1Box23.Text); matris2[1, 2] = Convert.ToInt32(text2Box23.Text);
                matris1[2, 0] = Convert.ToInt32(text1Box31.Text); matris2[2, 0] = Convert.ToInt32(text2Box31.Text);
                matris1[2, 1] = Convert.ToInt32(text1Box32.Text); matris2[2, 1] = Convert.ToInt32(text2Box32.Text);
                matris1[2, 2] = Convert.ToInt32(text1Box33.Text); matris2[2, 2] = Convert.ToInt32(text2Box33.Text);
                matris1[3, 0] = Convert.ToInt32(text1Box41.Text); matris2[3, 0] = Convert.ToInt32(text2Box41.Text);
                matris1[3, 1] = Convert.ToInt32(text1Box42.Text); matris2[3, 1] = Convert.ToInt32(text2Box42.Text);
                matris1[3, 2] = Convert.ToInt32(text1Box43.Text); matris2[3, 2] = Convert.ToInt32(text2Box43.Text);
                matris1[3, 3] = Convert.ToInt32(text1Box44.Text); matris2[3, 3] = Convert.ToInt32(text2Box44.Text);
                matris1[0, 3] = Convert.ToInt32(text1Box14.Text); matris2[0, 3] = Convert.ToInt32(text2Box14.Text);
                matris1[1, 3] = Convert.ToInt32(text1Box24.Text); matris2[1, 3] = Convert.ToInt32(text2Box24.Text);
                matris1[2, 3] = Convert.ToInt32(text1Box34.Text); matris2[2, 3] = Convert.ToInt32(text2Box34.Text);
                matris1[4, 0] = Convert.ToInt32(text1Box51.Text); matris2[4, 0] = Convert.ToInt32(text2Box51.Text);
                matris1[4, 1] = Convert.ToInt32(text1Box52.Text); matris2[4, 1] = Convert.ToInt32(text2Box52.Text);
                matris1[4, 2] = Convert.ToInt32(text1Box53.Text); matris2[4, 2] = Convert.ToInt32(text2Box53.Text);
                matris1[4, 3] = Convert.ToInt32(text1Box54.Text); matris2[4, 3] = Convert.ToInt32(text2Box54.Text);
                matris1[4, 4] = Convert.ToInt32(text1Box55.Text); matris2[4, 4] = Convert.ToInt32(text2Box55.Text);
                matris1[0, 4] = Convert.ToInt32(text1Box15.Text); matris2[0, 4] = Convert.ToInt32(text2Box15.Text);
                matris1[1, 4] = Convert.ToInt32(text1Box25.Text); matris2[1, 4] = Convert.ToInt32(text2Box25.Text);
                matris1[2, 4] = Convert.ToInt32(text1Box35.Text); matris2[2, 4] = Convert.ToInt32(text2Box35.Text);
                matris1[3, 4] = Convert.ToInt32(text1Box45.Text); matris2[3, 4] = Convert.ToInt32(text2Box45.Text);
            }

            if (boyut == 6)
            {
                matris1[0, 0] = Convert.ToInt32(text1Box11.Text); matris2[0, 0] = Convert.ToInt32(text2Box11.Text);
                matris1[1, 0] = Convert.ToInt32(text1Box21.Text); matris2[1, 0] = Convert.ToInt32(text2Box21.Text);
                matris1[0, 1] = Convert.ToInt32(text1Box12.Text); matris2[0, 1] = Convert.ToInt32(text2Box12.Text);
                matris1[1, 1] = Convert.ToInt32(text1Box22.Text); matris2[1, 1] = Convert.ToInt32(text2Box22.Text);
                matris1[0, 2] = Convert.ToInt32(text1Box13.Text); matris2[0, 2] = Convert.ToInt32(text2Box13.Text);
                matris1[1, 2] = Convert.ToInt32(text1Box23.Text); matris2[1, 2] = Convert.ToInt32(text2Box23.Text);
                matris1[2, 0] = Convert.ToInt32(text1Box31.Text); matris2[2, 0] = Convert.ToInt32(text2Box31.Text);
                matris1[2, 1] = Convert.ToInt32(text1Box32.Text); matris2[2, 1] = Convert.ToInt32(text2Box32.Text);
                matris1[2, 2] = Convert.ToInt32(text1Box33.Text); matris2[2, 2] = Convert.ToInt32(text2Box33.Text);
                matris1[3, 0] = Convert.ToInt32(text1Box41.Text); matris2[3, 0] = Convert.ToInt32(text2Box41.Text);
                matris1[3, 1] = Convert.ToInt32(text1Box42.Text); matris2[3, 1] = Convert.ToInt32(text2Box42.Text);
                matris1[3, 2] = Convert.ToInt32(text1Box43.Text); matris2[3, 2] = Convert.ToInt32(text2Box43.Text);
                matris1[3, 3] = Convert.ToInt32(text1Box44.Text); matris2[3, 3] = Convert.ToInt32(text2Box44.Text);
                matris1[0, 3] = Convert.ToInt32(text1Box14.Text); matris2[0, 3] = Convert.ToInt32(text2Box14.Text);
                matris1[1, 3] = Convert.ToInt32(text1Box24.Text); matris2[1, 3] = Convert.ToInt32(text2Box24.Text);
                matris1[2, 3] = Convert.ToInt32(text1Box34.Text); matris2[2, 3] = Convert.ToInt32(text2Box34.Text);
                matris1[4, 0] = Convert.ToInt32(text1Box51.Text); matris2[4, 0] = Convert.ToInt32(text2Box51.Text);
                matris1[4, 1] = Convert.ToInt32(text1Box52.Text); matris2[4, 1] = Convert.ToInt32(text2Box52.Text);
                matris1[4, 2] = Convert.ToInt32(text1Box53.Text); matris2[4, 2] = Convert.ToInt32(text2Box53.Text);
                matris1[4, 3] = Convert.ToInt32(text1Box54.Text); matris2[4, 3] = Convert.ToInt32(text2Box54.Text);
                matris1[4, 4] = Convert.ToInt32(text1Box55.Text); matris2[4, 4] = Convert.ToInt32(text2Box55.Text);
                matris1[0, 4] = Convert.ToInt32(text1Box15.Text); matris2[0, 4] = Convert.ToInt32(text2Box15.Text);
                matris1[1, 4] = Convert.ToInt32(text1Box25.Text); matris2[1, 4] = Convert.ToInt32(text2Box25.Text);
                matris1[2, 4] = Convert.ToInt32(text1Box35.Text); matris2[2, 4] = Convert.ToInt32(text2Box35.Text);
                matris1[3, 4] = Convert.ToInt32(text1Box45.Text); matris2[3, 4] = Convert.ToInt32(text2Box45.Text);
                matris1[0, 5] = Convert.ToInt32(text1Box16.Text); matris2[0, 5] = Convert.ToInt32(text2Box16.Text);
                matris1[1, 5] = Convert.ToInt32(text1Box26.Text); matris2[1, 5] = Convert.ToInt32(text2Box26.Text);
                matris1[2, 5] = Convert.ToInt32(text1Box36.Text); matris2[2, 5] = Convert.ToInt32(text2Box36.Text);
                matris1[3, 5] = Convert.ToInt32(text1Box46.Text); matris2[3, 5] = Convert.ToInt32(text2Box46.Text);
                matris1[4, 5] = Convert.ToInt32(text1Box56.Text); matris2[4, 5] = Convert.ToInt32(text2Box56.Text);
                matris1[5, 5] = Convert.ToInt32(text1Box66.Text); matris2[5, 5] = Convert.ToInt32(text2Box66.Text);
                matris1[5, 0] = Convert.ToInt32(text1Box61.Text); matris2[5, 0] = Convert.ToInt32(text2Box61.Text);
                matris1[5, 1] = Convert.ToInt32(text1Box62.Text); matris2[5, 1] = Convert.ToInt32(text2Box62.Text);
                matris1[5, 2] = Convert.ToInt32(text1Box63.Text); matris2[5, 2] = Convert.ToInt32(text2Box63.Text);
                matris1[5, 3] = Convert.ToInt32(text1Box64.Text); matris2[5, 3] = Convert.ToInt32(text2Box64.Text);
                matris1[5, 4] = Convert.ToInt32(text1Box65.Text); matris2[5, 4] = Convert.ToInt32(text2Box65.Text);
            }

            //  İşlem numarasına göre static sınıftan çağırılacak metotu belirleyen ve sonucu ekrana yazdıran if blokları
            if (islem == 1)
            {
                //  Sonuç metni görünür olur ve ilgili fonksiyon parametresiyle çağırılır.
                aciklamaMetin2.Visible = true;
                aciklamaMetin2.Text = Matrisİslemleri.YazdirMatris(matris1, boyut);
            }

            if (islem == 2)
            {
                //  İşlemi yapan metot static sınıftan çağırılır ve sonuç dizisine aktarılır.
                int[,] sonuc = Matrisİslemleri.ToplaMatris(matris1, matris2, boyut);

                //  Sonucu temsil eden label görünür olur ve sonuç for döngüsüyle label'a yazdırılır.
                aciklamaMetin2.Visible = true;
                aciklamaMetin2.Text = "SONUÇ : \n";

                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < boyut; j++)
                    {
                        aciklamaMetin2.Text += sonuc[i, j] + " ";

                    }
                    aciklamaMetin2.Text += "\n";
                }
            }

            if (islem == 3)
            {
                // if islem2 bloğuyla aynı çalışma mantığına sahiptir.
                int[,] sonuc = Matrisİslemleri.CarpMatris(matris1, matris2, boyut);

                aciklamaMetin2.Visible = true;
                aciklamaMetin2.Text = "SONUÇ : \n";

                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < boyut; j++)
                    {
                        aciklamaMetin2.Text += sonuc[i, j] + " ";

                    }
                    aciklamaMetin2.Text += "\n";
                }
            }

            if (islem == 4)
            {
                //  Text dosyasındaki bütün metni string dizisine aktarır.
                string[] metin = System.IO.File.ReadAllLines(@"matris.txt");

                //  Sonuç metninin görünürlüğü ve lokasyon ayarlanması
                aciklamaMetin2.Text = "";
                aciklamaMetin2.Visible = true;
                aciklamaMetin2.Location = new Point(30,117);

                //  İşlem numaralarının satırlarını tutacak int dizi tanımlaması
                int[] islemDizi = new int[metin.Length];
                int sayac = 0;

                //  İşlem bulmada kolaylık olsun diye text dosyasına işlemleri yazarken metnin en başına '***' ifadesi ekledim.
                //  For döngüsüyle metnin satırlarında bu 3 yıldız ifadesini aradım. 
                for (int i = 0; i < metin.Length; i++)
                {
                    // 3 yıldız ifadesi bulunduğunda satır numarasını diziye aktarır ve dizinin indis değeri 1 arttırlır.
                    if (metin[i] == "***")
                    {
                        islemDizi[sayac] = i;
                        sayac++;
                    }
                }

                //  En son işlemi de ekranda gösterebilmek için metnin en son karakterini de işlem dizisine ekledim.
                islemDizi[sayac] = metin.Length;

                //  İşlem no değeri alınır.
                int islemNo = Convert.ToInt32(text1Box11.Text);

                //  işlem numarasının arasında bulunduğu 2 tane 3 yıldız ifadesinin arası label'a yazdırılır.
                for (int i = islemDizi[islemNo-1]; i < islemDizi[islemNo]; i++)
                {
                    aciklamaMetin2.Text += metin[i] + "\n";
                }

                
            }

            if (islem == 5)
            {
                //  if islemno 2 ile aynı çalışma mantığına sahiptir. Tek farkı dizinin float olması
                float[,] sonuc = Matrisİslemleri.TersMatris(matris1, boyut);

                aciklamaMetin2.Visible = true;
                aciklamaMetin2.Text = "SONUÇ : \n";

                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < boyut; j++)
                    {
                        aciklamaMetin2.Text += sonuc[i, j] + " ";

                    }
                    aciklamaMetin2.Text += "\n";
                }
            }

            if (islem == 6)
            {
                // Metot çağırlır ve sonuç label'a yazdırılır.
                aciklamaMetin2.Visible = true;
                aciklamaMetin2.Text = "SONUÇ : " + Matrisİslemleri.IzMatris(matris1, boyut) ;
            }

            if (islem == 7)
            {
                //  if islemno 2 ile aynı çalışma mantığına sahiptir.
                int[,] sonuc = Matrisİslemleri.TranspozeMatris(matris1, boyut);

                aciklamaMetin2.Visible = true;
                aciklamaMetin2.Text = "SONUÇ : \n";

                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < boyut; j++)
                    {
                        aciklamaMetin2.Text += sonuc[i, j] + " ";

                    }
                    aciklamaMetin2.Text += "\n";
                }
            }

        }
    }

    //  Metotları tutan, text dosyasına matrisleri yazan ve matrisler üzerinde işlemler yapan static sınıf
    static class Matrisİslemleri
    {
        //  İşlem numarasını tutan sayaç değişkeni
        static int sayac = 1;

        //  İşlem tipini, işlem numarasını text dosyasına yazdıran metot
        private static void BaslikTexteYazdir(int islem)
        {
            StreamWriter sw = new StreamWriter(@"matris.txt", true);

            //  İşlem numarasının daha kolay bulmaya yarayacak olan 3 yıldız ifadesi textbox'a yazdırılır.
            sw.WriteLine("***");

            //  İşlem tipine göre if blokları çalışır işlemin tipini text dosyasına yazar.
            if (islem == 1)
                sw.WriteLine("ISLEM TIPI : MATRIS YAZDIR");
            if (islem == 2)
                sw.WriteLine("ISLEM TIPI : MATRIS TOPLAMA");
            if (islem == 3)
                sw.WriteLine("ISLEM TIPI : MATRIS CARPMA");
            if (islem == 5)
                sw.WriteLine("ISLEM TIPI : MATRIS TERSI");
            if (islem == 6)
                sw.WriteLine("ISLEM TIPI : MATRIS IZI");
            if (islem == 7)
                sw.WriteLine("ISLEM TIPI : MATRIS TRANSPOZE");

            //  İşlem numarası yazdırılır.
            sw.WriteLine("ISLEM NO : " + sayac);
            sw.Close();
            sayac++;
        }

        //  Matrisi text dosyasına yazan metot
        private static void MatrisTexteYazdir(int[,] matris, int boyut)
        {
            StreamWriter sw1 = new StreamWriter(@"matris.txt", true);

            //  For döngüsü kullanılarak matris text dosyasına yazdırılır.
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    sw1.Write(matris[i, j] + " ");
                }
                sw1.WriteLine();
            }
            sw1.WriteLine();
            sw1.Close();
        }

        //  Text dosyasına matris kaydetmeye yarayan metot
        public static string YazdirMatris(int[,] matris1, int boyut)
        {
            //  Başlık fonksiyonu ve matris fonksiyonu kullanırak işlem ve matris text dosyasına yazılır.
            BaslikTexteYazdir(1);

            MatrisTexteYazdir(matris1,boyut);

            return "Matris Yazma İşlemi Başarılı.";
        }

        //  2 matrisi toplayıp text dosyasına yazdıran metot
        public static int[,] ToplaMatris(int[,] matris1 , int[,]matris2 , int boyut)
        {
            //  İşlemin başlığı dosyaya yazdırılır.
            BaslikTexteYazdir(2);

            // Sonucu tutan toplam matris
            int[,] toplamMatris = new int[boyut,boyut];

            // İç içe for döngüsüyle matrisin her elemanı gezilir.
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    //  Aynı indisteki değerler toplanır, sonuç matrisine aktarılır.
                    toplamMatris[i, j] = matris1[i, j] + matris2[i, j];
                }
            }

            //  3 matris text dosyasına yazılır.
            MatrisTexteYazdir(matris1, boyut);

            MatrisTexteYazdir(matris2, boyut);

            MatrisTexteYazdir(toplamMatris, boyut);

            return toplamMatris;
        }

        //  2 matrisi çarpıp text dosyasına yazdıran metot
        public static int[,] CarpMatris(int[,] matris1, int[,] matris2 ,int boyut)
        {
            //  İşlemin başlığı dosyaya yazdırılır.
            BaslikTexteYazdir(3);

            // Sonucu tutan matris
            int[,] sonucMatris = new int[boyut, boyut];

            //  Matriste çarpma kuralı iç içe 3 for döngüsüyle sağlanır.
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    int toplam = 0;
                    for (int k = 0; k < boyut; k++)
                    {
                        toplam += (matris1[i,k]*matris2[k,j]);
                    }

                    sonucMatris[i, j] =toplam;
                }
            }

            //  3 matris text dosyasına yazılır.
            MatrisTexteYazdir(matris1, boyut);

            MatrisTexteYazdir(matris2, boyut);

            MatrisTexteYazdir(sonucMatris, boyut);

            return sonucMatris;
        }

        //  Metrisin tersini alıp text dosyasına yazdıran metot
        public static float[,] TersMatris(int[,]matris1,int boyut)
        {
            //  İşlemin başlığı dosyaya yazdırılır.
            BaslikTexteYazdir(5);

            //  Determinantı ifade eden değişken
            float det =0;

            // Sonucu tutan matris
            float[,] sonucMatris = new float[boyut, boyut];

            //  Matrisin büyüklüğüne göre çalışan if blokları
            if (boyut == 2)
            {
                //  Ek matris tanımlanır.
                int[,] ekMatris = new int[boyut, boyut];

                //  2x2 matrisin determinantı alınır
                det = (matris1[0, 0] * matris1[1, 1]) - (matris1[0, 1] * matris1[1, 0]);

                //  Ek matris değerleri atanır.
                ekMatris[0, 0] = matris1[1,1];
                ekMatris[0,1]= -1*matris1[1, 0];
                ekMatris[1,0]= -1* matris1[0, 1];
                ekMatris[1,1]= matris1[0, 0];

                //  Ek matrisin transpozu alınır.
                ekMatris = TranspozAl(ekMatris, boyut);

                // Ek matrisin her indisi determinanta bölünür.
                sonucMatris[0, 0] = ekMatris[0, 0] / det;
                sonucMatris[0, 1] = ekMatris[0, 1] / det;
                sonucMatris[1, 0] = ekMatris[1, 0] / det;
                sonucMatris[1, 1] = ekMatris[1, 1] / det;
            }

            if (boyut == 3)
            {
                //  Ek matris tanımlanır.
                int[,] ek3Matris = new int[boyut, boyut];

                //  tüm 2x2 minör matrislerin determinantı bulunur ve ek matris değerleri atanır.
                ek3Matris[0, 0] = (matris1[1, 1] * matris1[2, 2]) - (matris1[2, 1] * matris1[1, 2]);
                ek3Matris[0, 1] = (-1) *   ((matris1[1, 0] * matris1[2, 2]) - (matris1[2, 0] * matris1[1, 2]));
                ek3Matris[0, 2] = (matris1[1, 0] * matris1[2, 1]) - (matris1[2, 0] * matris1[1, 1]);
                ek3Matris[1, 0] = (-1) *   ((matris1[0, 1] * matris1[2, 2]) - (matris1[2, 1] * matris1[0, 2]));
                ek3Matris[1, 1] = (matris1[0, 0] * matris1[2, 2]) - (matris1[2, 0] * matris1[0, 2]);
                ek3Matris[1, 2] = (-1) *   ((matris1[0, 0] * matris1[2, 1]) - (matris1[2, 0] * matris1[0, 1]));
                ek3Matris[2, 0] = (matris1[0, 1] * matris1[1, 2]) - (matris1[1, 1] * matris1[0, 2]);
                ek3Matris[2, 1] = (-1)*    ((matris1[0, 0] * matris1[1, 2]) - (matris1[1, 0] * matris1[0, 2]));
                ek3Matris[2, 2] = (matris1[0, 0] * matris1[1, 1]) - (matris1[1, 0] * matris1[0, 1]);

                //  Ek matris kullanılarak determinant alınır.
                det = (matris1[0, 0] * ek3Matris[0, 0]) + (matris1[0, 1] * ek3Matris[0, 1]) + (matris1[0, 2] * ek3Matris[0, 2]);

                //  Ek matrisin transpozu alınır.
                ek3Matris = TranspozAl(ek3Matris, boyut);

                // Ek matrisin her indisi determinanta bölünür.
                sonucMatris[0,0]= ek3Matris[0, 0] / det;
                sonucMatris[0,1]= ek3Matris[0, 1] / det;
                sonucMatris[0,2]= ek3Matris[0, 2] / det;
                sonucMatris[1,0]= ek3Matris[1, 0] / det;
                sonucMatris[1,1]= ek3Matris[1, 1] / det;
                sonucMatris[1,2]= ek3Matris[1, 2] / det;
                sonucMatris[2,0]= ek3Matris[2, 0] / det;
                sonucMatris[2,1]= ek3Matris[2, 1] / det;
                sonucMatris[2,2]= ek3Matris[2, 2] / det;
            }

            //  Matris text dosyasına yazdırılır.
            MatrisTexteYazdir(matris1, boyut);

            //  Ek matris float tipinde olduğu için MatrisTexteYazdir fonksiyonu kullanılmaz. For dögüsü kullanılarak metotun içinden dosyaya yazılır.
            StreamWriter sw1 = new StreamWriter(@"matris.txt", true);

            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    sw1.Write(sonucMatris[i, j] + " ");
                }
                sw1.WriteLine();
            }
            sw1.WriteLine();
            sw1.Close();

            return sonucMatris;
        }

        //  Matrisin izini bulup text dosyasına yazdıran metot
        public static int IzMatris(int[,] matris1 ,int boyut)
        {
            //  İşlemin başlığı dosyaya yazdırılır.
            BaslikTexteYazdir(6);

            int sonuc = 0;

            //  For döngüsüyle matrisin elemanları gezilir.
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    //  Eğer köşegen indisindeyse değer sonuca eklenir.
                    if (i==j)
                    {
                        sonuc += matris1[i, j];
                    }
                }
            }

            //  Matris ve sonuç text dosyasına yazdırılır.
            MatrisTexteYazdir(matris1,boyut);

            StreamWriter sw = new StreamWriter(@"matris.txt", true);

            sw.WriteLine(sonuc);
            sw.Close();

            return sonuc;
        }

        //  Matrisin transpozunu alan metot
        private static int[,] TranspozAl(int[,] matris , int boyut)
        {
            // Sonucu tutan matris
            int[,] sonucMatris = new int[boyut, boyut];

            //  For döngüsüyle matrisin elemanları gezilir. satır sütun dönüşümü yapılarak transpoz alınır.
            for (int i = 0; i < boyut; i++)
            {
                for (int j = 0; j < boyut; j++)
                {
                    sonucMatris[j, i] = matris[i, j];
                }
            }

            return sonucMatris;
        }

        //  Matrisin transpozunu alıp text dosyasına yazdıran metot
        public static int[,] TranspozeMatris(int[,] matris1 , int boyut)
        {
            //  İşlemin başlığı dosyaya yazdırılır.
            BaslikTexteYazdir(7);

            //  İstenilen matris TranspozAl metotuyla transpozu alınır.
            int[,] sonucMatris = TranspozAl(matris1 ,boyut);
            
            //  2 matris text dosyasına yazılır.
            MatrisTexteYazdir(matris1,boyut);

            MatrisTexteYazdir(sonucMatris,boyut);

            return sonucMatris;
        }
    }
}

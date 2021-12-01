
namespace b201210009_Ödev2_Soru2
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
            this.YazdirButon = new System.Windows.Forms.Button();
            this.ToplaButon = new System.Windows.Forms.Button();
            this.CarpButon = new System.Windows.Forms.Button();
            this.OkuButon = new System.Windows.Forms.Button();
            this.TersButon = new System.Windows.Forms.Button();
            this.İzButon = new System.Windows.Forms.Button();
            this.TranButon = new System.Windows.Forms.Button();
            this.TextDosyaButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YazdirButon
            // 
            this.YazdirButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(95)))), ((int)(((byte)(116)))));
            this.YazdirButon.FlatAppearance.BorderSize = 0;
            this.YazdirButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YazdirButon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YazdirButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.YazdirButon.Location = new System.Drawing.Point(0, 0);
            this.YazdirButon.Margin = new System.Windows.Forms.Padding(0);
            this.YazdirButon.Name = "YazdirButon";
            this.YazdirButon.Size = new System.Drawing.Size(200, 200);
            this.YazdirButon.TabIndex = 0;
            this.YazdirButon.Text = "MATRİS YAZDIRMA";
            this.YazdirButon.UseVisualStyleBackColor = false;
            this.YazdirButon.Click += new System.EventHandler(this.YazdirButon_Click);
            // 
            // ToplaButon
            // 
            this.ToplaButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ToplaButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ToplaButon.FlatAppearance.BorderSize = 0;
            this.ToplaButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToplaButon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplaButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(95)))), ((int)(((byte)(116)))));
            this.ToplaButon.Location = new System.Drawing.Point(200, 0);
            this.ToplaButon.Margin = new System.Windows.Forms.Padding(0);
            this.ToplaButon.Name = "ToplaButon";
            this.ToplaButon.Size = new System.Drawing.Size(200, 200);
            this.ToplaButon.TabIndex = 0;
            this.ToplaButon.Text = "MATRİS TOPLAMA";
            this.ToplaButon.UseVisualStyleBackColor = false;
            this.ToplaButon.Click += new System.EventHandler(this.ToplaButon_Click);
            // 
            // CarpButon
            // 
            this.CarpButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(95)))), ((int)(((byte)(116)))));
            this.CarpButon.FlatAppearance.BorderSize = 0;
            this.CarpButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarpButon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CarpButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CarpButon.Location = new System.Drawing.Point(400, 0);
            this.CarpButon.Margin = new System.Windows.Forms.Padding(0);
            this.CarpButon.Name = "CarpButon";
            this.CarpButon.Size = new System.Drawing.Size(200, 200);
            this.CarpButon.TabIndex = 0;
            this.CarpButon.Text = "MATRİS ÇARPMA";
            this.CarpButon.UseVisualStyleBackColor = false;
            this.CarpButon.Click += new System.EventHandler(this.CarpButon_Click);
            // 
            // OkuButon
            // 
            this.OkuButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.OkuButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OkuButon.FlatAppearance.BorderSize = 0;
            this.OkuButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkuButon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OkuButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(95)))), ((int)(((byte)(116)))));
            this.OkuButon.Location = new System.Drawing.Point(600, 0);
            this.OkuButon.Margin = new System.Windows.Forms.Padding(0);
            this.OkuButon.Name = "OkuButon";
            this.OkuButon.Size = new System.Drawing.Size(200, 200);
            this.OkuButon.TabIndex = 0;
            this.OkuButon.Text = "MATRİS OKUMA";
            this.OkuButon.UseVisualStyleBackColor = false;
            this.OkuButon.Click += new System.EventHandler(this.OkuButon_Click);
            // 
            // TersButon
            // 
            this.TersButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TersButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TersButon.FlatAppearance.BorderSize = 0;
            this.TersButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TersButon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TersButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(95)))), ((int)(((byte)(116)))));
            this.TersButon.Location = new System.Drawing.Point(0, 200);
            this.TersButon.Margin = new System.Windows.Forms.Padding(0);
            this.TersButon.Name = "TersButon";
            this.TersButon.Size = new System.Drawing.Size(200, 200);
            this.TersButon.TabIndex = 0;
            this.TersButon.Text = "MATRİS TERSİ ALMA";
            this.TersButon.UseVisualStyleBackColor = false;
            this.TersButon.Click += new System.EventHandler(this.TersButon_Click);
            // 
            // İzButon
            // 
            this.İzButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(95)))), ((int)(((byte)(116)))));
            this.İzButon.FlatAppearance.BorderSize = 0;
            this.İzButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.İzButon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İzButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.İzButon.Location = new System.Drawing.Point(200, 200);
            this.İzButon.Margin = new System.Windows.Forms.Padding(0);
            this.İzButon.Name = "İzButon";
            this.İzButon.Size = new System.Drawing.Size(200, 200);
            this.İzButon.TabIndex = 0;
            this.İzButon.Text = "MATRİS İZİ BULMA";
            this.İzButon.UseVisualStyleBackColor = false;
            this.İzButon.Click += new System.EventHandler(this.İzButon_Click);
            // 
            // TranButon
            // 
            this.TranButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TranButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TranButon.FlatAppearance.BorderSize = 0;
            this.TranButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TranButon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TranButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(95)))), ((int)(((byte)(116)))));
            this.TranButon.Location = new System.Drawing.Point(400, 200);
            this.TranButon.Margin = new System.Windows.Forms.Padding(0);
            this.TranButon.Name = "TranButon";
            this.TranButon.Size = new System.Drawing.Size(200, 200);
            this.TranButon.TabIndex = 0;
            this.TranButon.Text = "MATRİS TRANSPOZE";
            this.TranButon.UseVisualStyleBackColor = false;
            this.TranButon.Click += new System.EventHandler(this.TranButon_Click);
            // 
            // TextDosyaButon
            // 
            this.TextDosyaButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(95)))), ((int)(((byte)(116)))));
            this.TextDosyaButon.FlatAppearance.BorderSize = 0;
            this.TextDosyaButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextDosyaButon.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextDosyaButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.TextDosyaButon.Location = new System.Drawing.Point(600, 200);
            this.TextDosyaButon.Margin = new System.Windows.Forms.Padding(0);
            this.TextDosyaButon.Name = "TextDosyaButon";
            this.TextDosyaButon.Size = new System.Drawing.Size(200, 200);
            this.TextDosyaButon.TabIndex = 0;
            this.TextDosyaButon.Text = "TEXT DOSYASI GÖRÜNTÜLEME";
            this.TextDosyaButon.UseVisualStyleBackColor = false;
            this.TextDosyaButon.Click += new System.EventHandler(this.TextDosyaButon_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.TextDosyaButon);
            this.Controls.Add(this.OkuButon);
            this.Controls.Add(this.TranButon);
            this.Controls.Add(this.CarpButon);
            this.Controls.Add(this.İzButon);
            this.Controls.Add(this.TersButon);
            this.Controls.Add(this.ToplaButon);
            this.Controls.Add(this.YazdirButon);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "MATRİS İŞLEMLERİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YazdirButon;
        private System.Windows.Forms.Button ToplaButon;
        private System.Windows.Forms.Button CarpButon;
        private System.Windows.Forms.Button OkuButon;
        private System.Windows.Forms.Button TersButon;
        private System.Windows.Forms.Button İzButon;
        private System.Windows.Forms.Button TranButon;
        private System.Windows.Forms.Button TextDosyaButon;
    }
}


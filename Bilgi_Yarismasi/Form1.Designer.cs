namespace Bilgi_Yarismasi
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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.BTNA = new System.Windows.Forms.Button();
            this.BTNB = new System.Windows.Forms.Button();
            this.BTNC = new System.Windows.Forms.Button();
            this.BTND = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSoruNo = new System.Windows.Forms.Label();
            this.labelDogrusayisi = new System.Windows.Forms.Label();
            this.labelyanlissayisi = new System.Windows.Forms.Label();
            this.BTNSonraki = new System.Windows.Forms.Button();
            this.picturureBoxDogru = new System.Windows.Forms.PictureBox();
            this.pictureBoxYanlis = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturureBoxDogru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYanlis)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(1, 1);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(570, 173);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // BTNA
            // 
            this.BTNA.Location = new System.Drawing.Point(1, 170);
            this.BTNA.Name = "BTNA";
            this.BTNA.Size = new System.Drawing.Size(275, 57);
            this.BTNA.TabIndex = 2;
            this.BTNA.Text = "A";
            this.BTNA.UseVisualStyleBackColor = true;
            this.BTNA.Click += new System.EventHandler(this.BTNA_Click);
            // 
            // BTNB
            // 
            this.BTNB.Location = new System.Drawing.Point(273, 170);
            this.BTNB.Name = "BTNB";
            this.BTNB.Size = new System.Drawing.Size(298, 57);
            this.BTNB.TabIndex = 3;
            this.BTNB.Text = "B";
            this.BTNB.UseVisualStyleBackColor = true;
            this.BTNB.Click += new System.EventHandler(this.BTNB_Click);
            // 
            // BTNC
            // 
            this.BTNC.Location = new System.Drawing.Point(1, 233);
            this.BTNC.Name = "BTNC";
            this.BTNC.Size = new System.Drawing.Size(286, 57);
            this.BTNC.TabIndex = 4;
            this.BTNC.Text = "C";
            this.BTNC.UseVisualStyleBackColor = true;
            this.BTNC.Click += new System.EventHandler(this.BTNC_Click);
            // 
            // BTND
            // 
            this.BTND.Location = new System.Drawing.Point(273, 233);
            this.BTND.Name = "BTND";
            this.BTND.Size = new System.Drawing.Size(298, 57);
            this.BTND.TabIndex = 5;
            this.BTND.Text = "D";
            this.BTND.UseVisualStyleBackColor = true;
            this.BTND.Click += new System.EventHandler(this.BTND_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Soru Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dogru Sayisi:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yanlis Sayisi:";
            // 
            // labelSoruNo
            // 
            this.labelSoruNo.AutoSize = true;
            this.labelSoruNo.Location = new System.Drawing.Point(773, 4);
            this.labelSoruNo.Name = "labelSoruNo";
            this.labelSoruNo.Size = new System.Drawing.Size(29, 31);
            this.labelSoruNo.TabIndex = 9;
            this.labelSoruNo.Text = "0";
            // 
            // labelDogrusayisi
            // 
            this.labelDogrusayisi.AutoSize = true;
            this.labelDogrusayisi.Location = new System.Drawing.Point(773, 35);
            this.labelDogrusayisi.Name = "labelDogrusayisi";
            this.labelDogrusayisi.Size = new System.Drawing.Size(29, 31);
            this.labelDogrusayisi.TabIndex = 10;
            this.labelDogrusayisi.Text = "0";
            // 
            // labelyanlissayisi
            // 
            this.labelyanlissayisi.AutoSize = true;
            this.labelyanlissayisi.Location = new System.Drawing.Point(773, 76);
            this.labelyanlissayisi.Name = "labelyanlissayisi";
            this.labelyanlissayisi.Size = new System.Drawing.Size(29, 31);
            this.labelyanlissayisi.TabIndex = 11;
            this.labelyanlissayisi.Text = "0";
            // 
            // BTNSonraki
            // 
            this.BTNSonraki.Location = new System.Drawing.Point(597, 117);
            this.BTNSonraki.Name = "BTNSonraki";
            this.BTNSonraki.Size = new System.Drawing.Size(232, 57);
            this.BTNSonraki.TabIndex = 12;
            this.BTNSonraki.Text = "Sonraki:";
            this.BTNSonraki.UseVisualStyleBackColor = true;
            this.BTNSonraki.Click += new System.EventHandler(this.BTNSonraki_Click);
            // 
            // picturureBoxDogru
            // 
            this.picturureBoxDogru.Image = ((System.Drawing.Image)(resources.GetObject("picturureBoxDogru.Image")));
            this.picturureBoxDogru.Location = new System.Drawing.Point(597, 204);
            this.picturureBoxDogru.Name = "picturureBoxDogru";
            this.picturureBoxDogru.Size = new System.Drawing.Size(130, 86);
            this.picturureBoxDogru.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturureBoxDogru.TabIndex = 13;
            this.picturureBoxDogru.TabStop = false;
            this.picturureBoxDogru.Visible = false;
            // 
            // pictureBoxYanlis
            // 
            this.pictureBoxYanlis.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxYanlis.Image")));
            this.pictureBoxYanlis.Location = new System.Drawing.Point(744, 204);
            this.pictureBoxYanlis.Name = "pictureBoxYanlis";
            this.pictureBoxYanlis.Size = new System.Drawing.Size(118, 86);
            this.pictureBoxYanlis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxYanlis.TabIndex = 14;
            this.pictureBoxYanlis.TabStop = false;
            this.pictureBoxYanlis.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(888, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxYanlis);
            this.Controls.Add(this.picturureBoxDogru);
            this.Controls.Add(this.BTNSonraki);
            this.Controls.Add(this.labelyanlissayisi);
            this.Controls.Add(this.labelDogrusayisi);
            this.Controls.Add(this.labelSoruNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTND);
            this.Controls.Add(this.BTNC);
            this.Controls.Add(this.BTNB);
            this.Controls.Add(this.BTNA);
            this.Controls.Add(this.richTextBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Online_Sınav_Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.picturureBoxDogru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYanlis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button BTNA;
        private System.Windows.Forms.Button BTNB;
        private System.Windows.Forms.Button BTNC;
        private System.Windows.Forms.Button BTND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSoruNo;
        private System.Windows.Forms.Label labelDogrusayisi;
        private System.Windows.Forms.Label labelyanlissayisi;
        private System.Windows.Forms.Button BTNSonraki;
        private System.Windows.Forms.PictureBox picturureBoxDogru;
        private System.Windows.Forms.PictureBox pictureBoxYanlis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


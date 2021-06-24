namespace Kafe_Restorant_Yonetim_Sistemi
{
    partial class frmUrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUrunGoster = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBildirim = new System.Windows.Forms.Label();
            this.btnGrupEkle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.comboGrup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUrunGozat = new System.Windows.Forms.Button();
            this.lblGozat = new System.Windows.Forms.Label();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUrunGoster);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblBildirim);
            this.groupBox1.Controls.Add(this.btnGrupEkle);
            this.groupBox1.Controls.Add(this.btnUrunEkle);
            this.groupBox1.Controls.Add(this.comboGrup);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnUrunGozat);
            this.groupBox1.Controls.Add(this.lblGozat);
            this.groupBox1.Controls.Add(this.txtUrunFiyati);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünün";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUrunGoster
            // 
            this.btnUrunGoster.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunGoster.Image")));
            this.btnUrunGoster.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunGoster.Location = new System.Drawing.Point(371, 212);
            this.btnUrunGoster.Name = "btnUrunGoster";
            this.btnUrunGoster.Size = new System.Drawing.Size(150, 40);
            this.btnUrunGoster.TabIndex = 6;
            this.btnUrunGoster.Text = "Ürünleri Göster";
            this.btnUrunGoster.UseVisualStyleBackColor = true;
            this.btnUrunGoster.Click += new System.EventHandler(this.btnUrunGoster_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(255, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "₺";
            // 
            // lblBildirim
            // 
            this.lblBildirim.AutoSize = true;
            this.lblBildirim.Location = new System.Drawing.Point(12, 187);
            this.lblBildirim.Name = "lblBildirim";
            this.lblBildirim.Size = new System.Drawing.Size(0, 21);
            this.lblBildirim.TabIndex = 13;
            // 
            // btnGrupEkle
            // 
            this.btnGrupEkle.Location = new System.Drawing.Point(276, 84);
            this.btnGrupEkle.Name = "btnGrupEkle";
            this.btnGrupEkle.Size = new System.Drawing.Size(87, 24);
            this.btnGrupEkle.TabIndex = 3;
            this.btnGrupEkle.Text = "Grup Ekle";
            this.btnGrupEkle.UseVisualStyleBackColor = true;
            this.btnGrupEkle.Click += new System.EventHandler(this.btnGrupEkle_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.Image")));
            this.btnUrunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunEkle.Location = new System.Drawing.Point(371, 166);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(150, 40);
            this.btnUrunEkle.TabIndex = 5;
            this.btnUrunEkle.Text = "Ürünü Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // comboGrup
            // 
            this.comboGrup.BackColor = System.Drawing.Color.White;
            this.comboGrup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrup.FormattingEnabled = true;
            this.comboGrup.Location = new System.Drawing.Point(100, 84);
            this.comboGrup.Name = "comboGrup";
            this.comboGrup.Size = new System.Drawing.Size(150, 27);
            this.comboGrup.TabIndex = 2;
            this.comboGrup.SelectedIndexChanged += new System.EventHandler(this.comboGrup_SelectedIndexChanged);
            this.comboGrup.Click += new System.EventHandler(this.comboGrup_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Grubu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ürünün Görünümü";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(393, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnUrunGozat
            // 
            this.btnUrunGozat.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunGozat.Image")));
            this.btnUrunGozat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunGozat.Location = new System.Drawing.Point(100, 140);
            this.btnUrunGozat.Name = "btnUrunGozat";
            this.btnUrunGozat.Size = new System.Drawing.Size(100, 40);
            this.btnUrunGozat.TabIndex = 4;
            this.btnUrunGozat.Text = "Gözat";
            this.btnUrunGozat.UseVisualStyleBackColor = true;
            this.btnUrunGozat.Click += new System.EventHandler(this.btnUrunGozat_Click);
            // 
            // lblGozat
            // 
            this.lblGozat.Location = new System.Drawing.Point(98, 118);
            this.lblGozat.Name = "lblGozat";
            this.lblGozat.Size = new System.Drawing.Size(206, 19);
            this.lblGozat.TabIndex = 5;
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.Location = new System.Drawing.Point(100, 55);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(149, 27);
            this.txtUrunFiyati.TabIndex = 1;
            this.txtUrunFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUrunFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunFiyati_KeyPress);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUrunAdi.Location = new System.Drawing.Point(100, 26);
            this.txtUrunAdi.MaxLength = 50;
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(149, 27);
            this.txtUrunAdi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resim Yolu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatı :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 260);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.frmUrunEkle_Load);
            this.Resize += new System.EventHandler(this.frmUrunEkle_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.ComboBox comboGrup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUrunGozat;
        private System.Windows.Forms.Label lblGozat;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGrupEkle;
        private System.Windows.Forms.Label lblBildirim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUrunGoster;
    }
}
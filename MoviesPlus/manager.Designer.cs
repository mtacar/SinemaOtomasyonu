namespace BookMyshow
{
    partial class manager
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
            this.moviebox = new System.Windows.Forms.ComboBox();
            this.tnametxt = new System.Windows.Forms.TextBox();
            this.tnamebox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rptxt = new System.Windows.Forms.TextBox();
            this.pptxt = new System.Windows.Forms.TextBox();
            this.sptxt = new System.Windows.Forms.TextBox();
            this.tsidlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.resetbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moviebox
            // 
            this.moviebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moviebox.FormattingEnabled = true;
            this.moviebox.Location = new System.Drawing.Point(195, 148);
            this.moviebox.Margin = new System.Windows.Forms.Padding(4);
            this.moviebox.Name = "moviebox";
            this.moviebox.Size = new System.Drawing.Size(303, 24);
            this.moviebox.TabIndex = 1;
            // 
            // tnametxt
            // 
            this.tnametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tnametxt.Location = new System.Drawing.Point(195, 368);
            this.tnametxt.Margin = new System.Windows.Forms.Padding(4);
            this.tnametxt.Name = "tnametxt";
            this.tnametxt.Size = new System.Drawing.Size(303, 22);
            this.tnametxt.TabIndex = 4;
            this.tnametxt.TextChanged += new System.EventHandler(this.tnametxt_TextChanged);
            // 
            // tnamebox
            // 
            this.tnamebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tnamebox.FormattingEnabled = true;
            this.tnamebox.Location = new System.Drawing.Point(195, 294);
            this.tnamebox.Margin = new System.Windows.Forms.Padding(4);
            this.tnamebox.Name = "tnamebox";
            this.tnamebox.Size = new System.Drawing.Size(303, 24);
            this.tnamebox.TabIndex = 3;
            this.tnamebox.SelectedIndexChanged += new System.EventHandler(this.tnamebox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 332);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "ya da";
            // 
            // rptxt
            // 
            this.rptxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rptxt.Location = new System.Drawing.Point(660, 298);
            this.rptxt.Margin = new System.Windows.Forms.Padding(4);
            this.rptxt.Name = "rptxt";
            this.rptxt.Size = new System.Drawing.Size(303, 22);
            this.rptxt.TabIndex = 8;
            // 
            // pptxt
            // 
            this.pptxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pptxt.Location = new System.Drawing.Point(660, 224);
            this.pptxt.Margin = new System.Windows.Forms.Padding(4);
            this.pptxt.Name = "pptxt";
            this.pptxt.Size = new System.Drawing.Size(303, 22);
            this.pptxt.TabIndex = 7;
            // 
            // sptxt
            // 
            this.sptxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sptxt.Location = new System.Drawing.Point(660, 150);
            this.sptxt.Margin = new System.Windows.Forms.Padding(4);
            this.sptxt.Name = "sptxt";
            this.sptxt.Size = new System.Drawing.Size(303, 22);
            this.sptxt.TabIndex = 6;
            // 
            // tsidlbl
            // 
            this.tsidlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tsidlbl.AutoSize = true;
            this.tsidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsidlbl.ForeColor = System.Drawing.Color.Red;
            this.tsidlbl.Location = new System.Drawing.Point(659, 375);
            this.tsidlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tsidlbl.Name = "tsidlbl";
            this.tsidlbl.Size = new System.Drawing.Size(45, 20);
            this.tsidlbl.TabIndex = 0;
            this.tsidlbl.Text = "ts_id";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(37, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Film Seç:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(536, 373);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ts_id is :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(536, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Arka K. Fiyat :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(536, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Orta K. Fiyat :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(531, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ön K. Fiyat :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(37, 443);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Saat:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(37, 295);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sinema Seç :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(37, 222);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tarih Seç:";
            // 
            // addbtn
            // 
            this.addbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbtn.Location = new System.Drawing.Point(823, 558);
            this.addbtn.Margin = new System.Windows.Forms.Padding(4);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(141, 33);
            this.addbtn.TabIndex = 9;
            this.addbtn.Text = "EKLE";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(656, 447);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(315, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "* Tüm Alanların Doldurulması Zorunludur.";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(195, 220);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(303, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(195, 442);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(303, 22);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.Value = new System.DateTime(2017, 6, 9, 21, 30, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // resetbtn
            // 
            this.resetbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetbtn.Location = new System.Drawing.Point(864, 62);
            this.resetbtn.Margin = new System.Windows.Forms.Padding(4);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(100, 28);
            this.resetbtn.TabIndex = 11;
            this.resetbtn.Text = "Sıfırla";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1005, 697);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tsidlbl);
            this.Controls.Add(this.sptxt);
            this.Controls.Add(this.pptxt);
            this.Controls.Add(this.rptxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tnamebox);
            this.Controls.Add(this.tnametxt);
            this.Controls.Add(this.moviebox);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "manager";
            this.Text = "manager";
            this.Load += new System.EventHandler(this.manager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox moviebox;
        private System.Windows.Forms.TextBox tnametxt;
        private System.Windows.Forms.ComboBox tnamebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rptxt;
        private System.Windows.Forms.TextBox pptxt;
        private System.Windows.Forms.TextBox sptxt;
        private System.Windows.Forms.Label tsidlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button resetbtn;
    }
}
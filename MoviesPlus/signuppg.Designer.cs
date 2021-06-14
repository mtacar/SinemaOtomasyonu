namespace BookMyshow
{
    partial class signuppg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signuppg));
            this.loggrbx = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cpwdlbl = new System.Windows.Forms.Label();
            this.cpwdtxt = new System.Windows.Forms.TextBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.signinbtn = new System.Windows.Forms.Button();
            this.pwdtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.pwdbtn = new System.Windows.Forms.Label();
            this.userbtn = new System.Windows.Forms.Label();
            this.loggrbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // loggrbx
            // 
            this.loggrbx.BackColor = System.Drawing.Color.Transparent;
            this.loggrbx.Controls.Add(this.button1);
            this.loggrbx.Controls.Add(this.cpwdlbl);
            this.loggrbx.Controls.Add(this.cpwdtxt);
            this.loggrbx.Controls.Add(this.registerbtn);
            this.loggrbx.Controls.Add(this.signinbtn);
            this.loggrbx.Controls.Add(this.pwdtxt);
            this.loggrbx.Controls.Add(this.usertxt);
            this.loggrbx.Controls.Add(this.pwdbtn);
            this.loggrbx.Controls.Add(this.userbtn);
            this.loggrbx.Location = new System.Drawing.Point(4, 5);
            this.loggrbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loggrbx.Name = "loggrbx";
            this.loggrbx.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loggrbx.Size = new System.Drawing.Size(783, 438);
            this.loggrbx.TabIndex = 0;
            this.loggrbx.TabStop = false;
            this.loggrbx.Enter += new System.EventHandler(this.loggrbx_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(748, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 22);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cpwdlbl
            // 
            this.cpwdlbl.AutoSize = true;
            this.cpwdlbl.BackColor = System.Drawing.Color.Transparent;
            this.cpwdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpwdlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cpwdlbl.Location = new System.Drawing.Point(70, 196);
            this.cpwdlbl.Name = "cpwdlbl";
            this.cpwdlbl.Size = new System.Drawing.Size(230, 29);
            this.cpwdlbl.TabIndex = 0;
            this.cpwdlbl.Text = "Şifreyi Tekrar Girin:";
            // 
            // cpwdtxt
            // 
            this.cpwdtxt.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cpwdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpwdtxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.cpwdtxt.Location = new System.Drawing.Point(427, 196);
            this.cpwdtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cpwdtxt.Name = "cpwdtxt";
            this.cpwdtxt.PasswordChar = '*';
            this.cpwdtxt.Size = new System.Drawing.Size(313, 36);
            this.cpwdtxt.TabIndex = 3;
            this.cpwdtxt.TextChanged += new System.EventHandler(this.cpwdtxt_TextChanged);
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.Color.Black;
            this.registerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.registerbtn.Location = new System.Drawing.Point(565, 257);
            this.registerbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(176, 41);
            this.registerbtn.TabIndex = 4;
            this.registerbtn.Text = "Kaydol";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // signinbtn
            // 
            this.signinbtn.BackColor = System.Drawing.Color.Black;
            this.signinbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signinbtn.Location = new System.Drawing.Point(587, 330);
            this.signinbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(155, 41);
            this.signinbtn.TabIndex = 5;
            this.signinbtn.Text = "Giriş Yap";
            this.signinbtn.UseVisualStyleBackColor = false;
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // pwdtxt
            // 
            this.pwdtxt.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pwdtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdtxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.pwdtxt.Location = new System.Drawing.Point(427, 132);
            this.pwdtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.PasswordChar = '*';
            this.pwdtxt.Size = new System.Drawing.Size(313, 36);
            this.pwdtxt.TabIndex = 2;
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.usertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.usertxt.Location = new System.Drawing.Point(427, 73);
            this.usertxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(313, 36);
            this.usertxt.TabIndex = 1;
            this.usertxt.Tag = "";
            // 
            // pwdbtn
            // 
            this.pwdbtn.AutoSize = true;
            this.pwdbtn.BackColor = System.Drawing.Color.Transparent;
            this.pwdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pwdbtn.Location = new System.Drawing.Point(221, 132);
            this.pwdbtn.Name = "pwdbtn";
            this.pwdbtn.Size = new System.Drawing.Size(72, 29);
            this.pwdbtn.TabIndex = 0;
            this.pwdbtn.Text = "Şifre:";
            // 
            // userbtn
            // 
            this.userbtn.AutoSize = true;
            this.userbtn.BackColor = System.Drawing.Color.Transparent;
            this.userbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userbtn.Location = new System.Drawing.Point(133, 73);
            this.userbtn.Name = "userbtn";
            this.userbtn.Size = new System.Drawing.Size(160, 29);
            this.userbtn.TabIndex = 0;
            this.userbtn.Text = "Kullanıcı Adı:";
            // 
            // signuppg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.loggrbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "signuppg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.signuppg_Load);
            this.loggrbx.ResumeLayout(false);
            this.loggrbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loggrbx;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Button signinbtn;
        private System.Windows.Forms.TextBox pwdtxt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Label pwdbtn;
        private System.Windows.Forms.Label userbtn;
        private System.Windows.Forms.Label cpwdlbl;
        private System.Windows.Forms.TextBox cpwdtxt;
        private System.Windows.Forms.Button button1;
    }
}


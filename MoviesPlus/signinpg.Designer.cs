namespace BookMyshow
{
    partial class signinpg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signinpg));
            this.loggrbx = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.registerbtnr = new System.Windows.Forms.Button();
            this.signuplblr = new System.Windows.Forms.Label();
            this.signinbtnr = new System.Windows.Forms.Button();
            this.pwdtxtr = new System.Windows.Forms.TextBox();
            this.usertxtr = new System.Windows.Forms.TextBox();
            this.pwdbtnr = new System.Windows.Forms.Label();
            this.userbtnr = new System.Windows.Forms.Label();
            this.loggrbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // loggrbx
            // 
            this.loggrbx.BackColor = System.Drawing.Color.Transparent;
            this.loggrbx.Controls.Add(this.button1);
            this.loggrbx.Controls.Add(this.registerbtnr);
            this.loggrbx.Controls.Add(this.signuplblr);
            this.loggrbx.Controls.Add(this.signinbtnr);
            this.loggrbx.Controls.Add(this.pwdtxtr);
            this.loggrbx.Controls.Add(this.usertxtr);
            this.loggrbx.Controls.Add(this.pwdbtnr);
            this.loggrbx.Controls.Add(this.userbtnr);
            resources.ApplyResources(this.loggrbx, "loggrbx");
            this.loggrbx.Name = "loggrbx";
            this.loggrbx.TabStop = false;
            this.loggrbx.Enter += new System.EventHandler(this.loggrbx_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerbtnr
            // 
            this.registerbtnr.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.registerbtnr, "registerbtnr");
            this.registerbtnr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registerbtnr.Name = "registerbtnr";
            this.registerbtnr.UseVisualStyleBackColor = false;
            this.registerbtnr.Click += new System.EventHandler(this.registerbtnr_Click);
            // 
            // signuplblr
            // 
            resources.ApplyResources(this.signuplblr, "signuplblr");
            this.signuplblr.BackColor = System.Drawing.Color.Transparent;
            this.signuplblr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signuplblr.Name = "signuplblr";
            this.signuplblr.Click += new System.EventHandler(this.signuplblr_Click);
            // 
            // signinbtnr
            // 
            this.signinbtnr.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.signinbtnr, "signinbtnr");
            this.signinbtnr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signinbtnr.Name = "signinbtnr";
            this.signinbtnr.UseVisualStyleBackColor = false;
            this.signinbtnr.Click += new System.EventHandler(this.signinbtnr_Click);
            // 
            // pwdtxtr
            // 
            this.pwdtxtr.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.pwdtxtr, "pwdtxtr");
            this.pwdtxtr.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.pwdtxtr.Name = "pwdtxtr";
            // 
            // usertxtr
            // 
            this.usertxtr.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.usertxtr, "usertxtr");
            this.usertxtr.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.usertxtr.Name = "usertxtr";
            this.usertxtr.Tag = "";
            // 
            // pwdbtnr
            // 
            resources.ApplyResources(this.pwdbtnr, "pwdbtnr");
            this.pwdbtnr.BackColor = System.Drawing.Color.Transparent;
            this.pwdbtnr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pwdbtnr.Name = "pwdbtnr";
            // 
            // userbtnr
            // 
            resources.ApplyResources(this.userbtnr, "userbtnr");
            this.userbtnr.BackColor = System.Drawing.Color.Transparent;
            this.userbtnr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userbtnr.Name = "userbtnr";
            // 
            // signinpg
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.loggrbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signinpg";
            this.Load += new System.EventHandler(this.signinpg_Load);
            this.loggrbx.ResumeLayout(false);
            this.loggrbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loggrbx;
        private System.Windows.Forms.Button registerbtnr;
        private System.Windows.Forms.Label signuplblr;
        private System.Windows.Forms.Button signinbtnr;
        private System.Windows.Forms.TextBox pwdtxtr;
        private System.Windows.Forms.TextBox usertxtr;
        private System.Windows.Forms.Label pwdbtnr;
        private System.Windows.Forms.Label userbtnr;
        private System.Windows.Forms.Button button1;
    }
}
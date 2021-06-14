namespace BookMyshow
{
    partial class mdihome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdihome));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookedTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRemoveMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMainPicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTheatreInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelBookedTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Black;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.moviesToolStripMenuItem,
            this.bookNowToolStripMenuItem,
            this.bookedTicketsToolStripMenuItem,
            this.manageMoviesToolStripMenuItem,
            this.cancelBookedTicketToolStripMenuItem,
            this.signInToolStripMenuItem,
            this.nameToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(1005, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.homeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.homeToolStripMenuItem.Text = "Ana Sayfa";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.moviesToolStripMenuItem.Text = "Filmler";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.moviesToolStripMenuItem_Click);
            // 
            // bookNowToolStripMenuItem
            // 
            this.bookNowToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookNowToolStripMenuItem.Name = "bookNowToolStripMenuItem";
            this.bookNowToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.bookNowToolStripMenuItem.Text = "Bilet Satın Al";
            this.bookNowToolStripMenuItem.Click += new System.EventHandler(this.bookNowToolStripMenuItem_Click);
            // 
            // bookedTicketsToolStripMenuItem
            // 
            this.bookedTicketsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.bookedTicketsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bookedTicketsToolStripMenuItem.Name = "bookedTicketsToolStripMenuItem";
            this.bookedTicketsToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.bookedTicketsToolStripMenuItem.Text = "Biletlerim";
            this.bookedTicketsToolStripMenuItem.Click += new System.EventHandler(this.bookedTicketsToolStripMenuItem_Click);
            // 
            // manageMoviesToolStripMenuItem
            // 
            this.manageMoviesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.manageMoviesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRemoveMovieToolStripMenuItem,
            this.manageMainPicToolStripMenuItem,
            this.addTheatreInfoToolStripMenuItem});
            this.manageMoviesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.manageMoviesToolStripMenuItem.Name = "manageMoviesToolStripMenuItem";
            this.manageMoviesToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.manageMoviesToolStripMenuItem.Text = "Filmleri Yönet";
            this.manageMoviesToolStripMenuItem.Click += new System.EventHandler(this.manageMoviesToolStripMenuItem_Click);
            // 
            // addRemoveMovieToolStripMenuItem
            // 
            this.addRemoveMovieToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.addRemoveMovieToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.addRemoveMovieToolStripMenuItem.Name = "addRemoveMovieToolStripMenuItem";
            this.addRemoveMovieToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.addRemoveMovieToolStripMenuItem.Text = "Film Ekle/Sil";
            this.addRemoveMovieToolStripMenuItem.Click += new System.EventHandler(this.addRemoveMovieToolStripMenuItem_Click);
            // 
            // manageMainPicToolStripMenuItem
            // 
            this.manageMainPicToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manageMainPicToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.manageMainPicToolStripMenuItem.Name = "manageMainPicToolStripMenuItem";
            this.manageMainPicToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.manageMainPicToolStripMenuItem.Text = "Ana Filmi Yönet";
            this.manageMainPicToolStripMenuItem.Click += new System.EventHandler(this.manageMainPicToolStripMenuItem_Click);
            // 
            // addTheatreInfoToolStripMenuItem
            // 
            this.addTheatreInfoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addTheatreInfoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.addTheatreInfoToolStripMenuItem.Name = "addTheatreInfoToolStripMenuItem";
            this.addTheatreInfoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.addTheatreInfoToolStripMenuItem.Text = "Sinema Bilgisi Ekle";
            this.addTheatreInfoToolStripMenuItem.Click += new System.EventHandler(this.addTheatreInfoToolStripMenuItem_Click);
            // 
            // cancelBookedTicketToolStripMenuItem
            // 
            this.cancelBookedTicketToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelBookedTicketToolStripMenuItem.Name = "cancelBookedTicketToolStripMenuItem";
            this.cancelBookedTicketToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.cancelBookedTicketToolStripMenuItem.Text = "Bilet İptal Et";
            this.cancelBookedTicketToolStripMenuItem.Click += new System.EventHandler(this.cancelBookedTicketToolStripMenuItem_Click);
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.signInToolStripMenuItem.Text = "Giriş Yap";
            this.signInToolStripMenuItem.Click += new System.EventHandler(this.signInToolStripMenuItem_Click);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.nameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Visible = false;
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 711);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1005, 10);
            this.progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 694);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(969, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 22);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // mdihome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 721);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "mdihome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "              Welcome To Movies Plus";
            this.Load += new System.EventHandler(this.mdihome_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRemoveMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMainPicToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelBookedTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTheatreInfoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookedTicketsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}




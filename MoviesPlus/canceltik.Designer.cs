namespace BookMyshow
{
    partial class canceltik
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.walletamt = new System.Windows.Forms.Label();
            this.resetbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox.ForeColor = System.Drawing.Color.White;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(4, 75);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1007, 276);
            this.listBox.TabIndex = 0;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelbtn.ForeColor = System.Drawing.Color.White;
            this.cancelbtn.Location = new System.Drawing.Point(424, 449);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(204, 33);
            this.cancelbtn.TabIndex = 0;
            this.cancelbtn.Text = "Bilet İptal";
            this.cancelbtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 369);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cüzdan:";
            // 
            // walletamt
            // 
            this.walletamt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.walletamt.AutoSize = true;
            this.walletamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletamt.Location = new System.Drawing.Point(97, 369);
            this.walletamt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.walletamt.Name = "walletamt";
            this.walletamt.Size = new System.Drawing.Size(18, 20);
            this.walletamt.TabIndex = 2;
            this.walletamt.Text = "0";
            // 
            // resetbtn
            // 
            this.resetbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetbtn.Location = new System.Drawing.Point(907, 15);
            this.resetbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(100, 28);
            this.resetbtn.TabIndex = 24;
            this.resetbtn.Text = "Yenile";
            this.resetbtn.UseVisualStyleBackColor = false;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // canceltik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1023, 672);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.walletamt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.listBox);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "canceltik";
            this.Text = "canceltik";
            this.Load += new System.EventHandler(this.canceltik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label walletamt;
        private System.Windows.Forms.Button resetbtn;
    }
}
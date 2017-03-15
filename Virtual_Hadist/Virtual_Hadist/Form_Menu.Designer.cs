namespace Virtual_Hadist
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.cmb_bab = new System.Windows.Forms.ComboBox();
            this.rtb_terjemahan = new System.Windows.Forms.RichTextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.cmb_subbab = new System.Windows.Forms.ComboBox();
            this.pb_gambar = new System.Windows.Forms.PictureBox();
            this.rtb_arab = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtb_shahih = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gambar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_bab
            // 
            this.cmb_bab.BackColor = System.Drawing.SystemColors.MenuText;
            this.cmb_bab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_bab.ForeColor = System.Drawing.SystemColors.Window;
            this.cmb_bab.FormattingEnabled = true;
            this.cmb_bab.ItemHeight = 13;
            this.cmb_bab.Location = new System.Drawing.Point(123, 50);
            this.cmb_bab.Name = "cmb_bab";
            this.cmb_bab.Size = new System.Drawing.Size(227, 21);
            this.cmb_bab.TabIndex = 0;
            this.cmb_bab.SelectedIndexChanged += new System.EventHandler(this.cmb_bab_SelectedIndexChanged_1);
            // 
            // rtb_terjemahan
            // 
            this.rtb_terjemahan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtb_terjemahan.Location = new System.Drawing.Point(12, 155);
            this.rtb_terjemahan.Name = "rtb_terjemahan";
            this.rtb_terjemahan.ReadOnly = true;
            this.rtb_terjemahan.Size = new System.Drawing.Size(343, 96);
            this.rtb_terjemahan.TabIndex = 1;
            this.rtb_terjemahan.Text = "";
            this.rtb_terjemahan.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(275, 109);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(194, 109);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 7;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(372, 309);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(251, 45);
            this.axWindowsMediaPlayer1.TabIndex = 13;
            // 
            // cmb_subbab
            // 
            this.cmb_subbab.BackColor = System.Drawing.SystemColors.MenuText;
            this.cmb_subbab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_subbab.ForeColor = System.Drawing.SystemColors.Window;
            this.cmb_subbab.FormattingEnabled = true;
            this.cmb_subbab.ItemHeight = 13;
            this.cmb_subbab.Location = new System.Drawing.Point(123, 77);
            this.cmb_subbab.Name = "cmb_subbab";
            this.cmb_subbab.Size = new System.Drawing.Size(227, 21);
            this.cmb_subbab.TabIndex = 14;
            this.cmb_subbab.SelectedIndexChanged += new System.EventHandler(this.cmb_subbab_SelectedIndexChanged);
            // 
            // pb_gambar
            // 
            this.pb_gambar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_gambar.BackgroundImage")));
            this.pb_gambar.Location = new System.Drawing.Point(372, 12);
            this.pb_gambar.Name = "pb_gambar";
            this.pb_gambar.Size = new System.Drawing.Size(251, 239);
            this.pb_gambar.TabIndex = 16;
            this.pb_gambar.TabStop = false;
            // 
            // rtb_arab
            // 
            this.rtb_arab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtb_arab.Location = new System.Drawing.Point(12, 277);
            this.rtb_arab.Name = "rtb_arab";
            this.rtb_arab.ReadOnly = true;
            this.rtb_arab.Size = new System.Drawing.Size(338, 78);
            this.rtb_arab.TabIndex = 18;
            this.rtb_arab.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 20;
            // 
            // rtb_shahih
            // 
            this.rtb_shahih.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtb_shahih.Location = new System.Drawing.Point(421, 259);
            this.rtb_shahih.Name = "rtb_shahih";
            this.rtb_shahih.ReadOnly = true;
            this.rtb_shahih.Size = new System.Drawing.Size(202, 19);
            this.rtb_shahih.TabIndex = 22;
            this.rtb_shahih.Text = "";
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(635, 366);
            this.Controls.Add(this.rtb_shahih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rtb_arab);
            this.Controls.Add(this.pb_gambar);
            this.Controls.Add(this.cmb_subbab);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.rtb_terjemahan);
            this.Controls.Add(this.cmb_bab);
            this.Name = "Form_Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gambar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_bab;
        private System.Windows.Forms.RichTextBox rtb_terjemahan;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_search;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ComboBox cmb_subbab;
        private System.Windows.Forms.PictureBox pb_gambar;
        private System.Windows.Forms.RichTextBox rtb_arab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtb_shahih;

    }
}


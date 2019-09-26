namespace Media_Player
{
    partial class MediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            this.panel3 = new System.Windows.Forms.Panel();
            this.mp = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Shuffle = new System.Windows.Forms.CheckBox();
            this.repeatallbox = new System.Windows.Forms.CheckBox();
            this.Repeatsongchecbox = new System.Windows.Forms.CheckBox();
            this.plusbutton = new System.Windows.Forms.Button();
            this.minusbutton = new System.Windows.Forms.Button();
            this.prebutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.pausebutton = new System.Windows.Forms.Button();
            this.playbutton = new System.Windows.Forms.Button();
            this.playList = new System.Windows.Forms.ListBox();
            this.Browse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.panel3.Controls.Add(this.mp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(599, 100);
            this.panel3.TabIndex = 2;
            // 
            // mp
            // 
            this.mp.Enabled = true;
            this.mp.Location = new System.Drawing.Point(0, 3);
            this.mp.Name = "mp";
            this.mp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mp.OcxState")));
            this.mp.Size = new System.Drawing.Size(599, 97);
            this.mp.TabIndex = 1;
            this.mp.Enter += new System.EventHandler(this.mp_Enter);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Media_Player.Properties.Resources.music_14_wallpaper_1024x10241;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 399);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(18)))), ((int)(((byte)(95)))));
            this.panel1.BackgroundImage = global::Media_Player.Properties.Resources._10;
            this.panel1.Controls.Add(this.Shuffle);
            this.panel1.Controls.Add(this.repeatallbox);
            this.panel1.Controls.Add(this.Repeatsongchecbox);
            this.panel1.Controls.Add(this.plusbutton);
            this.panel1.Controls.Add(this.minusbutton);
            this.panel1.Controls.Add(this.prebutton);
            this.panel1.Controls.Add(this.nextbutton);
            this.panel1.Controls.Add(this.stopbutton);
            this.panel1.Controls.Add(this.pausebutton);
            this.panel1.Controls.Add(this.playbutton);
            this.panel1.Controls.Add(this.playList);
            this.panel1.Controls.Add(this.Browse);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(599, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 480);
            this.panel1.TabIndex = 0;
            // 
            // Shuffle
            // 
            this.Shuffle.AutoSize = true;
            this.Shuffle.Location = new System.Drawing.Point(153, 231);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(59, 17);
            this.Shuffle.TabIndex = 11;
            this.Shuffle.Text = "Shuffle";
            this.Shuffle.UseVisualStyleBackColor = true;
            this.Shuffle.CheckedChanged += new System.EventHandler(this.Shuffle_CheckedChanged);
            // 
            // repeatallbox
            // 
            this.repeatallbox.AutoSize = true;
            this.repeatallbox.Location = new System.Drawing.Point(153, 208);
            this.repeatallbox.Name = "repeatallbox";
            this.repeatallbox.Size = new System.Drawing.Size(75, 17);
            this.repeatallbox.TabIndex = 3;
            this.repeatallbox.Text = "Repeat All";
            this.repeatallbox.UseVisualStyleBackColor = true;
            this.repeatallbox.CheckedChanged += new System.EventHandler(this.repeatallbox_CheckedChanged);
            // 
            // Repeatsongchecbox
            // 
            this.Repeatsongchecbox.AutoSize = true;
            this.Repeatsongchecbox.Location = new System.Drawing.Point(153, 186);
            this.Repeatsongchecbox.Name = "Repeatsongchecbox";
            this.Repeatsongchecbox.Size = new System.Drawing.Size(89, 17);
            this.Repeatsongchecbox.TabIndex = 10;
            this.Repeatsongchecbox.Text = "Repeat Song";
            this.Repeatsongchecbox.UseVisualStyleBackColor = true;
            this.Repeatsongchecbox.CheckedChanged += new System.EventHandler(this.Repeatsongchecbox_CheckedChanged);
            // 
            // plusbutton
            // 
            this.plusbutton.BackColor = System.Drawing.Color.Transparent;
            this.plusbutton.BackgroundImage = global::Media_Player.Properties.Resources._1497253714_plus_add_blue;
            this.plusbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plusbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plusbutton.Location = new System.Drawing.Point(6, 198);
            this.plusbutton.Name = "plusbutton";
            this.plusbutton.Size = new System.Drawing.Size(35, 35);
            this.plusbutton.TabIndex = 9;
            this.plusbutton.UseVisualStyleBackColor = false;
            this.plusbutton.Click += new System.EventHandler(this.plusbutton_Click);
            // 
            // minusbutton
            // 
            this.minusbutton.BackColor = System.Drawing.Color.Transparent;
            this.minusbutton.BackgroundImage = global::Media_Player.Properties.Resources._1497253719_plus_add_minus;
            this.minusbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minusbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minusbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minusbutton.Location = new System.Drawing.Point(61, 198);
            this.minusbutton.Name = "minusbutton";
            this.minusbutton.Size = new System.Drawing.Size(35, 35);
            this.minusbutton.TabIndex = 8;
            this.minusbutton.UseVisualStyleBackColor = false;
            this.minusbutton.Click += new System.EventHandler(this.minusbutton_Click);
            // 
            // prebutton
            // 
            this.prebutton.BackColor = System.Drawing.Color.Transparent;
            this.prebutton.BackgroundImage = global::Media_Player.Properties.Resources._1497252514_previous_2;
            this.prebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.prebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.prebutton.Location = new System.Drawing.Point(209, 145);
            this.prebutton.Name = "prebutton";
            this.prebutton.Size = new System.Drawing.Size(35, 35);
            this.prebutton.TabIndex = 7;
            this.prebutton.UseVisualStyleBackColor = false;
            this.prebutton.Click += new System.EventHandler(this.prebutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.BackColor = System.Drawing.Color.Transparent;
            this.nextbutton.BackgroundImage = global::Media_Player.Properties.Resources._1497252512_next_2;
            this.nextbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nextbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nextbutton.Location = new System.Drawing.Point(162, 145);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(35, 35);
            this.nextbutton.TabIndex = 6;
            this.nextbutton.UseVisualStyleBackColor = false;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.BackColor = System.Drawing.Color.Transparent;
            this.stopbutton.BackgroundImage = global::Media_Player.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_media_playback_stop;
            this.stopbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stopbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopbutton.Location = new System.Drawing.Point(112, 145);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(35, 35);
            this.stopbutton.TabIndex = 5;
            this.stopbutton.UseVisualStyleBackColor = false;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // pausebutton
            // 
            this.pausebutton.BackColor = System.Drawing.Color.Transparent;
            this.pausebutton.BackgroundImage = global::Media_Player.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_media_playback_pause;
            this.pausebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pausebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pausebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pausebutton.Location = new System.Drawing.Point(61, 145);
            this.pausebutton.Name = "pausebutton";
            this.pausebutton.Size = new System.Drawing.Size(35, 35);
            this.pausebutton.TabIndex = 4;
            this.pausebutton.UseVisualStyleBackColor = false;
            this.pausebutton.Click += new System.EventHandler(this.pausebutton_Click);
            // 
            // playbutton
            // 
            this.playbutton.BackColor = System.Drawing.Color.Transparent;
            this.playbutton.BackgroundImage = global::Media_Player.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_media_playback_start;
            this.playbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playbutton.Location = new System.Drawing.Point(6, 145);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(35, 35);
            this.playbutton.TabIndex = 3;
            this.playbutton.UseVisualStyleBackColor = false;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // playList
            // 
            this.playList.AllowDrop = true;
            this.playList.BackColor = System.Drawing.Color.Gray;
            this.playList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playList.FormattingEnabled = true;
            this.playList.ItemHeight = 20;
            this.playList.Location = new System.Drawing.Point(0, 260);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(246, 220);
            this.playList.TabIndex = 0;
            this.playList.SelectedIndexChanged += new System.EventHandler(this.playList_SelectedIndexChanged);
            this.playList.DoubleClick += new System.EventHandler(this.playList_DoubleClick);
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.Transparent;
            this.Browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Browse.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ForeColor = System.Drawing.Color.Gold;
            this.Browse.Location = new System.Drawing.Point(6, 75);
            this.Browse.Name = "Browse";
            this.Browse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Browse.Size = new System.Drawing.Size(149, 40);
            this.Browse.TabIndex = 3;
            this.Browse.Text = "Browse";
            this.Browse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Media_Player.Properties.Resources.minimize;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(162, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // exit
            // 
            this.exit.BackgroundImage = global::Media_Player.Properties.Resources.gnome_panel_force_quit;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Location = new System.Drawing.Point(200, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(32, 25);
            this.exit.TabIndex = 2;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(843, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.ListBox playList;
        private System.Windows.Forms.Panel panel3;
        private AxWMPLib.AxWindowsMediaPlayer mp;
        private System.Windows.Forms.Button playbutton;
        private System.Windows.Forms.Button pausebutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button prebutton;
        private System.Windows.Forms.Button plusbutton;
        private System.Windows.Forms.Button minusbutton;
        private System.Windows.Forms.CheckBox Repeatsongchecbox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox repeatallbox;
        private System.Windows.Forms.CheckBox Shuffle;
    }
}


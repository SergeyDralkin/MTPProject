namespace WindowsApplication
{
    partial class MainForm
    {
     
        private System.ComponentModel.IContainer components = null;   
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
            this.Track_Balance = new System.Windows.Forms.TrackBar();
            this.Track_Volume = new System.Windows.Forms.TrackBar();
            this.Laber_TimeNow = new System.Windows.Forms.Label();
            this.Laber_TimeAll = new System.Windows.Forms.Label();
            this.r = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.Panel_Video = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Ù‡ÈÎToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BT_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ÓÚÍ˚Ú¸œÎÂÈÎËÒÚToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ÒÓÁ‰‡Ú¸«‡ÍÎ‡‰ÍÛToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer100ms = new System.Windows.Forms.Timer(this.components);
            this.Track_AudioTrack = new ProXoft.WinForms.ScrollBarEnhanced();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_Play = new System.Windows.Forms.Button();
            this.BT_Stop = new System.Windows.Forms.Button();
            this.BT_Pause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Balance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Volume)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Track_Balance
            // 
            this.Track_Balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Track_Balance.Enabled = false;
            this.Track_Balance.Location = new System.Drawing.Point(473, 410);
            this.Track_Balance.Maximum = 20;
            this.Track_Balance.Name = "Track_Balance";
            this.Track_Balance.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Track_Balance.Size = new System.Drawing.Size(45, 59);
            this.Track_Balance.TabIndex = 9;
            this.Track_Balance.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Track_Balance.Value = 10;
            this.Track_Balance.Scroll += new System.EventHandler(this.Track_Balance_Scroll);
            this.Track_Balance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Track_Balance_KeyDown);
            // 
            // Track_Volume
            // 
            this.Track_Volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Track_Volume.Enabled = false;
            this.Track_Volume.Location = new System.Drawing.Point(17, 414);
            this.Track_Volume.Maximum = 100;
            this.Track_Volume.Name = "Track_Volume";
            this.Track_Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Track_Volume.Size = new System.Drawing.Size(45, 59);
            this.Track_Volume.TabIndex = 10;
            this.Track_Volume.Value = 100;
            this.Track_Volume.Scroll += new System.EventHandler(this.Track_Volume_Scroll);
            // 
            // Laber_TimeNow
            // 
            this.Laber_TimeNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Laber_TimeNow.AutoSize = true;
            this.Laber_TimeNow.BackColor = System.Drawing.Color.White;
            this.Laber_TimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Laber_TimeNow.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Laber_TimeNow.Location = new System.Drawing.Point(65, 406);
            this.Laber_TimeNow.Name = "Laber_TimeNow";
            this.Laber_TimeNow.Size = new System.Drawing.Size(39, 13);
            this.Laber_TimeNow.TabIndex = 11;
            this.Laber_TimeNow.Text = "00:00";
            // 
            // Laber_TimeAll
            // 
            this.Laber_TimeAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Laber_TimeAll.AutoSize = true;
            this.Laber_TimeAll.BackColor = System.Drawing.Color.White;
            this.Laber_TimeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Laber_TimeAll.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Laber_TimeAll.Location = new System.Drawing.Point(421, 406);
            this.Laber_TimeAll.Name = "Laber_TimeAll";
            this.Laber_TimeAll.Size = new System.Drawing.Size(39, 13);
            this.Laber_TimeAll.TabIndex = 12;
            this.Laber_TimeAll.Text = "00:00";
            // 
            // r
            // 
            this.r.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.r.AutoSize = true;
            this.r.BackColor = System.Drawing.Color.White;
            this.r.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r.ForeColor = System.Drawing.Color.MidnightBlue;
            this.r.Location = new System.Drawing.Point(471, 402);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(45, 13);
            this.r.TabIndex = 14;
            this.r.Text = "œ‡‚‡ˇ";
            this.r.MouseClick += new System.Windows.Forms.MouseEventHandler(this.r_MouseClick);
            // 
            // l
            // 
            this.l.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l.AutoSize = true;
            this.l.BackColor = System.Drawing.Color.White;
            this.l.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l.ForeColor = System.Drawing.Color.MidnightBlue;
            this.l.Location = new System.Drawing.Point(477, 472);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(39, 13);
            this.l.TabIndex = 15;
            this.l.Text = "ÀÂ‚‡ˇ";
            this.l.Click += new System.EventHandler(this.l_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(14, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "√ÓÏÍÓ";
            // 
            // min
            // 
            this.min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.min.AutoSize = true;
            this.min.BackColor = System.Drawing.Color.White;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.min.ForeColor = System.Drawing.Color.MidnightBlue;
            this.min.Location = new System.Drawing.Point(14, 472);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(31, 13);
            this.min.TabIndex = 17;
            this.min.Text = "“ËıÓ";
            // 
            // Panel_Video
            // 
            this.Panel_Video.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Video.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel_Video.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Video.Location = new System.Drawing.Point(17, 30);
            this.Panel_Video.Name = "Panel_Video";
            this.Panel_Video.Size = new System.Drawing.Size(499, 350);
            this.Panel_Video.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ù‡ÈÎToolStripMenuItem,
            this.ÒÓÁ‰‡Ú¸«‡ÍÎ‡‰ÍÛToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Ù‡ÈÎToolStripMenuItem
            // 
            this.Ù‡ÈÎToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BT_OpenFile,
            this.ÓÚÍ˚Ú¸œÎÂÈÎËÒÚToolStripMenuItem});
            this.Ù‡ÈÎToolStripMenuItem.Name = "Ù‡ÈÎToolStripMenuItem";
            this.Ù‡ÈÎToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.Ù‡ÈÎToolStripMenuItem.Text = "‘‡ÈÎ";
            // 
            // BT_OpenFile
            // 
            this.BT_OpenFile.Name = "BT_OpenFile";
            this.BT_OpenFile.Size = new System.Drawing.Size(176, 22);
            this.BT_OpenFile.Text = "ŒÚÍ˚Ú¸";
            this.BT_OpenFile.Click += new System.EventHandler(this.BT_OpenFile_Click_1);
            // 
            // ÓÚÍ˚Ú¸œÎÂÈÎËÒÚToolStripMenuItem
            // 
            this.ÓÚÍ˚Ú¸œÎÂÈÎËÒÚToolStripMenuItem.Name = "ÓÚÍ˚Ú¸œÎÂÈÎËÒÚToolStripMenuItem";
            this.ÓÚÍ˚Ú¸œÎÂÈÎËÒÚToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ÓÚÍ˚Ú¸œÎÂÈÎËÒÚToolStripMenuItem.Text = "ŒÚÍ˚Ú¸ ÔÎÂÈÎËÒÚ";
            this.ÓÚÍ˚Ú¸œÎÂÈÎËÒÚToolStripMenuItem.Click += new System.EventHandler(this.ÓÚÍ˚Ú¸œÎÂÈÎËÒÚToolStripMenuItem_Click);
            // 
            // ÒÓÁ‰‡Ú¸«‡ÍÎ‡‰ÍÛToolStripMenuItem
            // 
            this.ÒÓÁ‰‡Ú¸«‡ÍÎ‡‰ÍÛToolStripMenuItem.Name = "ÒÓÁ‰‡Ú¸«‡ÍÎ‡‰ÍÛToolStripMenuItem";
            this.ÒÓÁ‰‡Ú¸«‡ÍÎ‡‰ÍÛToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.ÒÓÁ‰‡Ú¸«‡ÍÎ‡‰ÍÛToolStripMenuItem.Text = "—ÓÁ‰‡Ú¸ Á‡ÍÎ‡‰ÍÛ";
            this.ÒÓÁ‰‡Ú¸«‡ÍÎ‡‰ÍÛToolStripMenuItem.Click += new System.EventHandler(this.ÒÓÁ‰‡Ú¸«‡ÍÎ‡‰ÍÛToolStripMenuItem_Click);
            // 
            // Timer100ms
            // 
            this.Timer100ms.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Track_AudioTrack
            // 
            this.Track_AudioTrack.AutoSize = true;
            this.Track_AudioTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Track_AudioTrack.Enabled = false;
            this.Track_AudioTrack.LargeChange = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Track_AudioTrack.Location = new System.Drawing.Point(0, 0);
            this.Track_AudioTrack.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
            this.Track_AudioTrack.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Track_AudioTrack.MaximumSize = new System.Drawing.Size(0, 17);
            this.Track_AudioTrack.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Track_AudioTrack.MinimumSize = new System.Drawing.Size(51, 0);
            this.Track_AudioTrack.Name = "Track_AudioTrack";
            this.Track_AudioTrack.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Track_AudioTrack.Size = new System.Drawing.Size(305, 17);
            this.Track_AudioTrack.SmallChange = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Track_AudioTrack.TabIndex = 21;
            this.Track_AudioTrack.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.Track_AudioTrack.MouseClick += new System.EventHandler<ProXoft.WinForms.EnhancedMouseEventArgs>(this.Track_AudioTreck_MouseClick);
            this.Track_AudioTrack.Scroll += new System.EventHandler<ProXoft.WinForms.EnhancedScrollEventArgs>(this.Track_AudioTreck_Scroll);
            this.Track_AudioTrack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Track_AudioTreck_MouseDown);
            this.Track_AudioTrack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Track_AudioTreck_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Track_AudioTrack);
            this.panel1.Location = new System.Drawing.Point(110, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 30);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.BT_Play);
            this.panel2.Controls.Add(this.BT_Stop);
            this.panel2.Controls.Add(this.BT_Pause);
            this.panel2.Location = new System.Drawing.Point(51, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 31);
            this.panel2.TabIndex = 21;
            // 
            // BT_Play
            // 
            this.BT_Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_Play.BackColor = System.Drawing.Color.Teal;
            this.BT_Play.Enabled = false;
            this.BT_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Play.ForeColor = System.Drawing.Color.White;
            this.BT_Play.Location = new System.Drawing.Point(107, -4);
            this.BT_Play.Name = "BT_Play";
            this.BT_Play.Size = new System.Drawing.Size(59, 30);
            this.BT_Play.TabIndex = 0;
            this.BT_Play.Text = "œÎÂÈ";
            this.BT_Play.UseVisualStyleBackColor = false;
            this.BT_Play.Click += new System.EventHandler(this.BT_Play_Click);
            // 
            // BT_Stop
            // 
            this.BT_Stop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_Stop.BackColor = System.Drawing.Color.Brown;
            this.BT_Stop.Enabled = false;
            this.BT_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Stop.ForeColor = System.Drawing.Color.White;
            this.BT_Stop.Location = new System.Drawing.Point(244, -4);
            this.BT_Stop.Name = "BT_Stop";
            this.BT_Stop.Size = new System.Drawing.Size(59, 30);
            this.BT_Stop.TabIndex = 3;
            this.BT_Stop.Text = "—ÚÓÔ";
            this.BT_Stop.UseVisualStyleBackColor = false;
            this.BT_Stop.Click += new System.EventHandler(this.BT_Stop_Click);
            // 
            // BT_Pause
            // 
            this.BT_Pause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_Pause.BackColor = System.Drawing.Color.SteelBlue;
            this.BT_Pause.Enabled = false;
            this.BT_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Pause.ForeColor = System.Drawing.Color.White;
            this.BT_Pause.Location = new System.Drawing.Point(172, -4);
            this.BT_Pause.Name = "BT_Pause";
            this.BT_Pause.Size = new System.Drawing.Size(66, 30);
            this.BT_Pause.TabIndex = 1;
            this.BT_Pause.Text = "œ‡ÛÁ‡";
            this.BT_Pause.UseVisualStyleBackColor = false;
            this.BT_Pause.Click += new System.EventHandler(this.BT_Pause_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Laber_TimeNow);
            this.Controls.Add(this.Laber_TimeAll);
            this.Controls.Add(this.Panel_Video);
            this.Controls.Add(this.min);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l);
            this.Controls.Add(this.r);
            this.Controls.Add(this.Track_Volume);
            this.Controls.Add(this.Track_Balance);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(538, 523);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Player";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.Track_Balance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Track_Volume)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar Track_Balance;
        private System.Windows.Forms.TrackBar Track_Volume;
        private System.Windows.Forms.Label Laber_TimeNow;
        private System.Windows.Forms.Label Laber_TimeAll;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Panel Panel_Video;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Ù‡ÈÎToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BT_OpenFile;
        private System.Windows.Forms.Timer Timer100ms;
        private ProXoft.WinForms.ScrollBarEnhanced Track_AudioTrack;
        private System.Windows.Forms.ToolStripMenuItem ÒÓÁ‰‡Ú¸«‡ÍÎ‡‰ÍÛToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ÓÚÍ˚Ú¸œÎÂÈÎËÒÚToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_Play;
        private System.Windows.Forms.Button BT_Stop;
        private System.Windows.Forms.Button BT_Pause;
    }
}


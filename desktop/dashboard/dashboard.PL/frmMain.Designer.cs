namespace dashboard.PL
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlActiveButton = new System.Windows.Forms.Panel();
            this.pbMinimize = new System.Windows.Forms.Button();
            this.pbClose = new System.Windows.Forms.Button();
            this.btnAnnouncement = new System.Windows.Forms.Button();
            this.btnMatches = new System.Windows.Forms.Button();
            this.btnControlPanel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(126)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.pnlActiveButton);
            this.panel1.Controls.Add(this.btnAnnouncement);
            this.panel1.Controls.Add(this.btnMatches);
            this.panel1.Controls.Add(this.btnControlPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 720);
            this.panel1.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMain.Location = new System.Drawing.Point(164, 43);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1116, 677);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(130)))), ((int)(((byte)(118)))));
            this.pnlHeader.Controls.Add(this.pbMinimize);
            this.pnlHeader.Controls.Add(this.pbClose);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(164, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1116, 45);
            this.pnlHeader.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volleyball Electronic Scoreboard";
            // 
            // pnlActiveButton
            // 
            this.pnlActiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(80)))), ((int)(((byte)(134)))));
            this.pnlActiveButton.Location = new System.Drawing.Point(0, 103);
            this.pnlActiveButton.Name = "pnlActiveButton";
            this.pnlActiveButton.Size = new System.Drawing.Size(7, 96);
            this.pnlActiveButton.TabIndex = 3;
            // 
            // pbMinimize
            // 
            this.pbMinimize.BackgroundImage = global::dashboard.PL.Properties.Resources.minimize_tab;
            this.pbMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMinimize.FlatAppearance.BorderSize = 0;
            this.pbMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbMinimize.Location = new System.Drawing.Point(1040, 9);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(29, 28);
            this.pbMinimize.TabIndex = 2;
            this.pbMinimize.UseVisualStyleBackColor = true;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbClose
            // 
            this.pbClose.BackgroundImage = global::dashboard.PL.Properties.Resources.cross_inside_a_square;
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbClose.FlatAppearance.BorderSize = 0;
            this.pbClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbClose.Location = new System.Drawing.Point(1075, 9);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(29, 28);
            this.pbClose.TabIndex = 1;
            this.pbClose.UseVisualStyleBackColor = true;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // btnAnnouncement
            // 
            this.btnAnnouncement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(113)))), ((int)(((byte)(143)))));
            this.btnAnnouncement.FlatAppearance.BorderSize = 0;
            this.btnAnnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnouncement.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnouncement.ForeColor = System.Drawing.Color.White;
            this.btnAnnouncement.Image = global::dashboard.PL.Properties.Resources.megaphone__3_;
            this.btnAnnouncement.Location = new System.Drawing.Point(0, 307);
            this.btnAnnouncement.Name = "btnAnnouncement";
            this.btnAnnouncement.Size = new System.Drawing.Size(164, 96);
            this.btnAnnouncement.TabIndex = 2;
            this.btnAnnouncement.Text = "Announcement";
            this.btnAnnouncement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnnouncement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnnouncement.UseVisualStyleBackColor = false;
            this.btnAnnouncement.Click += new System.EventHandler(this.btnAnnouncement_Click);
            // 
            // btnMatches
            // 
            this.btnMatches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(113)))), ((int)(((byte)(143)))));
            this.btnMatches.FlatAppearance.BorderSize = 0;
            this.btnMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatches.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatches.ForeColor = System.Drawing.Color.White;
            this.btnMatches.Image = global::dashboard.PL.Properties.Resources.volleyball__2_;
            this.btnMatches.Location = new System.Drawing.Point(0, 205);
            this.btnMatches.Name = "btnMatches";
            this.btnMatches.Size = new System.Drawing.Size(164, 96);
            this.btnMatches.TabIndex = 1;
            this.btnMatches.Text = "Matches";
            this.btnMatches.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMatches.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMatches.UseVisualStyleBackColor = false;
            this.btnMatches.Click += new System.EventHandler(this.btnMatches_Click);
            // 
            // btnControlPanel
            // 
            this.btnControlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(113)))), ((int)(((byte)(143)))));
            this.btnControlPanel.FlatAppearance.BorderSize = 0;
            this.btnControlPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlPanel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlPanel.ForeColor = System.Drawing.Color.White;
            this.btnControlPanel.Image = global::dashboard.PL.Properties.Resources.score__1_;
            this.btnControlPanel.Location = new System.Drawing.Point(0, 103);
            this.btnControlPanel.Name = "btnControlPanel";
            this.btnControlPanel.Size = new System.Drawing.Size(164, 96);
            this.btnControlPanel.TabIndex = 0;
            this.btnControlPanel.Text = "Control Panel";
            this.btnControlPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnControlPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnControlPanel.UseVisualStyleBackColor = false;
            this.btnControlPanel.Click += new System.EventHandler(this.btnControlPanel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(65)))), ((int)(((byte)(66)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volleyball Electronic Scoreboard";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnControlPanel;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pbClose;
        private System.Windows.Forms.Button pbMinimize;
        private System.Windows.Forms.Button btnMatches;
        private System.Windows.Forms.Button btnAnnouncement;
        private System.Windows.Forms.Panel pnlActiveButton;
    }
}



namespace Agent_Ace
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.lblAce = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveProgress = new System.Windows.Forms.Button();
            this.btnLoadProgress = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAce
            // 
            this.lblAce.AutoSize = true;
            this.lblAce.BackColor = System.Drawing.Color.Transparent;
            this.lblAce.Font = new System.Drawing.Font("Broadway", 136F, System.Drawing.FontStyle.Bold);
            this.lblAce.ForeColor = System.Drawing.Color.Brown;
            this.lblAce.Location = new System.Drawing.Point(427, 69);
            this.lblAce.Name = "lblAce";
            this.lblAce.Size = new System.Drawing.Size(1065, 206);
            this.lblAce.TabIndex = 0;
            this.lblAce.Text = "Agent Ace";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Black;
            this.btnPlay.Font = new System.Drawing.Font("Comic Sans MS", 80F);
            this.btnPlay.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPlay.Location = new System.Drawing.Point(762, 395);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(395, 175);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.LoadGame);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Black;
            this.btnSettings.Font = new System.Drawing.Font("Comic Sans MS", 80F);
            this.btnSettings.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSettings.Location = new System.Drawing.Point(589, 611);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(742, 175);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "HOW 2 PLAY";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.LoadSettings);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 80F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExit.Location = new System.Drawing.Point(762, 826);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(395, 175);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveProgress
            // 
            this.btnSaveProgress.BackColor = System.Drawing.Color.Black;
            this.btnSaveProgress.Font = new System.Drawing.Font("Comic Sans MS", 30F);
            this.btnSaveProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveProgress.Location = new System.Drawing.Point(1599, 891);
            this.btnSaveProgress.Name = "btnSaveProgress";
            this.btnSaveProgress.Size = new System.Drawing.Size(297, 76);
            this.btnSaveProgress.TabIndex = 4;
            this.btnSaveProgress.Text = "Save progress";
            this.btnSaveProgress.UseVisualStyleBackColor = false;
            this.btnSaveProgress.Click += new System.EventHandler(this.btnSaveProgress_Click);
            // 
            // btnLoadProgress
            // 
            this.btnLoadProgress.BackColor = System.Drawing.Color.Black;
            this.btnLoadProgress.Font = new System.Drawing.Font("Comic Sans MS", 30F);
            this.btnLoadProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoadProgress.Location = new System.Drawing.Point(1599, 973);
            this.btnLoadProgress.Name = "btnLoadProgress";
            this.btnLoadProgress.Size = new System.Drawing.Size(293, 76);
            this.btnLoadProgress.TabIndex = 5;
            this.btnLoadProgress.Text = "Load progress";
            this.btnLoadProgress.UseVisualStyleBackColor = false;
            this.btnLoadProgress.Click += new System.EventHandler(this.btnLoadProgress_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Black;
            this.lblVersion.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVersion.Location = new System.Drawing.Point(12, 1014);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(177, 38);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "Version 1.2.0";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Agent_Ace.Properties.Resources.mainMenuBG;
            this.ClientSize = new System.Drawing.Size(1904, 1061);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnLoadProgress);
            this.Controls.Add(this.btnSaveProgress);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblAce);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agent Ace";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAce;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveProgress;
        private System.Windows.Forms.Button btnLoadProgress;
        private System.Windows.Forms.Label lblVersion;
    }
}


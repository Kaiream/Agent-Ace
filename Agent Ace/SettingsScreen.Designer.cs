
namespace Agent_Ace
{
    partial class SettingsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsScreen));
            this.btnBack = new System.Windows.Forms.Button();
            this.pcbMainScreen = new System.Windows.Forms.PictureBox();
            this.pcbWASD = new System.Windows.Forms.PictureBox();
            this.pcbArrowKeys = new System.Windows.Forms.PictureBox();
            this.lblOr = new System.Windows.Forms.Label();
            this.pcbSpacebar = new System.Windows.Forms.PictureBox();
            this.pcbRetry = new System.Windows.Forms.PictureBox();
            this.lblArrowKeys = new System.Windows.Forms.Label();
            this.lblShoot = new System.Windows.Forms.Label();
            this.lblRetry = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pcbEscape = new System.Windows.Forms.PictureBox();
            this.lblEscapePause = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMainScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWASD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArrowKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpacebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRetry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEscape)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 80F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBack.Location = new System.Drawing.Point(762, 826);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(395, 175);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.LoadMenu);
            // 
            // pcbMainScreen
            // 
            this.pcbMainScreen.BackColor = System.Drawing.Color.Black;
            this.pcbMainScreen.Image = global::Agent_Ace.Properties.Resources.tutorial1;
            this.pcbMainScreen.Location = new System.Drawing.Point(428, 12);
            this.pcbMainScreen.Name = "pcbMainScreen";
            this.pcbMainScreen.Size = new System.Drawing.Size(1064, 596);
            this.pcbMainScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMainScreen.TabIndex = 5;
            this.pcbMainScreen.TabStop = false;
            // 
            // pcbWASD
            // 
            this.pcbWASD.BackColor = System.Drawing.Color.Black;
            this.pcbWASD.Image = global::Agent_Ace.Properties.Resources.wasd;
            this.pcbWASD.Location = new System.Drawing.Point(70, 304);
            this.pcbWASD.Name = "pcbWASD";
            this.pcbWASD.Size = new System.Drawing.Size(302, 203);
            this.pcbWASD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbWASD.TabIndex = 6;
            this.pcbWASD.TabStop = false;
            // 
            // pcbArrowKeys
            // 
            this.pcbArrowKeys.BackColor = System.Drawing.Color.Black;
            this.pcbArrowKeys.Image = global::Agent_Ace.Properties.Resources.arrow;
            this.pcbArrowKeys.Location = new System.Drawing.Point(12, 37);
            this.pcbArrowKeys.Name = "pcbArrowKeys";
            this.pcbArrowKeys.Size = new System.Drawing.Size(425, 277);
            this.pcbArrowKeys.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbArrowKeys.TabIndex = 7;
            this.pcbArrowKeys.TabStop = false;
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.BackColor = System.Drawing.Color.Black;
            this.lblOr.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOr.Location = new System.Drawing.Point(193, 280);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(66, 49);
            this.lblOr.TabIndex = 8;
            this.lblOr.Text = "Or";
            // 
            // pcbSpacebar
            // 
            this.pcbSpacebar.BackColor = System.Drawing.Color.Black;
            this.pcbSpacebar.Image = global::Agent_Ace.Properties.Resources.spacebar;
            this.pcbSpacebar.Location = new System.Drawing.Point(1554, 64);
            this.pcbSpacebar.Name = "pcbSpacebar";
            this.pcbSpacebar.Size = new System.Drawing.Size(327, 137);
            this.pcbSpacebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSpacebar.TabIndex = 9;
            this.pcbSpacebar.TabStop = false;
            // 
            // pcbRetry
            // 
            this.pcbRetry.BackColor = System.Drawing.Color.Black;
            this.pcbRetry.Image = global::Agent_Ace.Properties.Resources.enter;
            this.pcbRetry.Location = new System.Drawing.Point(1601, 256);
            this.pcbRetry.Name = "pcbRetry";
            this.pcbRetry.Size = new System.Drawing.Size(249, 89);
            this.pcbRetry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRetry.TabIndex = 10;
            this.pcbRetry.TabStop = false;
            // 
            // lblArrowKeys
            // 
            this.lblArrowKeys.AutoSize = true;
            this.lblArrowKeys.BackColor = System.Drawing.Color.Black;
            this.lblArrowKeys.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrowKeys.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblArrowKeys.Location = new System.Drawing.Point(54, 4);
            this.lblArrowKeys.Name = "lblArrowKeys";
            this.lblArrowKeys.Size = new System.Drawing.Size(341, 49);
            this.lblArrowKeys.TabIndex = 11;
            this.lblArrowKeys.Text = "Arrow keys to move";
            // 
            // lblShoot
            // 
            this.lblShoot.AutoSize = true;
            this.lblShoot.BackColor = System.Drawing.Color.Black;
            this.lblShoot.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoot.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblShoot.Location = new System.Drawing.Point(1563, 12);
            this.lblShoot.Name = "lblShoot";
            this.lblShoot.Size = new System.Drawing.Size(318, 49);
            this.lblShoot.TabIndex = 12;
            this.lblShoot.Text = "Spacebar to shoot";
            // 
            // lblRetry
            // 
            this.lblRetry.AutoSize = true;
            this.lblRetry.BackColor = System.Drawing.Color.Black;
            this.lblRetry.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetry.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRetry.Location = new System.Drawing.Point(1598, 204);
            this.lblRetry.Name = "lblRetry";
            this.lblRetry.Size = new System.Drawing.Size(252, 49);
            this.lblRetry.TabIndex = 13;
            this.lblRetry.Text = "Enter to retry";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.Font = new System.Drawing.Font("Comic Sans MS", 50F);
            this.btnNext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNext.Location = new System.Drawing.Point(1163, 900);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(322, 101);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Black;
            this.btnPrevious.Font = new System.Drawing.Font("Comic Sans MS", 50F);
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPrevious.Location = new System.Drawing.Point(434, 900);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(322, 101);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // pcbEscape
            // 
            this.pcbEscape.BackColor = System.Drawing.Color.Black;
            this.pcbEscape.Image = global::Agent_Ace.Properties.Resources.escape;
            this.pcbEscape.Location = new System.Drawing.Point(1588, 427);
            this.pcbEscape.Name = "pcbEscape";
            this.pcbEscape.Size = new System.Drawing.Size(278, 175);
            this.pcbEscape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEscape.TabIndex = 16;
            this.pcbEscape.TabStop = false;
            // 
            // lblEscapePause
            // 
            this.lblEscapePause.AutoSize = true;
            this.lblEscapePause.BackColor = System.Drawing.Color.Black;
            this.lblEscapePause.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscapePause.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEscapePause.Location = new System.Drawing.Point(1586, 373);
            this.lblEscapePause.Name = "lblEscapePause";
            this.lblEscapePause.Size = new System.Drawing.Size(280, 49);
            this.lblEscapePause.TabIndex = 17;
            this.lblEscapePause.Text = "Escape to pause";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(1591, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 84);
            this.label1.TabIndex = 18;
            this.label1.Text = "By pausing you can\r\naccess the shop!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Agent_Ace.Properties.Resources.mainMenuBG;
            this.ClientSize = new System.Drawing.Size(1904, 1061);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEscapePause);
            this.Controls.Add(this.pcbEscape);
            this.Controls.Add(this.pcbMainScreen);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblRetry);
            this.Controls.Add(this.lblShoot);
            this.Controls.Add(this.lblArrowKeys);
            this.Controls.Add(this.pcbRetry);
            this.Controls.Add(this.pcbSpacebar);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.pcbArrowKeys);
            this.Controls.Add(this.pcbWASD);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agent Ace";
            this.Load += new System.EventHandler(this.SettingsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMainScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWASD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArrowKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpacebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRetry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEscape)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pcbMainScreen;
        private System.Windows.Forms.PictureBox pcbWASD;
        private System.Windows.Forms.PictureBox pcbArrowKeys;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.PictureBox pcbSpacebar;
        private System.Windows.Forms.PictureBox pcbRetry;
        private System.Windows.Forms.Label lblArrowKeys;
        private System.Windows.Forms.Label lblShoot;
        private System.Windows.Forms.Label lblRetry;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.PictureBox pcbEscape;
        private System.Windows.Forms.Label lblEscapePause;
        private System.Windows.Forms.Label label1;
    }
}
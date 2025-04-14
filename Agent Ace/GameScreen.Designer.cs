
namespace Agent_Ace
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblGunOverheat = new System.Windows.Forms.Label();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pgbEnemy2 = new System.Windows.Forms.ProgressBar();
            this.pgbEnemy1 = new System.Windows.Forms.ProgressBar();
            this.pgbScore = new System.Windows.Forms.ProgressBar();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblGoalM = new System.Windows.Forms.Label();
            this.lblGoal0M = new System.Windows.Forms.Label();
            this.lblCurrentGun = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblRifleTitle = new System.Windows.Forms.Label();
            this.lblSpaceRifleTitle = new System.Windows.Forms.Label();
            this.lblMachineGunTitle = new System.Windows.Forms.Label();
            this.lblSonicGunTitle = new System.Windows.Forms.Label();
            this.lblCashShop = new System.Windows.Forms.Label();
            this.lblCurrentRig = new System.Windows.Forms.Label();
            this.btnBuyRifle = new System.Windows.Forms.Button();
            this.btnBuySpaceRifle = new System.Windows.Forms.Button();
            this.btnBuyMachineGun = new System.Windows.Forms.Button();
            this.btnBuySonicGun = new System.Windows.Forms.Button();
            this.rdbEquipRifle = new System.Windows.Forms.RadioButton();
            this.rdbEquipSpaceRifle = new System.Windows.Forms.RadioButton();
            this.rdbEquipMachineGun = new System.Windows.Forms.RadioButton();
            this.rdbEquipSonicGun = new System.Windows.Forms.RadioButton();
            this.btnBackShop = new System.Windows.Forms.Button();
            this.txtRifleDesc = new System.Windows.Forms.TextBox();
            this.txtSpaceRifleDesc = new System.Windows.Forms.TextBox();
            this.txtMachineGunDesc = new System.Windows.Forms.TextBox();
            this.txtSonicGunDesc = new System.Windows.Forms.TextBox();
            this.lblBuiltInPistol = new System.Windows.Forms.Label();
            this.rdbEquipBuiltInPistol = new System.Windows.Forms.RadioButton();
            this.btnMainMenuShop = new System.Windows.Forms.Button();
            this.pcbSonicGun = new System.Windows.Forms.PictureBox();
            this.pcbMachineGun = new System.Windows.Forms.PictureBox();
            this.pcbSpaceRifle = new System.Windows.Forms.PictureBox();
            this.pcbRifle = new System.Windows.Forms.PictureBox();
            this.pcbShop = new System.Windows.Forms.PictureBox();
            this.pcbExplosion = new System.Windows.Forms.PictureBox();
            this.pcbCarScore = new System.Windows.Forms.PictureBox();
            this.pcbMainMenu = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSonicGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMachineGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpaceRifle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRifle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExplosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Comic Sans MS", 26.75F);
            this.lblScore.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblScore.Location = new System.Drawing.Point(379, 26);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(205, 51);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score: 0 m";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.BackColor = System.Drawing.Color.Transparent;
            this.lblCash.Font = new System.Drawing.Font("Comic Sans MS", 26.75F);
            this.lblCash.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblCash.Location = new System.Drawing.Point(12, 950);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(297, 51);
            this.lblCash.TabIndex = 5;
            this.lblCash.Text = "Cashmoney: 0$€";
            // 
            // lblGunOverheat
            // 
            this.lblGunOverheat.AutoSize = true;
            this.lblGunOverheat.BackColor = System.Drawing.Color.Transparent;
            this.lblGunOverheat.Font = new System.Drawing.Font("Comic Sans MS", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGunOverheat.ForeColor = System.Drawing.Color.Maroon;
            this.lblGunOverheat.Location = new System.Drawing.Point(792, 148);
            this.lblGunOverheat.Name = "lblGunOverheat";
            this.lblGunOverheat.Size = new System.Drawing.Size(336, 54);
            this.lblGunOverheat.TabIndex = 6;
            this.lblGunOverheat.Text = "GUN OVERHEAT";
            // 
            // btnResume
            // 
            this.btnResume.Enabled = false;
            this.btnResume.Font = new System.Drawing.Font("Comic Sans MS", 27.75F);
            this.btnResume.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResume.Location = new System.Drawing.Point(789, 448);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(359, 61);
            this.btnResume.TabIndex = 1;
            this.btnResume.TabStop = false;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Visible = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMainMenu.Enabled = false;
            this.btnMainMenu.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMainMenu.Location = new System.Drawing.Point(789, 649);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(359, 61);
            this.btnMainMenu.TabIndex = 3;
            this.btnMainMenu.TabStop = false;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Visible = false;
            this.btnMainMenu.Click += new System.EventHandler(this.LoadMenu);
            // 
            // btnShop
            // 
            this.btnShop.Enabled = false;
            this.btnShop.Font = new System.Drawing.Font("Comic Sans MS", 27.75F);
            this.btnShop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShop.Location = new System.Drawing.Point(789, 582);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(359, 61);
            this.btnShop.TabIndex = 4;
            this.btnShop.TabStop = false;
            this.btnShop.Text = "Shop";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Visible = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRestart.Enabled = false;
            this.btnRestart.Font = new System.Drawing.Font("Comic Sans MS", 27.75F);
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestart.Location = new System.Drawing.Point(789, 515);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(359, 61);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.TabStop = false;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pgbEnemy2
            // 
            this.pgbEnemy2.BackColor = System.Drawing.Color.Red;
            this.pgbEnemy2.ForeColor = System.Drawing.Color.Red;
            this.pgbEnemy2.Location = new System.Drawing.Point(134, 253);
            this.pgbEnemy2.Name = "pgbEnemy2";
            this.pgbEnemy2.Size = new System.Drawing.Size(100, 5);
            this.pgbEnemy2.TabIndex = 13;
            this.pgbEnemy2.Visible = false;
            // 
            // pgbEnemy1
            // 
            this.pgbEnemy1.BackColor = System.Drawing.Color.Red;
            this.pgbEnemy1.ForeColor = System.Drawing.Color.Red;
            this.pgbEnemy1.Location = new System.Drawing.Point(28, 253);
            this.pgbEnemy1.Name = "pgbEnemy1";
            this.pgbEnemy1.Size = new System.Drawing.Size(100, 5);
            this.pgbEnemy1.TabIndex = 14;
            this.pgbEnemy1.Visible = false;
            // 
            // pgbScore
            // 
            this.pgbScore.Location = new System.Drawing.Point(460, 80);
            this.pgbScore.Name = "pgbScore";
            this.pgbScore.Size = new System.Drawing.Size(1000, 30);
            this.pgbScore.TabIndex = 15;
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.BackColor = System.Drawing.Color.Transparent;
            this.lblGoal.Font = new System.Drawing.Font("Comic Sans MS", 26.75F);
            this.lblGoal.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblGoal.Location = new System.Drawing.Point(1411, 26);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(93, 51);
            this.lblGoal.TabIndex = 17;
            this.lblGoal.Text = "Goal";
            // 
            // lblGoalM
            // 
            this.lblGoalM.AutoSize = true;
            this.lblGoalM.BackColor = System.Drawing.Color.Transparent;
            this.lblGoalM.Font = new System.Drawing.Font("Comic Sans MS", 16.75F);
            this.lblGoalM.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblGoalM.Location = new System.Drawing.Point(1466, 80);
            this.lblGoalM.Name = "lblGoalM";
            this.lblGoalM.Size = new System.Drawing.Size(95, 31);
            this.lblGoalM.TabIndex = 18;
            this.lblGoalM.Text = "3000 m";
            // 
            // lblGoal0M
            // 
            this.lblGoal0M.AutoSize = true;
            this.lblGoal0M.BackColor = System.Drawing.Color.Transparent;
            this.lblGoal0M.Font = new System.Drawing.Font("Comic Sans MS", 16.75F);
            this.lblGoal0M.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblGoal0M.Location = new System.Drawing.Point(401, 80);
            this.lblGoal0M.Name = "lblGoal0M";
            this.lblGoal0M.Size = new System.Drawing.Size(53, 31);
            this.lblGoal0M.TabIndex = 19;
            this.lblGoal0M.Text = "0 m";
            // 
            // lblCurrentGun
            // 
            this.lblCurrentGun.AutoSize = true;
            this.lblCurrentGun.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentGun.Font = new System.Drawing.Font("Comic Sans MS", 26.75F);
            this.lblCurrentGun.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblCurrentGun.Location = new System.Drawing.Point(12, 1001);
            this.lblCurrentGun.Name = "lblCurrentGun";
            this.lblCurrentGun.Size = new System.Drawing.Size(471, 51);
            this.lblCurrentGun.TabIndex = 20;
            this.lblCurrentGun.Text = "Current Gun: Built in pistol";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOver.Font = new System.Drawing.Font("Comic Sans MS", 38.25F, System.Drawing.FontStyle.Bold);
            this.lblGameOver.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblGameOver.Location = new System.Drawing.Point(798, 930);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(341, 71);
            this.lblGameOver.TabIndex = 21;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.Visible = false;
            // 
            // lblRifleTitle
            // 
            this.lblRifleTitle.AutoSize = true;
            this.lblRifleTitle.BackColor = System.Drawing.Color.Black;
            this.lblRifleTitle.Font = new System.Drawing.Font("Comic Sans MS", 28.25F);
            this.lblRifleTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblRifleTitle.Location = new System.Drawing.Point(319, 536);
            this.lblRifleTitle.Name = "lblRifleTitle";
            this.lblRifleTitle.Size = new System.Drawing.Size(108, 53);
            this.lblRifleTitle.TabIndex = 28;
            this.lblRifleTitle.Text = "Rifle";
            this.lblRifleTitle.Visible = false;
            // 
            // lblSpaceRifleTitle
            // 
            this.lblSpaceRifleTitle.AutoSize = true;
            this.lblSpaceRifleTitle.BackColor = System.Drawing.Color.Black;
            this.lblSpaceRifleTitle.Font = new System.Drawing.Font("Comic Sans MS", 28.25F);
            this.lblSpaceRifleTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblSpaceRifleTitle.Location = new System.Drawing.Point(650, 536);
            this.lblSpaceRifleTitle.Name = "lblSpaceRifleTitle";
            this.lblSpaceRifleTitle.Size = new System.Drawing.Size(225, 53);
            this.lblSpaceRifleTitle.TabIndex = 29;
            this.lblSpaceRifleTitle.Text = "Space Rifle";
            this.lblSpaceRifleTitle.Visible = false;
            // 
            // lblMachineGunTitle
            // 
            this.lblMachineGunTitle.AutoSize = true;
            this.lblMachineGunTitle.BackColor = System.Drawing.Color.Black;
            this.lblMachineGunTitle.Font = new System.Drawing.Font("Comic Sans MS", 28.25F);
            this.lblMachineGunTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblMachineGunTitle.Location = new System.Drawing.Point(1034, 536);
            this.lblMachineGunTitle.Name = "lblMachineGunTitle";
            this.lblMachineGunTitle.Size = new System.Drawing.Size(245, 53);
            this.lblMachineGunTitle.TabIndex = 30;
            this.lblMachineGunTitle.Text = "Machine Gun";
            this.lblMachineGunTitle.Visible = false;
            // 
            // lblSonicGunTitle
            // 
            this.lblSonicGunTitle.AutoSize = true;
            this.lblSonicGunTitle.BackColor = System.Drawing.Color.Black;
            this.lblSonicGunTitle.Font = new System.Drawing.Font("Comic Sans MS", 28.25F);
            this.lblSonicGunTitle.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblSonicGunTitle.Location = new System.Drawing.Point(1431, 536);
            this.lblSonicGunTitle.Name = "lblSonicGunTitle";
            this.lblSonicGunTitle.Size = new System.Drawing.Size(197, 53);
            this.lblSonicGunTitle.TabIndex = 31;
            this.lblSonicGunTitle.Text = "Sonic Gun";
            this.lblSonicGunTitle.Visible = false;
            // 
            // lblCashShop
            // 
            this.lblCashShop.AutoSize = true;
            this.lblCashShop.BackColor = System.Drawing.Color.Black;
            this.lblCashShop.Font = new System.Drawing.Font("Comic Sans MS", 26.75F);
            this.lblCashShop.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblCashShop.Location = new System.Drawing.Point(1397, 116);
            this.lblCashShop.Name = "lblCashShop";
            this.lblCashShop.Size = new System.Drawing.Size(297, 51);
            this.lblCashShop.TabIndex = 32;
            this.lblCashShop.Text = "Cashmoney: 0$€";
            this.lblCashShop.Visible = false;
            // 
            // lblCurrentRig
            // 
            this.lblCurrentRig.AutoSize = true;
            this.lblCurrentRig.BackColor = System.Drawing.Color.Black;
            this.lblCurrentRig.Font = new System.Drawing.Font("Comic Sans MS", 26.75F);
            this.lblCurrentRig.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblCurrentRig.Location = new System.Drawing.Point(125, 116);
            this.lblCurrentRig.Name = "lblCurrentRig";
            this.lblCurrentRig.Size = new System.Drawing.Size(500, 51);
            this.lblCurrentRig.TabIndex = 33;
            this.lblCurrentRig.Text = "Current setup: built in pistol";
            this.lblCurrentRig.Visible = false;
            // 
            // btnBuyRifle
            // 
            this.btnBuyRifle.BackColor = System.Drawing.Color.Black;
            this.btnBuyRifle.Font = new System.Drawing.Font("Comic Sans MS", 28.25F);
            this.btnBuyRifle.ForeColor = System.Drawing.Color.Crimson;
            this.btnBuyRifle.Location = new System.Drawing.Point(278, 323);
            this.btnBuyRifle.Name = "btnBuyRifle";
            this.btnBuyRifle.Size = new System.Drawing.Size(190, 64);
            this.btnBuyRifle.TabIndex = 50;
            this.btnBuyRifle.TabStop = false;
            this.btnBuyRifle.Text = "5000$€";
            this.btnBuyRifle.UseVisualStyleBackColor = false;
            this.btnBuyRifle.Visible = false;
            this.btnBuyRifle.Click += new System.EventHandler(this.btnBuyRifle_Click);
            // 
            // btnBuySpaceRifle
            // 
            this.btnBuySpaceRifle.BackColor = System.Drawing.Color.Black;
            this.btnBuySpaceRifle.Font = new System.Drawing.Font("Comic Sans MS", 28.25F);
            this.btnBuySpaceRifle.ForeColor = System.Drawing.Color.Crimson;
            this.btnBuySpaceRifle.Location = new System.Drawing.Point(669, 323);
            this.btnBuySpaceRifle.Name = "btnBuySpaceRifle";
            this.btnBuySpaceRifle.Size = new System.Drawing.Size(190, 64);
            this.btnBuySpaceRifle.TabIndex = 51;
            this.btnBuySpaceRifle.TabStop = false;
            this.btnBuySpaceRifle.Text = "7500$€";
            this.btnBuySpaceRifle.UseVisualStyleBackColor = false;
            this.btnBuySpaceRifle.Visible = false;
            this.btnBuySpaceRifle.Click += new System.EventHandler(this.btnBuySpaceRifle_Click);
            // 
            // btnBuyMachineGun
            // 
            this.btnBuyMachineGun.BackColor = System.Drawing.Color.Black;
            this.btnBuyMachineGun.Font = new System.Drawing.Font("Comic Sans MS", 28.25F);
            this.btnBuyMachineGun.ForeColor = System.Drawing.Color.Crimson;
            this.btnBuyMachineGun.Location = new System.Drawing.Point(1056, 323);
            this.btnBuyMachineGun.Name = "btnBuyMachineGun";
            this.btnBuyMachineGun.Size = new System.Drawing.Size(195, 64);
            this.btnBuyMachineGun.TabIndex = 52;
            this.btnBuyMachineGun.TabStop = false;
            this.btnBuyMachineGun.Text = "15000$€";
            this.btnBuyMachineGun.UseVisualStyleBackColor = false;
            this.btnBuyMachineGun.Visible = false;
            this.btnBuyMachineGun.Click += new System.EventHandler(this.btnBuyMachineGun_Click);
            // 
            // btnBuySonicGun
            // 
            this.btnBuySonicGun.BackColor = System.Drawing.Color.Black;
            this.btnBuySonicGun.Font = new System.Drawing.Font("Comic Sans MS", 28.25F);
            this.btnBuySonicGun.ForeColor = System.Drawing.Color.Crimson;
            this.btnBuySonicGun.Location = new System.Drawing.Point(1427, 323);
            this.btnBuySonicGun.Name = "btnBuySonicGun";
            this.btnBuySonicGun.Size = new System.Drawing.Size(195, 64);
            this.btnBuySonicGun.TabIndex = 53;
            this.btnBuySonicGun.TabStop = false;
            this.btnBuySonicGun.Text = "25000$€";
            this.btnBuySonicGun.UseVisualStyleBackColor = false;
            this.btnBuySonicGun.Visible = false;
            this.btnBuySonicGun.Click += new System.EventHandler(this.btnBuySonicGun_Click);
            // 
            // rdbEquipRifle
            // 
            this.rdbEquipRifle.AutoSize = true;
            this.rdbEquipRifle.BackColor = System.Drawing.Color.Black;
            this.rdbEquipRifle.Enabled = false;
            this.rdbEquipRifle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.rdbEquipRifle.ForeColor = System.Drawing.Color.Crimson;
            this.rdbEquipRifle.Location = new System.Drawing.Point(328, 284);
            this.rdbEquipRifle.Name = "rdbEquipRifle";
            this.rdbEquipRifle.Size = new System.Drawing.Size(96, 33);
            this.rdbEquipRifle.TabIndex = 54;
            this.rdbEquipRifle.Text = "Equip";
            this.rdbEquipRifle.UseVisualStyleBackColor = false;
            this.rdbEquipRifle.Visible = false;
            this.rdbEquipRifle.CheckedChanged += new System.EventHandler(this.rdbEquipRifle_CheckedChanged);
            // 
            // rdbEquipSpaceRifle
            // 
            this.rdbEquipSpaceRifle.AutoSize = true;
            this.rdbEquipSpaceRifle.BackColor = System.Drawing.Color.Black;
            this.rdbEquipSpaceRifle.Enabled = false;
            this.rdbEquipSpaceRifle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.rdbEquipSpaceRifle.ForeColor = System.Drawing.Color.Crimson;
            this.rdbEquipSpaceRifle.Location = new System.Drawing.Point(719, 284);
            this.rdbEquipSpaceRifle.Name = "rdbEquipSpaceRifle";
            this.rdbEquipSpaceRifle.Size = new System.Drawing.Size(96, 33);
            this.rdbEquipSpaceRifle.TabIndex = 55;
            this.rdbEquipSpaceRifle.Text = "Equip";
            this.rdbEquipSpaceRifle.UseVisualStyleBackColor = false;
            this.rdbEquipSpaceRifle.Visible = false;
            this.rdbEquipSpaceRifle.CheckedChanged += new System.EventHandler(this.rdbEquipSpaceRifle_CheckedChanged);
            // 
            // rdbEquipMachineGun
            // 
            this.rdbEquipMachineGun.AutoSize = true;
            this.rdbEquipMachineGun.BackColor = System.Drawing.Color.Black;
            this.rdbEquipMachineGun.Enabled = false;
            this.rdbEquipMachineGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.rdbEquipMachineGun.ForeColor = System.Drawing.Color.Crimson;
            this.rdbEquipMachineGun.Location = new System.Drawing.Point(1100, 284);
            this.rdbEquipMachineGun.Name = "rdbEquipMachineGun";
            this.rdbEquipMachineGun.Size = new System.Drawing.Size(96, 33);
            this.rdbEquipMachineGun.TabIndex = 56;
            this.rdbEquipMachineGun.Text = "Equip";
            this.rdbEquipMachineGun.UseVisualStyleBackColor = false;
            this.rdbEquipMachineGun.Visible = false;
            this.rdbEquipMachineGun.CheckedChanged += new System.EventHandler(this.rdbEquipMachineGun_CheckedChanged);
            // 
            // rdbEquipSonicGun
            // 
            this.rdbEquipSonicGun.AutoSize = true;
            this.rdbEquipSonicGun.BackColor = System.Drawing.Color.Black;
            this.rdbEquipSonicGun.Enabled = false;
            this.rdbEquipSonicGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.rdbEquipSonicGun.ForeColor = System.Drawing.Color.Crimson;
            this.rdbEquipSonicGun.Location = new System.Drawing.Point(1472, 284);
            this.rdbEquipSonicGun.Name = "rdbEquipSonicGun";
            this.rdbEquipSonicGun.Size = new System.Drawing.Size(96, 33);
            this.rdbEquipSonicGun.TabIndex = 57;
            this.rdbEquipSonicGun.Text = "Equip";
            this.rdbEquipSonicGun.UseVisualStyleBackColor = false;
            this.rdbEquipSonicGun.Visible = false;
            this.rdbEquipSonicGun.CheckedChanged += new System.EventHandler(this.rdbEquipSonicGun_CheckedChanged);
            // 
            // btnBackShop
            // 
            this.btnBackShop.BackColor = System.Drawing.Color.Black;
            this.btnBackShop.Enabled = false;
            this.btnBackShop.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackShop.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnBackShop.Location = new System.Drawing.Point(134, 880);
            this.btnBackShop.Name = "btnBackShop";
            this.btnBackShop.Size = new System.Drawing.Size(277, 80);
            this.btnBackShop.TabIndex = 58;
            this.btnBackShop.TabStop = false;
            this.btnBackShop.Text = "Back to action";
            this.btnBackShop.UseVisualStyleBackColor = false;
            this.btnBackShop.Visible = false;
            this.btnBackShop.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtRifleDesc
            // 
            this.txtRifleDesc.BackColor = System.Drawing.Color.Black;
            this.txtRifleDesc.Enabled = false;
            this.txtRifleDesc.Font = new System.Drawing.Font("Comic Sans MS", 15.25F);
            this.txtRifleDesc.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtRifleDesc.Location = new System.Drawing.Point(228, 601);
            this.txtRifleDesc.Multiline = true;
            this.txtRifleDesc.Name = "txtRifleDesc";
            this.txtRifleDesc.ReadOnly = true;
            this.txtRifleDesc.Size = new System.Drawing.Size(275, 115);
            this.txtRifleDesc.TabIndex = 59;
            this.txtRifleDesc.TabStop = false;
            this.txtRifleDesc.Text = "Rifle bullet speed: 75\r\nRifle exhaustion: 4 bullets\r\nDamage per shot: 1\r\nRifle pr" +
    "ice: 5000$€";
            this.txtRifleDesc.Visible = false;
            // 
            // txtSpaceRifleDesc
            // 
            this.txtSpaceRifleDesc.BackColor = System.Drawing.Color.Black;
            this.txtSpaceRifleDesc.Enabled = false;
            this.txtSpaceRifleDesc.Font = new System.Drawing.Font("Comic Sans MS", 15.25F);
            this.txtSpaceRifleDesc.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtSpaceRifleDesc.Location = new System.Drawing.Point(615, 601);
            this.txtSpaceRifleDesc.Multiline = true;
            this.txtSpaceRifleDesc.Name = "txtSpaceRifleDesc";
            this.txtSpaceRifleDesc.ReadOnly = true;
            this.txtSpaceRifleDesc.Size = new System.Drawing.Size(325, 115);
            this.txtSpaceRifleDesc.TabIndex = 60;
            this.txtSpaceRifleDesc.TabStop = false;
            this.txtSpaceRifleDesc.Text = "Space Rifle bullet speed: 100\r\nSace Rifle exhaustion: 10 bullets\r\nDamage per shot" +
    ": 2\r\nSpace Rifle price: 7500$€";
            this.txtSpaceRifleDesc.Visible = false;
            // 
            // txtMachineGunDesc
            // 
            this.txtMachineGunDesc.BackColor = System.Drawing.Color.Black;
            this.txtMachineGunDesc.Enabled = false;
            this.txtMachineGunDesc.Font = new System.Drawing.Font("Comic Sans MS", 15.25F);
            this.txtMachineGunDesc.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtMachineGunDesc.Location = new System.Drawing.Point(1007, 602);
            this.txtMachineGunDesc.Multiline = true;
            this.txtMachineGunDesc.Name = "txtMachineGunDesc";
            this.txtMachineGunDesc.ReadOnly = true;
            this.txtMachineGunDesc.Size = new System.Drawing.Size(345, 115);
            this.txtMachineGunDesc.TabIndex = 61;
            this.txtMachineGunDesc.TabStop = false;
            this.txtMachineGunDesc.Text = "Machine Gun bullet speed: 125\r\nMachine Gun exhaustion: 15 bullets\r\nDamage per sho" +
    "t: 1\r\nMachine Gun price: 15000$€";
            this.txtMachineGunDesc.Visible = false;
            // 
            // txtSonicGunDesc
            // 
            this.txtSonicGunDesc.BackColor = System.Drawing.Color.Black;
            this.txtSonicGunDesc.Enabled = false;
            this.txtSonicGunDesc.Font = new System.Drawing.Font("Comic Sans MS", 15.25F);
            this.txtSonicGunDesc.ForeColor = System.Drawing.Color.SlateBlue;
            this.txtSonicGunDesc.Location = new System.Drawing.Point(1375, 602);
            this.txtSonicGunDesc.Multiline = true;
            this.txtSonicGunDesc.Name = "txtSonicGunDesc";
            this.txtSonicGunDesc.ReadOnly = true;
            this.txtSonicGunDesc.Size = new System.Drawing.Size(320, 115);
            this.txtSonicGunDesc.TabIndex = 62;
            this.txtSonicGunDesc.TabStop = false;
            this.txtSonicGunDesc.Text = "Sonic Gun bullet speed: ∞\r\nSonic Gun overheat: ∞\r\nDamage per shot: ∞\r\nSonic Gun p" +
    "rice: 25000$€";
            this.txtSonicGunDesc.Visible = false;
            // 
            // lblBuiltInPistol
            // 
            this.lblBuiltInPistol.AutoSize = true;
            this.lblBuiltInPistol.BackColor = System.Drawing.Color.Black;
            this.lblBuiltInPistol.Font = new System.Drawing.Font("Comic Sans MS", 26.75F);
            this.lblBuiltInPistol.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblBuiltInPistol.Location = new System.Drawing.Point(1455, 909);
            this.lblBuiltInPistol.Name = "lblBuiltInPistol";
            this.lblBuiltInPistol.Size = new System.Drawing.Size(245, 51);
            this.lblBuiltInPistol.TabIndex = 63;
            this.lblBuiltInPistol.Text = "Built in pistol";
            this.lblBuiltInPistol.Visible = false;
            // 
            // rdbEquipBuiltInPistol
            // 
            this.rdbEquipBuiltInPistol.AutoSize = true;
            this.rdbEquipBuiltInPistol.BackColor = System.Drawing.Color.Black;
            this.rdbEquipBuiltInPistol.Checked = true;
            this.rdbEquipBuiltInPistol.Enabled = false;
            this.rdbEquipBuiltInPistol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.rdbEquipBuiltInPistol.ForeColor = System.Drawing.Color.Crimson;
            this.rdbEquipBuiltInPistol.Location = new System.Drawing.Point(1706, 924);
            this.rdbEquipBuiltInPistol.Name = "rdbEquipBuiltInPistol";
            this.rdbEquipBuiltInPistol.Size = new System.Drawing.Size(96, 33);
            this.rdbEquipBuiltInPistol.TabIndex = 64;
            this.rdbEquipBuiltInPistol.TabStop = true;
            this.rdbEquipBuiltInPistol.Text = "Equip";
            this.rdbEquipBuiltInPistol.UseVisualStyleBackColor = false;
            this.rdbEquipBuiltInPistol.Visible = false;
            this.rdbEquipBuiltInPistol.CheckedChanged += new System.EventHandler(this.rdbEquipBuiltInPistol_CheckedChanged);
            // 
            // btnMainMenuShop
            // 
            this.btnMainMenuShop.BackColor = System.Drawing.Color.Black;
            this.btnMainMenuShop.Enabled = false;
            this.btnMainMenuShop.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuShop.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMainMenuShop.Location = new System.Drawing.Point(417, 880);
            this.btnMainMenuShop.Name = "btnMainMenuShop";
            this.btnMainMenuShop.Size = new System.Drawing.Size(277, 80);
            this.btnMainMenuShop.TabIndex = 65;
            this.btnMainMenuShop.TabStop = false;
            this.btnMainMenuShop.Text = "Main Menu";
            this.btnMainMenuShop.UseVisualStyleBackColor = false;
            this.btnMainMenuShop.Visible = false;
            this.btnMainMenuShop.Click += new System.EventHandler(this.LoadMenu);
            // 
            // pcbSonicGun
            // 
            this.pcbSonicGun.BackColor = System.Drawing.Color.Black;
            this.pcbSonicGun.Image = global::Agent_Ace.Properties.Resources.shopSonicGun;
            this.pcbSonicGun.Location = new System.Drawing.Point(1379, 393);
            this.pcbSonicGun.Name = "pcbSonicGun";
            this.pcbSonicGun.Size = new System.Drawing.Size(297, 140);
            this.pcbSonicGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSonicGun.TabIndex = 27;
            this.pcbSonicGun.TabStop = false;
            this.pcbSonicGun.Visible = false;
            // 
            // pcbMachineGun
            // 
            this.pcbMachineGun.BackColor = System.Drawing.Color.Black;
            this.pcbMachineGun.Image = global::Agent_Ace.Properties.Resources.shopMachineGun;
            this.pcbMachineGun.Location = new System.Drawing.Point(1007, 393);
            this.pcbMachineGun.Name = "pcbMachineGun";
            this.pcbMachineGun.Size = new System.Drawing.Size(297, 140);
            this.pcbMachineGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMachineGun.TabIndex = 26;
            this.pcbMachineGun.TabStop = false;
            this.pcbMachineGun.Visible = false;
            // 
            // pcbSpaceRifle
            // 
            this.pcbSpaceRifle.BackColor = System.Drawing.Color.Black;
            this.pcbSpaceRifle.Image = global::Agent_Ace.Properties.Resources.shopSpaceRifle;
            this.pcbSpaceRifle.Location = new System.Drawing.Point(615, 393);
            this.pcbSpaceRifle.Name = "pcbSpaceRifle";
            this.pcbSpaceRifle.Size = new System.Drawing.Size(297, 140);
            this.pcbSpaceRifle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSpaceRifle.TabIndex = 25;
            this.pcbSpaceRifle.TabStop = false;
            this.pcbSpaceRifle.Visible = false;
            // 
            // pcbRifle
            // 
            this.pcbRifle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pcbRifle.Image = global::Agent_Ace.Properties.Resources.shopRifle;
            this.pcbRifle.Location = new System.Drawing.Point(228, 393);
            this.pcbRifle.Name = "pcbRifle";
            this.pcbRifle.Size = new System.Drawing.Size(297, 140);
            this.pcbRifle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRifle.TabIndex = 24;
            this.pcbRifle.TabStop = false;
            // 
            // pcbShop
            // 
            this.pcbShop.Image = global::Agent_Ace.Properties.Resources.shopPng;
            this.pcbShop.Location = new System.Drawing.Point(0, 0);
            this.pcbShop.Name = "pcbShop";
            this.pcbShop.Size = new System.Drawing.Size(1920, 1080);
            this.pcbShop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbShop.TabIndex = 23;
            this.pcbShop.TabStop = false;
            this.pcbShop.Visible = false;
            // 
            // pcbExplosion
            // 
            this.pcbExplosion.BackColor = System.Drawing.Color.Transparent;
            this.pcbExplosion.Image = ((System.Drawing.Image)(resources.GetObject("pcbExplosion.Image")));
            this.pcbExplosion.Location = new System.Drawing.Point(12, 12);
            this.pcbExplosion.Name = "pcbExplosion";
            this.pcbExplosion.Size = new System.Drawing.Size(200, 200);
            this.pcbExplosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbExplosion.TabIndex = 22;
            this.pcbExplosion.TabStop = false;
            this.pcbExplosion.Visible = false;
            // 
            // pcbCarScore
            // 
            this.pcbCarScore.BackColor = System.Drawing.Color.Transparent;
            this.pcbCarScore.Image = global::Agent_Ace.Properties.Resources.playerCar;
            this.pcbCarScore.Location = new System.Drawing.Point(460, 116);
            this.pcbCarScore.Name = "pcbCarScore";
            this.pcbCarScore.Size = new System.Drawing.Size(38, 22);
            this.pcbCarScore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCarScore.TabIndex = 16;
            this.pcbCarScore.TabStop = false;
            // 
            // pcbMainMenu
            // 
            this.pcbMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.pcbMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("pcbMainMenu.Image")));
            this.pcbMainMenu.Location = new System.Drawing.Point(719, 306);
            this.pcbMainMenu.Name = "pcbMainMenu";
            this.pcbMainMenu.Size = new System.Drawing.Size(500, 483);
            this.pcbMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMainMenu.TabIndex = 11;
            this.pcbMainMenu.TabStop = false;
            this.pcbMainMenu.Visible = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            this.enemy2.Image = global::Agent_Ace.Properties.Resources.police;
            this.enemy2.Location = new System.Drawing.Point(1800, 365);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(200, 125);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy2.TabIndex = 7;
            this.enemy2.TabStop = false;
            this.enemy2.Tag = "enemy";
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            this.enemy1.Image = global::Agent_Ace.Properties.Resources.police;
            this.enemy1.Location = new System.Drawing.Point(1100, 740);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(200, 125);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy1.TabIndex = 3;
            this.enemy1.TabStop = false;
            this.enemy1.Tag = "enemy";
            // 
            // obstacle2
            // 
            this.obstacle2.BackColor = System.Drawing.Color.Transparent;
            this.obstacle2.Image = ((System.Drawing.Image)(resources.GetObject("obstacle2.Image")));
            this.obstacle2.Location = new System.Drawing.Point(1375, 365);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(115, 115);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obstacle2.TabIndex = 2;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle2";
            // 
            // obstacle1
            // 
            this.obstacle1.BackColor = System.Drawing.Color.Transparent;
            this.obstacle1.Image = ((System.Drawing.Image)(resources.GetObject("obstacle1.Image")));
            this.obstacle1.Location = new System.Drawing.Point(490, 740);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(115, 115);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.obstacle1.TabIndex = 1;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle1";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Agent_Ace.Properties.Resources.playerCar;
            this.player.Location = new System.Drawing.Point(90, 500);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(200, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1904, 1061);
            this.Controls.Add(this.btnMainMenuShop);
            this.Controls.Add(this.rdbEquipBuiltInPistol);
            this.Controls.Add(this.lblBuiltInPistol);
            this.Controls.Add(this.txtSonicGunDesc);
            this.Controls.Add(this.txtMachineGunDesc);
            this.Controls.Add(this.txtSpaceRifleDesc);
            this.Controls.Add(this.txtRifleDesc);
            this.Controls.Add(this.btnBackShop);
            this.Controls.Add(this.rdbEquipSonicGun);
            this.Controls.Add(this.rdbEquipMachineGun);
            this.Controls.Add(this.rdbEquipSpaceRifle);
            this.Controls.Add(this.rdbEquipRifle);
            this.Controls.Add(this.btnBuySonicGun);
            this.Controls.Add(this.btnBuyMachineGun);
            this.Controls.Add(this.btnBuySpaceRifle);
            this.Controls.Add(this.btnBuyRifle);
            this.Controls.Add(this.lblCurrentRig);
            this.Controls.Add(this.lblCashShop);
            this.Controls.Add(this.lblSonicGunTitle);
            this.Controls.Add(this.lblMachineGunTitle);
            this.Controls.Add(this.lblSpaceRifleTitle);
            this.Controls.Add(this.lblRifleTitle);
            this.Controls.Add(this.pcbSonicGun);
            this.Controls.Add(this.pcbMachineGun);
            this.Controls.Add(this.pcbSpaceRifle);
            this.Controls.Add(this.pcbRifle);
            this.Controls.Add(this.pcbShop);
            this.Controls.Add(this.pcbExplosion);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblCurrentGun);
            this.Controls.Add(this.lblGoal0M);
            this.Controls.Add(this.lblGoalM);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.pcbCarScore);
            this.Controls.Add(this.pgbScore);
            this.Controls.Add(this.pgbEnemy1);
            this.Controls.Add(this.pgbEnemy2);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.pcbMainMenu);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.lblGunOverheat);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agent Ace";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSonicGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMachineGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSpaceRifle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRifle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbExplosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox obstacle1;
        private System.Windows.Forms.PictureBox obstacle2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblGunOverheat;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.PictureBox pcbMainMenu;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.ProgressBar pgbEnemy2;
        private System.Windows.Forms.ProgressBar pgbEnemy1;
        private System.Windows.Forms.ProgressBar pgbScore;
        private System.Windows.Forms.PictureBox pcbCarScore;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblGoalM;
        private System.Windows.Forms.Label lblGoal0M;
        private System.Windows.Forms.Label lblCurrentGun;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox pcbExplosion;
        private System.Windows.Forms.PictureBox pcbShop;
        private System.Windows.Forms.PictureBox pcbRifle;
        private System.Windows.Forms.PictureBox pcbSpaceRifle;
        private System.Windows.Forms.PictureBox pcbMachineGun;
        private System.Windows.Forms.PictureBox pcbSonicGun;
        private System.Windows.Forms.Label lblRifleTitle;
        private System.Windows.Forms.Label lblSpaceRifleTitle;
        private System.Windows.Forms.Label lblMachineGunTitle;
        private System.Windows.Forms.Label lblSonicGunTitle;
        private System.Windows.Forms.Label lblCashShop;
        private System.Windows.Forms.Label lblCurrentRig;
        private System.Windows.Forms.Button btnBuyRifle;
        private System.Windows.Forms.Button btnBuySpaceRifle;
        private System.Windows.Forms.Button btnBuyMachineGun;
        private System.Windows.Forms.Button btnBuySonicGun;
        private System.Windows.Forms.RadioButton rdbEquipRifle;
        private System.Windows.Forms.RadioButton rdbEquipSpaceRifle;
        private System.Windows.Forms.RadioButton rdbEquipMachineGun;
        private System.Windows.Forms.RadioButton rdbEquipSonicGun;
        private System.Windows.Forms.Button btnBackShop;
        private System.Windows.Forms.TextBox txtRifleDesc;
        private System.Windows.Forms.TextBox txtSpaceRifleDesc;
        private System.Windows.Forms.TextBox txtMachineGunDesc;
        private System.Windows.Forms.TextBox txtSonicGunDesc;
        private System.Windows.Forms.Label lblBuiltInPistol;
        private System.Windows.Forms.RadioButton rdbEquipBuiltInPistol;
        private System.Windows.Forms.Button btnMainMenuShop;
    }
}
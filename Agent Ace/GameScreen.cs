using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Agent_Ace
{
    // SPSŠ Betlémská, 3.I Karim Boufala
    // Version: 1.2.0 - loads of bug fixes.
    // Version: 1.1.0 - added save and load function.
    // Version: 1.0.0 - game release.
    // Date: 13.05.2021

    public partial class GameScreen : Form
    {
        // Definujem základní proměnné, které budem používat skrz celou hru
        bool up, down, left, right, shot, gameOver, gunOverheat;
        
        double score = 0;
        int enemySpeed = 15;
        int playerSpeed = 12;
        int index = 0;
        int indexObstacle = 0;
        int bulletCount = 0;
        int level1Distance = 3000;
        int bulletSpeed = 40;
        int overHeatValue = 5;

        public static int cash = MainMenu.cash;
        public static bool hasRifle, hasSpaceRifle, hasMachineGun, hasSonicGun;
        int cashPolice = 20, cashSwat = 50, cashVan = 100, cashTank = 200;

        int swathp1, vanhp1, tankhp1;
        int swathp2, vanhp2, tankhp2;

        int riflePrice = 5000, spaceRiflePrice = 7500, machineGunPrice = 15000, sonicGunPrice = 25000;

        Random rnd = new Random();
        Thread thr;

        public GameScreen()
        {
            InitializeComponent();
            // Změněné styl tlačítek a textboxů.
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnRestart.FlatStyle = FlatStyle.Flat;
            btnResume.FlatStyle = FlatStyle.Flat;
            btnShop.FlatStyle = FlatStyle.Flat;
            btnBuyRifle.FlatStyle = FlatStyle.Flat;
            btnBuySpaceRifle.FlatStyle = FlatStyle.Flat;
            btnBuyMachineGun.FlatStyle = FlatStyle.Flat;
            btnBuySonicGun.FlatStyle = FlatStyle.Flat;
            txtRifleDesc.BorderStyle = BorderStyle.None;
            txtSpaceRifleDesc.BorderStyle = BorderStyle.None;
            txtMachineGunDesc.BorderStyle = BorderStyle.None;
            txtSonicGunDesc.BorderStyle = BorderStyle.None;
            btnBackShop.FlatStyle = FlatStyle.Flat;
            btnMainMenuShop.FlatStyle = FlatStyle.Flat;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            // Zase jdeme do fullscreen.
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;

            // Různé nastavení, které se aktivují při načtení formuláře.
            ChangeCar1();
            ChangeCar2();
            ChangeObstacle1();
            ChangeObstacle2();
            lblGunOverheat.Text = "";
            pcbRifle.Visible = false;
            rdbEquipBuiltInPistol.Checked = true;

            // Load Save function
            if (hasRifle == true || Convert.ToBoolean(MainMenu.hasRifleS) == true)
            {
                riflePrice = 0;
                btnBuyRifle.Text = "Free";
            }
            if (hasSpaceRifle == true || Convert.ToBoolean(MainMenu.hasSpaceRifleS) == true)
            {
                spaceRiflePrice = 0;
                btnBuySpaceRifle.Text = "Free";
            }
            if (hasMachineGun == true || Convert.ToBoolean(MainMenu.hasMachineGunS) == true)
            {
                machineGunPrice = 0;
                btnBuyMachineGun.Text = "Free";
            }
            if (hasSonicGun == true || Convert.ToBoolean(MainMenu.hasSonicGunS) == true)
            {
                sonicGunPrice = 0;
                btnBuySonicGun.Text = "Free";
            }
            if (Convert.ToInt32(MainMenu.cashS) > 0)
            {
                cash = Convert.ToInt32(MainMenu.cashS);
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            // Tady vykresluju silnici za pomocí graphics.
            Pen penDash = new Pen(Color.FromArgb(255, 250, 255, 245), 5);
            Pen penLine = new Pen(Color.FromArgb(255, 250, 255, 245), 7);
            penDash.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            e.Graphics.DrawLine(penLine, 0, 240, 1920, 240);
            e.Graphics.DrawLine(penDash, 0, 365, 1920, 365);
            e.Graphics.DrawLine(penDash, 0, 490, 1920, 490);
            e.Graphics.DrawLine(penDash, 0, 615, 1920, 615);
            e.Graphics.DrawLine(penDash, 0, 740, 1920, 740);
            e.Graphics.DrawLine(penLine, 0, 865, 1920, 865);

            // Vykreslí se blok trávníku.
            SolidBrush brushGrass = new SolidBrush(Color.FromArgb(255, 0, 200, 33));
            e.Graphics.FillRectangle(brushGrass, 0, 870, 1920, 237);
            e.Graphics.FillRectangle(brushGrass, 0, 0, 1920, 237);
        }

        // Hlavní časovač, vlastně určuje všechno v téhle hře.
        private void MainTimerEvent(object sender, EventArgs e)
        {
            // Scóre se zvetší každým uplynulým intervalem
            score += 0.5 + (playerSpeed / 50);

            // Progress bar a hra se zastaví když hráč dosáhne cíle.
            if (pgbScore.Value == level1Distance)
            {
                GameTimer.Stop();
                // Odměna.
                MessageBox.Show("You reached the goal of 3000 meters\n      here's a bonus of 10,000$€", "Congratulations you won!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cash += 10000;
                DialogResult msgContinue = MessageBox.Show("Would you like to continue playing?", "Endless mode", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Pokud chce hráč pokračovat, hra se znovu spustí.
                if (msgContinue == System.Windows.Forms.DialogResult.Yes)
                {
                    pgbScore.Maximum = int.MaxValue;
                    level1Distance = int.MaxValue;
                    pgbScore.Enabled = false;
                    playerSpeed = 30;
                    enemySpeed = 35;
                    GameTimer.Start();
                }
                else
                {
                    // Pokud ne tak se hra restartuje.
                    RestartGame();
                }
            }

            if (lblScore.Bounds.IntersectsWith(lblGoal.Bounds))
            {
                lblScore.Left = 1150;
            }
            else
            {
                lblScore.Left = (pgbScore.Value / 3) + 340;
            }

            // Připočání scóre do progress bar
            if (pgbScore.Value > 3001)
            {
                pcbCarScore.Left = 1440;
                lblScore.Left = 1150;
            }
            else
            {
                pgbScore.Maximum = level1Distance;
                pgbScore.Value = Convert.ToInt32(score);
                pcbCarScore.Left = (pgbScore.Value / 3) + 440;
            }

            // Scóre a peníze se každý tik aktualizuje
            lblScore.Text = "Score: " + Math.Round(score, 0) + " m";
            lblCash.Text = "Cashmoney: " + cash + "$€";

            // Zde je hlavní kód pro pohyb hráče, kde player.Top určuje kam až se smí hráč dostat nahorů.
            if (up == true && player.Top > 250)
            {
                player.Top -= playerSpeed;
            }
            if (down == true && player.Top + 320 < this.ClientSize.Height)
            {
                player.Top += playerSpeed;
            }
            if (left == true && player.Left > 100)
            {
                player.Left -= playerSpeed;
            }
            if (right == true && player.Left + 300 < this.ClientSize.Width)
            {
                player.Left += playerSpeed;
            }

            // Pohyb nepřátel. Nepřátelé jsou trochu rychlejší než hráč.
            enemy1.Left -= enemySpeed;
            enemy2.Left -= enemySpeed;
            // Progress bar
            pgbEnemy1.Left -= enemySpeed;
            pgbEnemy2.Left -= enemySpeed;

            // Až se nepřítel dostane mimo obrazovku, změní se jeho poloha pomocí metody ChangeCar.
            if (enemy1.Left + enemy1.Width < 0)
            {
                ChangeCar1();
            }
            if (enemy2.Left + enemy2.Width < 0)
            {
                ChangeCar2();
            }

            // Foreach kontroluje, jestli jsou komponenty ve formuláří.
            foreach (Control x in this.Controls)
            {
                // If který pohybuje s překážkama.
                if (x is PictureBox && (string)x.Tag == "obstacle1")
                {
                    x.Left -= playerSpeed;

                    if (x.Left < -200)
                    {
                        // Překážka se změní na jinou.
                        ChangeObstacle1();
                    }
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        // Pokud se hráč dotkne překážky, aktivuje se metoda GameOver.
                        GameOver();
                    }
                }

                // Překážka 2.
                if (x is PictureBox && (string)x.Tag == "obstacle2")
                {
                    x.Left -= playerSpeed;

                    if (x.Left < -200)
                    {
                        ChangeObstacle2();
                    }
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameOver();
                    }
                }

                // If, který si kontruluje jestli je x Picturbox a má Tag "bullet".
                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    // Pokud jo tak se kulka začne hýbat.
                    x.Left += bulletSpeed;

                    if (x.Left >= 2000)
                    {
                        // Kulka se rozbije pokud vejde z pole hry.
                        RemoveBullet((PictureBox)x);
                    }

                    // If, který pozná, když se kulka s nepřátely potká.
                    if (enemy1.Bounds.IntersectsWith(x.Bounds))
                    {
                        // Switch rozezná, která auta jsou v pictureboxu.
                        switch ((string)enemy1.Tag)
                        {
                            case "police":
                                // Pokud je to policie tak ti dá peníze za polici, resetne hp bar a zničí kulku.
                                cash += cashPolice;
                                pgbEnemy1.Value = 0;
                                RemoveBullet((PictureBox)x);
                                ChangeCar1();
                                break;
                            case "swat":
                                // If kolik hp má konkrétni nepřítel.
                                if (swathp1 > 1)
                                {
                                    swathp1--;
                                    pgbEnemy1.Value--;
                                    RemoveBullet((PictureBox)x);
                                }
                                else
                                {
                                    // Pokud už nemá životy, tak se stane to samé jako u policie.
                                    cash += cashSwat;
                                    pgbEnemy1.Value = 0;
                                    RemoveBullet((PictureBox)x);
                                    ChangeCar1();
                                }
                                break;
                            case "van":
                                if (vanhp1 > 1)
                                {
                                    vanhp1--;
                                    pgbEnemy1.Value--;
                                    RemoveBullet((PictureBox)x);
                                }
                                else
                                {
                                    cash += cashVan;
                                    pgbEnemy1.Value = 0;
                                    RemoveBullet((PictureBox)x);
                                    ChangeCar1();
                                }
                                break;
                            case "tank":
                                if (tankhp1 > 1)
                                {
                                    tankhp1--;
                                    pgbEnemy1.Value--;
                                    RemoveBullet((PictureBox)x);
                                }
                                else
                                {
                                    cash += cashTank;
                                    pgbEnemy1.Value = 0;
                                    RemoveBullet((PictureBox)x);
                                    ChangeCar1();
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    // To stejné taky i pro nepřátele 2.
                    if (enemy2.Bounds.IntersectsWith(x.Bounds))
                    {
                        switch ((string)enemy2.Tag)
                        {
                            case "police":
                                cash += cashPolice;
                                pgbEnemy2.Value = 0;
                                RemoveBullet((PictureBox)x);
                                ChangeCar2();
                                break;
                            case "swat":
                                if (swathp2 > 1)
                                {
                                    swathp2--;
                                    pgbEnemy2.Value--;
                                    RemoveBullet((PictureBox)x);
                                }
                                else
                                {
                                    cash += cashSwat;
                                    pgbEnemy2.Value = 0;
                                    RemoveBullet((PictureBox)x);
                                    ChangeCar2();
                                }
                                break;
                            case "van":
                                if (vanhp2 > 1)
                                {
                                    vanhp2--;
                                    pgbEnemy2.Value--;
                                    RemoveBullet((PictureBox)x);
                                }
                                else
                                {
                                    cash += cashVan;
                                    pgbEnemy2.Value = 0;
                                    RemoveBullet((PictureBox)x);
                                    ChangeCar2();
                                }
                                break;
                            case "tank":
                                if (tankhp2 > 1)
                                {
                                    tankhp2--;
                                    pgbEnemy2.Value--;
                                    RemoveBullet((PictureBox)x);
                                }
                                else
                                {
                                    cash += cashTank;
                                    pgbEnemy2.Value = 0;
                                    RemoveBullet((PictureBox)x);
                                    ChangeCar2();
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            // Pokud se hráč dotkne nepřátel, prohraje
            if (player.Bounds.IntersectsWith(enemy1.Bounds))
            {
                GameOver();
            }
            if (player.Bounds.IntersectsWith(enemy2.Bounds))
            {
                GameOver();
            }

            // Switch který zrychluje rychlost hry při dosažením konkrétní hodnoty scóre.
            switch (score)
            {
                case 200:
                    enemySpeed = 16;
                    playerSpeed = 13;
                    break;
                case 400:
                    enemySpeed = 17;
                    playerSpeed = 14;
                    break;
                case 600:
                    enemySpeed = 18;
                    playerSpeed = 15;
                    break;
                case 800:
                    enemySpeed = 19;
                    playerSpeed = 16;
                    break;
                case 1000:
                    enemySpeed = 20;
                    playerSpeed = 17;
                    break;
                case 1250:
                    enemySpeed = 21;
                    playerSpeed = 18;
                    break;
                case 1500:
                    enemySpeed = 22;
                    playerSpeed = 19;
                    break;
                case 1750:
                    enemySpeed = 23;
                    playerSpeed = 20;
                    break;
                case 2000:
                    enemySpeed = 24;
                    playerSpeed = 21;
                    break;
                case 2500:
                    enemySpeed = 25;
                    playerSpeed = 22;
                    break;
            }

            // Pokud je počet kulek na obrazovce vyžší než hodnota přehřátí zbraně tak se aktivuje GunOverheat metoda.
            if (bulletCount > overHeatValue)
            {
                GunOverheat();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            // Pohyb hráče
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                up = true;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                down = true;
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                right = true;
            }
            // Když hráč zmáčkne escape, hra se zastaví a zobrazí se pause menu
            if (e.KeyCode == Keys.Escape)
            {
                GameTimer.Stop();
                shot = true;
                gunOverheat = true;
                btnResume.Show();
                btnResume.Enabled = true;
                btnMainMenu.Show();
                btnMainMenu.Enabled = true;
                btnRestart.Show();
                btnRestart.Enabled = true;
                btnShop.Show();
                btnShop.Enabled = true;
                pcbMainMenu.Visible = true;
                pcbExplosion.Visible = false;
            }
            // Když hráč zmáčkne space, tak vytvoří novou instanci metody MakeBullet. Při tom musí být všechny tyto metory false.
            if (e.KeyCode == Keys.Space && shot == false && gunOverheat == false && gameOver == false)
            {
                // Ify kontrolují jakou má hráč zbraň vybavenou
                if (rdbEquipBuiltInPistol.Checked)
                {
                    MakeBullet(10, 5);
                    shot = true;
                    bulletSpeed = 40;
                    overHeatValue = 5;
                }
                if (rdbEquipRifle.Checked)
                {
                    MakeBullet(15, 3);
                    shot = true;
                    bulletSpeed = 75;
                    overHeatValue = 4;
                }
                if (rdbEquipSpaceRifle.Checked)
                {
                    MakeSpaceBullet();
                    shot = true;
                    bulletSpeed = 100;
                    overHeatValue = 10;
                }
                if (rdbEquipMachineGun.Checked)
                {
                    MakeMachineGunBullets();
                    shot = true;
                    bulletSpeed = 125;
                    overHeatValue = 15;
                }
                if (rdbEquipSonicGun.Checked)
                {
                    MakeSoniceWave();
                    shot = true;
                    bulletSpeed = 150;
                    overHeatValue = 100;
                }
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            // Pohyb.
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                up = false;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                down = false;
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                right = false;
            }
            if (shot == true)
            {
                shot = false;
            }
            // Pokud je hra prohraná, hráč může hru znovu spustit pomocí enteru.
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }

        private void RestartGame() 
        {
            // Všechny boolean operátory se nastaví na false, i scóre, rychlost hráče a rychlost nepřátel se nastaví na defaultní hodnoty.
            up = false;
            down = false;
            left = false;
            right = false;
            shot = false;
            gameOver = false;
            gunOverheat = false;
            score = 0;
            enemySpeed = 15;
            playerSpeed = 12;
            level1Distance = 3000;
            pgbScore.Enabled = true;
            pgbScore.Value = 0;
            player.Visible = true;

            lblScore.Text = "Score: " + score;
            lblGameOver.Visible = false;
            pcbExplosion.Visible = false;

            // Při restartování hry se změní auta.
            ChangeCar1();
            ChangeCar2();

            // Také změní překážka.
            ChangeObstacle1();
            ChangeObstacle2();

            // Hráč se znovu vrátí na pozici, ve které začal.
            player.Top = 500;
            player.Left = 100;

            pcbCarScore.Top = 116;
            pcbCarScore.Left = 460;

            lblScore.Top = 26;
            lblScore.Left = 379;

            // While loop pro zničení všech střel při restartování hry.
            while (bulletCount > 0)
            {
                foreach (Control x in this.Controls)
                {
                    // if, který zjistí, jestli daný picturebox má Tag bullet.
                    if ((string)x.Tag == "bullet")
                    {
                        // Metedou se zničí všechny kulky
                        RemoveBullet((PictureBox)x);
                    }
                }
            }
            // Při zmáčknutí Enter se game timer zase spustí a hra znovu začne.
            GameTimer.Start();
        }

        private async void GameOver() 
        {
            // Metoda game over zastaví timer hry, to znamená že se všechno zastaví a pomocí metory RestartGame se vrátí vše do defaultních hodnot.
            GameTimer.Stop();
            lblScore.Text = "Score: " + Math.Round(score, 0) + " m";
            lblGameOver.Show();
            pcbExplosion.Show();
            pcbExplosion.Left = player.Left;
            pcbExplosion.Top = player.Top - 50;
            player.Visible = false;
            gameOver = true;

            await Task.Delay(1500);
            pcbExplosion.Visible = false;
        }

        private void RemoveBullet(PictureBox bullet) 
        {
            // Metoda, která kulky zničí.
            this.Controls.Remove(bullet);
            bullet.Dispose();
            bulletCount--;
        }

        private void MakeBullet(int width, int height)
        {
            // Metoda, která kulky vytváří, tady to dělám tak, že si metoda vytvoří nový picturebox a do něj udělá novou kulku.
            PictureBox bullet = new PictureBox();
            // Barva kulky.
            bullet.BackColor = Color.LightGoldenrodYellow;
            // Výška a šířka kulky.
            bullet.Height = height;
            bullet.Width = width;

            // Tady se nastavuje poloha kulky. Mám to udělaný tak, aby se kulka objevila přímo v pravo uprostřed hráče / auta.
            bullet.Left = player.Left + player.Width;
            bullet.Top = player.Top + player.Height / 2;
            
            // Definuje Tag kulky.
            bullet.Tag = "bullet";

            // Kulka se přidá do forms.
            this.Controls.Add(bullet);
            // Kulku přidáme do proměnné bulletCount.
            bulletCount++;
        }

        private void MakeSpaceBullet() 
        {
            // To stjné platí i pro ostatní metody, ale tady chci aby se kulka zobrazila dvakrát, protože Space Rifle má damage x2
            for (int i = 0; i < 2; i++)
            {
                PictureBox bullet = new PictureBox();
                bullet.BackColor = Color.Gainsboro;
                bullet.Height = 3;
                bullet.Width = 15;

                bullet.Left = player.Left + player.Width;
                bullet.Top = player.Top + player.Height / 2;

                bullet.Tag = "bullet";

                this.Controls.Add(bullet);
                bulletCount++;
            }
        }

        private void MakeMachineGunBullets() 
        {
            for (int i = 0; i < 5; i++)
            {
                PictureBox bullet = new PictureBox();
                bullet.BackColor = Color.Yellow;
                bullet.Height = 4;
                bullet.Width = 10;

                bullet.Left = player.Left + player.Width + (50 * i);
                bullet.Top = (player.Top + player.Height / 2);
                bullet.Tag = "bullet";

                this.Controls.Add(bullet);
                bulletCount++;
            }
        }

        private void MakeSoniceWave()
        {
            for (int i = 0; i < 15; i++)
            {
                PictureBox bullet1 = new PictureBox();
                bullet1.BackColor = Color.Transparent;
                bullet1.Height = 300;
                bullet1.Width = 1;

                bullet1.Left = player.Left + player.Width;
                bullet1.Top = (player.Top - 150 + player.Height / 2);
                bullet1.Tag = "bullet";

                this.Controls.Add(bullet1);
                bulletCount++;
            }

            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.Transparent;
            bullet.SizeMode = PictureBoxSizeMode.Zoom;
            bullet.Image = Properties.Resources.sonicWave;
            bullet.Width = rnd.Next(150, 200);
            bullet.Height = rnd.Next(150, 200);

            bullet.Left = player.Left + player.Width;
            bullet.Top = player.Top - 85 + player.Height / 2;
            bullet.Tag = "bullet";

            this.Controls.Add(bullet);
            bulletCount++;
        }

        // Zde jsem použil asynchornní metodu.
        // Tato metoda běží synchronně, dokud nedosáhne proměnnou await, kde je metoda pozastavena, dokud není očekávaná úloha dokončena.
        private async void GunOverheat() 
        {
            // Metodou jsem zabránil hráči aby spammoval spacebar nepřetržitě, aby si hru trochu víc užil.
            shot = true;
            // proměnou gunOverheat zjistíme jestli je nebo není zbraň přehrátá.
            gunOverheat = true;
            // Pokud jo tak nam pomocí lblGunOverheat zobrazí když je zbraň přehřátá a nedá se použít.
            lblGunOverheat.Text = "GUN OVERHEAT";
            // Ify, který kontrolují jaká zbraň je vybraná, a dají tam příslušnou fotku.
            if (rdbEquipBuiltInPistol.Checked)
            {
                player.Image = Properties.Resources.playerCarOverheat;
            }
            if (rdbEquipRifle.Checked)
            {
                player.Image = Properties.Resources.playerCarRifleOverheat;
            }
            if (rdbEquipSpaceRifle.Checked)
            {
                player.Image = Properties.Resources.playerCarSpaceRifleOverheat;
            }
            if (rdbEquipMachineGun.Checked)
            {
                player.Image = Properties.Resources.playerCarMachineGunOverheat;
            }
            if (rdbEquipSonicGun.Checked)
            {
                player.Image = Properties.Resources.playerCarSonicGunOverheat;
            }

            // Zde metoda počká 2000 milisekund.
            await Task.Delay(2000);
            // A po 2000 milisekundách se proměnná vratí na true a hráč zase může střílet.
            lblGunOverheat.Text = "";
            gunOverheat = false;
            // Vratím se na normální fotky.
            if (rdbEquipBuiltInPistol.Checked)
            {
                player.Image = Properties.Resources.playerCar;
            }
            if (rdbEquipRifle.Checked)
            {
                player.Image = Properties.Resources.playerCarRifle;
            }
            if (rdbEquipSpaceRifle.Checked)
            {
                player.Image = Properties.Resources.playerCarSpaceRifle;
            }
            if (rdbEquipMachineGun.Checked)
            {
                player.Image = Properties.Resources.playerCarMachineGun;
            }
            if (rdbEquipSonicGun.Checked)
            {
                player.Image = Properties.Resources.playerCarSonicGun;
            }
        }

        private void ObstacleChangeSet(PictureBox obstacle)
        {
            // Zde změním obrázek, pozici a velikost překážek.
            // Nejdřív random number generator vyvolá náhodné číslo.
            indexObstacle = rnd.Next(1, 5);

            // Překážka zapadne do jedné z pěti pruhů.
            int[] laneArray = new int[] { 245, 370, 495, 620, 745 };
            int randomIndex = rnd.Next(0, laneArray.Length);
            obstacle.Left = rnd.Next(2000, 4001);
            obstacle.Top = laneArray[randomIndex];

            // Náhodné číslo použijem při vybýrání obrázků a velikosti.
            switch (indexObstacle)
            {
                case 1:
                    obstacle.Image = Properties.Resources.glass;
                    obstacle.Width = 115;
                    obstacle.Height = 115;
                    break;
                case 2:
                    obstacle.Image = Properties.Resources.roadBarrier;
                    obstacle.Width = 40;
                    obstacle.Height = 115;
                    break;
                case 3:
                    obstacle.Image = Properties.Resources.manhole;
                    obstacle.Width = 100;
                    obstacle.Height = 100;
                    obstacle.Top += 10;
                    break;
                case 4:
                    obstacle.Image = Properties.Resources.bananaPeel;
                    obstacle.Width = 75;
                    obstacle.Height = 75;
                    obstacle.Top += rnd.Next(10, 30);
                    break;
            }
        }

        // Metody které mění překážky.
        private void ChangeObstacle1() 
        {
            ObstacleChangeSet(obstacle1);
        }

        private void ChangeObstacle2()
        {
            ObstacleChangeSet(obstacle2);
        }

        private void CarChangeSet(PictureBox enemy, ProgressBar pgbEnemy)
        {
            // Funguje stejně jako překážky, až na to, že hummer/van a tanky se budou zobrazovat od většího scóre.
            if (score > 1500)
            {
                // Tanky a hummer.
                index = rnd.Next(1, 5);
            }
            else if (score > 750)
            {
                // Hummer.
                index = rnd.Next(1, 4);
            }
            else
            {
                // Policie nebo SWAT.
                index = rnd.Next(1, 3);
            }

            // Zadefinuje obrázek a životy.
            switch (index)
            {
                case 1:
                    enemy.Image = Properties.Resources.police;
                    enemy.Tag = "police";
                    pgbEnemy.Maximum = 1;
                    pgbEnemy.Value = 1;
                    break;
                case 2:
                    enemy.Image = Properties.Resources.swat;
                    enemy.Tag = "swat";
                    pgbEnemy.Maximum = 3;
                    pgbEnemy.Value = 3;
                    break;
                case 3:
                    enemy.Image = Properties.Resources.van;
                    enemy.Tag = "van";
                    pgbEnemy.Maximum = 5;
                    pgbEnemy.Value = 5;
                    break;
                case 4:
                    enemy.Image = Properties.Resources.tank;
                    enemy.Tag = "tank";
                    pgbEnemy.Maximum = 8;
                    pgbEnemy.Value = 8;
                    break;
            }

            // Přeřadí je do pruhů.
            int[] laneArray = new int[] { 240, 365, 490, 615, 740 };
            int randomIndex = rnd.Next(0, laneArray.Length);
            enemy.Left = rnd.Next(2000, 2501);
            enemy.Top = laneArray[randomIndex];

            pgbEnemy.Left = enemy.Left + 50;
            pgbEnemy.Top = enemy.Top + 7;
            pgbEnemy.Show();
        }

        // Metodý které mění nepřátelské auta.
        private void ChangeCar1()
        {
            swathp1 = 3;
            vanhp1 = 5;
            tankhp1 = 8;
            CarChangeSet(enemy1, pgbEnemy1);
        }

        private void ChangeCar2()
        {
            swathp2 = 3;
            vanhp2 = 5;
            tankhp2 = 8;
            CarChangeSet(enemy2, pgbEnemy2);
        }

        // Menu
        private void LoadMenu(object sender, EventArgs e)
        {
            DialogResult msgMenuLoad = MessageBox.Show("Are you sure you want to go to the main menu?", "Go to main menu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (msgMenuLoad == System.Windows.Forms.DialogResult.Yes)
            {
                MainMenu gameWindow = new MainMenu();
                gameWindow.Show();
                this.Close();
                thr = new Thread(OpenMenu);
                thr.SetApartmentState(ApartmentState.STA);
                thr.Start();
            }
            if (btnBuyRifle.Enabled == false)
            {
                hasRifle = true;
            }
            if (btnBuySpaceRifle.Enabled == false)
            {
                hasSpaceRifle = true;
            }
            if (btnBuyMachineGun.Enabled == false)
            {
                hasMachineGun = true;
            }
            if (btnBuySonicGun.Enabled == false)
            {
                hasSonicGun = true;
            }
        }

        // Tlačítko pokračovat
        private void btnResume_Click(object sender, EventArgs e)
        {
            // Znovu začne hru.
            shot = false;
            gunOverheat = false;
            Pause();
            GameTimer.Start();
        }

        // Tlačítko restartovat hru
        private void btnRestart_Click(object sender, EventArgs e)
        {
            // Restartuje hru
            RestartGame();
            Pause();
        }

        // Tlačítko obchod
        private void btnShop_Click(object sender, EventArgs e)
        {
            // Message Box pokud chce jít uživatel do obchodu koupit si nové zbraně.
            DialogResult msgShop = MessageBox.Show("Are you sure you want to your abondon current run?", "Go to shop", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (msgShop == System.Windows.Forms.DialogResult.Yes)
            {
                // Pokud jo tak ukáže obchod.
                pcbShop.Show();
                pcbRifle.Show();
                pcbSpaceRifle.Show();
                pcbMachineGun.Show();
                pcbSonicGun.Show();
                lblRifleTitle.Show();
                lblSpaceRifleTitle.Show();
                lblMachineGunTitle.Show();
                lblSonicGunTitle.Show();
                lblCashShop.Show();
                lblCashShop.Text = lblCash.Text;
                lblCurrentRig.Show();

                btnBuyRifle.Show();
                txtRifleDesc.Show();

                btnBuySpaceRifle.Show();
                txtSpaceRifleDesc.Show();

                btnBuyMachineGun.Show();
                txtMachineGunDesc.Show();

                lblGameOver.Visible = false;

                btnBuySonicGun.Show();
                txtSonicGunDesc.Show();

                // Pokud uživatel koupil zbraň, tak se zobrazí Radio button, kde si může zbraň navolit.
                if (btnBuyRifle.Enabled == false)
                {
                    rdbEquipRifle.Show();
                    rdbEquipRifle.Enabled = true;
                }
                if (btnBuySpaceRifle.Enabled == false)
                {
                    rdbEquipSpaceRifle.Show();
                    rdbEquipSpaceRifle.Enabled = true;
                }
                if (btnBuyMachineGun.Enabled == false)
                {
                    rdbEquipMachineGun.Show();
                    rdbEquipMachineGun.Enabled = true;
                }
                if (btnBuySonicGun.Enabled == false)
                {
                    rdbEquipSonicGun.Show();
                    rdbEquipSonicGun.Enabled = true;
                }

                lblBuiltInPistol.Show();
                rdbEquipBuiltInPistol.Show();
                rdbEquipBuiltInPistol.Enabled = true;

                btnBackShop.Show();
                btnBackShop.Enabled = true;

                btnMainMenuShop.Show();
                btnMainMenuShop.Enabled = true;
            }
        }

        // Metoda Pause usnadnění kódování.
        private void Pause() 
        {
            btnResume.Visible = false;
            btnResume.Enabled = false;
            btnMainMenu.Visible = false;
            btnMainMenu.Enabled = false;
            btnRestart.Visible = false;
            btnRestart.Enabled = false;
            btnShop.Visible = false;
            btnShop.Enabled = false;
            pcbMainMenu.Visible = false;
        }

        private void OpenMenu(object obj)
        {
            Application.Run(new MainMenu());
        }

        private void InsufficientFunds(int price, Button btnGun, RadioButton rdbGun)
        {
            // Pokud má uživatel nedostatek peněz, tak nemuže koupit zbraň.
            if (cash < price)
            {
                MessageBox.Show("Not enough cashmoney you dingus", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Pokud jo tak mu to vezme prachy
                cash -= price;
                lblCashShop.Text = "Cashmoney: " + cash + "$€";
                btnGun.Text = "!bought!";
                btnGun.BackColor = Color.Chartreuse;
                btnGun.FlatStyle = FlatStyle.Standard;
                btnGun.Enabled = false;
                rdbGun.Enabled = true;
                rdbGun.Visible = true;
            }
        }

        // Metody pro zakoupení zbraní.
        private void btnBuyRifle_Click(object sender, EventArgs e)
        {
            InsufficientFunds(riflePrice, btnBuyRifle, rdbEquipRifle);
        }
        private void btnBuySpaceRifle_Click(object sender, EventArgs e)
        {
            InsufficientFunds(spaceRiflePrice, btnBuySpaceRifle, rdbEquipSpaceRifle);
        }
        private void btnBuyMachineGun_Click(object sender, EventArgs e)
        {
            InsufficientFunds(machineGunPrice, btnBuyMachineGun, rdbEquipMachineGun);
        }
        private void btnBuySonicGun_Click(object sender, EventArgs e)
        {
            InsufficientFunds(sonicGunPrice, btnBuySonicGun, rdbEquipSonicGun);
        }

        // Jít zpátky z obchodu.
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Všechno se znovu zavře.
            pcbShop.Visible = false;
            pcbRifle.Visible = false;
            pcbSpaceRifle.Visible = false;
            pcbMachineGun.Visible = false;
            pcbSonicGun.Visible = false;
            lblRifleTitle.Visible = false;
            lblSpaceRifleTitle.Visible = false;
            lblMachineGunTitle.Visible = false;
            lblSonicGunTitle.Visible = false;
            lblCashShop.Visible = false;
            lblCurrentRig.Visible = false;

            btnBuyRifle.Visible = false;
            txtRifleDesc.Visible = false;

            btnBuySpaceRifle.Visible = false;
            txtSpaceRifleDesc.Visible = false;

            btnBuyMachineGun.Visible = false;
            txtMachineGunDesc.Visible = false;

            btnBuySonicGun.Visible = false;
            txtSonicGunDesc.Visible = false;

            rdbEquipRifle.Visible = false;
            rdbEquipRifle.Enabled = false;
            rdbEquipSpaceRifle.Visible = false;
            rdbEquipSpaceRifle.Enabled = false;
            rdbEquipMachineGun.Visible = false;
            rdbEquipMachineGun.Enabled = false;
            rdbEquipSonicGun.Visible = false;
            rdbEquipSonicGun.Enabled = false;

            lblBuiltInPistol.Visible = false;
            rdbEquipBuiltInPistol.Visible = false;
            rdbEquipBuiltInPistol.Enabled = false;

            btnBackShop.Visible = false;
            btnBackShop.Enabled = false;

            btnMainMenuShop.Visible = false;
            btnMainMenuShop.Enabled = false;

            // Hra se restartuje.
            RestartGame();
            Pause();
        }

        // Metody, které zobrazí obrázek zbraně ve hře.
        private void rdbEquipRifle_CheckedChanged(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.playerCarRifle;
            lblCurrentRig.Text = "Current setup: Rifle";
            lblCurrentGun.Text = "Current gun: Rifle";
        }
        private void rdbEquipSpaceRifle_CheckedChanged(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.playerCarSpaceRifle;
            lblCurrentRig.Text = "Current setup: Space Rifle";
            lblCurrentGun.Text = "Current gun: Space Rifle";
        }
        private void rdbEquipMachineGun_CheckedChanged(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.playerCarMachineGun;
            lblCurrentRig.Text = "Current setup: Machine Gun";
            lblCurrentGun.Text = "Current gun: Machine Gun";
        }
        private void rdbEquipSonicGun_CheckedChanged(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.playerCarSonicGun;
            lblCurrentRig.Text = "Current setup: Sonic Gun";
            lblCurrentGun.Text = "Current gun: Sonic Gun";
        }
        private void rdbEquipBuiltInPistol_CheckedChanged(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.playerCar;
            lblCurrentRig.Text = "Current setup: built in pistol";
            lblCurrentGun.Text = "Current gun: built in pistol";
        }
    }
}

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
using System.IO;

namespace Agent_Ace
{
    // ČZU PEF: Informatics
    // Creator: Karim Boufala

    // Date: 13.05.2024
    // Version: 1.0.0 - game release.
    // Version: 1.1.0 - added save and load function.
    // Version: 1.2.0 - loads of bug fixes.

    public partial class MainMenu : Form
    {
        // Values from the game (if the game was running prior to exiting to the main menu, all values will load back)
        public static int cash;
        public static bool hasRifle, hasSpaceRifle, hasMachineGun, hasSonicGun;
        public static string cashS, hasRifleS, hasSpaceRifleS, hasMachineGunS, hasSonicGunS;

        public MainMenu()
        {
            InitializeComponent();
            hasRifle = GameScreen.hasRifle;
            hasSpaceRifle = GameScreen.hasSpaceRifle;
            hasMachineGun = GameScreen.hasMachineGun;
            hasSonicGun = GameScreen.hasSonicGun;
        }
        Thread thr;

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Auto full screen
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            GameScreen gameWindow = new GameScreen();
            gameWindow.Show();
            this.Close();
            thr = new Thread(OpenGame);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }

        // Save function
        private void btnSaveProgress_Click(object sender, EventArgs e)
        {
            DialogResult msgWarning = MessageBox.Show("You can only save the game in one file.\n        Do you stil want to proceed?", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (msgWarning == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter("save.txt"))
                {
                    sw.WriteLine(GameScreen.cash);
                    sw.WriteLine(GameScreen.hasRifle);
                    sw.WriteLine(GameScreen.hasSpaceRifle);
                    sw.WriteLine(GameScreen.hasMachineGun);
                    sw.WriteLine(GameScreen.hasSonicGun);
                }
            }
        }

        // Load function
        private void btnLoadProgress_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("save.txt"))
            {
                cashS = sr.ReadLine();
                hasRifleS = sr.ReadLine();
                hasSpaceRifleS = sr.ReadLine();
                hasMachineGunS = sr.ReadLine();
                hasSonicGunS = sr.ReadLine();
            }
        }

        private void LoadSettings(object sender, EventArgs e)
        {
            SettingsScreen gameWindow = new SettingsScreen();
            gameWindow.Show();
            this.Close();
            thr = new Thread(OpenSettings);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }

        private void OpenSettings(object obj) 
        {
            Application.Run(new SettingsScreen());
        }
        private void OpenGame(object obj)
        {
            Application.Run(new GameScreen());
        }
    }
}

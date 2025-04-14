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
    // SPSŠ Betlémská, 3.I Karim Boufala
    // Version: 1.2.0 - loads of bug fixes.
    // Version: 1.1.0 - added save and load function.
    // Version: 1.0.0 - game release.
    // Date: 13.05.2021

    public partial class MainMenu : Form
    {
        // Hodnoty ze hry
        public static int cash;
        public static bool hasRifle, hasSpaceRifle, hasMachineGun, hasSonicGun;
        public static string cashS, hasRifleS, hasSpaceRifleS, hasMachineGunS, hasSonicGunS;
        // Třída hlavní menu, kde si uživatel vybere jestli chce hru spustit, jít do nastevní nebo hru ukončit.
        public MainMenu()
        {
            InitializeComponent();
            hasRifle = GameScreen.hasRifle;
            hasSpaceRifle = GameScreen.hasSpaceRifle;
            hasMachineGun = GameScreen.hasMachineGun;
            hasSonicGun = GameScreen.hasSonicGun;
        }
        // Thread pro optimalizaci hry, kde když uživatel klikne na jedno z tlačítek, tak se hlavní menu uzavře.
        Thread thr;

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Kód pro maximalizaci hry, neboli fullscreen.
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Pokud uživatel zmáčkne tlačítko exit, aplikace se uzavře.
            Application.Exit();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            // Tlačítko pro start hry.
            // Tady když uživatel zamáčkne tlačítko, tak se nejdřív zobrazí formulář se hrou a hned na to se hlavní menu zavře.
            GameScreen gameWindow = new GameScreen();
            gameWindow.Show();
            this.Close();
            thr = new Thread(OpenGame);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }

        // Load Save function
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
            // Tlačítko pro nastavení hry.
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

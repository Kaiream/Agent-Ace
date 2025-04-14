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

    public partial class SettingsScreen : Form
    {
        // Hodnoty ze hry.
        public static int cash;
        public static bool hasRifle, hasSpaceRifle, hasMachineGun, hasSonicGun;

        // Hodnota pro tutoriál.
        int indexTutorial = 1;
        public SettingsScreen()
        {
            InitializeComponent();
            cash = Convert.ToInt32(MainMenu.cashS);
            hasRifle = Convert.ToBoolean(MainMenu.hasRifleS);
            hasSpaceRifle = Convert.ToBoolean(MainMenu.hasSpaceRifleS);
            hasMachineGun = Convert.ToBoolean(MainMenu.hasMachineGunS);
            hasSonicGun = Convert.ToBoolean(MainMenu.hasSonicGunS);
        }
        Thread thr;

        private void SettingsScreen_Load(object sender, EventArgs e)
        {
            // Fullscreen.
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void LoadMenu(object sender, EventArgs e)
        {
            // Stejné nastavení jako u Main Menu
            MainMenu gameWindow = new MainMenu();
            gameWindow.Show();
            this.Close();
            thr = new Thread(OpenMenu);
            thr.SetApartmentState(ApartmentState.STA);
            thr.Start();
        }
        private void OpenMenu(object obj)
        {
            Application.Run(new MainMenu());
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Tutorál funguje tak, že si uživatel může překlikovat jak chce, vždycky to vykreslí jiný obrázek s jinýma informacema.
            if (indexTutorial > 0 && indexTutorial < 7)
            {
                indexTutorial++;
                switch (indexTutorial)
                {
                    case 1:
                        pcbMainScreen.Image = Properties.Resources.tutorial1;
                        break;
                    case 2:
                        pcbMainScreen.Image = Properties.Resources.tutorial2;
                        break;
                    case 3:
                        pcbMainScreen.Image = Properties.Resources.tutorial3;
                        break;
                    case 4:
                        pcbMainScreen.Image = Properties.Resources.tutorial4;
                        break;
                    case 5:
                        pcbMainScreen.Image = Properties.Resources.tutorial5;
                        break;
                    case 6:
                        pcbMainScreen.Image = Properties.Resources.tutorial6;
                        break;
                    case 7:
                        pcbMainScreen.Image = Properties.Resources.tutorial7;
                        break;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            indexTutorial--;
            if (indexTutorial > 0 && indexTutorial < 7)
            {
                switch (indexTutorial)
                {
                    case 1:
                        pcbMainScreen.Image = Properties.Resources.tutorial1;
                        break;
                    case 2:
                        pcbMainScreen.Image = Properties.Resources.tutorial2;
                        break;
                    case 3:
                        pcbMainScreen.Image = Properties.Resources.tutorial3;
                        break;
                    case 4:
                        pcbMainScreen.Image = Properties.Resources.tutorial4;
                        break;
                    case 5:
                        pcbMainScreen.Image = Properties.Resources.tutorial5;
                        break;
                    case 6:
                        pcbMainScreen.Image = Properties.Resources.tutorial6;
                        break;
                    case 7:
                        pcbMainScreen.Image = Properties.Resources.tutorial7;
                        break;
                }
            }
            else
            {
                indexTutorial = 1;
            }
        }
    }
}

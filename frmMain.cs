using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleonD_FinalProject_ACS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuMainItemExit_Click(object sender, EventArgs e)
        {
            //exits the application
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //opens the database
            ProgOps.OpenDatabase();
            //loads the images upon form startup
            pbxSpireLogo.Image = DeleonD_FinalProject_ACS.Properties.Resources.LogoMakr_6e3m9S;
            pbxGameBanner.Image = DeleonD_FinalProject_ACS.Properties.Resources.tuxpi_com_1628011368_removebg_preview;
            pbxSpireTower.Image = DeleonD_FinalProject_ACS.Properties.Resources.sidewaysSpire;
            //grabs the help file upon start up
            hlpHelp.HelpNamespace = Application.StartupPath + "\\Help.chm";
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //closes database
            ProgOps.CloseDatabase();
        }

        private void mnuMainItemShop_Click(object sender, EventArgs e)
        {
            //loads the shop now form on menu item click
            frmShopNow frmShopNow = new frmShopNow();
            frmShopNow.ShowDialog();
        }

        private void mnuMainItemAbout_Click(object sender, EventArgs e)
        {
            //loads the About form on start up
            frmAbout frmAbout = new frmAbout();
            frmAbout.ShowDialog();
        }

        private void lblShopNow_Click(object sender, EventArgs e)
        {
            //loads the Shop now form on label click
            frmShopNow frmShopNow = new frmShopNow();
            frmShopNow.ShowDialog();
        }

        private void mnuMainItemHelp_Click(object sender, EventArgs e)
        {
            //instantiates the help file to be loaded on menu item click
            Help.ShowHelp(this, hlpHelp.HelpNamespace);
        }
    }
}

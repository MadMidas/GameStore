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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            //closes form
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }

        private void pbxSpireLogo_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            //loads pictures on start up
            pbxSpireLogo.Image = DeleonD_FinalProject_ACS.Properties.Resources.LogoMakr_6e3m9S;
            pbxGameStock.Image = DeleonD_FinalProject_ACS.Properties.Resources.gamestock;
        }
    }
}

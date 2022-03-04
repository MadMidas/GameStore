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
    public partial class frmShopNow : Form
    {
        //create lists and variables to add values that can be used in other forms
        public static List<string> customerItems = new List<string>();
        public static List<double> customerPrice = new List<double>();
        public static List<int> customerQuantity = new List<int>();
        public static List<double> customerLineTotal = new List<double>();
        public static List<string> customerUPC = new List<string>();
        public static List<int> gameQ = new List<int>();
        public static string gameTitle;
        public double gamePrice;
        public static int gameQuantity;
        public static int custQuantity;
        public static string gameUPC;
        public frmShopNow()
        {
            InitializeComponent();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            //closes form 
            this.Close();
        }

        private void frmShopNow_Load(object sender, EventArgs e)
        {
            //loads the dgvGames with the database info on form load up
            ProgOps.DatabaseCommandVideoGames(dgvGames);
            //loads the pictures on form load up
            pbxSpireLogo.Image = DeleonD_FinalProject_ACS.Properties.Resources.LogoMakr_6e3m9S;
            pbxDestiny.Image = DeleonD_FinalProject_ACS.Properties.Resources.destiny;
            pbxGtaIv.Image = DeleonD_FinalProject_ACS.Properties.Resources.gtaiv;
            pbxPerfectDark.Image = DeleonD_FinalProject_ACS.Properties.Resources.perfectdark;
        }

        private void pbxSpireLogo_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }

        private void dgvGames_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {         
            //create variables
            int imageNum = 0;
            int amount = 0;
            DataGridViewRow game;
            //grab the row index number
            game = dgvGames.Rows[e.RowIndex];
            //add values to the variables dependent on which row is clicked
            imageNum = Convert.ToInt32(game.Cells[5].Value);
            amount = Convert.ToInt32(game.Cells[4].Value);
            gameQuantity = Convert.ToInt32(game.Cells[4].Value);
            gameTitle = Convert.ToString(game.Cells[1].Value);
            gamePrice = Convert.ToDouble(game.Cells[3].Value);
            gameUPC = Convert.ToString(game.Cells[0].Value);
            //loads the picture box with the correct picture dependent upon which game is clicked in the dgvGames
            //and loads the combo box with the appropriate quantity amount
            switch (imageNum)
            {
                case 1:
                    pbxSelectedGame.Image = DeleonD_FinalProject_ACS.Properties.Resources.zelda;
                    cbxAmount.Items.Clear();
                    for (int i = 0; i < amount + 1; i++)
                    {
                        cbxAmount.Items.Add(i);
                    }
                    break;
                case 2:
                    pbxSelectedGame.Image = DeleonD_FinalProject_ACS.Properties.Resources.tonyhawk;
                    cbxAmount.Items.Clear();
                    for (int i = 0; i < amount + 1; i++)
                    {
                        cbxAmount.Items.Add(i);
                    }
                    break;
                case 3:
                    pbxSelectedGame.Image = DeleonD_FinalProject_ACS.Properties.Resources.gtaiv;
                    cbxAmount.Items.Clear();
                    for (int i = 0; i < amount + 1; i++)
                    {
                        cbxAmount.Items.Add(i);
                    }
                    break;
                case 4:
                    pbxSelectedGame.Image = DeleonD_FinalProject_ACS.Properties.Resources.soulCalibur;
                    cbxAmount.Items.Clear();
                    for (int i = 0; i < amount + 1; i++)
                    {
                        cbxAmount.Items.Add(i);
                    }
                    break;
                case 5:
                    pbxSelectedGame.Image = DeleonD_FinalProject_ACS.Properties.Resources.superMario;
                    cbxAmount.Items.Clear();
                    for (int i = 0; i < amount + 1; i++)
                    {
                        cbxAmount.Items.Add(i);
                    }
                    break;
                case 6:
                    pbxSelectedGame.Image = DeleonD_FinalProject_ACS.Properties.Resources.redDead;
                    cbxAmount.Items.Clear();
                    for (int i = 0; i < amount + 1; i++)
                    {
                        cbxAmount.Items.Add(i);
                    }
                    break;
                case 7:
                    pbxSelectedGame.Image = DeleonD_FinalProject_ACS.Properties.Resources.perfectdark;
                    cbxAmount.Items.Clear();
                    for (int i = 0; i < amount + 1; i++)
                    {
                        cbxAmount.Items.Add(i);
                    }
                    break;
                case 8:
                    pbxSelectedGame.Image = DeleonD_FinalProject_ACS.Properties.Resources.metroid;
                    cbxAmount.Items.Clear();
                    for (int i = 0; i < amount + 1; i++)
                    {
                        cbxAmount.Items.Add(i);
                    }
                    break;
                case 9:
                    pbxSelectedGame.Image = DeleonD_FinalProject_ACS.Properties.Resources.batman;
                    cbxAmount.Items.Clear();
                    for (int i = 0; i < amount + 1; i++)
                    {
                        cbxAmount.Items.Add(i);
                    }
                    break;
                case 10:
                    pbxSelectedGame.Image = DeleonD_FinalProject_ACS.Properties.Resources.destiny;
                    cbxAmount.Items.Clear();
                    for (int i = 0; i < amount + 1; i++)
                    {
                        cbxAmount.Items.Add(i);
                    }
                    break;
            }
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            //loads the shopping cart form on button click
            frmShoppingCart frmShoppingCart = new frmShoppingCart();
            frmShoppingCart.ShowDialog();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            //will return and not execute code if the restrictions are met
            if (cbxAmount.Text == "" || cbxAmount.Text == "0")
            {
                MessageBox.Show("Must select an item to add to cart.", "No Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (customerItems.Contains(gameTitle))
            {
                MessageBox.Show("Item in cart!", "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //on add to cart button click, each list has the games seperate values added            
                gameQ.Add(gameQuantity);
                custQuantity = Convert.ToInt32(cbxAmount.Text);
                double quantity = Convert.ToDouble(cbxAmount.Text);
                int updateItemQuantity = 0;
                updateItemQuantity = gameQuantity - Convert.ToInt32(quantity);
                //quantity is updated in real time in the dgvGames
                ProgOps.UpdateQuantity(gameTitle, updateItemQuantity);
                ProgOps.DatabaseCommandVideoGames(dgvGames);
                double total = gamePrice * quantity;
                customerLineTotal.Add(total);
                customerItems.Add(gameTitle);
                customerPrice.Add(gamePrice);
                customerQuantity.Add(Convert.ToInt32(quantity));
                customerUPC.Add(gameUPC);
            }
        }

        private void frmShopNow_Activated(object sender, EventArgs e)
        {
            //allows for the dgvGames to be updated in real time
            ProgOps.DatabaseCommandVideoGames(dgvGames);
        }
    }
}

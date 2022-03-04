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
    public partial class frmShoppingCart : Form
    {
        public frmShoppingCart()
        {
            InitializeComponent();
        }

        private void frmShoppingCart_Load(object sender, EventArgs e)
        {
            //loads the images on start up of form
            pbxSpireLogo.Image = DeleonD_FinalProject_ACS.Properties.Resources.LogoMakr_6e3m9S;
            pbxAmazonPay.Image = DeleonD_FinalProject_ACS.Properties.Resources.amazon;
            pbxGPay.Image = DeleonD_FinalProject_ACS.Properties.Resources.gpay;
            pbxPayPal.Image = DeleonD_FinalProject_ACS.Properties.Resources.PayPal;
            //adds the variables in the lists into the list boxes on start up
            for (int i = 0; i < frmShopNow.customerItems.Count; i++)
            {
                lbxShoppingCart.Items.Add(frmShopNow.customerItems[i]);
                lbxPrice.Items.Add(frmShopNow.customerPrice[i].ToString("c"));
                lbxQuantity.Items.Add(frmShopNow.customerQuantity[i]);
                lbxTotal.Items.Add(frmShopNow.customerLineTotal[i].ToString("c"));
            }
        }

        private void pbxSpireLogo_Click(object sender, EventArgs e)
        {
            //closes form on picture box click
            this.Close();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            //closes form on label click
            this.Close();
        }

        private void lblShoppingCart_Click(object sender, EventArgs e)
        {
            //closes form on label clcik
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //closes form button click
            this.Close();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            //shows message if the cart is empty on clear cart click
            if (lbxShoppingCart.Items.Count == 0)
            {
                MessageBox.Show("Cart is empty.", "Clear Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //asks if user would like to clear cart
            var result = MessageBox.Show("Clear all items in cart?", "Clear Cart", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //if user wants to clear cart 
                //for loop updates the quantity of the games back to the dgvGames
                for (int i = 0; i < lbxShoppingCart.Items.Count; i++)
                {                                     
                     int updateItemQuantity = 0;
                     updateItemQuantity = frmShopNow.gameQ[i];
                     string title = frmShopNow.customerItems[i];
                     ProgOps.UpdateQuantity(title, updateItemQuantity); 
                }
                //clears all the list boxes and lists of their values
                lbxShoppingCart.Items.Clear();
                lbxPrice.Items.Clear();
                lbxQuantity.Items.Clear();
                lbxTotal.Items.Clear();
                frmShopNow.gameQ.Clear();
                frmShopNow.customerItems.Clear();
                frmShopNow.customerPrice.Clear();
                frmShopNow.customerLineTotal.Clear();
                frmShopNow.customerQuantity.Clear();
            }
            else
            {
                return;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //shows message if the cart is empty on remove click
            if (lbxShoppingCart.Items.Count == 0)
            {
                MessageBox.Show("Cart is empty.", "Clear Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //for loop removes the selected item from the list box
            for (int i = 0; i < lbxShoppingCart.Items.Count; i++)
            {
                //if statement to check for the selected game and remove that item from lists 
                //and list boxes as well as update the quantity back to the dgvGames
                if (lbxShoppingCart.SelectedIndex.Equals(i))
                {
                    lbxShoppingCart.Items.RemoveAt(i);
                    lbxPrice.Items.RemoveAt(i);
                    lbxQuantity.Items.RemoveAt(i);
                    lbxTotal.Items.RemoveAt(i);
                    int updateItemQuantity = 0;
                    updateItemQuantity = frmShopNow.gameQ[i];
                    string title = frmShopNow.customerItems[i];
                    ProgOps.UpdateQuantity(title, updateItemQuantity);
                    frmShopNow.gameQ.RemoveAt(i);
                    frmShopNow.customerItems.RemoveAt(i);
                    frmShopNow.customerPrice.RemoveAt(i);
                    frmShopNow.customerLineTotal.RemoveAt(i);
                    frmShopNow.customerQuantity.RemoveAt(i);
                }
            }           
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //create variables
            double subTotal = 0, taxAmount = 0, netTotal = 0, tax = 0.0825;
            //shows message boxes if specific restrictions are met
            if (lbxShoppingCart.Items.Count == 0)
            {
                MessageBox.Show("Cannot checkout with empty cart.", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbxName.Text == "" || tbxEmail.Text == "" || tbxAddress.Text == "")
            {
                MessageBox.Show("Cannot checkout without shipping information.", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //adds all the items price to one variable
            for (int i = 0; i < lbxShoppingCart.Items.Count; i++)
            {
                subTotal += frmShopNow.customerPrice[i];
            }
            //calculates the tax, subtotal, and total 
            taxAmount = subTotal * tax;
            netTotal = taxAmount + subTotal;
            lblSubtotalOutput.Text = subTotal.ToString("c");
            lblTaxOutput.Text = taxAmount.ToString("c");
            lblNetOutput.Text = netTotal.ToString("c");
            string name = tbxName.Text;
            string email = tbxEmail.Text;
            string address = tbxAddress.Text;

            //gets the ids needed to add order to the database with correct ids
            ProgOps.GetIDs();

            //inserts the customers shipping info into the customers table
            ProgOps.InsertIntoCustomers(name, address, email);

            //for loop inserts the correct amount of orders into the order table
            for (int i = 0; i < frmShopNow.customerItems.Count; i++)
            {
                ProgOps.InsertIntoOrders(frmShopNow.customerUPC[i], frmShopNow.customerQuantity[i]);   
            }
            //inserts calculated values into the oder details table
            ProgOps.InsertIntoOrderDetails(subTotal, tax, netTotal);

            //creates and shows the crystal report on the frmReciept
            CrystalReport.crptReciept reciept = new CrystalReport.crptReciept();
            reciept.SetDatabaseLogon("ddeleonsu212353", "1632908");
            frmReciept frmReciept = new frmReciept();
            frmReciept.crvReciept.ReportSource = null;
            frmReciept.crvReciept.ReportSource = reciept;
            frmReciept.Show();
        }
    }
}

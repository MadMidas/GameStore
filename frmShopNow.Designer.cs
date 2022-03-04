namespace DeleonD_FinalProject_ACS
{
    partial class frmShopNow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShopNow));
            this.lblSkyBlueBanner = new System.Windows.Forms.Label();
            this.dgvGames = new System.Windows.Forms.DataGridView();
            this.lblShopNow = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblStoreInfoTitle = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnShoppingCart = new System.Windows.Forms.Button();
            this.lblSelectedGame = new System.Windows.Forms.Label();
            this.lblRecommendedGames = new System.Windows.Forms.Label();
            this.cbxAmount = new System.Windows.Forms.ComboBox();
            this.pbxPerfectDark = new System.Windows.Forms.PictureBox();
            this.pbxGtaIv = new System.Windows.Forms.PictureBox();
            this.pbxDestiny = new System.Windows.Forms.PictureBox();
            this.pbxSelectedGame = new System.Windows.Forms.PictureBox();
            this.pbxSpireLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerfectDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGtaIv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDestiny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelectedGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpireLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSkyBlueBanner
            // 
            this.lblSkyBlueBanner.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblSkyBlueBanner.Location = new System.Drawing.Point(-2, 0);
            this.lblSkyBlueBanner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSkyBlueBanner.Name = "lblSkyBlueBanner";
            this.lblSkyBlueBanner.Size = new System.Drawing.Size(802, 86);
            this.lblSkyBlueBanner.TabIndex = 9;
            // 
            // dgvGames
            // 
            this.dgvGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGames.Location = new System.Drawing.Point(12, 164);
            this.dgvGames.Name = "dgvGames";
            this.dgvGames.ReadOnly = true;
            this.dgvGames.Size = new System.Drawing.Size(775, 150);
            this.dgvGames.TabIndex = 12;
            this.dgvGames.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGames_CellMouseClick);
            // 
            // lblShopNow
            // 
            this.lblShopNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopNow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblShopNow.Location = new System.Drawing.Point(72, 99);
            this.lblShopNow.Name = "lblShopNow";
            this.lblShopNow.Size = new System.Drawing.Size(77, 23);
            this.lblShopNow.TabIndex = 13;
            this.lblShopNow.Text = "Shop Now";
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHome.Location = new System.Drawing.Point(10, 99);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(69, 23);
            this.lblHome.TabIndex = 14;
            this.lblHome.Text = "Home  >";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // lblStoreInfoTitle
            // 
            this.lblStoreInfoTitle.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreInfoTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblStoreInfoTitle.Location = new System.Drawing.Point(12, 122);
            this.lblStoreInfoTitle.Name = "lblStoreInfoTitle";
            this.lblStoreInfoTitle.Size = new System.Drawing.Size(206, 34);
            this.lblStoreInfoTitle.TabIndex = 15;
            this.lblStoreInfoTitle.Text = "GAMES FOR SALE";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddToCart.Location = new System.Drawing.Point(170, 427);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(106, 34);
            this.btnAddToCart.TabIndex = 16;
            this.btnAddToCart.Text = "Add To &Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnShoppingCart
            // 
            this.btnShoppingCart.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnShoppingCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoppingCart.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnShoppingCart.Location = new System.Drawing.Point(170, 506);
            this.btnShoppingCart.Name = "btnShoppingCart";
            this.btnShoppingCart.Size = new System.Drawing.Size(106, 34);
            this.btnShoppingCart.TabIndex = 16;
            this.btnShoppingCart.Text = "&Shopping Cart";
            this.btnShoppingCart.UseVisualStyleBackColor = false;
            this.btnShoppingCart.Click += new System.EventHandler(this.btnShoppingCart_Click);
            // 
            // lblSelectedGame
            // 
            this.lblSelectedGame.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedGame.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSelectedGame.Location = new System.Drawing.Point(8, 317);
            this.lblSelectedGame.Name = "lblSelectedGame";
            this.lblSelectedGame.Size = new System.Drawing.Size(206, 34);
            this.lblSelectedGame.TabIndex = 15;
            this.lblSelectedGame.Text = "SELECTED GAME";
            // 
            // lblRecommendedGames
            // 
            this.lblRecommendedGames.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecommendedGames.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRecommendedGames.Location = new System.Drawing.Point(303, 317);
            this.lblRecommendedGames.Name = "lblRecommendedGames";
            this.lblRecommendedGames.Size = new System.Drawing.Size(259, 34);
            this.lblRecommendedGames.TabIndex = 15;
            this.lblRecommendedGames.Text = "RECOMMENDED GAMES";
            // 
            // cbxAmount
            // 
            this.cbxAmount.FormattingEnabled = true;
            this.cbxAmount.Location = new System.Drawing.Point(170, 369);
            this.cbxAmount.Name = "cbxAmount";
            this.cbxAmount.Size = new System.Drawing.Size(121, 21);
            this.cbxAmount.TabIndex = 18;
            // 
            // pbxPerfectDark
            // 
            this.pbxPerfectDark.Location = new System.Drawing.Point(665, 369);
            this.pbxPerfectDark.Name = "pbxPerfectDark";
            this.pbxPerfectDark.Size = new System.Drawing.Size(133, 171);
            this.pbxPerfectDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPerfectDark.TabIndex = 17;
            this.pbxPerfectDark.TabStop = false;
            // 
            // pbxGtaIv
            // 
            this.pbxGtaIv.Location = new System.Drawing.Point(492, 369);
            this.pbxGtaIv.Name = "pbxGtaIv";
            this.pbxGtaIv.Size = new System.Drawing.Size(133, 171);
            this.pbxGtaIv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxGtaIv.TabIndex = 17;
            this.pbxGtaIv.TabStop = false;
            // 
            // pbxDestiny
            // 
            this.pbxDestiny.Location = new System.Drawing.Point(308, 369);
            this.pbxDestiny.Name = "pbxDestiny";
            this.pbxDestiny.Size = new System.Drawing.Size(133, 171);
            this.pbxDestiny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDestiny.TabIndex = 17;
            this.pbxDestiny.TabStop = false;
            // 
            // pbxSelectedGame
            // 
            this.pbxSelectedGame.Location = new System.Drawing.Point(12, 369);
            this.pbxSelectedGame.Name = "pbxSelectedGame";
            this.pbxSelectedGame.Size = new System.Drawing.Size(133, 171);
            this.pbxSelectedGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSelectedGame.TabIndex = 17;
            this.pbxSelectedGame.TabStop = false;
            // 
            // pbxSpireLogo
            // 
            this.pbxSpireLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxSpireLogo.BackColor = System.Drawing.Color.RoyalBlue;
            this.pbxSpireLogo.Location = new System.Drawing.Point(298, 0);
            this.pbxSpireLogo.Name = "pbxSpireLogo";
            this.pbxSpireLogo.Size = new System.Drawing.Size(154, 86);
            this.pbxSpireLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSpireLogo.TabIndex = 10;
            this.pbxSpireLogo.TabStop = false;
            this.pbxSpireLogo.Click += new System.EventHandler(this.pbxSpireLogo_Click);
            // 
            // frmShopNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.cbxAmount);
            this.Controls.Add(this.pbxPerfectDark);
            this.Controls.Add(this.pbxGtaIv);
            this.Controls.Add(this.pbxDestiny);
            this.Controls.Add(this.pbxSelectedGame);
            this.Controls.Add(this.btnShoppingCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lblRecommendedGames);
            this.Controls.Add(this.lblSelectedGame);
            this.Controls.Add(this.lblStoreInfoTitle);
            this.Controls.Add(this.lblShopNow);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.dgvGames);
            this.Controls.Add(this.pbxSpireLogo);
            this.Controls.Add(this.lblSkyBlueBanner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShopNow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop Now";
            this.Activated += new System.EventHandler(this.frmShopNow_Activated);
            this.Load += new System.EventHandler(this.frmShopNow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPerfectDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGtaIv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDestiny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelectedGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpireLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSpireLogo;
        private System.Windows.Forms.Label lblSkyBlueBanner;
        private System.Windows.Forms.DataGridView dgvGames;
        private System.Windows.Forms.Label lblShopNow;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblStoreInfoTitle;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnShoppingCart;
        private System.Windows.Forms.PictureBox pbxSelectedGame;
        private System.Windows.Forms.PictureBox pbxDestiny;
        private System.Windows.Forms.PictureBox pbxGtaIv;
        private System.Windows.Forms.PictureBox pbxPerfectDark;
        private System.Windows.Forms.Label lblSelectedGame;
        private System.Windows.Forms.Label lblRecommendedGames;
        private System.Windows.Forms.ComboBox cbxAmount;
    }
}
namespace DeleonD_FinalProject_ACS
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblSkyBlueBanner = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblAboutTheProgrammer = new System.Windows.Forms.Label();
            this.lblAboutTheProgram = new System.Windows.Forms.Label();
            this.lblAboutProgrammerInfo = new System.Windows.Forms.Label();
            this.lblAboutProgramInfo = new System.Windows.Forms.Label();
            this.pbxGameStock = new System.Windows.Forms.PictureBox();
            this.pbxSpireLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameStock)).BeginInit();
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
            this.lblSkyBlueBanner.TabIndex = 1;
            // 
            // lblHome
            // 
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHome.Location = new System.Drawing.Point(12, 94);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(69, 23);
            this.lblHome.TabIndex = 6;
            this.lblHome.Text = "Home  >";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAbout.Location = new System.Drawing.Point(74, 94);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(60, 23);
            this.lblAbout.TabIndex = 6;
            this.lblAbout.Text = "About";
            // 
            // lblAboutTheProgrammer
            // 
            this.lblAboutTheProgrammer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutTheProgrammer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAboutTheProgrammer.Location = new System.Drawing.Point(15, 135);
            this.lblAboutTheProgrammer.Name = "lblAboutTheProgrammer";
            this.lblAboutTheProgrammer.Size = new System.Drawing.Size(207, 23);
            this.lblAboutTheProgrammer.TabIndex = 7;
            this.lblAboutTheProgrammer.Text = "About the Programmer";
            // 
            // lblAboutTheProgram
            // 
            this.lblAboutTheProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutTheProgram.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAboutTheProgram.Location = new System.Drawing.Point(11, 287);
            this.lblAboutTheProgram.Name = "lblAboutTheProgram";
            this.lblAboutTheProgram.Size = new System.Drawing.Size(207, 23);
            this.lblAboutTheProgram.TabIndex = 7;
            this.lblAboutTheProgram.Text = "About the Program";
            // 
            // lblAboutProgrammerInfo
            // 
            this.lblAboutProgrammerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutProgrammerInfo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAboutProgrammerInfo.Location = new System.Drawing.Point(16, 180);
            this.lblAboutProgrammerInfo.Name = "lblAboutProgrammerInfo";
            this.lblAboutProgrammerInfo.Size = new System.Drawing.Size(207, 57);
            this.lblAboutProgrammerInfo.TabIndex = 7;
            this.lblAboutProgrammerInfo.Text = "Programmed By: Daniel Deleon\r\nVersion #: 01.0\r\nCompletion Date: 08/10/2021";
            // 
            // lblAboutProgramInfo
            // 
            this.lblAboutProgramInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutProgramInfo.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAboutProgramInfo.Location = new System.Drawing.Point(12, 336);
            this.lblAboutProgramInfo.Name = "lblAboutProgramInfo";
            this.lblAboutProgramInfo.Size = new System.Drawing.Size(711, 73);
            this.lblAboutProgramInfo.TabIndex = 7;
            this.lblAboutProgramInfo.Text = resources.GetString("lblAboutProgramInfo.Text");
            // 
            // pbxGameStock
            // 
            this.pbxGameStock.Location = new System.Drawing.Point(361, 135);
            this.pbxGameStock.Name = "pbxGameStock";
            this.pbxGameStock.Size = new System.Drawing.Size(427, 163);
            this.pbxGameStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGameStock.TabIndex = 9;
            this.pbxGameStock.TabStop = false;
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
            this.pbxSpireLogo.TabIndex = 5;
            this.pbxSpireLogo.TabStop = false;
            this.pbxSpireLogo.Click += new System.EventHandler(this.pbxSpireLogo_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxGameStock);
            this.Controls.Add(this.lblAboutTheProgram);
            this.Controls.Add(this.lblAboutProgramInfo);
            this.Controls.Add(this.lblAboutProgrammerInfo);
            this.Controls.Add(this.lblAboutTheProgrammer);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.pbxSpireLogo);
            this.Controls.Add(this.lblSkyBlueBanner);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpireLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSkyBlueBanner;
        private System.Windows.Forms.PictureBox pbxSpireLogo;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblAboutTheProgrammer;
        private System.Windows.Forms.Label lblAboutTheProgram;
        private System.Windows.Forms.Label lblAboutProgrammerInfo;
        private System.Windows.Forms.Label lblAboutProgramInfo;
        private System.Windows.Forms.PictureBox pbxGameStock;
    }
}
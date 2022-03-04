namespace DeleonD_FinalProject_ACS
{
    partial class frmReciept
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReciept));
            this.crvReciept = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReciept
            // 
            this.crvReciept.AccessibleName = "";
            this.crvReciept.ActiveViewIndex = -1;
            this.crvReciept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReciept.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReciept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReciept.Location = new System.Drawing.Point(0, 0);
            this.crvReciept.Margin = new System.Windows.Forms.Padding(4);
            this.crvReciept.Name = "crvReciept";
            this.crvReciept.Size = new System.Drawing.Size(1067, 554);
            this.crvReciept.TabIndex = 0;
            this.crvReciept.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvReciept.Load += new System.EventHandler(this.crvReciept_Load);
            // 
            // frmReciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.crvReciept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReciept";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Reciept";
            this.Load += new System.EventHandler(this.frmReciept_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvReciept;
    }
}
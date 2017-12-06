namespace WinFormMenu
{
    partial class FrmMenu
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
            this.mnRoot = new System.Windows.Forms.MenuStrip();
            this.mnLoadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRoot.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnRoot
            // 
            this.mnRoot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLoadMenu,
            this.mnExit});
            this.mnRoot.Location = new System.Drawing.Point(0, 0);
            this.mnRoot.Name = "mnRoot";
            this.mnRoot.Size = new System.Drawing.Size(284, 24);
            this.mnRoot.TabIndex = 1;
            this.mnRoot.Text = "menuStrip1";
            // 
            // mnLoadMenu
            // 
            this.mnLoadMenu.Name = "mnLoadMenu";
            this.mnLoadMenu.Size = new System.Drawing.Size(79, 20);
            this.mnLoadMenu.Text = "Load Menu";
            this.mnLoadMenu.Click += new System.EventHandler(this.mnLoadMenu_Click);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(37, 20);
            this.mnExit.Text = "Exit";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.mnRoot);
            this.MainMenuStrip = this.mnRoot;
            this.Name = "FrmMenu";
            this.Text = "Evidea Form";
            this.mnRoot.ResumeLayout(false);
            this.mnRoot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnRoot;
        private System.Windows.Forms.ToolStripMenuItem mnLoadMenu;
        private System.Windows.Forms.ToolStripMenuItem mnExit;

    }
}


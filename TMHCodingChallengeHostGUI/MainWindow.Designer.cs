
namespace TMHCodingChallengeHostGUI
{
    partial class MainWindow
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
            this.menuMainWindow = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChallenges = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDiagDiff = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMainWindow
            // 
            this.menuMainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiChallenges});
            this.menuMainWindow.Location = new System.Drawing.Point(0, 0);
            this.menuMainWindow.Name = "menuMainWindow";
            this.menuMainWindow.Size = new System.Drawing.Size(1008, 24);
            this.menuMainWindow.TabIndex = 2;
            this.menuMainWindow.Text = "Menu";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHome,
            this.tsmiQuit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiHome
            // 
            this.tsmiHome.Name = "tsmiHome";
            this.tsmiHome.Size = new System.Drawing.Size(107, 22);
            this.tsmiHome.Text = "Home";
            this.tsmiHome.Click += new System.EventHandler(this.tsmiHome_Click);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(107, 22);
            this.tsmiQuit.Text = "Quit";
            // 
            // tsmiChallenges
            // 
            this.tsmiChallenges.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDiagDiff});
            this.tsmiChallenges.Name = "tsmiChallenges";
            this.tsmiChallenges.Size = new System.Drawing.Size(77, 20);
            this.tsmiChallenges.Text = "Challenges";
            // 
            // tsmiDiagDiff
            // 
            this.tsmiDiagDiff.Name = "tsmiDiagDiff";
            this.tsmiDiagDiff.Size = new System.Drawing.Size(178, 22);
            this.tsmiDiagDiff.Text = "Diagonal Difference";
            this.tsmiDiagDiff.Click += new System.EventHandler(this.tsmiDiagDiff_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.menuMainWindow);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMainWindow;
            this.Name = "MainWindow";
            this.Text = "TimHerron.Dev Coding GUI";
            this.menuMainWindow.ResumeLayout(false);
            this.menuMainWindow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMainWindow;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiHome;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.ToolStripMenuItem tsmiChallenges;
        private System.Windows.Forms.ToolStripMenuItem tsmiDiagDiff;
    }
}
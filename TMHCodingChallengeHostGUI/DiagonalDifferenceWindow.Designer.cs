
namespace TMHCodingChallengeHostGUI
{
    partial class DiagonalDifferenceWindow
    {


        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            this.tbArray = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbArray
            // 
            this.tbArray.Enabled = false;
            this.tbArray.Font = new System.Drawing.Font("Fira Code Retina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbArray.Location = new System.Drawing.Point(33, 102);
            this.tbArray.Multiline = true;
            this.tbArray.Name = "tbArray";
            this.tbArray.ReadOnly = true;
            this.tbArray.Size = new System.Drawing.Size(389, 201);
            this.tbArray.TabIndex = 0;
            this.tbArray.Text = "1 2 3\r\n4 5 6\r\n7 8 9";
            this.tbArray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DiagonalDifferenceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.ControlBox = false;
            this.Controls.Add(this.tbArray);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiagonalDifferenceWindow";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Diagonal Difference Challenge";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbArray;
    }
}
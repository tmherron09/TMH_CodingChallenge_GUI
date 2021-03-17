
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
            this.rtfResult = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpDiagDiff = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbArray
            // 
            this.tbArray.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbArray.Enabled = false;
            this.tbArray.Font = new System.Drawing.Font("Fira Code Retina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbArray.Location = new System.Drawing.Point(84, 11);
            this.tbArray.MinimumSize = new System.Drawing.Size(300, 300);
            this.tbArray.Multiline = true;
            this.tbArray.Name = "tbArray";
            this.tbArray.ReadOnly = true;
            this.tbArray.Size = new System.Drawing.Size(302, 300);
            this.tbArray.TabIndex = 0;
            this.tbArray.Text = "1 2 3\r\n4 5 6\r\n7 8 9";
            this.tbArray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtfResult
            // 
            this.rtfResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtfResult.BackColor = System.Drawing.Color.PeachPuff;
            this.rtfResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfResult.Enabled = false;
            this.rtfResult.Font = new System.Drawing.Font("Fira Code Retina", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtfResult.Location = new System.Drawing.Point(49, 350);
            this.rtfResult.MinimumSize = new System.Drawing.Size(100, 100);
            this.rtfResult.Name = "rtfResult";
            this.rtfResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtfResult.Size = new System.Drawing.Size(371, 266);
            this.rtfResult.TabIndex = 1;
            this.rtfResult.Text = "";
            this.rtfResult.WordWrap = false;
            this.rtfResult.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.rtfResult_ContentsResized);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rtfResult, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbArray, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 644);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tlpDiagDiff
            // 
            this.tlpDiagDiff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDiagDiff.AutoSize = true;
            this.tlpDiagDiff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpDiagDiff.ColumnCount = 2;
            this.tlpDiagDiff.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDiagDiff.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDiagDiff.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpDiagDiff.Location = new System.Drawing.Point(27, 177);
            this.tlpDiagDiff.MinimumSize = new System.Drawing.Size(300, 300);
            this.tlpDiagDiff.Name = "tlpDiagDiff";
            this.tlpDiagDiff.RowCount = 2;
            this.tlpDiagDiff.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDiagDiff.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDiagDiff.Size = new System.Drawing.Size(300, 300);
            this.tlpDiagDiff.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlpDiagDiff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(470, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 644);
            this.panel1.TabIndex = 5;
            // 
            // DiagonalDifferenceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 644);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DiagonalDifferenceWindow";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Diagonal Difference Challenge";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbArray;
        private System.Windows.Forms.RichTextBox rtfResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpDiagDiff;
        private System.Windows.Forms.Panel panel1;
    }
}
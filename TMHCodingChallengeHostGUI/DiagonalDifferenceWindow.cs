using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMHCodingChallengeHostGUI
{
    public partial class DiagonalDifferenceWindow : Form
    {

        private DiagonalDifference diagDiff = new DiagonalDifference();

        private int Result
        {
            get
            {
                if(diagDiff == null)
                {
                    diagDiff = new DiagonalDifference();
                    
                }
                return diagDiff.DiagonalDifferenceResult();
            }
        }

        public DiagonalDifferenceWindow()
        {
            InitializeComponent();

            tbArray.ReadOnly = true;

            string[] strArr = new string[diagDiff.InputLength];
            for(int i = 0; i < diagDiff.InputLength; i++)
            {
                string lineStr = "";
                for(int j = 0; j < diagDiff.InputLength; j++)
                {
                    lineStr += diagDiff.InputLength - 1 != j ? diagDiff.Arr[i][j].ToString() + " " : diagDiff.Arr[i][j].ToString();
                }
                strArr[i] = lineStr;
            }
            tbArray.Lines = strArr;

            string rtfString = "";
            rtfString = String.Concat(strArr[0], "\n", strArr[1], "\n", strArr[2]);
            rtfResult.AppendText(rtfString);

            DiagDiffPopulateTable(tlpDiagDiff);


        }

        private void rtfResult_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            int margin = 5;
            RichTextBox rch = sender as RichTextBox;
            rch.ClientSize = new Size(
                e.NewRectangle.Width + margin,
                e.NewRectangle.Height + margin);
        }

        private void DiagDiffPopulateTable(TableLayoutPanel table)
        {
            table.ColumnCount = diagDiff.InputLength;
            table.RowCount = diagDiff.InputLength;
            
            //TableLayoutControlCollection diagDiffNumbers = new TableLayoutControlCollection(table);


            for (int i = 0; i < diagDiff.InputLength; i++)
            {
                for (int j = 0; j < diagDiff.InputLength; j++)
                {
                    var cellText = new System.Windows.Forms.Label();
                    cellText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top 
                        | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
                    cellText.AutoSize = true;
                    cellText.Font = new System.Drawing.Font("Fira Code Retina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    cellText.Text = diagDiff.Arr[i][j].ToString();
                    cellText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    table.Controls.Add(cellText, i, j);
                }
            }
            table.Refresh();
            var stop = true;

        }
 
    }
}

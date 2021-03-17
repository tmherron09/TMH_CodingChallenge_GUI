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

        }






    }
}

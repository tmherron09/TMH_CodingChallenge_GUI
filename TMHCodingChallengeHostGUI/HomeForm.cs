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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        public HomeForm(Form parent)
        {
            InitializeComponent();
            this.MdiParent = parent;
            this.WindowState = FormWindowState.Maximized;
            this.Show();
        }


        private void btnDiagDiff_Click(object sender, EventArgs e)
        {
            DiagonalDifferenceWindow ddWindow = new DiagonalDifferenceWindow();
            ddWindow.MdiParent = this.MdiParent;
            ddWindow.Size = this.Size;
            ddWindow.WindowState = FormWindowState.Maximized;
            ddWindow.Show();
            MainWindow.MainWindowCurrentForm = ddWindow;
            this.Close();
        }
    }
}

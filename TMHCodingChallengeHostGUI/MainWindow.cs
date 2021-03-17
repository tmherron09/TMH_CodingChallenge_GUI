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


    public partial class MainWindow : Form
    {
        public static Form MainWindowCurrentForm;
        public MainWindow()
        {
            InitializeComponent();

            HomeForm home = new HomeForm(this);
            home.Size = this.Size;
            MainWindowCurrentForm = home;
        }


        private void miFileHome_Click(object sender, EventArgs e)
        {
            

        }

        private void tsmiDiagDiff_Click(object sender, EventArgs e)
        {
            DiagonalDifferenceWindow ddWindow = new DiagonalDifferenceWindow();
            MainWindowCurrentForm.Close();
            ddWindow.MdiParent = this;
            ddWindow.Size = this.Size;
            ddWindow.WindowState = FormWindowState.Maximized;
            ddWindow.Show();
            MainWindowCurrentForm = ddWindow;
        }

        private void tsmiHome_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            MainWindowCurrentForm.Close();
            home.MdiParent = this;
            home.Size = this.Size;
            home.WindowState = FormWindowState.Maximized;
            home.Show();
            MainWindowCurrentForm = home;
        }
    }
}

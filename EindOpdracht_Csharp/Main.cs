using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EindOpdracht_Csharp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void SystemTrayMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void TrayMenuAboutButton_Click(object sender, EventArgs e)
        {
            StendenWeatherAbout about = new StendenWeatherAbout();
            about.Show();
        }

        private void TrayMenuOptionsButton_Click(object sender, EventArgs e)
        {
            tabMenu.SelectedTab = tabOptions;
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void TrayMenuCloseButton_Click(object sender, EventArgs e)
        { 
            Application.Exit();
        }

        private void TrayMenuRefreshButton_Click(object sender, EventArgs e)
        {

        }

        private void TrayMenuTitle_Click(object sender, EventArgs e)
        {
            tabMenu.SelectedTab = tabCurrent;
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}

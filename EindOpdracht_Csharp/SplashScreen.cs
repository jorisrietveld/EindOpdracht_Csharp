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
    public partial class SplashScreen : Form
    {
        private int timeLeft;

        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timeLeft = 5;
            DelayStartupTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
            }
            else
            {
                DelayStartupTimer.Stop();
                new Main().Show();
                this.Hide();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeaApp
{
    public partial class Startup_screen : Form
    {
        public Startup_screen()
        {
            InitializeComponent();
        }

        private void Startup_screen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // the timer is here to show the loading screen until the progress bar reaches 100%
            timer1.Enabled = true;
            progressBar.Increment(1);
            if (progressBar.Value == 100)
            {
                this.Hide();
                timer1.Enabled = false;
                Form1 form1 = new Form1();
                form1.Show();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace StartGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //countdown
            countdownLabel.Text = "3";

            Refresh();
            Thread.Sleep(1000);

            countdownLabel.Text = "2";

            Refresh();
            Thread.Sleep(1000);

            countdownLabel.Text = "1";

            Refresh();
            Thread.Sleep(1000);

            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.airhorn);
            countdownLabel.Text = "GO!!";

            Refresh();
            Thread.Sleep(1000);

            startButton.ForeColor = Color.Black;
            countdownLabel.ForeColor = Color.Black;
        }

        private void countdownLabel_Click(object sender, EventArgs e)
        {

        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TaskStopwatch
{
    public partial class TaskStopwatch : Form
    {

        public Stopwatch s;
        public TaskStopwatch()
        {
            InitializeComponent();
            s = new Stopwatch();
            timer1.Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            s.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = s.Elapsed.Seconds + "";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            s.Stop();
        }
    }
}

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
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            s.Start();
            ticktimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timeLabel.Text = s.Elapsed.Seconds + "";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            s.Stop();
            ticktimer.Stop();
        }

        private void TaskStopwatch_Load(object sender, EventArgs e)
        {
            this.Text = Program.mainForm.taskTreeView.SelectedNode.Text;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ticktimer_Tick(object sender, EventArgs e)
        {
            singleSecondsLabel.Text = s.Elapsed.Seconds+"";
            singleMinutesLabel.Text = s.Elapsed.Minutes + "";
            singHoursLabel.Text = s.Elapsed.Hours + "";

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            TaskNode node = (TaskNode)(Program.mainForm.taskTreeView.SelectedNode);
            node.Elapsed += s.Elapsed;

            Program.mainForm.taskTreeView.SelectedNode = null;
            Program.mainForm.taskTreeView.SelectedNode = node;
            this.Close();
        }
    }
}

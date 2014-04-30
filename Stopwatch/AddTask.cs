using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaskStopwatch
{
    public partial class AddTask : Form
    {
        public AddTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Must have integers as input times and task must have a title
            if (!(IsInteger(hoursTextBox.Text) && IsInteger(minutesTextBox.Text)) && taskTitleTextBox.Text != "")
            {
                MessageBox.Show("Please only use integers in the textbox inputs and task must have a title");
                return;
            }

            TimeSpan estimatedTime = new TimeSpan( int.Parse(hoursTextBox.Text), int.Parse(minutesTextBox.Text), 0);
            TaskNode newTask = new TaskNode(taskTitleTextBox.Text, estimatedTime);

            if (Program.mainForm.taskTreeView.SelectedNode == null)
            {
                Program.mainForm.taskTreeView.Nodes.Add(newTask);
                Program.mainForm.taskTreeView.SelectedNode = newTask;
            }
            else
            {
                Program.mainForm.taskTreeView.SelectedNode.Nodes.Add(newTask);
                Program.mainForm.taskTreeView.SelectedNode = newTask;
            }

            this.Close();
        }

        /// <summary>
        /// Checks to make sure that object can be converted to an integer by int.parse
        /// </summary>
        /// <param name="Expression">object in question</param>
        public static bool IsInteger(object Expression)
        {
            bool isNum;
            int retNum;

            isNum = int.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void taskTitleTextBox_Enter(object sender, EventArgs e)
        {

        }
    }
}

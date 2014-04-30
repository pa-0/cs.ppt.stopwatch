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
    public partial class EditTask : Form
    {
        public EditTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Must have integers as input times and task must have a title
            if (!(IsInteger(hoursTextBox.Text) && IsInteger(minutesTextBox.Text)))
            {
                MessageBox.Show("Please only use integers in the textbox inputs and task must have a title");
                return;
            }

            var foundNodes =  Program.mainForm.taskTreeView.Nodes.Find(label2.Text, true);

            TaskNode nodeToBeUpdated = (TaskNode)foundNodes[0];
            nodeToBeUpdated.CurrentEstimated = new TimeSpan( int.Parse(hoursTextBox.Text), int.Parse(minutesTextBox.Text), 0);

            Program.mainForm.UpdateNode();

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

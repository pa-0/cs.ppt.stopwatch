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
                MessageBox.Show("Please only use integers in the textbox inputs");
                return;
            }

            TaskNode nodeToBeUpdated = (TaskNode) Program.mainForm.taskTreeView.SelectedNode;

            nodeToBeUpdated.CurrentEstimated = new TimeSpan( int.Parse(hoursTextBox.Text), int.Parse(minutesTextBox.Text), 0);

            Program.mainForm.UpdateNode();

            Program.mainForm.taskTreeView.SelectedNode = null;
            Program.mainForm.taskTreeView.SelectedNode = nodeToBeUpdated;

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

        private void EditTask_Load(object sender, EventArgs e)
        {
            label2.Text = Program.mainForm.taskTreeView.SelectedNode.Text;
            hoursTextBox.Text = ((TaskNode)Program.mainForm.taskTreeView.SelectedNode).CurrentEstimated.Hours+"";
            minutesTextBox.Text = ((TaskNode)Program.mainForm.taskTreeView.SelectedNode).CurrentEstimated.Minutes + "";
        }
    }
}

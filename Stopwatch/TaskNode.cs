using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaskStopwatch
{
    class TaskNode: TreeNode
    {
        //The duration that was originally expected to complete the task
        private TimeSpan originalEstimated;
        public TimeSpan OriginalEstimated
        {
            get { return originalEstimated; }
        }

        //The duration that is currently expected to complete the task
        private TimeSpan currentEstimated;
        public TimeSpan CurrentEstimated
        {
            get { return currentEstimated; }
        }

        //The amount of time already spent on this task
        public TimeSpan Elapsed;

        //constructor that builds the initial node
        public TaskNode(String title, TimeSpan estimatedTime)
        {
            this.Text = title;
            originalEstimated = estimatedTime;

            //the current estimated time is equal to the original until it is specifically changed.
            currentEstimated = estimatedTime;
        }

        //changes the current estimate
        public void changeEstimate(TimeSpan timeChange)
        {
            currentEstimated = currentEstimated + timeChange;
        }
    }
}

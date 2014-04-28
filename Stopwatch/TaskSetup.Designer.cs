namespace TaskStopwatch
{
    partial class TaskSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("PreFabComponent");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("ClearspanMainLibraries", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Truss Design Program", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.taskTitleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.openTaskListButton = new System.Windows.Forms.Button();
            this.saveTaskListButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskTitleTextBox
            // 
            this.taskTitleTextBox.Location = new System.Drawing.Point(75, 12);
            this.taskTitleTextBox.Name = "taskTitleTextBox";
            this.taskTitleTextBox.Size = new System.Drawing.Size(205, 20);
            this.taskTitleTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Task Title:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(101, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Minutes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Weeks";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(101, 48);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(300, 48);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "PreFabComponentNode";
            treeNode7.Text = "PreFabComponent";
            treeNode8.Name = "ClearspanMainLibrariesNode";
            treeNode8.Text = "ClearspanMainLibraries";
            treeNode9.Name = "TrussDesignNode";
            treeNode9.Text = "Truss Design Program";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(307, 249);
            this.treeView1.TabIndex = 14;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // openTaskListButton
            // 
            this.openTaskListButton.Location = new System.Drawing.Point(300, 15);
            this.openTaskListButton.Name = "openTaskListButton";
            this.openTaskListButton.Size = new System.Drawing.Size(108, 23);
            this.openTaskListButton.TabIndex = 15;
            this.openTaskListButton.Text = "Open Task List";
            this.openTaskListButton.UseVisualStyleBackColor = true;
            this.openTaskListButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveTaskListButton
            // 
            this.saveTaskListButton.Location = new System.Drawing.Point(499, 15);
            this.saveTaskListButton.Name = "saveTaskListButton";
            this.saveTaskListButton.Size = new System.Drawing.Size(108, 23);
            this.saveTaskListButton.TabIndex = 16;
            this.saveTaskListButton.Text = "Save Task List";
            this.saveTaskListButton.UseVisualStyleBackColor = true;
            this.saveTaskListButton.Click += new System.EventHandler(this.saveTaskListButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Open Stopwatch for Current Task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TaskSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveTaskListButton);
            this.Controls.Add(this.openTaskListButton);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.taskTitleTextBox);
            this.Controls.Add(this.label1);
            this.Name = "TaskSetup";
            this.Text = "TaskSetup";
            this.Load += new System.EventHandler(this.TaskSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox taskTitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button openTaskListButton;
        private System.Windows.Forms.Button saveTaskListButton;
        private System.Windows.Forms.Button button1;
    }
}
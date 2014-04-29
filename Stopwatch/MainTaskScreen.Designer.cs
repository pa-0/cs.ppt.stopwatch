namespace TaskStopwatch
{
    partial class MainTaskScreen
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("PreFabComponent");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("ClearspanMainLibraries", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Truss Design Program", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.openTaskListButton = new System.Windows.Forms.Button();
            this.saveTaskListButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.taskTitleLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Location = new System.Drawing.Point(300, 48);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "PreFabComponentNode";
            treeNode1.Text = "PreFabComponent";
            treeNode2.Name = "ClearspanMainLibrariesNode";
            treeNode2.Text = "ClearspanMainLibraries";
            treeNode3.Name = "TrussDesignNode";
            treeNode3.Text = "Truss Design Program";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(307, 249);
            this.treeView1.TabIndex = 14;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // openTaskListButton
            // 
            this.openTaskListButton.Location = new System.Drawing.Point(385, 15);
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
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(219, 55);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(75, 66);
            this.addTaskButton.TabIndex = 18;
            this.addTaskButton.Text = "Add Task below current Node";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Task";
            // 
            // taskTitleLabel
            // 
            this.taskTitleLabel.AutoSize = true;
            this.taskTitleLabel.Location = new System.Drawing.Point(85, 25);
            this.taskTitleLabel.Name = "taskTitleLabel";
            this.taskTitleLabel.Size = new System.Drawing.Size(35, 13);
            this.taskTitleLabel.TabIndex = 20;
            this.taskTitleLabel.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(300, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // MainTaskScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.taskTitleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveTaskListButton);
            this.Controls.Add(this.openTaskListButton);
            this.Controls.Add(this.treeView1);
            this.Name = "MainTaskScreen";
            this.Text = "TaskSetup";
            this.Load += new System.EventHandler(this.TaskSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openTaskListButton;
        private System.Windows.Forms.Button saveTaskListButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label taskTitleLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.TreeView treeView1;
    }
}
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
            this.components = new System.ComponentModel.Container();
            this.taskTreeView = new System.Windows.Forms.TreeView();
            this.openTaskListButton = new System.Windows.Forms.Button();
            this.saveTaskListButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.taskTitleLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TaskNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalEstimateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElapsedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTaskScreenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTaskScreenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // taskTreeView
            // 
            this.taskTreeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.taskTreeView.Location = new System.Drawing.Point(300, 48);
            this.taskTreeView.Name = "taskTreeView";
            this.taskTreeView.Size = new System.Drawing.Size(380, 249);
            this.taskTreeView.TabIndex = 14;
            this.taskTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.taskTreeView_AfterSelect);
            // 
            // openTaskListButton
            // 
            this.openTaskListButton.Location = new System.Drawing.Point(435, 15);
            this.openTaskListButton.Name = "openTaskListButton";
            this.openTaskListButton.Size = new System.Drawing.Size(108, 23);
            this.openTaskListButton.TabIndex = 15;
            this.openTaskListButton.Text = "Open Task List";
            this.openTaskListButton.UseVisualStyleBackColor = true;
            this.openTaskListButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveTaskListButton
            // 
            this.saveTaskListButton.Location = new System.Drawing.Point(564, 15);
            this.saveTaskListButton.Name = "saveTaskListButton";
            this.saveTaskListButton.Size = new System.Drawing.Size(108, 23);
            this.saveTaskListButton.TabIndex = 16;
            this.saveTaskListButton.Text = "Save Task List";
            this.saveTaskListButton.UseVisualStyleBackColor = true;
            this.saveTaskListButton.Click += new System.EventHandler(this.saveTaskListButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 130);
            this.button1.TabIndex = 17;
            this.button1.Text = "Open Stopwatch for Current Task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(219, 48);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Selected Task:";
            // 
            // taskTitleLabel
            // 
            this.taskTitleLabel.AutoSize = true;
            this.taskTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTitleLabel.Location = new System.Drawing.Point(13, 131);
            this.taskTitleLabel.Name = "taskTitleLabel";
            this.taskTitleLabel.Size = new System.Drawing.Size(79, 29);
            this.taskTitleLabel.TabIndex = 20;
            this.taskTitleLabel.Text = "label2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskNameColumn,
            this.OriginalEstimateColumn,
            this.Column2,
            this.ElapsedColumn});
            this.dataGridView1.Location = new System.Drawing.Point(210, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(470, 238);
            this.dataGridView1.TabIndex = 21;
            // 
            // TaskNameColumn
            // 
            this.TaskNameColumn.HeaderText = "Task";
            this.TaskNameColumn.Name = "TaskNameColumn";
            this.TaskNameColumn.ReadOnly = true;
            this.TaskNameColumn.Width = 120;
            // 
            // OriginalEstimateColumn
            // 
            this.OriginalEstimateColumn.HeaderText = "Original Estimate";
            this.OriginalEstimateColumn.Name = "OriginalEstimateColumn";
            this.OriginalEstimateColumn.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Current Estimate";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ElapsedColumn
            // 
            this.ElapsedColumn.HeaderText = "Elapsed Time";
            this.ElapsedColumn.Name = "ElapsedColumn";
            this.ElapsedColumn.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(300, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "New Task List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 66);
            this.button3.TabIndex = 23;
            this.button3.Text = "Delete Current Node";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(219, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 66);
            this.button4.TabIndex = 24;
            this.button4.Text = "Edit Current Node\'s Estimate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainTaskScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 541);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.taskTitleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveTaskListButton);
            this.Controls.Add(this.openTaskListButton);
            this.Controls.Add(this.taskTreeView);
            this.Name = "MainTaskScreen";
            this.Text = "TaskSetup";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainTaskScreenBindingSource)).EndInit();
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
        internal System.Windows.Forms.TreeView taskTreeView;
        private System.Windows.Forms.BindingSource mainTaskScreenBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalEstimateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElapsedColumn;
        internal System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
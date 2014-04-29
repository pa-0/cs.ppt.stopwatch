namespace TaskStopwatch
{
    partial class TaskStopwatch
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
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.singleSecondsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.singleMinutesLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.singHoursLabel = new System.Windows.Forms.Label();
            this.ticktimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 218);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(201, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(219, 218);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(201, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(219, 247);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(201, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 247);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(201, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // singleSecondsLabel
            // 
            this.singleSecondsLabel.AutoSize = true;
            this.singleSecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleSecondsLabel.Location = new System.Drawing.Point(356, 9);
            this.singleSecondsLabel.Name = "singleSecondsLabel";
            this.singleSecondsLabel.Size = new System.Drawing.Size(51, 55);
            this.singleSecondsLabel.TabIndex = 4;
            this.singleSecondsLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 55);
            this.label2.TabIndex = 9;
            this.label2.Text = "Minutes";
            // 
            // singleMinutesLabel
            // 
            this.singleMinutesLabel.AutoSize = true;
            this.singleMinutesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleMinutesLabel.Location = new System.Drawing.Point(356, 64);
            this.singleMinutesLabel.Name = "singleMinutesLabel";
            this.singleMinutesLabel.Size = new System.Drawing.Size(51, 55);
            this.singleMinutesLabel.TabIndex = 7;
            this.singleMinutesLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 55);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hours";
            // 
            // singHoursLabel
            // 
            this.singHoursLabel.AutoSize = true;
            this.singHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singHoursLabel.Location = new System.Drawing.Point(356, 119);
            this.singHoursLabel.Name = "singHoursLabel";
            this.singHoursLabel.Size = new System.Drawing.Size(51, 55);
            this.singHoursLabel.TabIndex = 10;
            this.singHoursLabel.Text = "0";
            // 
            // ticktimer
            // 
            this.ticktimer.Tick += new System.EventHandler(this.ticktimer_Tick);
            // 
            // TaskStopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 273);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.singHoursLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.singleMinutesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.singleSecondsLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Name = "TaskStopwatch";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TaskStopwatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label singleSecondsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label singleMinutesLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label singHoursLabel;
        private System.Windows.Forms.Timer ticktimer;
    }
}


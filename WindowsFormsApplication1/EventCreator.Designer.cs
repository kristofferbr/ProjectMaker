namespace ProjectMaker
{
    partial class EventCreator
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
            this.eventName = new System.Windows.Forms.Label();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.startDate = new System.Windows.Forms.Label();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.amountOfDays = new System.Windows.Forms.Label();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.createEvent = new System.Windows.Forms.Button();
            this.abort = new System.Windows.Forms.Button();
            this.startTime = new System.Windows.Forms.Label();
            this.startTimeTextBox = new System.Windows.Forms.TextBox();
            this.endTimeTextBox = new System.Windows.Forms.TextBox();
            this.endTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eventName
            // 
            this.eventName.AutoSize = true;
            this.eventName.Location = new System.Drawing.Point(13, 13);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(111, 13);
            this.eventName.TabIndex = 0;
            this.eventName.Text = "Begivenhedens navn:";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(13, 30);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.eventNameTextBox.TabIndex = 1;
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(13, 62);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(127, 13);
            this.startDate.TabIndex = 2;
            this.startDate.Text = "Start dato (mm/dd/åååå):";
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Location = new System.Drawing.Point(13, 78);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(127, 20);
            this.startDateTextBox.TabIndex = 3;
            // 
            // amountOfDays
            // 
            this.amountOfDays.AutoSize = true;
            this.amountOfDays.Location = new System.Drawing.Point(146, 62);
            this.amountOfDays.Name = "amountOfDays";
            this.amountOfDays.Size = new System.Drawing.Size(61, 13);
            this.amountOfDays.TabIndex = 4;
            this.amountOfDays.Text = "Antal dage:";
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(146, 78);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(123, 20);
            this.daysTextBox.TabIndex = 5;
            // 
            // createEvent
            // 
            this.createEvent.Location = new System.Drawing.Point(194, 162);
            this.createEvent.Name = "createEvent";
            this.createEvent.Size = new System.Drawing.Size(75, 23);
            this.createEvent.TabIndex = 6;
            this.createEvent.Text = "Opret";
            this.createEvent.UseVisualStyleBackColor = true;
            this.createEvent.Click += new System.EventHandler(this.createEvent_Click);
            // 
            // abort
            // 
            this.abort.Location = new System.Drawing.Point(113, 162);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(75, 23);
            this.abort.TabIndex = 7;
            this.abort.Text = "Fortryd";
            this.abort.UseVisualStyleBackColor = true;
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Location = new System.Drawing.Point(12, 110);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(120, 13);
            this.startTime.TabIndex = 8;
            this.startTime.Text = "Start tidspunkt (TT:mm):";
            // 
            // startTimeTextBox
            // 
            this.startTimeTextBox.Location = new System.Drawing.Point(13, 127);
            this.startTimeTextBox.Name = "startTimeTextBox";
            this.startTimeTextBox.Size = new System.Drawing.Size(127, 20);
            this.startTimeTextBox.TabIndex = 9;
            // 
            // endTimeTextBox
            // 
            this.endTimeTextBox.Location = new System.Drawing.Point(147, 127);
            this.endTimeTextBox.Name = "endTimeTextBox";
            this.endTimeTextBox.Size = new System.Drawing.Size(122, 20);
            this.endTimeTextBox.TabIndex = 11;
            // 
            // endTime
            // 
            this.endTime.AutoSize = true;
            this.endTime.Location = new System.Drawing.Point(146, 110);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(116, 13);
            this.endTime.TabIndex = 10;
            this.endTime.Text = "Slut tidspunkt (TT:mm):";
            // 
            // EventCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 197);
            this.Controls.Add(this.endTimeTextBox);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTimeTextBox);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.createEvent);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.amountOfDays);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.eventName);
            this.Name = "EventCreator";
            this.Text = "EventCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventName;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.Label amountOfDays;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.Button createEvent;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.TextBox startTimeTextBox;
        private System.Windows.Forms.TextBox endTimeTextBox;
        private System.Windows.Forms.Label endTime;
    }
}
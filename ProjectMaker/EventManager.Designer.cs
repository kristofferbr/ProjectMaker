namespace ProjectMaker
{
    partial class EventManager
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
            this.button1 = new System.Windows.Forms.Button();
            this.Navn = new System.Windows.Forms.TextBox();
            this.TidFra = new System.Windows.Forms.TextBox();
            this.TidTil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Opgave = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TaskTimeStart = new System.Windows.Forms.TextBox();
            this.TaskTimeEnd = new System.Windows.Forms.TextBox();
            this.AddTask = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.WorkerBox = new System.Windows.Forms.ListBox();
            this.TimeBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TaskBox = new System.Windows.Forms.ListBox();
            this.DeleteData = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generér";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Navn
            // 
            this.Navn.Location = new System.Drawing.Point(12, 66);
            this.Navn.Name = "Navn";
            this.Navn.Size = new System.Drawing.Size(100, 20);
            this.Navn.TabIndex = 2;
            this.Navn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TidFra
            // 
            this.TidFra.Location = new System.Drawing.Point(37, 120);
            this.TidFra.Name = "TidFra";
            this.TidFra.Size = new System.Drawing.Size(100, 20);
            this.TidFra.TabIndex = 3;
            // 
            // TidTil
            // 
            this.TidTil.Location = new System.Drawing.Point(37, 146);
            this.TidTil.Name = "TidTil";
            this.TidTil.Size = new System.Drawing.Size(100, 20);
            this.TidTil.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Navn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fri";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Tilføj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Til";
            // 
            // Opgave
            // 
            this.Opgave.AutoSize = true;
            this.Opgave.Location = new System.Drawing.Point(13, 265);
            this.Opgave.Name = "Opgave";
            this.Opgave.Size = new System.Drawing.Size(72, 13);
            this.Opgave.TabIndex = 11;
            this.Opgave.Text = "Opgave navn";
            // 
            // TaskName
            // 
            this.TaskName.Location = new System.Drawing.Point(12, 282);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(100, 20);
            this.TaskName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Til";
            // 
            // TaskTimeStart
            // 
            this.TaskTimeStart.Location = new System.Drawing.Point(37, 315);
            this.TaskTimeStart.Name = "TaskTimeStart";
            this.TaskTimeStart.Size = new System.Drawing.Size(100, 20);
            this.TaskTimeStart.TabIndex = 15;
            // 
            // TaskTimeEnd
            // 
            this.TaskTimeEnd.Location = new System.Drawing.Point(37, 341);
            this.TaskTimeEnd.Name = "TaskTimeEnd";
            this.TaskTimeEnd.Size = new System.Drawing.Size(100, 20);
            this.TaskTimeEnd.TabIndex = 16;
            // 
            // AddTask
            // 
            this.AddTask.Location = new System.Drawing.Point(37, 368);
            this.AddTask.Name = "AddTask";
            this.AddTask.Size = new System.Drawing.Size(75, 23);
            this.AddTask.TabIndex = 17;
            this.AddTask.Text = "Tilføj";
            this.AddTask.UseVisualStyleBackColor = true;
            this.AddTask.Click += new System.EventHandler(this.AddTask_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Medlemmer";
            // 
            // WorkerBox
            // 
            this.WorkerBox.Location = new System.Drawing.Point(310, 47);
            this.WorkerBox.Name = "WorkerBox";
            this.WorkerBox.Size = new System.Drawing.Size(120, 160);
            this.WorkerBox.TabIndex = 19;
            this.WorkerBox.SelectedIndexChanged += new System.EventHandler(this.WorkerBox_SelectedIndexChanged);
            // 
            // TimeBox
            // 
            this.TimeBox.Location = new System.Drawing.Point(509, 47);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(120, 368);
            this.TimeBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(506, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tider";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Opgaver";
            // 
            // TaskBox
            // 
            this.TaskBox.FormattingEnabled = true;
            this.TaskBox.Location = new System.Drawing.Point(310, 242);
            this.TaskBox.Name = "TaskBox";
            this.TaskBox.Size = new System.Drawing.Size(120, 173);
            this.TaskBox.TabIndex = 23;
            this.TaskBox.SelectedIndexChanged += new System.EventHandler(this.TaskBox_SelectedIndexChanged);
            // 
            // DeleteData
            // 
            this.DeleteData.Location = new System.Drawing.Point(12, 447);
            this.DeleteData.Name = "DeleteData";
            this.DeleteData.Size = new System.Drawing.Size(75, 23);
            this.DeleteData.TabIndex = 24;
            this.DeleteData.Text = "Slet Data";
            this.DeleteData.UseVisualStyleBackColor = true;
            this.DeleteData.Click += new System.EventHandler(this.DeleteData_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(505, 447);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 25;
            this.Save.Text = "Gem";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EventManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 482);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DeleteData);
            this.Controls.Add(this.TaskBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.WorkerBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddTask);
            this.Controls.Add(this.TaskTimeEnd);
            this.Controls.Add(this.TaskTimeStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.Opgave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TidTil);
            this.Controls.Add(this.TidFra);
            this.Controls.Add(this.Navn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EventManager";
            this.Text = "ProjectMaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Navn;
        private System.Windows.Forms.TextBox TidFra;
        private System.Windows.Forms.TextBox TidTil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Opgave;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TaskTimeStart;
        private System.Windows.Forms.TextBox TaskTimeEnd;
        private System.Windows.Forms.Button AddTask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox WorkerBox;
        private System.Windows.Forms.ListBox TimeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox TaskBox;
        private System.Windows.Forms.Button DeleteData;
        private System.Windows.Forms.Button Save;


      
    }
}


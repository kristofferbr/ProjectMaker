namespace ProjectMaker
{
    partial class EventOverview
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newEvent_Button = new System.Windows.Forms.Button();
            this.taskDataGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabController = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.workerDataGrid = new System.Windows.Forms.DataGridView();
            this.initials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityOrigins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.driverLicense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGrid)).BeginInit();
            this.tabController.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(109, 472);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(127, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(557, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newEvent_Button
            // 
            this.newEvent_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newEvent_Button.Location = new System.Drawing.Point(12, 542);
            this.newEvent_Button.Name = "newEvent_Button";
            this.newEvent_Button.Size = new System.Drawing.Size(109, 23);
            this.newEvent_Button.TabIndex = 3;
            this.newEvent_Button.Text = "Tilføj";
            this.newEvent_Button.UseVisualStyleBackColor = true;
            this.newEvent_Button.Click += new System.EventHandler(this.newEvent_Click);
            // 
            // taskDataGrid
            // 
            this.taskDataGrid.AllowUserToAddRows = false;
            this.taskDataGrid.AllowUserToDeleteRows = false;
            this.taskDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.description,
            this.duration,
            this.Location,
            this.Column1});
            this.taskDataGrid.Location = new System.Drawing.Point(3, 3);
            this.taskDataGrid.Name = "taskDataGrid";
            this.taskDataGrid.ReadOnly = true;
            this.taskDataGrid.Size = new System.Drawing.Size(543, 226);
            this.taskDataGrid.TabIndex = 4;
            // 
            // name
            // 
            this.name.HeaderText = "Opgave navn";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Start tid";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // duration
            // 
            this.duration.HeaderText = "Varighed";
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.HeaderText = "Sted";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Beskrivelse";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // tabController
            // 
            this.tabController.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabController.Controls.Add(this.tabPage1);
            this.tabController.Controls.Add(this.tabPage2);
            this.tabController.Location = new System.Drawing.Point(127, 39);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(557, 258);
            this.tabController.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.taskDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Opgaver";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.workerDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Arbejdere";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // workerDataGrid
            // 
            this.workerDataGrid.AllowUserToAddRows = false;
            this.workerDataGrid.AllowUserToDeleteRows = false;
            this.workerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workerDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.initials,
            this.workerName,
            this.cityOrigins,
            this.driverLicense,
            this.phoneNumber,
            this.activeTime});
            this.workerDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workerDataGrid.Location = new System.Drawing.Point(3, 3);
            this.workerDataGrid.Name = "workerDataGrid";
            this.workerDataGrid.ReadOnly = true;
            this.workerDataGrid.Size = new System.Drawing.Size(543, 226);
            this.workerDataGrid.TabIndex = 0;
            // 
            // initials
            // 
            this.initials.HeaderText = "Initialer";
            this.initials.Name = "initials";
            this.initials.ReadOnly = true;
            // 
            // workerName
            // 
            this.workerName.HeaderText = "Navn";
            this.workerName.Name = "workerName";
            this.workerName.ReadOnly = true;
            // 
            // cityOrigins
            // 
            this.cityOrigins.HeaderText = "By";
            this.cityOrigins.Name = "cityOrigins";
            this.cityOrigins.ReadOnly = true;
            // 
            // driverLicense
            // 
            this.driverLicense.HeaderText = "Må køre?";
            this.driverLicense.Name = "driverLicense";
            this.driverLicense.ReadOnly = true;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Telefon";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            // 
            // activeTime
            // 
            this.activeTime.HeaderText = "Medlem tid";
            this.activeTime.Name = "activeTime";
            this.activeTime.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(13, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Rediger";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EventOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 581);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.newEvent_Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "EventOverview";
            this.Text = "EventOverview";
            this.Load += new System.EventHandler(this.EventOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskDataGrid)).EndInit();
            this.tabController.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workerDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button newEvent_Button;
        private System.Windows.Forms.DataGridView taskDataGrid;
        private System.Windows.Forms.TabControl tabController;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView workerDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn initials;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityOrigins;
        private System.Windows.Forms.DataGridViewTextBoxColumn driverLicense;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;

    }
}
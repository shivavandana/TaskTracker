namespace TaskTrackerApp
{
    partial class TaskTracker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskTracker));
            this.projectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.projectNameComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hoursNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.projectTypeLabel = new System.Windows.Forms.Label();
            this.projectNamelabel = new System.Windows.Forms.Label();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.projectTypeValidatorLabel = new System.Windows.Forms.Label();
            this.projectNameValidatorLabel = new System.Windows.Forms.Label();
            this.taskNameValidatorLabel = new System.Windows.Forms.Label();
            this.statusValidatorLabel = new System.Windows.Forms.Label();
            this.hoursValidatorLabel = new System.Windows.Forms.Label();
            this.MoveToExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CommonMessage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.taskNameTextArea = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.taskId_Control = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CommonMessage1 = new System.Windows.Forms.Label();
            this.total_Hours = new System.Windows.Forms.Label();
            this.totalHours_text = new System.Windows.Forms.TextBox();
            this.taskTrackerlabel = new System.Windows.Forms.Label();
            this.CommonMesage = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // projectTypeComboBox
            // 
            this.projectTypeComboBox.DisplayMember = "-1";
            this.projectTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectTypeComboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTypeComboBox.FormattingEnabled = true;
            this.projectTypeComboBox.Location = new System.Drawing.Point(149, 218);
            this.projectTypeComboBox.Name = "projectTypeComboBox";
            this.projectTypeComboBox.Size = new System.Drawing.Size(205, 23);
            this.projectTypeComboBox.TabIndex = 1;
            this.projectTypeComboBox.ValueMember = "-1";
            this.projectTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.projectTypeComboBox_SelectedIndexChanged);
            // 
            // projectNameComboBox
            // 
            this.projectNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectNameComboBox.FormattingEnabled = true;
            this.projectNameComboBox.Location = new System.Drawing.Point(510, 216);
            this.projectNameComboBox.Name = "projectNameComboBox";
            this.projectNameComboBox.Size = new System.Drawing.Size(205, 21);
            this.projectNameComboBox.TabIndex = 2;
            this.projectNameComboBox.SelectedIndexChanged += new System.EventHandler(this.projectNameComboBox_SelectedIndexChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Highlight;
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(510, 268);
            this.dateTimePicker.MinDate = new System.DateTime(2016, 4, 7, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(205, 23);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2016, 4, 7, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // hoursNumericUpDown
            // 
            this.hoursNumericUpDown.Location = new System.Drawing.Point(150, 368);
            this.hoursNumericUpDown.Name = "hoursNumericUpDown";
            this.hoursNumericUpDown.Size = new System.Drawing.Size(204, 20);
            this.hoursNumericUpDown.TabIndex = 7;
            this.hoursNumericUpDown.ValueChanged += new System.EventHandler(this.hoursNumericUpDown_ValueChanged);
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(510, 320);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(205, 21);
            this.statusComboBox.TabIndex = 8;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.submitButton.Location = new System.Drawing.Point(173, 537);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 30);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.Control;
            this.resetButton.Location = new System.Drawing.Point(342, 537);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 30);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // projectTypeLabel
            // 
            this.projectTypeLabel.AutoSize = true;
            this.projectTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectTypeLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.projectTypeLabel.Location = new System.Drawing.Point(35, 218);
            this.projectTypeLabel.Name = "projectTypeLabel";
            this.projectTypeLabel.Size = new System.Drawing.Size(85, 18);
            this.projectTypeLabel.TabIndex = 12;
            this.projectTypeLabel.Text = "Project Type";
            // 
            // projectNamelabel
            // 
            this.projectNamelabel.AutoSize = true;
            this.projectNamelabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNamelabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.projectNamelabel.Location = new System.Drawing.Point(411, 219);
            this.projectNamelabel.Name = "projectNamelabel";
            this.projectNamelabel.Size = new System.Drawing.Size(92, 18);
            this.projectNamelabel.TabIndex = 13;
            this.projectNamelabel.Text = "Project Name";
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.taskNameLabel.Location = new System.Drawing.Point(34, 262);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(108, 18);
            this.taskNameLabel.TabIndex = 18;
            this.taskNameLabel.Text = "Task Description";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dateLabel.Location = new System.Drawing.Point(412, 268);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(37, 18);
            this.dateLabel.TabIndex = 19;
            this.dateLabel.Text = "Date";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.statusLabel.Location = new System.Drawing.Point(412, 323);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(46, 18);
            this.statusLabel.TabIndex = 20;
            this.statusLabel.Text = "Status";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.hoursLabel.Location = new System.Drawing.Point(36, 369);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(44, 18);
            this.hoursLabel.TabIndex = 21;
            this.hoursLabel.Text = "Hours";
            // 
            // projectTypeValidatorLabel
            // 
            this.projectTypeValidatorLabel.AutoSize = true;
            this.projectTypeValidatorLabel.ForeColor = System.Drawing.Color.Red;
            this.projectTypeValidatorLabel.Location = new System.Drawing.Point(148, 243);
            this.projectTypeValidatorLabel.Name = "projectTypeValidatorLabel";
            this.projectTypeValidatorLabel.Size = new System.Drawing.Size(148, 13);
            this.projectTypeValidatorLabel.TabIndex = 22;
            this.projectTypeValidatorLabel.Text = "*   Please Select Project Type";
            // 
            // projectNameValidatorLabel
            // 
            this.projectNameValidatorLabel.AutoSize = true;
            this.projectNameValidatorLabel.ForeColor = System.Drawing.Color.Red;
            this.projectNameValidatorLabel.Location = new System.Drawing.Point(507, 241);
            this.projectNameValidatorLabel.Name = "projectNameValidatorLabel";
            this.projectNameValidatorLabel.Size = new System.Drawing.Size(152, 13);
            this.projectNameValidatorLabel.TabIndex = 23;
            this.projectNameValidatorLabel.Text = "*   Please Select Project Name";
            // 
            // taskNameValidatorLabel
            // 
            this.taskNameValidatorLabel.AutoSize = true;
            this.taskNameValidatorLabel.ForeColor = System.Drawing.Color.Red;
            this.taskNameValidatorLabel.Location = new System.Drawing.Point(151, 344);
            this.taskNameValidatorLabel.Name = "taskNameValidatorLabel";
            this.taskNameValidatorLabel.Size = new System.Drawing.Size(138, 13);
            this.taskNameValidatorLabel.TabIndex = 24;
            this.taskNameValidatorLabel.Text = "*   Please Enter Task Name";
            // 
            // statusValidatorLabel
            // 
            this.statusValidatorLabel.AutoSize = true;
            this.statusValidatorLabel.ForeColor = System.Drawing.Color.Red;
            this.statusValidatorLabel.Location = new System.Drawing.Point(507, 344);
            this.statusValidatorLabel.Name = "statusValidatorLabel";
            this.statusValidatorLabel.Size = new System.Drawing.Size(118, 13);
            this.statusValidatorLabel.TabIndex = 25;
            this.statusValidatorLabel.Text = "*   Please Select Status";
            this.statusValidatorLabel.Click += new System.EventHandler(this.statusValidatorLabel_Click);
            // 
            // hoursValidatorLabel
            // 
            this.hoursValidatorLabel.AutoSize = true;
            this.hoursValidatorLabel.ForeColor = System.Drawing.Color.Red;
            this.hoursValidatorLabel.Location = new System.Drawing.Point(149, 389);
            this.hoursValidatorLabel.Name = "hoursValidatorLabel";
            this.hoursValidatorLabel.Size = new System.Drawing.Size(111, 13);
            this.hoursValidatorLabel.TabIndex = 26;
            this.hoursValidatorLabel.Text = "*   Please Enter Hours";
            // 
            // MoveToExcel
            // 
            this.MoveToExcel.BackColor = System.Drawing.SystemColors.Highlight;
            this.MoveToExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveToExcel.ForeColor = System.Drawing.SystemColors.Control;
            this.MoveToExcel.Location = new System.Drawing.Point(508, 537);
            this.MoveToExcel.Name = "MoveToExcel";
            this.MoveToExcel.Size = new System.Drawing.Size(136, 30);
            this.MoveToExcel.TabIndex = 27;
            this.MoveToExcel.Text = "Export To Excel";
            this.MoveToExcel.UseVisualStyleBackColor = false;
            this.MoveToExcel.Click += new System.EventHandler(this.MoveToExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(352, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(713, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(352, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(713, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(352, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(713, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 18);
            this.label6.TabIndex = 33;
            this.label6.Text = "*";
            // 
            // CommonMessage
            // 
            this.CommonMessage.AutoSize = true;
            this.CommonMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommonMessage.ForeColor = System.Drawing.Color.Black;
            this.CommonMessage.Location = new System.Drawing.Point(281, 95);
            this.CommonMessage.Name = "CommonMessage";
            this.CommonMessage.Size = new System.Drawing.Size(0, 15);
            this.CommonMessage.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(664, 569);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 14);
            this.label7.TabIndex = 35;
            this.label7.Text = "* Mandatory Fields";
            // 
            // taskNameTextArea
            // 
            this.taskNameTextArea.Location = new System.Drawing.Point(149, 268);
            this.taskNameTextArea.Multiline = true;
            this.taskNameTextArea.Name = "taskNameTextArea";
            this.taskNameTextArea.Size = new System.Drawing.Size(205, 77);
            this.taskNameTextArea.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(35, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "Select the pending tasks";
            // 
            // taskId_Control
            // 
            this.taskId_Control.Location = new System.Drawing.Point(940, 360);
            this.taskId_Control.Name = "taskId_Control";
            this.taskId_Control.ReadOnly = true;
            this.taskId_Control.Size = new System.Drawing.Size(100, 20);
            this.taskId_Control.TabIndex = 39;
            this.taskId_Control.Visible = false;
            this.taskId_Control.TextChanged += new System.EventHandler(this.taskId_Control_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(869, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 40;
            this.label9.Text = "Task ID";
            this.label9.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Location = new System.Drawing.Point(89, 429);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(635, 102);
            this.dataGridView2.TabIndex = 41;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseDoubleClick);
            // 
            // CommonMessage1
            // 
            this.CommonMessage1.AutoSize = true;
            this.CommonMessage1.Location = new System.Drawing.Point(284, 492);
            this.CommonMessage1.Name = "CommonMessage1";
            this.CommonMessage1.Size = new System.Drawing.Size(0, 13);
            this.CommonMessage1.TabIndex = 42;
            // 
            // total_Hours
            // 
            this.total_Hours.AutoSize = true;
            this.total_Hours.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Hours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.total_Hours.Location = new System.Drawing.Point(411, 365);
            this.total_Hours.Name = "total_Hours";
            this.total_Hours.Size = new System.Drawing.Size(76, 18);
            this.total_Hours.TabIndex = 43;
            this.total_Hours.Text = "Total hours";
            // 
            // totalHours_text
            // 
            this.totalHours_text.Location = new System.Drawing.Point(510, 365);
            this.totalHours_text.Name = "totalHours_text";
            this.totalHours_text.ReadOnly = true;
            this.totalHours_text.Size = new System.Drawing.Size(100, 20);
            this.totalHours_text.TabIndex = 44;
            // 
            // taskTrackerlabel
            // 
            this.taskTrackerlabel.AutoSize = true;
            this.taskTrackerlabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTrackerlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.taskTrackerlabel.Location = new System.Drawing.Point(287, 38);
            this.taskTrackerlabel.Name = "taskTrackerlabel";
            this.taskTrackerlabel.Size = new System.Drawing.Size(237, 40);
            this.taskTrackerlabel.TabIndex = 45;
            this.taskTrackerlabel.Text = "Task Tracker";
            // 
            // CommonMesage
            // 
            this.CommonMesage.AutoSize = true;
            this.CommonMesage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommonMesage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CommonMesage.Location = new System.Drawing.Point(302, 127);
            this.CommonMesage.Name = "CommonMesage";
            this.CommonMesage.Size = new System.Drawing.Size(11, 13);
            this.CommonMesage.TabIndex = 46;
            this.CommonMesage.Text = ".";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(23, 26);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(11, 15);
            this.userNameLabel.TabIndex = 49;
            this.userNameLabel.Text = ".";
            // 
            // TaskTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 601);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.CommonMesage);
            this.Controls.Add(this.taskTrackerlabel);
            this.Controls.Add(this.totalHours_text);
            this.Controls.Add(this.total_Hours);
            this.Controls.Add(this.CommonMessage1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.taskId_Control);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.taskNameTextArea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CommonMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoveToExcel);
            this.Controls.Add(this.hoursValidatorLabel);
            this.Controls.Add(this.statusValidatorLabel);
            this.Controls.Add(this.taskNameValidatorLabel);
            this.Controls.Add(this.projectNameValidatorLabel);
            this.Controls.Add(this.projectTypeValidatorLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.taskNameLabel);
            this.Controls.Add(this.projectNamelabel);
            this.Controls.Add(this.projectTypeLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.hoursNumericUpDown);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.projectNameComboBox);
            this.Controls.Add(this.projectTypeComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TaskTracker";
            this.Text = "Task Tracker";
            this.Load += new System.EventHandler(this.TaskTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hoursNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox projectTypeComboBox;
        private System.Windows.Forms.ComboBox projectNameComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.NumericUpDown hoursNumericUpDown;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label projectTypeLabel;
        private System.Windows.Forms.Label projectNamelabel;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label projectTypeValidatorLabel;
        private System.Windows.Forms.Label projectNameValidatorLabel;
        private System.Windows.Forms.Label taskNameValidatorLabel;
        private System.Windows.Forms.Label statusValidatorLabel;
        private System.Windows.Forms.Label hoursValidatorLabel;
        private System.Windows.Forms.Button MoveToExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CommonMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox taskNameTextArea;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox taskId_Control;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label CommonMessage1;
        private System.Windows.Forms.Label total_Hours;
        private System.Windows.Forms.TextBox totalHours_text;
        private System.Windows.Forms.Label taskTrackerlabel;
        private System.Windows.Forms.Label CommonMesage;
        private System.Windows.Forms.Label userNameLabel;
    }
}


namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Student = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LabMonitor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Equipment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxItem = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLabEquipment = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.equipmentLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.studentLbl = new System.Windows.Forms.Label();
            this.equipmentTitleLbl = new System.Windows.Forms.Label();
            this.SignInTitleLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.copyBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.filterBtn = new System.Windows.Forms.Button();
            this.dateToLbl = new System.Windows.Forms.Label();
            this.dateFromLbl = new System.Windows.Forms.Label();
            this.dateTitleLbl = new System.Windows.Forms.Label();
            this.toTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Student,
            this.LabMonitor,
            this.StudentID,
            this.Date,
            this.TimeIn,
            this.TimeOut,
            this.Equipment});
            this.listView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(187, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(893, 344);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Student
            // 
            this.Student.Text = "Student";
            this.Student.Width = 180;
            // 
            // LabMonitor
            // 
            this.LabMonitor.Text = "Lab Monitor";
            this.LabMonitor.Width = 150;
            // 
            // StudentID
            // 
            this.StudentID.Text = "Student ID";
            this.StudentID.Width = 100;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 74;
            // 
            // TimeIn
            // 
            this.TimeIn.Text = "TimeIn";
            this.TimeIn.Width = 95;
            // 
            // TimeOut
            // 
            this.TimeOut.Text = "Time Out";
            this.TimeOut.Width = 98;
            // 
            // Equipment
            // 
            this.Equipment.Text = "Equipment";
            this.Equipment.Width = 191;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(123, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.txtBoxName.Location = new System.Drawing.Point(123, 18);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(183, 31);
            this.txtBoxName.TabIndex = 4;
            this.txtBoxName.TextChanged += new System.EventHandler(this.txtBoxName_TextChanged);
            // 
            // txtBoxID
            // 
            this.txtBoxID.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.txtBoxID.Location = new System.Drawing.Point(123, 55);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(183, 31);
            this.txtBoxID.TabIndex = 5;
            this.txtBoxID.TextChanged += new System.EventHandler(this.txtBoxID_TextChanged);
            // 
            // txtBoxItem
            // 
            this.txtBoxItem.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.txtBoxItem.Location = new System.Drawing.Point(123, 92);
            this.txtBoxItem.Name = "txtBoxItem";
            this.txtBoxItem.Size = new System.Drawing.Size(183, 31);
            this.txtBoxItem.TabIndex = 6;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.deleteBtn.ForeColor = System.Drawing.Color.Indigo;
            this.deleteBtn.Location = new System.Drawing.Point(802, 440);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(117, 44);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.returnBtn.Enabled = false;
            this.returnBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.returnBtn.ForeColor = System.Drawing.Color.Indigo;
            this.returnBtn.Location = new System.Drawing.Point(925, 440);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(117, 44);
            this.returnBtn.TabIndex = 8;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Visible = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLabEquipment);
            this.panel1.Controls.Add(this.btnSignIn);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 747);
            this.panel1.TabIndex = 9;
            // 
            // btnLabEquipment
            // 
            this.btnLabEquipment.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLabEquipment.Enabled = false;
            this.btnLabEquipment.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLabEquipment.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLabEquipment.Location = new System.Drawing.Point(3, 138);
            this.btnLabEquipment.Name = "btnLabEquipment";
            this.btnLabEquipment.Size = new System.Drawing.Size(160, 137);
            this.btnLabEquipment.TabIndex = 1;
            this.btnLabEquipment.Text = "Lab Equipment";
            this.btnLabEquipment.UseVisualStyleBackColor = false;
            this.btnLabEquipment.Click += new System.EventHandler(this.btnLabEquipment_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSignIn.Enabled = false;
            this.btnSignIn.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSignIn.Location = new System.Drawing.Point(3, 3);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(160, 137);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.Text = "Lab Sign-In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Controls.Add(this.equipmentLbl);
            this.panel2.Controls.Add(this.idLbl);
            this.panel2.Controls.Add(this.studentLbl);
            this.panel2.Controls.Add(this.txtBoxID);
            this.panel2.Controls.Add(this.txtBoxItem);
            this.panel2.Controls.Add(this.txtBoxName);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(187, 446);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 184);
            this.panel2.TabIndex = 10;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.searchBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.searchBtn.ForeColor = System.Drawing.Color.Indigo;
            this.searchBtn.Location = new System.Drawing.Point(312, 56);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(28, 31);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "!";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // equipmentLbl
            // 
            this.equipmentLbl.AutoSize = true;
            this.equipmentLbl.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.equipmentLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.equipmentLbl.Location = new System.Drawing.Point(7, 92);
            this.equipmentLbl.Name = "equipmentLbl";
            this.equipmentLbl.Size = new System.Drawing.Size(110, 26);
            this.equipmentLbl.TabIndex = 9;
            this.equipmentLbl.Text = "Equipment";
            this.equipmentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.idLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.idLbl.Location = new System.Drawing.Point(85, 55);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(32, 26);
            this.idLbl.TabIndex = 8;
            this.idLbl.Text = "ID";
            this.idLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // studentLbl
            // 
            this.studentLbl.AutoSize = true;
            this.studentLbl.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.studentLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.studentLbl.Location = new System.Drawing.Point(34, 18);
            this.studentLbl.Name = "studentLbl";
            this.studentLbl.Size = new System.Drawing.Size(83, 26);
            this.studentLbl.TabIndex = 7;
            this.studentLbl.Text = "Student";
            this.studentLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // equipmentTitleLbl
            // 
            this.equipmentTitleLbl.AutoSize = true;
            this.equipmentTitleLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.equipmentTitleLbl.Font = new System.Drawing.Font("Franklin Gothic Demi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentTitleLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.equipmentTitleLbl.Location = new System.Drawing.Point(448, 32);
            this.equipmentTitleLbl.Name = "equipmentTitleLbl";
            this.equipmentTitleLbl.Size = new System.Drawing.Size(384, 39);
            this.equipmentTitleLbl.TabIndex = 10;
            this.equipmentTitleLbl.Text = "Lab Equipment Rental List";
            this.equipmentTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SignInTitleLabel
            // 
            this.SignInTitleLabel.AutoSize = true;
            this.SignInTitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SignInTitleLabel.Font = new System.Drawing.Font("Franklin Gothic Demi", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInTitleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SignInTitleLabel.Location = new System.Drawing.Point(448, 32);
            this.SignInTitleLabel.Name = "SignInTitleLabel";
            this.SignInTitleLabel.Size = new System.Drawing.Size(389, 39);
            this.SignInTitleLabel.TabIndex = 11;
            this.SignInTitleLabel.Text = " Game Lab Sign In Station ";
            this.SignInTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignInTitleLabel.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(515, 235);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(220, 52);
            this.progressBar1.TabIndex = 12;
            // 
            // copyBtn
            // 
            this.copyBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.copyBtn.Enabled = false;
            this.copyBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.copyBtn.ForeColor = System.Drawing.Color.Indigo;
            this.copyBtn.Location = new System.Drawing.Point(679, 440);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(117, 44);
            this.copyBtn.TabIndex = 13;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = false;
            this.copyBtn.Visible = false;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.filterBtn);
            this.panel3.Controls.Add(this.dateToLbl);
            this.panel3.Controls.Add(this.dateFromLbl);
            this.panel3.Controls.Add(this.dateTitleLbl);
            this.panel3.Controls.Add(this.toTimePicker);
            this.panel3.Controls.Add(this.fromTimePicker);
            this.panel3.Location = new System.Drawing.Point(679, 490);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 140);
            this.panel3.TabIndex = 11;
            // 
            // filterBtn
            // 
            this.filterBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.filterBtn.Enabled = false;
            this.filterBtn.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.filterBtn.ForeColor = System.Drawing.Color.Indigo;
            this.filterBtn.Location = new System.Drawing.Point(119, 97);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(136, 40);
            this.filterBtn.TabIndex = 11;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = false;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // dateToLbl
            // 
            this.dateToLbl.AutoSize = true;
            this.dateToLbl.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.dateToLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateToLbl.Location = new System.Drawing.Point(241, 33);
            this.dateToLbl.Name = "dateToLbl";
            this.dateToLbl.Size = new System.Drawing.Size(33, 26);
            this.dateToLbl.TabIndex = 12;
            this.dateToLbl.Text = "To";
            this.dateToLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateFromLbl
            // 
            this.dateFromLbl.AutoSize = true;
            this.dateFromLbl.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.dateFromLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateFromLbl.Location = new System.Drawing.Point(72, 33);
            this.dateFromLbl.Name = "dateFromLbl";
            this.dateFromLbl.Size = new System.Drawing.Size(59, 26);
            this.dateFromLbl.TabIndex = 11;
            this.dateFromLbl.Text = "From";
            this.dateFromLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTitleLbl
            // 
            this.dateTitleLbl.AutoSize = true;
            this.dateTitleLbl.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTitleLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateTitleLbl.Location = new System.Drawing.Point(118, 3);
            this.dateTitleLbl.Name = "dateTitleLbl";
            this.dateTitleLbl.Size = new System.Drawing.Size(137, 30);
            this.dateTitleLbl.TabIndex = 11;
            this.dateTitleLbl.Text = "Date Range";
            this.dateTitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toTimePicker
            // 
            this.toTimePicker.CustomFormat = "MM/dd/yy";
            this.toTimePicker.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.toTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toTimePicker.Location = new System.Drawing.Point(191, 62);
            this.toTimePicker.Name = "toTimePicker";
            this.toTimePicker.Size = new System.Drawing.Size(136, 31);
            this.toTimePicker.TabIndex = 1;
            this.toTimePicker.Value = new System.DateTime(2018, 2, 7, 19, 3, 34, 0);
            this.toTimePicker.ValueChanged += new System.EventHandler(this.toTimePicker_ValueChanged);
            // 
            // fromTimePicker
            // 
            this.fromTimePicker.CustomFormat = "MM/dd/yy";
            this.fromTimePicker.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F);
            this.fromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromTimePicker.Location = new System.Drawing.Point(36, 62);
            this.fromTimePicker.Name = "fromTimePicker";
            this.fromTimePicker.Size = new System.Drawing.Size(136, 31);
            this.fromTimePicker.TabIndex = 0;
            this.fromTimePicker.ValueChanged += new System.EventHandler(this.fromTimePicker_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1161, 635);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.SignInTitleLabel);
            this.Controls.Add(this.equipmentTitleLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Text = "Game Lab Monitor";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Student;
        private System.Windows.Forms.ColumnHeader LabMonitor;
        private System.Windows.Forms.ColumnHeader StudentID;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader TimeIn;
        private System.Windows.Forms.ColumnHeader TimeOut;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxItem;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnLabEquipment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label equipmentLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label studentLbl;
        private System.Windows.Forms.Label equipmentTitleLbl;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ColumnHeader Equipment;
        private System.Windows.Forms.Label SignInTitleLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker fromTimePicker;
        private System.Windows.Forms.Label dateToLbl;
        private System.Windows.Forms.Label dateFromLbl;
        private System.Windows.Forms.Label dateTitleLbl;
        private System.Windows.Forms.DateTimePicker toTimePicker;
        private System.Windows.Forms.Button filterBtn;
    }
}


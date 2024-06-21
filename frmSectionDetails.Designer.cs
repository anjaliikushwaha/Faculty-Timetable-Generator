namespace Scheduler
{
    partial class frmSectionDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSectionDetails));
            this.tabFaculty = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lsvRoomSchedule = new System.Windows.Forms.ListView();
            this._column_95 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._column_96 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editRoomScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lsvInstructor = new System.Windows.Forms.ListView();
            this._column_97 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFacultyID = new System.Windows.Forms.TextBox();
            this.txtYearLvl = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtSectionID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxStudent = new System.Windows.Forms.TextBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMinGrade = new System.Windows.Forms.TextBox();
            this.cboYearLvl = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.txtMaxGrade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAdviser = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lsvEnrollees = new System.Windows.Forms.ListView();
            this._column_106 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._column_107 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._column_108 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._column_109 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._column_110 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sbrEnrollees = new System.Windows.Forms.StatusBar();
            this._panel_111 = new System.Windows.Forms.StatusBarPanel();
            this.tabFaculty.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._panel_111)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFaculty
            // 
            this.tabFaculty.Controls.Add(this.tabPage1);
            this.tabFaculty.Controls.Add(this.tabPage2);
            this.tabFaculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFaculty.Location = new System.Drawing.Point(0, 0);
            this.tabFaculty.Name = "tabFaculty";
            this.tabFaculty.SelectedIndex = 0;
            this.tabFaculty.Size = new System.Drawing.Size(754, 488);
            this.tabFaculty.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 404);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 139);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lsvRoomSchedule);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lsvInstructor);
            this.splitContainer1.Size = new System.Drawing.Size(734, 262);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 25;
            // 
            // lsvRoomSchedule
            // 
            this.lsvRoomSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._column_95,
            this._column_96,
            this.columnHeader2,
            this.columnHeader1});
            this.lsvRoomSchedule.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvRoomSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvRoomSchedule.FullRowSelect = true;
            this.lsvRoomSchedule.Location = new System.Drawing.Point(0, 0);
            this.lsvRoomSchedule.Name = "lsvRoomSchedule";
            this.lsvRoomSchedule.Size = new System.Drawing.Size(734, 130);
            this.lsvRoomSchedule.TabIndex = 2;
            this.lsvRoomSchedule.UseCompatibleStateImageBehavior = false;
            this.lsvRoomSchedule.View = System.Windows.Forms.View.Details;
            this.lsvRoomSchedule.SelectedIndexChanged += new System.EventHandler(this.lsvRoomSchedule_SelectedIndexChanged);
            // 
            // _column_95
            // 
            this._column_95.Name = "_column_95";
            this._column_95.Text = "Subject";
            this._column_95.Width = 150;
            // 
            // _column_96
            // 
            this._column_96.Name = "_column_96";
            this._column_96.Text = "Room Assignment";
            this._column_96.Width = 145;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Class Schedules";
            this.columnHeader2.Width = 224;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Faculty";
            this.columnHeader1.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRoomScheduleToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 76);
            // 
            // editRoomScheduleToolStripMenuItem
            // 
            this.editRoomScheduleToolStripMenuItem.Name = "editRoomScheduleToolStripMenuItem";
            this.editRoomScheduleToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.editRoomScheduleToolStripMenuItem.Text = "Edit Subject Offered";
            this.editRoomScheduleToolStripMenuItem.Click += new System.EventHandler(this.editRoomScheduleToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // lsvInstructor
            // 
            this.lsvInstructor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._column_97});
            this.lsvInstructor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvInstructor.FullRowSelect = true;
            this.lsvInstructor.Location = new System.Drawing.Point(0, 0);
            this.lsvInstructor.Name = "lsvInstructor";
            this.lsvInstructor.Size = new System.Drawing.Size(734, 128);
            this.lsvInstructor.TabIndex = 3;
            this.lsvInstructor.UseCompatibleStateImageBehavior = false;
            this.lsvInstructor.View = System.Windows.Forms.View.Details;
            // 
            // _column_97
            // 
            this._column_97.Name = "_column_97";
            this._column_97.Text = "Instructor";
            this._column_97.Width = 412;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFacultyID);
            this.panel1.Controls.Add(this.txtYearLvl);
            this.panel1.Controls.Add(this.txtDepartment);
            this.panel1.Controls.Add(this.txtSectionID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMaxStudent);
            this.panel1.Controls.Add(this.cboDepartment);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtMinGrade);
            this.panel1.Controls.Add(this.cboYearLvl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSection);
            this.panel1.Controls.Add(this.txtMaxGrade);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboAdviser);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 122);
            this.panel1.TabIndex = 24;
            // 
            // txtFacultyID
            // 
            this.txtFacultyID.Location = new System.Drawing.Point(610, 64);
            this.txtFacultyID.Name = "txtFacultyID";
            this.txtFacultyID.Size = new System.Drawing.Size(81, 21);
            this.txtFacultyID.TabIndex = 24;
            this.txtFacultyID.Visible = false;
            // 
            // txtYearLvl
            // 
            this.txtYearLvl.Location = new System.Drawing.Point(610, 10);
            this.txtYearLvl.Name = "txtYearLvl";
            this.txtYearLvl.Size = new System.Drawing.Size(81, 21);
            this.txtYearLvl.TabIndex = 11;
            this.txtYearLvl.Visible = false;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(610, 36);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(81, 21);
            this.txtDepartment.TabIndex = 10;
            this.txtDepartment.Visible = false;
            // 
            // txtSectionID
            // 
            this.txtSectionID.BackColor = System.Drawing.SystemColors.Info;
            this.txtSectionID.Location = new System.Drawing.Point(112, 13);
            this.txtSectionID.Name = "txtSectionID";
            this.txtSectionID.ReadOnly = true;
            this.txtSectionID.Size = new System.Drawing.Size(173, 21);
            this.txtSectionID.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Curriculum:";
            // 
            // txtMaxStudent
            // 
            this.txtMaxStudent.Location = new System.Drawing.Point(112, 94);
            this.txtMaxStudent.Name = "txtMaxStudent";
            this.txtMaxStudent.Size = new System.Drawing.Size(173, 21);
            this.txtMaxStudent.TabIndex = 2;
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(387, 39);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(157, 23);
            this.cboDepartment.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max. Student #:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Year Level:";
            // 
            // txtMinGrade
            // 
            this.txtMinGrade.Location = new System.Drawing.Point(387, 67);
            this.txtMinGrade.Name = "txtMinGrade";
            this.txtMinGrade.Size = new System.Drawing.Size(157, 21);
            this.txtMinGrade.TabIndex = 4;
            // 
            // cboYearLvl
            // 
            this.cboYearLvl.FormattingEnabled = true;
            this.cboYearLvl.Location = new System.Drawing.Point(387, 10);
            this.cboYearLvl.Name = "cboYearLvl";
            this.cboYearLvl.Size = new System.Drawing.Size(157, 23);
            this.cboYearLvl.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Min. Grade:";
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(112, 40);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(173, 21);
            this.txtSection.TabIndex = 19;
            // 
            // txtMaxGrade
            // 
            this.txtMaxGrade.Location = new System.Drawing.Point(387, 94);
            this.txtMaxGrade.Name = "txtMaxGrade";
            this.txtMaxGrade.Size = new System.Drawing.Size(157, 21);
            this.txtMaxGrade.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Section Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max. Grade:";
            // 
            // cboAdviser
            // 
            this.cboAdviser.FormattingEnabled = true;
            this.cboAdviser.Location = new System.Drawing.Point(112, 67);
            this.cboAdviser.Name = "cboAdviser";
            this.cboAdviser.Size = new System.Drawing.Size(173, 23);
            this.cboAdviser.TabIndex = 14;
            this.cboAdviser.SelectedIndexChanged += new System.EventHandler(this.cboAdviser_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "Section ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Adviser:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 50);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lsvEnrollees);
            this.tabPage2.Controls.Add(this.sbrEnrollees);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enrollees";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lsvEnrollees
            // 
            this.lsvEnrollees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._column_106,
            this._column_107,
            this._column_108,
            this._column_109,
            this._column_110});
            this.lsvEnrollees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvEnrollees.FullRowSelect = true;
            this.lsvEnrollees.Location = new System.Drawing.Point(3, 3);
            this.lsvEnrollees.Name = "lsvEnrollees";
            this.lsvEnrollees.Size = new System.Drawing.Size(740, 538);
            this.lsvEnrollees.TabIndex = 3;
            this.lsvEnrollees.UseCompatibleStateImageBehavior = false;
            this.lsvEnrollees.View = System.Windows.Forms.View.Details;
            // 
            // _column_106
            // 
            this._column_106.Name = "_column_106";
            this._column_106.Text = "Student Name";
            this._column_106.Width = 167;
            // 
            // _column_107
            // 
            this._column_107.Name = "_column_107";
            this._column_107.Text = "ID Number";
            this._column_107.Width = 120;
            // 
            // _column_108
            // 
            this._column_108.Name = "_column_108";
            this._column_108.Text = "Year Level";
            this._column_108.Width = 97;
            // 
            // _column_109
            // 
            this._column_109.Name = "_column_109";
            this._column_109.Text = "Date Enrolled";
            this._column_109.Width = 117;
            // 
            // _column_110
            // 
            this._column_110.Name = "_column_110";
            this._column_110.Text = "Enrolled by";
            this._column_110.Width = 102;
            // 
            // sbrEnrollees
            // 
            this.sbrEnrollees.Location = new System.Drawing.Point(3, 541);
            this.sbrEnrollees.Name = "sbrEnrollees";
            this.sbrEnrollees.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this._panel_111});
            this.sbrEnrollees.ShowPanels = true;
            this.sbrEnrollees.Size = new System.Drawing.Size(740, 19);
            this.sbrEnrollees.TabIndex = 2;
            // 
            // _panel_111
            // 
            this._panel_111.Name = "_panel_111";
            // 
            // frmSectionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 488);
            this.Controls.Add(this.tabFaculty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSectionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Section";
            this.Load += new System.EventHandler(this.frmSectionDetails_Load);
            this.tabFaculty.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._panel_111)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.ListView lsvRoomSchedule;
        public System.Windows.Forms.ColumnHeader _column_95;
        public System.Windows.Forms.ColumnHeader _column_96;
        public System.Windows.Forms.ListView lsvInstructor;
        public System.Windows.Forms.ColumnHeader _column_97;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSectionID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxStudent;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMinGrade;
        private System.Windows.Forms.ComboBox cboYearLvl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.TextBox txtMaxGrade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAdviser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.StatusBar sbrEnrollees;
        public System.Windows.Forms.StatusBarPanel _panel_111;
        public System.Windows.Forms.ListView lsvEnrollees;
        public System.Windows.Forms.ColumnHeader _column_106;
        public System.Windows.Forms.ColumnHeader _column_107;
        public System.Windows.Forms.ColumnHeader _column_108;
        public System.Windows.Forms.ColumnHeader _column_109;
        public System.Windows.Forms.ColumnHeader _column_110;
        private System.Windows.Forms.TextBox txtYearLvl;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TabControl tabFaculty;
        private System.Windows.Forms.ToolStripMenuItem editRoomScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.TextBox txtFacultyID;

    }
}
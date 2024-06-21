namespace Scheduler
{
    partial class RoomSchedule
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
            this.btnSave = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this._column_91 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._column_92 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._column_93 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.lsvSection2 = new System.Windows.Forms.ListView();
            this.clbDay = new System.Windows.Forms.CheckedListBox();
            this.cboRoomCapacity = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.btnLookup = new System.Windows.Forms.Button();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.lsbClass = new System.Windows.Forms.ListBox();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(184, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(12, 10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(87, 13);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Room assignment:";
            // 
            // _column_91
            // 
            this._column_91.Name = "_column_91";
            this._column_91.Text = "Section";
            this._column_91.Width = 89;
            // 
            // _column_92
            // 
            this._column_92.Name = "_column_92";
            this._column_92.Text = "Day";
            this._column_92.Width = 45;
            // 
            // _column_93
            // 
            this._column_93.Name = "_column_93";
            this._column_93.Text = "Time";
            this._column_93.Width = 122;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(416, 7);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(44, 13);
            this.Label5.TabIndex = 23;
            this.Label5.Text = "Capacity:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(12, 58);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(74, 13);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "Class schedule:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(365, 196);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(33, 17);
            this.Label4.TabIndex = 28;
            this.Label4.Text = "to";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(265, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(293, 74);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(84, 13);
            this.Label7.TabIndex = 34;
            this.Label7.Text = "Custom schedule:";
            // 
            // lsvSection2
            // 
            this.lsvSection2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._column_91,
            this._column_92,
            this._column_93});
            this.lsvSection2.FullRowSelect = true;
            this.lsvSection2.Location = new System.Drawing.Point(12, 74);
            this.lsvSection2.Name = "lsvSection2";
            this.lsvSection2.Size = new System.Drawing.Size(263, 257);
            this.lsvSection2.TabIndex = 46;
            this.lsvSection2.UseCompatibleStateImageBehavior = false;
            this.lsvSection2.View = System.Windows.Forms.View.Details;
            this.lsvSection2.Visible = false;
            // 
            // clbDay
            // 
            this.clbDay.Items.AddRange(new object[] {
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat",
            "Sun",
            "Mon,Thu",
            "Tue,Fri",
            "Wed,Sat",
            "Tue,Thu",
            "Sat,Sun",
            "Mon,Wed,Fri",
            "Tue,Thu,Sat"});
            this.clbDay.Location = new System.Drawing.Point(292, 90);
            this.clbDay.Name = "clbDay";
            this.clbDay.Size = new System.Drawing.Size(196, 94);
            this.clbDay.TabIndex = 33;
            // 
            // cboRoomCapacity
            // 
            this.cboRoomCapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomCapacity.ItemHeight = 13;
            this.cboRoomCapacity.Location = new System.Drawing.Point(542, 38);
            this.cboRoomCapacity.Name = "cboRoomCapacity";
            this.cboRoomCapacity.Size = new System.Drawing.Size(41, 21);
            this.cboRoomCapacity.TabIndex = 42;
            this.cboRoomCapacity.Visible = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(12, 338);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(73, 21);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemove.Location = new System.Drawing.Point(116, 338);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(73, 21);
            this.btnRemove.TabIndex = 40;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnAdd3
            // 
            this.btnAdd3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd3.Location = new System.Drawing.Point(292, 219);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(84, 21);
            this.btnAdd3.TabIndex = 37;
            this.btnAdd3.Text = "<<";
            this.btnAdd3.UseVisualStyleBackColor = false;
            // 
            // btnLookup
            // 
            this.btnLookup.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLookup.Location = new System.Drawing.Point(466, 3);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(17, 20);
            this.btnLookup.TabIndex = 22;
            this.btnLookup.Text = "?";
            this.btnLookup.UseVisualStyleBackColor = false;
            // 
            // cboRoom
            // 
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoom.ItemHeight = 12;
            this.cboRoom.Location = new System.Drawing.Point(12, 26);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(471, 20);
            this.cboRoom.TabIndex = 20;
            // 
            // cboTo
            // 
            this.cboTo.FormatString = "t";
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Items.AddRange(new object[] {
            "7:00:00 AM",
            "7:30:00 AM",
            "8:00:00 AM",
            "8:30:00 AM",
            "9:00:00 AM",
            "9:30:00 AM",
            "10:00:00 AM",
            "10:30:00 AM",
            "11:00:00 AM",
            "11:30:00 AM",
            "12:00:00 PM",
            "12:30:00 PM",
            "1:00:00 PM",
            "1:30:00 PM",
            "2:00:00 PM",
            "2:30:00 PM",
            "3:00:00 PM",
            "3:30:00 PM",
            "4:00:00 PM",
            "4:30:00 PM",
            "5:00:00 PM",
            "5:30:00 PM",
            "6:00:00 PM",
            "6:30:00 PM",
            "7:00:00 PM",
            "7:30:00 PM"});
            this.cboTo.Location = new System.Drawing.Point(404, 192);
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(84, 21);
            this.cboTo.TabIndex = 47;
            // 
            // lsbClass
            // 
            this.lsbClass.Location = new System.Drawing.Point(12, 74);
            this.lsbClass.Name = "lsbClass";
            this.lsbClass.Size = new System.Drawing.Size(263, 251);
            this.lsbClass.TabIndex = 48;
            // 
            // cboFrom
            // 
            this.cboFrom.FormatString = "t";
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Items.AddRange(new object[] {
            "7:00:00 AM",
            "7:30:00 AM",
            "8:00:00 AM",
            "8:30:00 AM",
            "9:00:00 AM",
            "9:30:00 AM",
            "10:00:00 AM",
            "10:30:00 AM",
            "11:00:00 AM",
            "11:30:00 AM",
            "12:00:00 PM",
            "12:30:00 PM",
            "1:00:00 PM",
            "1:30:00 PM",
            "2:00:00 PM",
            "2:30:00 PM",
            "3:00:00 PM",
            "3:30:00 PM",
            "4:00:00 PM",
            "4:30:00 PM",
            "5:00:00 PM",
            "5:30:00 PM",
            "6:00:00 PM",
            "6:30:00 PM",
            "7:00:00 PM",
            "7:30:00 PM"});
            this.cboFrom.Location = new System.Drawing.Point(292, 192);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(84, 21);
            this.cboFrom.TabIndex = 49;
            // 
            // RoomSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 418);
            this.Controls.Add(this.cboFrom);
            this.Controls.Add(this.lsbClass);
            this.Controls.Add(this.cboTo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.lsvSection2);
            this.Controls.Add(this.clbDay);
            this.Controls.Add(this.cboRoomCapacity);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd3);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.cboRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoomSchedule";
            this.Text = "RoomSchedule";
            this.Load += new System.EventHandler(this.RoomSchedule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.ColumnHeader _column_91;
        public System.Windows.Forms.ColumnHeader _column_92;
        public System.Windows.Forms.ColumnHeader _column_93;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Label Label5;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label Label4;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label Label7;
        public System.Windows.Forms.ListView lsvSection2;
        public System.Windows.Forms.CheckedListBox clbDay;
        public System.Windows.Forms.ComboBox cboRoomCapacity;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.Button btnAdd3;
        public System.Windows.Forms.Button btnLookup;
        public System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.ComboBox cboTo;
        public System.Windows.Forms.ListBox lsbClass;
        private System.Windows.Forms.ComboBox cboFrom;

    }
}
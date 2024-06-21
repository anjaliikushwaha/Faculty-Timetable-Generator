using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Scheduler
{
    public partial class frmRoomSchedule : Form
    {
        #region Declaration
        private ToolStrip toolStrip1;
        private ToolStripComboBox cboSchoolYear;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
#endregion

        public int sDay,sDay1,sDay2;
        private ListView lvRooms;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel txtStatus;
        private ListView listView1;
        private ColumnHeader columnHeader9;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel lblStatus;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton printToolStripButton;
        private GroupBox groupBox1;
        private Panel panel1;
        private ListView lvRoom2;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private StatusStrip statusStrip3;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button cmdCheck;
        private Label label8;
        private Label label7;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private IContainer components;
        private ToolStripMenuItem addNewEntryToolStripMenuItem;
        private ToolStripMenuItem modifyNewEntryToolStripMenuItem;
        private ToolStripMenuItem deleteEntyToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private DataGridView dataGridViewSchedule;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn cl0700;
        private DataGridViewTextBoxColumn cl0730;
        private DataGridViewTextBoxColumn cl0800;
        private DataGridViewTextBoxColumn cl0830;
        private DataGridViewTextBoxColumn cl0900;
        private DataGridViewTextBoxColumn cl0930;
        private DataGridViewTextBoxColumn cl1000;
        private DataGridViewTextBoxColumn cl1030;
        private DataGridViewTextBoxColumn cl1100;
        private DataGridViewTextBoxColumn cl1130;
        private DataGridViewTextBoxColumn cl1200;
        private DataGridViewTextBoxColumn cl1230;
        private DataGridViewTextBoxColumn cl0100;
        private DataGridViewTextBoxColumn cl0130;
        private DataGridViewTextBoxColumn cl0200;
        private DataGridViewTextBoxColumn cl0230;
        private DataGridViewTextBoxColumn cl0300;
        private DataGridViewTextBoxColumn cl0330;
        private DataGridViewTextBoxColumn cl0400;
        private DataGridViewTextBoxColumn cl0430;
        private DataGridViewTextBoxColumn cl0500;
        private DataGridViewTextBoxColumn cl0530;
        private DataGridViewTextBoxColumn cl06pm;
        private DataGridViewTextBoxColumn cl063pm;
        private ListView lvSchedule;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ComboBox cboFrom;
        private ComboBox cboDay;
        private ComboBox cboTo;
        private ColumnHeader columnHeader13;
        private ToolStripLabel toolStripLabel1;

        public frmRoomSchedule()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (clsCon.con.State == ConnectionState.Open)
            { clsCon.con.Close(); }
            clsCon.con.Open();

            TimeTable();
            LoadRooms();
        }

        private void TimeTable()
        {
               String[] modules = new String[7] { "M", "T", "W", "H", "F", "S", "A" };
                for (int i = 0; i < 7; i++)
                {
                    dataGridViewSchedule.Rows.Add();
                    dataGridViewSchedule.Rows[i].Cells[0].Value = modules[i];
                    dataGridViewSchedule.Rows[i].Height = 20;
                    dataGridViewSchedule.Rows[i].ReadOnly = true;
                }
           
                dataGridViewSchedule.Rows[7].Cells[0].Value = "";
                dataGridViewSchedule.Rows[7].Height = 0;
                dataGridViewSchedule.Rows[7].ReadOnly = true;
        }
        
        public void LoadRooms()
        {
            OleDbCommand com = new OleDbCommand("Select * From Room", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            lvRooms.Items.Clear();
            while (dr.Read())
            {
                ListViewItem list = new ListViewItem(dr["RoomID"].ToString());
                list.SubItems.Add(dr["Building"].ToString());
                list.SubItems.Add(dr["RoomNo"].ToString());
                list.SubItems.Add(dr["Capacity"].ToString());
                lvRooms.Items.AddRange(new ListViewItem[] { list });
            }
            txtStatus.Text = Convert.ToString(lvRooms.Items.Count) + " rooms found.";
            dr.Close();
        }

        void DisplayRoomSchedule(string RoomNumber)
        {
            DateTime dTimeIn, dTimeOut;
            int num1, num2;

            Random randonGen = new Random();
            OleDbCommand com = new OleDbCommand("Select * From qrySubjectOfferring where cRoom='" + RoomNumber + "'", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            lvSchedule.Items.Clear();
            dataGridViewSchedule.Rows.Clear();

            TimeTable();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["Subject"].ToString());
                lv.SubItems.Add(dr["Section"].ToString());
                lv.SubItems.Add(dr["cRoom"].ToString());
                lv.SubItems.Add(dr["Schedule"].ToString());
                lv.SubItems.Add(dr["Faculty"].ToString());
                lvSchedule.Items.AddRange(new ListViewItem[] { lv });
                lv.ForeColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));

                dTimeIn = DateTime.Parse(dr["cTimeIn"].ToString());
                dTimeOut = DateTime.Parse(dr["cTimeOut"].ToString());

                ConvertsDaysToInt(dr["cDay"].ToString());

                num1 = clsSchedule.ConvertsTimeINToInt(dTimeIn.ToLongTimeString());
                num2 = clsSchedule.ConvertsTimeOUTToInt(dTimeOut.ToLongTimeString());

                switch (dr["cDay"].ToString())
                {
                    case "MH":
                        for (int time = num1; time <= num2; time++)
                        {
                            dataGridViewSchedule[time, sDay].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay].ToolTipText = dr["Schedule"].ToString();

                            dataGridViewSchedule[time, sDay1].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay1].ToolTipText = dr["Schedule"].ToString();
                        }
                        break;

                    case "TF":
                        for (int time = num1; time <= num2; time++)
                        {
                            dataGridViewSchedule[time, sDay].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay].ToolTipText = dr["Schedule"].ToString();

                            dataGridViewSchedule[time, sDay1].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay1].ToolTipText = dr["Schedule"].ToString();
                        }
                        break;

                    case "WS":
                        for (int time = num1; time <= num2; time++)
                        {
                            dataGridViewSchedule[time, sDay].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay].ToolTipText = dr["Schedule"].ToString();

                            dataGridViewSchedule[time, sDay1].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay1].ToolTipText = dr["Schedule"].ToString();
                        }
                        break;

                    case "MWF":
                        for (int time = num1; time <= num2; time++)
                        {
                            dataGridViewSchedule[time, sDay].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay].ToolTipText = dr["Schedule"].ToString();

                            dataGridViewSchedule[time, sDay1].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay1].ToolTipText = dr["Schedule"].ToString();

                            dataGridViewSchedule[time, sDay2].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay2].ToolTipText = dr["Schedule"].ToString();
                        }
                        break;

                    case "THS":
                        for (int time = num1; time <= num2; time++)
                        {
                            dataGridViewSchedule[time, sDay].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay].ToolTipText = dr["Schedule"].ToString();

                            dataGridViewSchedule[time, sDay1].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay1].ToolTipText = dr["Schedule"].ToString();

                            dataGridViewSchedule[time, sDay2].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay2].ToolTipText = dr["Schedule"].ToString();
                        }
                        break;

                    default:
                        for (int time = num1; time <= num2; time++)
                        {
                            dataGridViewSchedule[time, sDay].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay].ToolTipText = dr["Schedule"].ToString();
                        }
                        break;
                }
            }
            lblStatus.Text = "Utilize by " + lvSchedule.Items.Count.ToString() + " subjects.";    
            dr.Close();
        }

        #region Time and Day Scheduling
        void ConvertsDaysToInt(string cDays)
        {
            switch (cDays)
            {
                case "M":
                    sDay = 0;
                    break;
                case "T":
                    sDay = 1;
                    break;
                case "W":
                    sDay = 2;
                    break;
                case "H":
                    sDay = 3;
                    break;
                case "F":
                    sDay = 4;
                    break;
                case "S":
                    sDay = 5;
                    break;
                case "A":
                    sDay = 6;
                    break;
                case "MH":
                    sDay = 0;
                    sDay1 = 3;
                    break;
                case "TF":
                    sDay = 1;
                    sDay1 = 4;
                    break;
                case "WS":
                    sDay = 2;
                    sDay1 = 5;
                    break;
                case "MWF":
                    sDay = 0;
                    sDay1 = 2;
                    sDay2 = 4;
                    break;
                case "THS":
                    sDay = 1;
                    sDay1 = 3;
                    sDay2 = 5;
                    break;
            }
        }
        #endregion


        #region Components
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoomSchedule));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cboSchoolYear = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvRooms = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyNewEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEntyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvRoom2 = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.cboDay = new System.Windows.Forms.ComboBox();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.cmdCheck = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0700 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0730 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0800 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0830 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0900 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0930 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl1000 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl1030 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl1100 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl1130 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl1200 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl1230 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0100 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0130 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0200 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0230 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0300 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0330 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0400 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0430 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0500 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl0530 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl06pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl063pm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvSchedule = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cboSchoolYear,
            this.toolStripSeparator1,
            this.printToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "School Year";
            // 
            // cboSchoolYear
            // 
            this.cboSchoolYear.Name = "cboSchoolYear";
            this.cboSchoolYear.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "Print";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(365, 464);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvRooms);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(357, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Utilization";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvRooms
            // 
            this.lvRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader13});
            this.lvRooms.ContextMenuStrip = this.contextMenuStrip1;
            this.lvRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRooms.FullRowSelect = true;
            this.lvRooms.GridLines = true;
            this.lvRooms.Location = new System.Drawing.Point(3, 3);
            this.lvRooms.Name = "lvRooms";
            this.lvRooms.Size = new System.Drawing.Size(351, 408);
            this.lvRooms.TabIndex = 4;
            this.lvRooms.UseCompatibleStateImageBehavior = false;
            this.lvRooms.View = System.Windows.Forms.View.Details;
            this.lvRooms.Click += new System.EventHandler(this.lvRooms_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "RoomID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Building";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Room";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Capacity";
            this.columnHeader13.Width = 82;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEntryToolStripMenuItem,
            this.modifyNewEntryToolStripMenuItem,
            this.deleteEntyToolStripMenuItem,
            this.toolStripSeparator2,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 98);
            // 
            // addNewEntryToolStripMenuItem
            // 
            this.addNewEntryToolStripMenuItem.Name = "addNewEntryToolStripMenuItem";
            this.addNewEntryToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addNewEntryToolStripMenuItem.Text = "Add New Entry";
            this.addNewEntryToolStripMenuItem.Click += new System.EventHandler(this.addNewEntryToolStripMenuItem_Click);
            // 
            // modifyNewEntryToolStripMenuItem
            // 
            this.modifyNewEntryToolStripMenuItem.Name = "modifyNewEntryToolStripMenuItem";
            this.modifyNewEntryToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.modifyNewEntryToolStripMenuItem.Text = "Modify Entry";
            this.modifyNewEntryToolStripMenuItem.Click += new System.EventHandler(this.modifyNewEntryToolStripMenuItem_Click);
            // 
            // deleteEntyToolStripMenuItem
            // 
            this.deleteEntyToolStripMenuItem.Name = "deleteEntyToolStripMenuItem";
            this.deleteEntyToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteEntyToolStripMenuItem.Text = "Delete Enty";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatus});
            this.statusStrip1.Location = new System.Drawing.Point(3, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(351, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Click += new System.EventHandler(this.lvRooms_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(16, 17);
            this.txtStatus.Text = "...";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvRoom2);
            this.tabPage2.Controls.Add(this.statusStrip3);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(357, 693);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Availability";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvRoom2
            // 
            this.lvRoom2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvRoom2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRoom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvRoom2.FullRowSelect = true;
            this.lvRoom2.GridLines = true;
            this.lvRoom2.Location = new System.Drawing.Point(3, 138);
            this.lvRoom2.Name = "lvRoom2";
            this.lvRoom2.Size = new System.Drawing.Size(351, 530);
            this.lvRoom2.TabIndex = 7;
            this.lvRoom2.UseCompatibleStateImageBehavior = false;
            this.lvRoom2.View = System.Windows.Forms.View.Details;
            this.lvRoom2.Click += new System.EventHandler(this.lvRoom2_Click);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Building";
            this.columnHeader10.Width = 217;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Room";
            this.columnHeader11.Width = 127;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Capacity";
            // 
            // statusStrip3
            // 
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip3.Location = new System.Drawing.Point(3, 668);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Size = new System.Drawing.Size(351, 22);
            this.statusStrip3.TabIndex = 6;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 135);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboFrom);
            this.groupBox1.Controls.Add(this.cboDay);
            this.groupBox1.Controls.Add(this.cboTo);
            this.groupBox1.Controls.Add(this.cmdCheck);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
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
            this.cboFrom.Location = new System.Drawing.Point(99, 47);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(129, 23);
            this.cboFrom.TabIndex = 28;
            // 
            // cboDay
            // 
            this.cboDay.FormattingEnabled = true;
            this.cboDay.Items.AddRange(new object[] {
            "M",
            "T",
            "W",
            "H",
            "F",
            "S",
            "A",
            "MH",
            "TF",
            "WS",
            "MWF",
            "THS"});
            this.cboDay.Location = new System.Drawing.Point(99, 20);
            this.cboDay.Name = "cboDay";
            this.cboDay.Size = new System.Drawing.Size(129, 23);
            this.cboDay.TabIndex = 27;
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
            this.cboTo.Location = new System.Drawing.Point(99, 72);
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(129, 23);
            this.cboTo.TabIndex = 26;
            // 
            // cmdCheck
            // 
            this.cmdCheck.Location = new System.Drawing.Point(240, 72);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(79, 29);
            this.cmdCheck.TabIndex = 24;
            this.cmdCheck.Text = "Check";
            this.cmdCheck.UseVisualStyleBackColor = true;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Day";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "From";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(365, 287);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(663, 180);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Assigned Department";
            this.columnHeader9.Width = 572;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip2.Location = new System.Drawing.Point(365, 467);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(663, 22);
            this.statusStrip2.TabIndex = 21;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 17);
            this.lblStatus.Text = "...";
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.cl0700,
            this.cl0730,
            this.cl0800,
            this.cl0830,
            this.cl0900,
            this.cl0930,
            this.cl1000,
            this.cl1030,
            this.cl1100,
            this.cl1130,
            this.cl1200,
            this.cl1230,
            this.cl0100,
            this.cl0130,
            this.cl0200,
            this.cl0230,
            this.cl0300,
            this.cl0330,
            this.cl0400,
            this.cl0430,
            this.cl0500,
            this.cl0530,
            this.cl06pm,
            this.cl063pm});
            this.dataGridViewSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSchedule.Location = new System.Drawing.Point(365, 25);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.ReadOnly = true;
            this.dataGridViewSchedule.RowHeadersVisible = false;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(663, 167);
            this.dataGridViewSchedule.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 20;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 20;
            // 
            // cl0700
            // 
            this.cl0700.FillWeight = 86.68884F;
            this.cl0700.HeaderText = "07";
            this.cl0700.MinimumWidth = 7;
            this.cl0700.Name = "cl0700";
            this.cl0700.ReadOnly = true;
            this.cl0700.Width = 25;
            // 
            // cl0730
            // 
            this.cl0730.FillWeight = 48.58986F;
            this.cl0730.HeaderText = "07";
            this.cl0730.MinimumWidth = 7;
            this.cl0730.Name = "cl0730";
            this.cl0730.ReadOnly = true;
            this.cl0730.Width = 25;
            // 
            // cl0800
            // 
            this.cl0800.FillWeight = 20.42514F;
            this.cl0800.HeaderText = "08";
            this.cl0800.MinimumWidth = 7;
            this.cl0800.Name = "cl0800";
            this.cl0800.ReadOnly = true;
            this.cl0800.Width = 25;
            // 
            // cl0830
            // 
            this.cl0830.HeaderText = "08";
            this.cl0830.MinimumWidth = 7;
            this.cl0830.Name = "cl0830";
            this.cl0830.ReadOnly = true;
            this.cl0830.Width = 25;
            // 
            // cl0900
            // 
            this.cl0900.HeaderText = "09";
            this.cl0900.Name = "cl0900";
            this.cl0900.ReadOnly = true;
            this.cl0900.Width = 25;
            // 
            // cl0930
            // 
            this.cl0930.HeaderText = "09";
            this.cl0930.Name = "cl0930";
            this.cl0930.ReadOnly = true;
            this.cl0930.Width = 25;
            // 
            // cl1000
            // 
            this.cl1000.HeaderText = "10";
            this.cl1000.Name = "cl1000";
            this.cl1000.ReadOnly = true;
            this.cl1000.Width = 25;
            // 
            // cl1030
            // 
            this.cl1030.HeaderText = "10";
            this.cl1030.Name = "cl1030";
            this.cl1030.ReadOnly = true;
            this.cl1030.Width = 25;
            // 
            // cl1100
            // 
            this.cl1100.HeaderText = "11";
            this.cl1100.Name = "cl1100";
            this.cl1100.ReadOnly = true;
            this.cl1100.Width = 25;
            // 
            // cl1130
            // 
            this.cl1130.HeaderText = "11";
            this.cl1130.Name = "cl1130";
            this.cl1130.ReadOnly = true;
            this.cl1130.Width = 25;
            // 
            // cl1200
            // 
            this.cl1200.HeaderText = "12";
            this.cl1200.Name = "cl1200";
            this.cl1200.ReadOnly = true;
            this.cl1200.Width = 25;
            // 
            // cl1230
            // 
            this.cl1230.HeaderText = "12";
            this.cl1230.Name = "cl1230";
            this.cl1230.ReadOnly = true;
            this.cl1230.Width = 25;
            // 
            // cl0100
            // 
            this.cl0100.HeaderText = "01";
            this.cl0100.Name = "cl0100";
            this.cl0100.ReadOnly = true;
            this.cl0100.Width = 25;
            // 
            // cl0130
            // 
            this.cl0130.HeaderText = "01";
            this.cl0130.Name = "cl0130";
            this.cl0130.ReadOnly = true;
            this.cl0130.Width = 25;
            // 
            // cl0200
            // 
            this.cl0200.HeaderText = "02";
            this.cl0200.Name = "cl0200";
            this.cl0200.ReadOnly = true;
            this.cl0200.Width = 25;
            // 
            // cl0230
            // 
            this.cl0230.HeaderText = "02";
            this.cl0230.Name = "cl0230";
            this.cl0230.ReadOnly = true;
            this.cl0230.Width = 25;
            // 
            // cl0300
            // 
            this.cl0300.HeaderText = "03";
            this.cl0300.Name = "cl0300";
            this.cl0300.ReadOnly = true;
            this.cl0300.Width = 25;
            // 
            // cl0330
            // 
            this.cl0330.HeaderText = "03";
            this.cl0330.Name = "cl0330";
            this.cl0330.ReadOnly = true;
            this.cl0330.Width = 25;
            // 
            // cl0400
            // 
            this.cl0400.HeaderText = "04";
            this.cl0400.Name = "cl0400";
            this.cl0400.ReadOnly = true;
            this.cl0400.Width = 25;
            // 
            // cl0430
            // 
            this.cl0430.HeaderText = "04";
            this.cl0430.Name = "cl0430";
            this.cl0430.ReadOnly = true;
            this.cl0430.Width = 25;
            // 
            // cl0500
            // 
            this.cl0500.HeaderText = "05";
            this.cl0500.Name = "cl0500";
            this.cl0500.ReadOnly = true;
            this.cl0500.Width = 25;
            // 
            // cl0530
            // 
            this.cl0530.HeaderText = "05";
            this.cl0530.Name = "cl0530";
            this.cl0530.ReadOnly = true;
            this.cl0530.Width = 25;
            // 
            // cl06pm
            // 
            this.cl06pm.HeaderText = "06";
            this.cl06pm.Name = "cl06pm";
            this.cl06pm.ReadOnly = true;
            this.cl06pm.Width = 25;
            // 
            // cl063pm
            // 
            this.cl063pm.HeaderText = "06";
            this.cl063pm.Name = "cl063pm";
            this.cl063pm.ReadOnly = true;
            this.cl063pm.Width = 25;
            // 
            // lvSchedule
            // 
            this.lvSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSchedule.FullRowSelect = true;
            this.lvSchedule.GridLines = true;
            this.lvSchedule.Location = new System.Drawing.Point(365, 192);
            this.lvSchedule.Name = "lvSchedule";
            this.lvSchedule.Size = new System.Drawing.Size(663, 95);
            this.lvSchedule.TabIndex = 24;
            this.lvSchedule.UseCompatibleStateImageBehavior = false;
            this.lvSchedule.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subject";
            this.columnHeader4.Width = 138;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Section";
            this.columnHeader5.Width = 66;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Room";
            this.columnHeader6.Width = 125;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Schedule";
            this.columnHeader7.Width = 223;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Faculty";
            this.columnHeader8.Width = 202;
            // 
            // frmRoomSchedule
            // 
            this.ClientSize = new System.Drawing.Size(1028, 489);
            this.Controls.Add(this.lvSchedule);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRoomSchedule";
            this.Text = "Class Room";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion



        private void lvRooms_Click(object sender, EventArgs e)
        {
            DisplayRoomSchedule(lvRooms.Items[lvRooms.FocusedItem.Index].SubItems[1].Text + "- " + lvRooms.Items[lvRooms.FocusedItem.Index].SubItems[2].Text);
         }

        private void addNewEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoomAE room = new frmRoomAE();
            room.mFormState = "ADD";
            room.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            if (cboDay.Text == "" || cboFrom.Text == "" || cboTo.Text == "")
            {
                MessageBox.Show("Please fill all the required fields..");
            }
            else
            {
                RoomInUse();
            }
        }

        public void RoomInUse()
        {
            OleDbCommand com = new OleDbCommand("Select * from qryRoomAvailability Where cTimeIn <> #" + cboFrom.Text + "# and cTimeOut <> #" + cboTo.Text + "# and cDay LIKE '%" + cboDay.Text + "%'", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
                lvRoom2.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem list = new ListViewItem(dr["Building"].ToString());
                    list.SubItems.Add(dr["RoomNo"].ToString());
                    list.SubItems.Add(dr["Capacity"].ToString());
                    lvRoom2.Items.AddRange(new ListViewItem[] { list });
                }
                txtStatus.Text = Convert.ToString(lvRooms.Items.Count) + " rooms found.";
                dr.Close();
        }

        private void lvRoom2_Click(object sender, EventArgs e)
        {
            DisplayRoomSchedule(lvRoom2.Items[lvRoom2.FocusedItem.Index].SubItems[0].Text + "- " + lvRoom2.Items[lvRoom2.FocusedItem.Index].SubItems[1].Text);
        }

        private void modifyNewEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoomAE room = new frmRoomAE();
            room.mFormState = "EDIT";
            room.DisplayForEditing(lvRooms.FocusedItem.Text);
        }


  }
}
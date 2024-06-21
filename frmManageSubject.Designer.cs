namespace Scheduler
{
    partial class frmManageSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageSubject));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cboSY = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cboCurriculum = new System.Windows.Forms.ToolStripComboBox();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.offerSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvSchedule = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.viewOfferingDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvSubjects = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lsvFaculty = new System.Windows.Forms.ListView();
            this._column_43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdSubjectOffer = new System.Windows.Forms.ToolStripButton();
            this.cmdtoolCancel = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tvSubject = new System.Windows.Forms.TreeView();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cboSY,
            this.toolStripSeparator2,
            this.cboCurriculum,
            this.printToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1028, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cboSY
            // 
            this.cboSY.Name = "cboSY";
            this.cboSY.Size = new System.Drawing.Size(140, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cboCurriculum
            // 
            this.cboCurriculum.Name = "cboCurriculum";
            this.cboCurriculum.Size = new System.Drawing.Size(349, 25);
            this.cboCurriculum.SelectedIndexChanged += new System.EventHandler(this.cboCurriculum_SelectedIndexChanged);
            this.cboCurriculum.Click += new System.EventHandler(this.cboCurriculum_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEntryToolStripMenuItem,
            this.modifyEntryToolStripMenuItem,
            this.deleteEntryToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem,
            this.toolStripSeparator4,
            this.offerSubjectToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 126);
            // 
            // addNewEntryToolStripMenuItem
            // 
            this.addNewEntryToolStripMenuItem.Name = "addNewEntryToolStripMenuItem";
            this.addNewEntryToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addNewEntryToolStripMenuItem.Text = "Add New Entry";
            this.addNewEntryToolStripMenuItem.Click += new System.EventHandler(this.addNewEntryToolStripMenuItem_Click);
            // 
            // modifyEntryToolStripMenuItem
            // 
            this.modifyEntryToolStripMenuItem.Name = "modifyEntryToolStripMenuItem";
            this.modifyEntryToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.modifyEntryToolStripMenuItem.Text = "Modify Entry";
            this.modifyEntryToolStripMenuItem.Click += new System.EventHandler(this.modifyEntryToolStripMenuItem_Click);
            // 
            // deleteEntryToolStripMenuItem
            // 
            this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
            this.deleteEntryToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteEntryToolStripMenuItem.Text = "Delete Entry";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(150, 6);
            // 
            // offerSubjectToolStripMenuItem
            // 
            this.offerSubjectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("offerSubjectToolStripMenuItem.Image")));
            this.offerSubjectToolStripMenuItem.Name = "offerSubjectToolStripMenuItem";
            this.offerSubjectToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.offerSubjectToolStripMenuItem.Text = "Offer Subject...";
            this.offerSubjectToolStripMenuItem.Click += new System.EventHandler(this.cmdSubjectOffer_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "folder_open.png");
            this.imageList1.Images.SetKeyName(2, "folder_yel.png");
            this.imageList1.Images.SetKeyName(3, "folder_yel_open.png");
            this.imageList1.Images.SetKeyName(4, "idea.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(664, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 459);
            this.panel1.TabIndex = 3;
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage3);
            this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl4.Location = new System.Drawing.Point(0, 0);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(364, 459);
            this.tabControl4.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvSchedule);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(356, 431);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Subject Offered";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvSchedule
            // 
            this.lvSchedule.AllowDrop = true;
            this.lvSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSchedule.ContextMenuStrip = this.contextMenuStrip2;
            this.lvSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSchedule.FullRowSelect = true;
            this.lvSchedule.GridLines = true;
            this.lvSchedule.Location = new System.Drawing.Point(3, 3);
            this.lvSchedule.MultiSelect = false;
            this.lvSchedule.Name = "lvSchedule";
            this.lvSchedule.Size = new System.Drawing.Size(350, 425);
            this.lvSchedule.TabIndex = 27;
            this.lvSchedule.UseCompatibleStateImageBehavior = false;
            this.lvSchedule.View = System.Windows.Forms.View.Details;
            this.lvSchedule.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvSchedule_DragDrop);
            this.lvSchedule.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvSchedule_DragEnter);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Subject";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Room";
            this.columnHeader1.Width = 64;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Schedule";
            this.columnHeader2.Width = 223;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Faculty";
            this.columnHeader3.Width = 179;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem1,
            this.toolStripSeparator5,
            this.viewOfferingDetailToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(177, 54);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.refreshToolStripMenuItem1.Text = "Refresh...";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(173, 6);
            // 
            // viewOfferingDetailToolStripMenuItem
            // 
            this.viewOfferingDetailToolStripMenuItem.Name = "viewOfferingDetailToolStripMenuItem";
            this.viewOfferingDetailToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.viewOfferingDetailToolStripMenuItem.Text = "View offering detail";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 459);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvSubjects);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.tvSubject);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(656, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Available Subject";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvSubjects
            // 
            this.lvSubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader14,
            this.columnHeader5});
            this.lvSubjects.ContextMenuStrip = this.contextMenuStrip1;
            this.lvSubjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSubjects.FullRowSelect = true;
            this.lvSubjects.GridLines = true;
            this.lvSubjects.Location = new System.Drawing.Point(193, 28);
            this.lvSubjects.MultiSelect = false;
            this.lvSubjects.Name = "lvSubjects";
            this.lvSubjects.Size = new System.Drawing.Size(460, 187);
            this.lvSubjects.SmallImageList = this.imageList1;
            this.lvSubjects.TabIndex = 12;
            this.lvSubjects.UseCompatibleStateImageBehavior = false;
            this.lvSubjects.View = System.Windows.Forms.View.Details;
            this.lvSubjects.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvSubjects_ItemDrag);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "SubjectCode";
            this.columnHeader10.Width = 0;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Subject";
            this.columnHeader11.Width = 98;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Descriptive Title";
            this.columnHeader12.Width = 190;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Unit";
            this.columnHeader14.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yr";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl2.Location = new System.Drawing.Point(193, 215);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(460, 191);
            this.tabControl2.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lsvFaculty);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 163);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Faculty";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lsvFaculty
            // 
            this.lsvFaculty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._column_43});
            this.lsvFaculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvFaculty.FullRowSelect = true;
            this.lsvFaculty.HideSelection = false;
            this.lsvFaculty.Location = new System.Drawing.Point(3, 3);
            this.lsvFaculty.Name = "lsvFaculty";
            this.lsvFaculty.Size = new System.Drawing.Size(446, 157);
            this.lsvFaculty.TabIndex = 1;
            this.lsvFaculty.UseCompatibleStateImageBehavior = false;
            this.lsvFaculty.View = System.Windows.Forms.View.Details;
            // 
            // _column_43
            // 
            this._column_43.Name = "_column_43";
            this._column_43.Text = "Name";
            this._column_43.Width = 274;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.copyToolStripButton,
            this.toolStripSeparator3,
            this.cmdSubjectOffer,
            this.cmdtoolCancel});
            this.toolStrip2.Location = new System.Drawing.Point(193, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(460, 25);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.addNewEntryToolStripMenuItem_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.modifyEntryToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdSubjectOffer
            // 
            this.cmdSubjectOffer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSubjectOffer.Image = ((System.Drawing.Image)(resources.GetObject("cmdSubjectOffer.Image")));
            this.cmdSubjectOffer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSubjectOffer.Name = "cmdSubjectOffer";
            this.cmdSubjectOffer.Size = new System.Drawing.Size(23, 22);
            this.cmdSubjectOffer.Text = "Subject Offering";
            // 
            // cmdtoolCancel
            // 
            this.cmdtoolCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdtoolCancel.Image = ((System.Drawing.Image)(resources.GetObject("cmdtoolCancel.Image")));
            this.cmdtoolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdtoolCancel.Name = "cmdtoolCancel";
            this.cmdtoolCancel.Size = new System.Drawing.Size(23, 22);
            this.cmdtoolCancel.Text = "Cancel Offerring";
            this.cmdtoolCancel.Click += new System.EventHandler(this.cmdtoolCancel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(193, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(460, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tvSubject
            // 
            this.tvSubject.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvSubject.FullRowSelect = true;
            this.tvSubject.ImageIndex = 1;
            this.tvSubject.ImageList = this.imageList1;
            this.tvSubject.Location = new System.Drawing.Point(3, 3);
            this.tvSubject.Name = "tvSubject";
            this.tvSubject.SelectedImageIndex = 0;
            this.tvSubject.Size = new System.Drawing.Size(190, 425);
            this.tvSubject.TabIndex = 3;
            this.tvSubject.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSubject_AfterSelect);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmManageSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 484);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageSubject";
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.frmManageSubject_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripComboBox cboSY;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox cboCurriculum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TreeView tvSubject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton cmdSubjectOffer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem offerSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton cmdtoolCancel;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvSchedule;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem viewOfferingDetailToolStripMenuItem;
        private System.Windows.Forms.ListView lvSubjects;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.ListView lsvFaculty;
        public System.Windows.Forms.ColumnHeader _column_43;

    }
}
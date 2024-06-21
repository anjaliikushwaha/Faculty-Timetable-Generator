using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Scheduler
{
    public partial class MainForm : Form
    {

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
        public static extern long GetPrivateProfileString(string lpApplicationName, object lpKeyName, string lpDefault, string lpReturnedString, long nSize, string lpFileName);

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void classRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoomSchedule room = new frmRoomSchedule();
            room.MdiParent = this;
            room.WindowState = FormWindowState.Maximized;
            room.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectOffered schedule = new frmSubjectOffered();
            schedule.Show();
        }
            
        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacultySchedule faculty = new frmFacultySchedule();
            faculty.MdiParent = this;
            faculty.WindowState = FormWindowState.Maximized;
            faculty.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void manageSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageSections sections = new frmManageSections();
            sections.MdiParent = this;
            sections.WindowState = FormWindowState.Maximized;
            sections.Show();
        }

        private void manageSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageSubject subjects = new frmManageSubject();
            subjects.MdiParent =this;
            subjects.WindowState = FormWindowState.Maximized;
            subjects.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            System.IO.StreamReader Reader = new
                System.IO.StreamReader(Application.StartupPath + "\\config.txt");

            clsSchedule.CurrentSchoolYear = Reader.ReadToEnd();
            Reader.Close();

            if (clsSchedule.CurrentSchoolYear == "" || clsSchedule.CurrentSchoolYear == String.Empty)
            {
                frmSetActiveSY sy = new frmSetActiveSY();
                sy.ShowDialog();
            }
            else
            {
                ReloadSchoolYear();
            }
        }

        public void ReloadSchoolYear()
        {
            txtSchoolYear.Text = clsSchedule.CurrentSchoolYear;
        }
    }
}

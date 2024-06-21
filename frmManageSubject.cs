using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;


namespace Scheduler
{
    public partial class frmManageSubject : Form
    {

        public frmManageSubject()
        {
            InitializeComponent();
        }

        private void frmManageSubject_Load(object sender, EventArgs e)
        {
            if (clsCon.con.State == ConnectionState.Open)
            { clsCon.con.Close(); }
            clsCon.con.Open();


            LoadCurriculum();
            LoadSubjects();
            PopulatedTreeView();
            LoadSubjectOffered();
            cboCurriculum.SelectedIndex = cboCurriculum.FindStringExact("ALL");
            
        }

        public void LoadSubjects()
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM qrySubjects", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            lvSubjects.Items.Clear();
            while (dr.Read())
            {
                ListViewItem list = new ListViewItem(dr["SubjectCode"].ToString());
                list.SubItems.Add(dr["Subject"].ToString());
                list.SubItems.Add(dr["DescriptiveTitle"].ToString());
                list.SubItems.Add(dr["Units"].ToString());
                list.SubItems.Add(dr["YearLevel"].ToString());
                list.UseItemStyleForSubItems = false;
                list.ImageIndex = 0;
                lvSubjects.Items.AddRange(new ListViewItem[] { list });
            }
            dr.Close();
        }

        public void LoadSubjectsByYearLvl(string sYearLvl)
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM qrySubjects where YrLvlChar='" + sYearLvl +"'", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            lvSubjects.Items.Clear();
            while (dr.Read())
            {
                ListViewItem list = new ListViewItem(dr["Subject"].ToString());
                list.SubItems.Add(dr["SubjectCode"].ToString());
                list.SubItems.Add(dr["DescriptiveTitle"].ToString());
                list.SubItems.Add(dr["Units"].ToString());
                list.SubItems.Add(dr["HrsWk"].ToString());
                list.SubItems.Add(dr["YearLevel"].ToString());
                list.ImageIndex = 0;
                list.UseItemStyleForSubItems = false;
                lvSubjects.Items.AddRange(new ListViewItem[] { list });
            }
            dr.Close();
        }

        void LoadCurriculum()
        {
            OleDbCommand com = new OleDbCommand("Select CurriculumTitle From tblCurriculum", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            cboCurriculum.Items.Clear();
            while (dr.Read())
            {
                cboCurriculum.Items.Add(dr["CurriculumTitle"].ToString());
            }
            cboCurriculum.Items.Add("ALL");
            dr.Close();
        }

        public void LoadSubjectsByCurriculum(string Curriculum)
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM qrySubjects where CurriculumTitle Like '%" + Curriculum + "%'", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            lvSubjects.Items.Clear();
            while (dr.Read())
            {
                ListViewItem list = new ListViewItem(dr["Subject"].ToString());
                list.SubItems.Add(dr["SubjectCode"].ToString());
                list.SubItems.Add(dr["DescriptiveTitle"].ToString());
                list.SubItems.Add(dr["Units"].ToString());
                list.SubItems.Add(dr["HrsWk"].ToString());
                list.SubItems.Add(dr["YearLevel"].ToString());
                list.UseItemStyleForSubItems = false;
                list.ImageIndex = 0;
                lvSubjects.Items.AddRange(new ListViewItem[] { list });
            }
            dr.Close();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSubjects();
        }


        void LoadSubjectOffered()
        { 
            OleDbCommand com = new OleDbCommand("SELECT * FROM qrySubjectOfferring ", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            lvSchedule.Items.Clear();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["Subject"].ToString());
                lv.SubItems.Add(dr["cRoom"].ToString());
                lv.SubItems.Add(dr["Schedule"].ToString());
                lv.SubItems.Add(dr["Faculty"].ToString());
                lv.ImageIndex = 3;
                lvSchedule.Items.AddRange(new ListViewItem[] { lv });
            }
            dr.Close();
        }


        void PopulatedTreeView()
        {
            tvSubject.BeginUpdate();
            tvSubject.Nodes.Clear();

            #region SchoolYear
            OleDbCommand cmd = new OleDbCommand("Select * From tblSchoolYear", clsCon.con);
            OleDbDataReader rs = cmd.ExecuteReader();
            while (rs.Read())
            {
                //node.Text = rs["SchoolYear"].ToString();
                tvSubject.Nodes.Add(rs["SchoolYear"].ToString(), rs["SchoolYear"].ToString(), 0);
            }
            rs.Close();
            #endregion

            #region Curriculum
            OleDbCommand comm = new OleDbCommand("Select CurriculumTitle From tblCurriculum", clsCon.con);
            OleDbDataReader vRS = comm.ExecuteReader();
            while (vRS.Read())
            {
                ///node.Text = vRS["CurriculumTitle"].ToString();
                tvSubject.Nodes[0].Nodes.Add(vRS["CurriculumTitle"].ToString(), vRS["CurriculumTitle"].ToString(),1);
            }
            vRS.Close();
            #endregion

            #region YearLvl
            OleDbCommand com = new OleDbCommand("Select YrLvlChar From YearLevel", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                //node.Text = dr["YrLvlChar"].ToString();
                tvSubject.Nodes[0].Nodes[0].Nodes.Add(dr["YrLvlChar"].ToString(), dr["YrLvlChar"].ToString(),1);
            }
            dr.Close();
            #endregion

            tvSubject.EndUpdate();
            
        }

        private void addNewEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectAE subject = new frmSubjectAE();
            subject.mFormState = "ADD";
            subject.ShowDialog();
        }

        private void cmdSubjectOffer_Click(object sender, EventArgs e)
        {
            frmScheduler pipo = new frmScheduler();
            pipo.txtSubject.Text = lvSubjects.FocusedItem.Text;
            pipo.sSubjectCode = lvSubjects.Items[lvSubjects.FocusedItem.Index].SubItems[1].Text;
            pipo.sYearLevel = int.Parse(lvSubjects.Items[lvSubjects.FocusedItem.Index].SubItems[4].Text);
            pipo.mFormState = "ADD";
            pipo.ShowDialog();
        }

        private void cboCurriculum_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboCurriculum.Text)
            {
                case "ALL":
                    LoadSubjects();
                    break;
                default:
                    LoadSubjectsByCurriculum(cboCurriculum.Text);
                    break;
            }
        }

        private void cmdtoolCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void tvSubject_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void lvSubjects_ItemDrag(object sender, ItemDragEventArgs e)
        {
           lvSubjects.DoDragDrop(lvSubjects.FocusedItem.Text, DragDropEffects.Move);
        }

        private void lvSchedule_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lvSchedule_DragDrop(object sender, DragEventArgs e)
        {
            frmScheduler pipo = new frmScheduler();
            pipo.txtSubject.Text = lvSubjects.FocusedItem.Text;
            pipo.sSubjectCode = lvSubjects.Items[lvSubjects.FocusedItem.Index].SubItems[1].Text;
            pipo.sYearLevel=int.Parse(lvSubjects.Items[lvSubjects.FocusedItem.Index].SubItems[4].Text);
            pipo.mFormState = "ADD";
            pipo.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LoadSubjectOffered();
        }

        private void modifyEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectAE subj = new frmSubjectAE();
            subj.mFormState = "EDIT";
            subj.sSubjectCode = lvSubjects.FocusedItem.Text;
            subj.ShowDialog();
        }

        private void cboCurriculum_Click(object sender, EventArgs e)
        {

        }

        private void refreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadSubjectOffered();
        }

    }
}

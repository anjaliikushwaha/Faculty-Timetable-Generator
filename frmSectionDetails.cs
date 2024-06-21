using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class frmSectionDetails : Form
    {
        public string mFormState,sAdviserID,sSectionID;
        public int myID;

        public frmSectionDetails()
        {
            InitializeComponent();
        }

        public void GetSectionByID(string sSectionID)
        {
            OleDbCommand com = new OleDbCommand("SELECT * From qrySectionAdvisory WHERE SectionID='" + sSectionID + "'", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtSection.Text = dr["newSection"].ToString();
                txtSectionID.Text = sSectionID;
                cboYearLvl.Text = dr["YrLvlChar"].ToString();
                cboDepartment.Text = dr["CurriculumTitle"].ToString();
                cboAdviser.Text = dr["Faculty"].ToString();
                txtMaxGrade.Text = dr["MaxGrade"].ToString();
                txtMinGrade.Text = dr["MinGrade"].ToString();
                txtMaxStudent.Text = dr["MaxStudent"].ToString();
            }
            else
            {
                if (MessageBox.Show("This section has no class adviser.\n Would you like to assign?") == System.Windows.Forms.DialogResult.Yes)
                {

                }
                else
                { this.Close(); }

            }
            dr.Close();
        }

        public void GetSectionByTitle(string sSectionTitle)
        {
            OleDbCommand com = new OleDbCommand("SELECT * From qrySectionAdvisory WHERE (((Section.SectionName)='" + sSectionTitle + "'));", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtSection.Text = sSectionTitle;
                txtSectionID.Text = dr["SectionID"].ToString();
                cboYearLvl.Text = dr["YrLvlChar"].ToString();
                cboDepartment.Text = dr["CurriculumTitle"].ToString();
                cboAdviser.Text = dr["Faculty"].ToString();
                txtMaxGrade.Text = dr["MaxGrade"].ToString();
                txtMinGrade.Text = dr["MinGrade"].ToString();
                txtMaxStudent.Text = dr["MaxStudent"].ToString();
            }
            else
            {
                if (MessageBox.Show("This section has no class adviser.\n Would you like to assign?") == System.Windows.Forms.DialogResult.Yes)
                {

                }
                else
                { this.Close(); }
            }
            dr.Close();
        }

        public void GetSectionByFullTitle(string sSectionFullTitle)
        {
            string sSectionTitle;
            String[] splitsSectionFullTitle = sSectionFullTitle.Split('-');
            sSectionTitle = splitsSectionFullTitle[1];

            OleDbCommand com = new OleDbCommand("SELECT * From qrySectionAdvisory WHERE (((Section.SectionName)='" + sSectionTitle + "'));", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtSection.Text = dr["SectionName"].ToString();
                txtSectionID.Text = dr["SectionID"].ToString();
                cboYearLvl.Text = dr["YrLvlChar"].ToString();
                cboDepartment.Text = dr["CurriculumTitle"].ToString();
                cboAdviser.Text = dr["Faculty"].ToString();
                txtMaxGrade.Text = dr["MaxGrade"].ToString();
                txtMinGrade.Text = dr["MinGrade"].ToString();
                txtMaxStudent.Text = dr["MaxStudent"].ToString();
            }
            else 
            {
                if (MessageBox.Show("This section has no class adviser.\n Would you like to assign?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    mFormState = "ADD";
                }
                else
                { this.Close(); }
            }
            dr.Close();
        }

        bool SectionExistByTitle(string sSectionTitle)
        {
            OleDbCommand com = new OleDbCommand("SELECT [SectionName] From [Section] WHERE [SectionName]='" + sSectionTitle + "'", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            { return true; }
            else
            { return false; }

        }

        bool SectionExistByFullTitle(string sSectionFullTitle)
        {
            string sSectionTitle;
            String[] splitsSectionFullTitle = sSectionFullTitle.Split('-');
            sSectionTitle = splitsSectionFullTitle[1];

            OleDbCommand com = new OleDbCommand("SELECT * From [Section] WHERE (((Section.SectionName)='" + sSectionTitle + "'));", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            { return true; }
            else
            { return false; }
        }


        bool ValidateData()
        {
            bool Temp = false;
            if (clsCon.CheckTextBox(txtSectionID, "Please Enter Section ID") == true)
            { Temp = true; }
            else if (clsCon.CheckTextBox(txtSection, "Please Enter Section Title") == true)
            { Temp = true; }
            return Temp;
        }


        void AddSection(string sSectionID, string sSectionTitle, string sYearLvl, string sCurriculum,string sAdviser, string sMaxStudent,string sMaxGrade, string sMinGrade)
        {
            if (SectionExistByTitle(sSectionTitle) == true)
            {
                MessageBox.Show("Same record found...", "Duplicate Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                OleDbCommand com = new OleDbCommand();
                com.CommandText = "Insert Into [Section](SectionID,SectionName,YearLvl,CurriculumID,MaxStudent,MaxGrade,MinGrade) VALUES ('" + sSectionID + "','" + sSectionTitle + "','" + sYearLvl + "','" + sCurriculum + "','" + sMaxStudent + "','" + sMaxGrade + "','" + sMinGrade + "')";
                com.Connection = clsCon.con;
                com.ExecuteNonQuery();

                OleDbCommand com1 = new OleDbCommand();
                com1.CommandText = "Insert Into [tblAdviser](AdviserID,FacultyID,SectionID) VALUES ('" + sAdviser + "','" + txtFacultyID.Text + "','" + sSectionID + "')";
                com1.Connection = clsCon.con;
                com1.ExecuteNonQuery();

                OleDbCommand pipz = new OleDbCommand("Update tblGenerator Set NextNo='" + myID + "' where TableName ='" + "Section" + "'", clsCon.con);
                pipz.ExecuteNonQuery();

                MessageBox.Show("Record Successfully Saved...");
                this.Close();
            }
        }


        void UpdateSection(string sSectionID, string sSectionTitle, string sYearLvl, string sCurriculum, string sAdviser, string sMaxStudent, string sMaxGrade, string sMinGrade)
        {
            OleDbCommand com = new OleDbCommand();
            com.CommandText = "Update [Section] set SectionName ='" + sSectionTitle + "',YearLvl ='" + sYearLvl + "',CurriculumID = '" +sCurriculum + "',MaxStudent ='" + sMaxStudent + "',MaxGrade='" + sMaxGrade + "',MinGrade='" + sMinGrade + "' Where SectionID='" + sSectionID + "')";
            com.Connection = clsCon.con;
            com.ExecuteNonQuery();

            OleDbCommand pipz = new OleDbCommand("Update tblAdviser Set FacultyID='" + txtFacultyID.Text + "',SectionID='" + sSectionID + "' where AdviserID='" + sAdviser + "'", clsCon.con);
            pipz.ExecuteNonQuery();

            MessageBox.Show("Faculty record successfully modify.");
            this.Close();
        }

        void SaveData()
        {
            if (ValidateData() == true)
            { }
            else if (cboYearLvl.Text == "" || cboDepartment.Text == "")
            {
                MessageBox.Show("Please fill some required fields");
            }
            else
            {
                switch (mFormState)
                {
                    case "ADD":
                        AddSection(txtSectionID.Text, txtSection.Text, txtYearLvl.Text, txtDepartment.Text,sAdviserID,txtMaxStudent.Text,txtMaxGrade.Text,txtMinGrade.Text);
                        break;
                    case "EDIT":

                        break;
                }
            }
        }

        public void GenerateSectionID()
        {
            OleDbCommand cmddr = new OleDbCommand("select NextNo from tblGenerator where TableName='" + "Section" + "'", clsCon.con);
            OleDbDataReader dr = cmddr.ExecuteReader();
            while (dr.Read())
            {
                string strid = dr["NextNo"].ToString();
                if (strid == "")
                {
                    txtSectionID.Text = "SEC-" + "1";
                    myID = 1;
                }
                else
                {
                    myID = Convert.ToInt32(dr["NextNo"]) + 1;
                    txtSectionID.Text = "SEC-" + myID.ToString();
                }
            }
            dr.Close();
            cmddr.Dispose();
        }

        public void GenerateAdviserID()
        {
            OleDbCommand cmddr = new OleDbCommand("select NextNo from tblGenerator where TableName='" + "tblAdviser" + "'", clsCon.con);
            OleDbDataReader dr = cmddr.ExecuteReader();
            while (dr.Read())
            {
                string strid = dr["NextNo"].ToString();
                if (strid == "")
                {
                    sAdviserID = "ADV-" + "1";
                    myID = 1;
                }
                else
                {
                    myID = Convert.ToInt32(dr["NextNo"]) + 1;
                    sAdviserID = "ADV-" + myID.ToString();
                }
            }
            dr.Close();
            cmddr.Dispose();
        }

        private void frmSectionDetails_Load(object sender, EventArgs e)
        {
            try
            {
                if (clsCon.con.State == ConnectionState.Open)
                {
                    clsCon.con.Close();
                }
                clsCon.con.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }

            switch (mFormState)
            {
                case "ADD":
                    GenerateSectionID();
                    GenerateAdviserID();
                    clsCon.fillCombo(cboDepartment, "Select CurriculumTitle From tblCurriculum");
                    clsCon.fillCombo(cboYearLvl, "Select YrLvlChar From YearLevel");
                    clsCon.fillCombo(cboAdviser, "Select FacultyName From qryFaculty");
                    break;
                case "EDIT":
                    clsCon.fillCombo(cboDepartment, "Select CurriculumTitle From tblCurriculum");
                    clsCon.fillCombo(cboYearLvl, "Select YrLvlChar From YearLevel");
                    clsCon.fillCombo(cboAdviser,"Select FacultyName From qryFaculty");
                    GetSectionByID(sSectionID);
                    LoadSubjectOffered(sSectionID);
                    LoadAssignedInstructor(sSectionID);
                    break;
            }
        }

        void LoadSubjectOffered(string sSection)
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM qrySubjectOfferring Where SectionID ='" + sSection + "'", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            lsvRoomSchedule.Items.Clear();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["Subject"].ToString());
                lv.SubItems.Add(dr["cRoom"].ToString());
                lv.SubItems.Add(dr["Schedule"].ToString());
                lv.SubItems.Add(dr["Faculty"].ToString());
                lsvRoomSchedule.Items.AddRange(new ListViewItem[] { lv });
            }
            dr.Close();
        }

        void LoadAssignedInstructor(string sInstructor)
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM qrySectionAdvisory Where SectionID='" + sInstructor + "'", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            lsvInstructor.Items.Clear();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["Faculty"].ToString());
                lsvInstructor.Items.AddRange(new ListViewItem[] { lv });
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        void ShowDepartmentIDByTitle(string sTitle)
        {
            OleDbCommand com = new OleDbCommand("Select CurriculumID From tblCurriculum where CurriculumTitle='" + sTitle + "'", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtDepartment.Text = dr["CurriculumID"].ToString();
            }
            dr.Close();
        }

        void ShowAdviserByName(string sTitle)
        {
            OleDbCommand com = new OleDbCommand("Select FacultyID From qryFaculty where FacultyName='" + sTitle + "'", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                sAdviserID = dr["FacultyID"].ToString();
            }
            dr.Close();
        }


        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDepartmentIDByTitle(cboDepartment.Text);
        }

        private void cboYearLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = clsCon.YLTitleToID(cboYearLvl.Text);
            txtYearLvl.Text = num.ToString();
        }

        private void lsvRoomSchedule_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboAdviser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAdviserByName(cboAdviser.Text);
        }

        private void editRoomScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}

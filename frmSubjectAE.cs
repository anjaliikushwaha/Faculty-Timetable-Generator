using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class frmSubjectAE : Form
    {
        public string mFormState,sSubjectCode;
        public int myID;

        public frmSubjectAE()
        {
            InitializeComponent();
        }

        
        bool SubjectExistByID(string sSubjectID)
        {
            OleDbCommand com = new OleDbCommand("SELECT * From qrySubjects WHERE SubjectCode ='" + sSubjectID + "'", clsCon.con);
            OleDbDataReader vRS = com.ExecuteReader();
            vRS.Read();
            if (vRS.HasRows)
            { return true; }
            else
            { return false;}
        }

        bool SubjectExistByTitle(string sSubjectTitle)
        {
            OleDbCommand com = new OleDbCommand("SELECT * From qrySubjects WHERE DescriptiveTitle ='" + sSubjectTitle + "'", clsCon.con);
            OleDbDataReader vRS = com.ExecuteReader();
            vRS.Read();
            if (vRS.HasRows)
            { return true; }
            else
            { return false; }
        }

        void GetSubjectByID(string sSubjectID)
        {
            OleDbCommand com = new OleDbCommand("SELECT * From tblSubject WHERE tblSubject.SubjectCode LIKE '" + sSubjectID + "%'", clsCon.con);
            OleDbDataReader vRS = com.ExecuteReader();
            while (vRS.Read())
            {
                txtSubjectCode.Text = vRS["SubjectCode"].ToString();
                txtCurriculum.Text = vRS["CurriculumID"].ToString();
                txtYearLvl.Text = vRS["YearLevel"].ToString();
                txtDescription.Text = vRS["DescriptiveTitle"].ToString();
                txtUnits.Text = vRS["Units"].ToString();
                txtHrWk.Text = vRS["HrsWk"].ToString();
            }
            vRS.Close();
        }


        void GetSubjectByTitle(string sSubjectTitle)
        {
            OleDbCommand com = new OleDbCommand("SELECT *  FROM tblSubject WHERE tblSubject.DescriptiveTitle Like '" + sSubjectTitle + "%'", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtSubjectCode.Text = dr["SubjectCode"].ToString();
                txtSubjectCode.Text = dr["SubjectCode"].ToString();
                txtCurriculum.Text = dr["CurriculumID"].ToString();
                txtYearLvl.Text = dr["YearLevel"].ToString();
                txtDescription.Text = dr["DescriptiveTitle"].ToString();
                txtUnits.Text = dr["Units"].ToString();
                txtHrWk.Text = dr["HrsWk"].ToString();
            }
            dr.Close();
        }

        void ShowDepartmentIDByTitle(string sTitle)
        {
            OleDbCommand com = new OleDbCommand("Select CurriculumID From tblCurriculum where CurriculumTitle Like '%" + sTitle + "%'", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtCurriculum.Text = dr["CurriculumID"].ToString();
            }
            dr.Close();
        }

        void AddSubject(string sSubjectID, string sDescription,string sUnits,string sHrs, string sCurriculum,string sYearLvl)
        {
            if (SubjectExistByID(sSubjectID) == true)
            {
                MessageBox.Show("Subject Codes has already in the record..");
            }
            else if (SubjectExistByTitle(sDescription) == true)
            {
                MessageBox.Show("Subject Descriptive title has already in the record..");
            }
            else
            {
                OleDbCommand com = new OleDbCommand("Insert Into tblSubject(SubjectCode,DescriptiveTitle,Units,HrsWk,CurriculumID,YearLevel) VALUES " +
                                   " ('" + sSubjectID + "','" + sDescription + "','" + sUnits +"','" + sHrs + "','" + sCurriculum + "','" + sYearLvl + "')", clsCon.con);
                com.ExecuteNonQuery();

                MessageBox.Show("Record Successfully Saved...");

                frmManageSubject man = new frmManageSubject();
                man.LoadSubjects();

                this.Close();
            }
        }

        bool ValidateData()
        {
            bool Temp = false;
            if (clsCon.CheckTextBox(txtSubjectCode, "Please Enter Subject Code") == true)
            { Temp = true; }
            else if (clsCon.CheckTextBox(txtDescription, "Please Enter Descriptive Title") == true)
            { Temp = true; }
            else if (clsCon.CheckTextBox(txtUnits, "Please Enter Subject Unit") == true)
            { Temp = true; }
            else if (clsCon.CheckTextBox(txtHrWk, "Please Enter Subject's Hours per week.") == true)
            { Temp = true; }
            return Temp;
        }


        void SaveData()
        {
            if (ValidateData() == true)
            { }
            else if (cboYearLvl.Text == "" || cboCurriculum.Text == "")
            {
                MessageBox.Show("Please fill some required fields");
            }
            else
            {
                switch (mFormState)
                { 
                    case "ADD":
                        AddSubject(txtSubjectCode.Text, txtDescription.Text, txtUnits.Text, txtHrWk.Text, txtCurriculum.Text, txtYearLvl.Text);
                        break;
                    case "EDIT":
                        UpdateSubject(txtSubjectCode.Text, txtDescription.Text, txtYearLvl.Text, txtUnits.Text, txtHrWk.Text, txtCurriculum.Text);
                        break;
                }
            }
        }

        void UpdateSubject(string sSubjectID, string sDesc, string sYearLvl, string sUnit, string sHours, string sCur)
        {
            OleDbCommand com = new OleDbCommand();
            com.Connection = clsCon.con;
            com.CommandText = "Update tblSubject set DescriptiveTitle='" + sDesc + "', YearLevel='" + sYearLvl + "', Units='" + sUnit + "', HrsWk='" + sHours + "', CurriculumID='" + sCur + "' WHERE SubjectCode='" + sSubjectID + "'";
            com.ExecuteNonQuery();

            MessageBox.Show("Record successfully updated....");
            this.Close();
        }
        private void cboCurriculum_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDepartmentIDByTitle(cboCurriculum.Text);
        }

        private void cboYearLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = clsCon.YLTitleToID(cboYearLvl.Text);
            txtYearLvl.Text = num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSubjectAE_Load(object sender, EventArgs e)
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
                    clsCon.fillCombo(cboCurriculum, "Select CurriculumTitle From tblCurriculum");
                    break;
                case "EDIT":
                    clsCon.fillCombo(cboCurriculum, "Select CurriculumTitle From tblCurriculum");
                    GetSubjectByID(sSubjectCode);
                    break;
            }
        }
    }
}

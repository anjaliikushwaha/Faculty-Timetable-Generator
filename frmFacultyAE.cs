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
    public partial class frmFacultyAE : Form
    {
        public string mFormState,sFacultyID;
        public int myID;

        public frmFacultyAE()
        {
            InitializeComponent();
        }

        private void frmFacultyAE_Load(object sender, EventArgs e)
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
                    GenerateFacultyID();
                    break;
                case "EDIT":
                    GetTeacherByID(sFacultyID);
                    DisplayFacultyLoads(sFacultyID);
                    DisplayFacultySchedule(sFacultyID);
                    break;
            }
   
        }
        public void GenerateFacultyID()
        {
            OleDbCommand cmddr = new OleDbCommand("select NextNo from tblGenerator where TableName='" + "Faculty" + "'", clsCon.con);
            OleDbDataReader dr = cmddr.ExecuteReader();
            while (dr.Read())
            {
                string strid = dr["NextNo"].ToString();
                if (strid == "")
                {
                    txtFacultyID.Text = "Faculty-" + "1";
                    myID = 1;
                }
                else
                {
                    myID = Convert.ToInt32(dr["NextNo"]) + 1;
                    txtFacultyID.Text = "Faculty-" + myID.ToString();
                }
            }
            dr.Close();
            cmddr.Dispose();
        }

        public void GetTeacherByID(string sTeacherID)
        {
            OleDbCommand com = new OleDbCommand("SELECT * From Faculty WHERE (((Faculty.FacultyID)='" + sTeacherID + "'));", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            {
                txtFacultyID.Text = dr["FacultyID"].ToString();
                txtLName.Text = dr["LName"].ToString();
                txtFName.Text = dr["FName"].ToString();
                txtMName.Text = dr["MName"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                txtContact.Text = dr["Contact"].ToString();
                cboGender.Text = dr["Gender"].ToString();

                if (dr["OnService"].ToString() == "Yes")
                { cbxActiveService.Checked = true; }
                else
                { cbxActiveService.Checked = false; }
            }
            dr.Close();
        }

        public void GetTeacherByFullName(string sTeacherFullName)
        {
            OleDbCommand com = new OleDbCommand("SELECT *" +
            " From tblTeacher" +
            " WHERE ((([LastName] & ', ' & [FirstName])='" + sTeacherFullName + "'));", clsCon.con);
            
            OleDbDataReader dr = com.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtFacultyID.Text = dr["FacultyID"].ToString();
                txtLName.Text = dr["LName"].ToString();
                txtFName.Text = dr["FName"].ToString();
                txtMName.Text = dr["MName"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                txtContact.Text = dr["Contact"].ToString();
                cboGender.Text = dr["Gender"].ToString();

                if (dr["OnService"].ToString() == "Yes")
                { cbxActiveService.Checked = true; }
                else
                { cbxActiveService.Checked = false; }

            }
            dr.Close();
        }

        bool ValidateData()
        {
            bool Temp = false;
            if (clsCon.CheckTextBox(txtFacultyID, "Teacher ID") == true)
            { Temp = true;}
            else if (clsCon.CheckTextBox(txtLName, "Teacher Last Name") == true)
            {Temp = true;}
            else if (clsCon.CheckTextBox(txtFName, "Teacher First Name") == true)
            {Temp = true;}
            else if (clsCon.CheckTextBox(txtMName, "Teacher Middle Name") == true)
            { Temp = true; }
            else if (clsCon.CheckTextBox(txtAddress, "Teacher Address") == true)
            { Temp = true; }
            else if (clsCon.CheckTextBox(txtContact, "Teacher Contacts") == true)
            { Temp = true; }
            return Temp;
        }


        public bool TeacherExistByFullName(string sTeacherFullName)
        {
            bool temp = false;

            OleDbCommand com = new OleDbCommand("SELECT [LastName] & ', ' & [FirstName] & ' ' & [MiddleName] AS TeacherFullName" +
            " From tblTeacher" +
            " WHERE ((([LastName] & ', ' & [FirstName] & ' ' & [MiddleName])='" + sTeacherFullName + "'));", clsCon.con);

            OleDbDataReader dr = com.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            { temp = true; }
            else
            { temp = false; }
            return temp;
        }

        void SaveData()
        {
            if (ValidateData() == true)
            { }
            else
            {
                if (cbxActiveService.Checked == true)
                {
                    AddTeacher(txtFacultyID.Text, txtFName.Text, txtLName.Text, txtMName.Text, txtAddress.Text, txtContact.Text, cboGender.Text, "Yes");
                }
                else
                {
                    AddTeacher(txtFacultyID.Text, txtFName.Text, txtLName.Text, txtMName.Text, txtAddress.Text, txtContact.Text, cboGender.Text, "No");
                }
            }
        }
        void UpdateData()
        {
            if (ValidateData() == true)
            { }
            else
            {
                if (cbxActiveService.Checked == true)
                {
                    UpdateTeacher(txtFacultyID.Text, txtFName.Text, txtLName.Text, txtMName.Text, txtAddress.Text, txtContact.Text, cboGender.Text, "Yes");
                }
                else
                {
                    UpdateTeacher(txtFacultyID.Text, txtFName.Text, txtLName.Text, txtMName.Text, txtAddress.Text, txtContact.Text, cboGender.Text, "No");
                }
            }
        }



        public void UpdateTeacher(string sTeacherID, string sFName, string sLName, string sMName, string sAddress, string sContact, string sGender, string sActive)
        {
            OleDbCommand com = new OleDbCommand();
            com.CommandText = "Update Faculty set FName = '" +sFName+ "', LName='" + sLName+ "', MName ='" + sMName + "', Address ='" + sAddress +"',Contact ='" + sContact +"',Gender='" + sGender +"',OnService='" + sActive + "' Where FacultyID='" + sTeacherID + "'";
            com.Connection = clsCon.con;
            com.ExecuteNonQuery();

            MessageBox.Show("Record Successfully Updated...");
            this.Close();
        }

        public void AddTeacher(string sTeacherID,string sFName,string sLName,string sMName, string sAddress, string sContact,string sGender,string sActive)
        {
            OleDbCommand com = new OleDbCommand();
            com.CommandText = "Insert Into Faculty(FacultyID,FName,LName,MName,Address,Contact,Gender,OnService) VALUES ('" + sTeacherID +"','" + sFName + "','" + sLName + "','" +sMName+"','" + sAddress +"','" + sContact +"','" + sGender + "','" + sActive + "')";
            com.Connection = clsCon.con;
            com.ExecuteNonQuery();

            OleDbCommand pipz = new OleDbCommand("Update tblGenerator Set NextNo='" + myID + "' where TableName ='" + "Faculty" + "'", clsCon.con);
            pipz.ExecuteNonQuery();

            MessageBox.Show("Record Successfully Saved...");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (mFormState)
            {
                case "ADD":
                    SaveData();
                    break;
                case "EDIT":
                    UpdateData();
                    break;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void DisplayFacultyLoads(string faculty)
        {
            OleDbCommand com = new OleDbCommand("Select * From qrySubjectOfferring where FacultyID ='" + faculty + "'", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            lsvLoad.Items.Clear();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["Subject"].ToString());
                lv.SubItems.Add(dr["Section"].ToString());
                lv.SubItems.Add(dr["Units"].ToString());
                lsvLoad.Items.AddRange(new ListViewItem[] { lv });
            }
            dr.Close();
        }

        void DisplayFacultySchedule(string faculty)
        {
            OleDbCommand com = new OleDbCommand("Select * From qrySubjectOfferring where FacultyID ='" + faculty + "'", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            lsvRoomSchedule.Items.Clear();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["cRoom"].ToString());
                lv.SubItems.Add(dr["Schedule"].ToString());
                lsvRoomSchedule.Items.AddRange(new ListViewItem[] { lv });
            }
            dr.Close();
        }

    }
}

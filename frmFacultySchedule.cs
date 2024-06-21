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
    public partial class frmFacultySchedule : Form
    {

        public int sDay,sDay1,sDay2;
        int num1, num2;
        public frmFacultySchedule()
        {
            InitializeComponent();
        }

        private void TimeTable()
        {
            String[] modules = new String[7] { "M", "T", "W", "H", "F", "S", "A" };
            for (int i = 0; i < 7; i++)
            {
                dataGridViewSchedule.Rows.Add();
                dataGridViewSchedule.Rows[i].Cells[0].Value = modules[i];
                dataGridViewSchedule.Rows[i].Height = 20;
            }

            dataGridViewSchedule.Rows[7].Cells[0].Value = "";
            dataGridViewSchedule.Rows[7].Height = 0;
            dataGridViewSchedule.Rows[7].ReadOnly = true;
        }
 
        private void frmFacultySchedule_Load(object sender, EventArgs e)
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

            FillFaculty();
            TimeTable();
        }

        void FillFaculty()
        {
            OleDbCommand com = new OleDbCommand("Select FacultyName,FacultyID From qryFaculty", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            lvFaculty.Items.Clear();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["FacultyID"].ToString());
                lv.SubItems.Add(dr["FacultyName"].ToString());
                lvFaculty.Items.AddRange(new ListViewItem[] { lv });

                txtStatus.Text = lvFaculty.Items.Count.ToString() + " faculties found...";
            }
            dr.Close();
        }

        void DisplayFacultySchedule(string faculty)
        {
            DateTime dTimeIn, dTimeOut;
            
            Random randonGen = new Random();
            OleDbCommand com = new OleDbCommand("Select * From qrySubjectOfferring where FacultyID='" + faculty + "'", clsCon.con);
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

                lv.ForeColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));

                lvSchedule.Items.AddRange(new ListViewItem[] { lv });


                dTimeIn = DateTime.Parse(dr["cTimeIn"].ToString());
                dTimeOut = DateTime.Parse(dr["cTimeOut"].ToString());

                ConvertsDaysToInt(dr["cDay"].ToString());
                num1 =clsSchedule.ConvertsTimeINToInt(dTimeIn.ToLongTimeString());
                num2 = clsSchedule.ConvertsTimeOUTToInt(dTimeOut.ToLongTimeString());

                switch (dr["cDay"].ToString())
                {
                    case "MH":
                        #region Two Session
                        for (int time = num1; time <= num2; ++time)
                        {

                            dataGridViewSchedule[time, sDay].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay].ToolTipText = dr["Schedule"].ToString();

                            dataGridViewSchedule[time, sDay1].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay1].ToolTipText = dr["Schedule"].ToString();
                        }
                        #endregion
                        break;

                    case "TF":
                        #region Two Session
                        for (int time = num1; time <= num2; ++time)
                        {

                            dataGridViewSchedule[time, sDay].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay].ToolTipText = dr["Schedule"].ToString();

                            dataGridViewSchedule[time, sDay1].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay1].ToolTipText = dr["Schedule"].ToString();
                        }
                        #endregion
                        break;

                    case "WS":
                        #region Two Session
                        for (int time = num1; time <= num2; ++time)
                        {

                            dataGridViewSchedule[time, sDay].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay].ToolTipText = dr["Schedule"].ToString();

                            dataGridViewSchedule[time, sDay1].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay1].ToolTipText = dr["Schedule"].ToString();
                        }
                        #endregion
                        break;

                    case "MWF":
                        #region Three Session
                        for (int time = num1; time <= num2; ++time)
                        {

                            dataGridViewSchedule[time, sDay].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay].ToolTipText = dr["Schedule"].ToString();

                            dataGridViewSchedule[time, sDay1].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay1].ToolTipText = dr["Schedule"].ToString();

                            dataGridViewSchedule[time, sDay2].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay2].ToolTipText = dr["Schedule"].ToString();
                        }
                        #endregion
                        break;
                    case "THS":
                        #region Three Session
                        for (int time = num1; time <= num2; ++time)
                        {

                            dataGridViewSchedule[time, sDay].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay].ToolTipText = dr["Schedule"].ToString();

                            dataGridViewSchedule[time, sDay1].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay1].ToolTipText = dr["Schedule"].ToString();

                            dataGridViewSchedule[time, sDay2].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay2].ToolTipText = dr["Schedule"].ToString();
                        }
                        #endregion
                        break;

                    default:
                        #region Regular Session
                        for (int time = num1; time <= num2; time++)
                        {
                            dataGridViewSchedule[time, sDay].Style.BackColor = lv.ForeColor;
                            dataGridViewSchedule[time, sDay].ToolTipText = dr["Schedule"].ToString();
                        }
                        #endregion
                        break;
                }
            }
            dr.Close();
        }


        


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


        private void lvFaculty_Click(object sender, EventArgs e)
        {
            DisplayFacultySchedule(lvFaculty.FocusedItem.Text);
        }

        private void addNewEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacultyAE faculty = new frmFacultyAE();
            faculty.mFormState = "ADD";
            faculty.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillFaculty();
        }

        private void modifyEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacultyAE ea = new frmFacultyAE();
            ea.mFormState = "EDIT";
            ea.sFacultyID = lvFaculty.Items[lvFaculty.FocusedItem.Index].SubItems[1].Text;
            ea.ShowDialog();
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No function yet....");
        }
    }
}

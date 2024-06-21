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
    public partial class frmSubjectOffered : Form
    {
        public int sDay,sDay1;

        public frmSubjectOffered()
        {
            InitializeComponent();
        }
     
        private void frmScheduling_Load(object sender, EventArgs e)
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

            LoadSubjectOffered();

        }


        void LoadSubjectOffered()
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM qrySubjectOfferring ", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            lvSchedule.Items.Clear();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr["cSubjects"].ToString());
                lv.SubItems.Add(dr["cSection"].ToString());
                lv.SubItems.Add(dr["cRoom"].ToString());
                lv.SubItems.Add(dr["Schedule"].ToString());
                lv.SubItems.Add(dr["cFaculty"].ToString());
                lvSchedule.Items.AddRange(new ListViewItem[] { lv });
            }
            dr.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}

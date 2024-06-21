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
    public partial class frmSYAE : Form
    {
        public frmSYAE()
        {
            InitializeComponent();
        }

        void AddSchoolYear(string newSchoolYear)
        { 
        
        }

        void GetSchoolYearByTitle(string sSchoolYearTitle)
        {
            OleDbCommand com = new OleDbCommand("SELECT * FROM tblSchoolYear WHERE tblSchoolYear.SchoolYear='" + sSchoolYearTitle + "'",clsCon.con);
            
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

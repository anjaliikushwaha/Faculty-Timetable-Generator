using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class frmSetActiveSY : Form
    {

        public frmSetActiveSY()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboSY.Text == "")
            { MessageBox.Show("Please enter School Year."); }
            else
            {
                System.IO.StreamWriter Writer = new System.IO.StreamWriter(Application.StartupPath + "\\config.txt");
                Writer.Write(cboSY.Text);
                Writer.Close();
                clsSchedule.CurrentSchoolYear = cboSY.Text;

                this.Close();

                MainForm main = new MainForm();
                main.ReloadSchoolYear();
                                
            }
        }

        private void frmSetActiveSY_Load(object sender, EventArgs e)
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

            clsCon.fillCombo(cboSY, "Select SchoolYear From tblSchoolYear");
        }

    }
}

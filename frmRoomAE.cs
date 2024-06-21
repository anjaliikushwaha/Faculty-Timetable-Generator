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
    public partial class frmRoomAE : Form
    {
        public string mFormState;
        public int myID;

        public frmRoomAE()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRoomAE_Load(object sender, EventArgs e)
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
                    GenerateRoomID();
                    break;
                case "EDIT":
                    //DisplayForEditing();
                    break;
            }
       }

        public void GenerateRoomID()
        {
                OleDbCommand cmddr = new OleDbCommand("select NextNo from tblGenerator where TableName='" + "Room" + "'", clsCon.con);
                OleDbDataReader dr = cmddr.ExecuteReader();
                while (dr.Read())
                {
                    string strid = dr["NextNo"].ToString();
                    if (strid == "")
                    {
                        txtRoomID.Text = "Room-" + "1";
                        myID = 1;
                    }
                    else
                    {
                        myID = Convert.ToInt32(dr["NextNo"]) + 1;
                        txtRoomID.Text = "Room-" + myID.ToString();
                    }
                }
                dr.Close();
                cmddr.Dispose();
            }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtRoom.Text == "" || txtBuilding.Text == "" || txtCapacity.Text == "")
            {
                MessageBox.Show("Please fill all the required field..");
            }
            else
            {
                switch (mFormState)
                {
                    case "ADD":
                        AddRoom(txtRoomID.Text, txtBuilding.Text, txtRoom.Text, int.Parse(txtCapacity.Text));
                        break;
                    case "EDIT":
                        UpdateRoom(txtRoomID.Text, txtBuilding.Text, txtRoom.Text, int.Parse(txtCapacity.Text));
                        break;
                }         
            }
        }

        void AddRoom(string ID,string sBuilding, string sRoom, int sCapacity)
        {
            if (RoomExistByRoomNo(txtRoom.Text) == true && RoomExistByBuilding(txtBuilding.Text) == true)
            {
                MessageBox.Show("Building: " + txtBuilding.Text + " - Room: " + txtRoom.Text + " is already existed..");
            }
            else
            {
                OleDbCommand com = new OleDbCommand();
                com.CommandText = "Insert Into [Room](RoomID,RoomNo,Building,Capacity) VALUES ('" + ID + "','" + sRoom + "','" + sBuilding + "','" + sCapacity + "')";
                com.Connection = clsCon.con;
                com.ExecuteNonQuery();

                OleDbCommand pipz = new OleDbCommand("Update tblGenerator Set NextNo='" + myID + "' where TableName ='" + "Room" + "'", clsCon.con);
                pipz.ExecuteNonQuery();

                MessageBox.Show("Room Entry successfully added.");
                frmRoomSchedule room = new frmRoomSchedule();
                room.LoadRooms();

                this.Close();
            }
        }

        void UpdateRoom(string ID, string sBuilding, string sRoom, int sCapacity)
        {
            OleDbCommand com = new OleDbCommand();
            com.CommandText = "Update Room set RoomNo='" + sRoom + "', Building='" + sBuilding + "',Capacity='" + sCapacity + "' Where ID='" + ID + "')";
            com.Connection = clsCon.con;
            com.ExecuteNonQuery();

            MessageBox.Show("Room Entry successfully modify.");
            this.Close();
        }

        bool RoomExistByBuilding(string sRoomname)
        { 
            OleDbCommand com = new OleDbCommand("SELECT * From Room WHERE (((Room.Building)='" + sRoomname + "'));",clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
                return true;
            else
                return false;
        }

        bool RoomExistByRoomNo(string sRoomname)
        {
            OleDbCommand com = new OleDbCommand("SELECT * From Room WHERE (((Room.RoomNo)='" + sRoomname + "'));", clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
                return true;
            else
                return false;
        }

        public void DisplayForEditing(string sRoomID)
        {
            OleDbCommand com = new OleDbCommand("Select * From Room where RoomID='" + sRoomID + "'",clsCon.con);
            OleDbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                txtRoomID.Text = dr["RoomID"].ToString();
                txtRoom.Text = dr["RoomNo"].ToString();
                txtBuilding.Text = dr["Building"].ToString();
                txtCapacity.Text = dr["Capacity"].ToString();
            }
            this.ShowDialog();
            dr.Close();
        }
    }
}
 


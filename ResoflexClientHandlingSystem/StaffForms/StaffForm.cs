using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.Role;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem
{
    public partial class StaffForm : MetroFramework.Forms.MetroForm
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void htmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void htmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string firstName = fNameTxtBox.Text;
            string lastName = lNameTxtBox.Text;
            string Nic = addNICtxtBox.Text;
            string pAddress = pAddTxtBox.Text;
            string sAddress = sAddTxtBox.Text;
            string []telNumber = new string[2];
            telNumber[0] = telMobileTxtBox.Text;
            telNumber[1] = telLanTxtBox.Text;
            string email = emailTxtBox.Text;
            string facebook = fNameTxtBox.Text;
            string linkedIn = linkedTxtBox.Text;
            float basicSal = float.Parse(basicSalTxtBox.Text.ToString());
            float otRate = float.Parse(otRateTxtBox.Text.ToString());

            Designation desg = new Designation(desgCmbBox.SelectedItem.ToString());

            MySqlDataReader reader = DBConnection.getData("Select desig_id from Designation where designation='"+ desg.DesignationName +"'");

            if (reader.Read())
                desg.DesigId = reader.GetInt32("desig_id");

            Staff stf = new Staff(firstName, lastName, Nic, pAddress, telNumber, email, facebook, linkedIn, basicSal, otRate);
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        void clear ()
        {
            fNameTxtBox.Clear();
            lNameTxtBox.Clear();
            pAddTxtBox.Clear();
            sAddTxtBox.Clear();
            telMobileTxtBox.Clear();
            telLanTxtBox.Clear();
            emailTxtBox.Clear();
            fbTxtBox.Clear();
            linkedTxtBox.Clear();
            basicSalTxtBox.Clear();
            otRateTxtBox.Clear();
            desgCmbBox.SelectedItem = null;
        }

      
        private void metroButton2_Click(object sender, EventArgs e)
        {
            foreach(Control c in Controls)
            {
                /* if (c is TextBox)
                 {
                     c.Text = "";
                 } */

                clear();
            }
        }
    }
}

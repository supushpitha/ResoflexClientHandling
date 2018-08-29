using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Common;
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

namespace ResoflexClientHandlingSystem.StaffForms
{
    public partial class UpdateMemberForm : MetroFramework.Forms.MetroForm
    {
        int id;
        public UpdateMemberForm()
        {
            InitializeComponent();
        }

        public UpdateMemberForm(int id, string firstName, string lastName, string nic, string pAddress, string sAddress, string tel1, string tel2, string email, string facebook, string linkedIn, float basicSal, float otRate, string designation)
        {
            InitializeComponent();

            this.id = id;
            fNameTxtBox.Text = firstName;
            lNameTxtBox.Text = lastName;
            addNICtxtBox.Text = nic;
            pAddTxtBox.Text = pAddress;
            sAddTxtBox.Text = sAddress;
            telMobileTxtBox.Text = tel1;
            telLanTxtBox.Text = tel2;
            emailTxtBox.Text = email;
            fbTxtBox.Text = facebook;
            linkedTxtBox.Text = linkedIn;
            basicSalTxtBox.Text = basicSal.ToString();
            otRateTxtBox.Text = otRate.ToString();

            fillDesigCmbBox();
            desgCmbBox.SelectedItem = designation;

        }


        private void staffAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = fNameTxtBox.Text;
                string lastName = lNameTxtBox.Text;
                string Nic = addNICtxtBox.Text;
                string pAddress = pAddTxtBox.Text;
                string sAddress = sAddTxtBox.Text;
                string[] telNumber = new string[2];
                telNumber[0] = telMobileTxtBox.Text;
                telNumber[1] = telLanTxtBox.Text;
                string email = emailTxtBox.Text;
                string facebook = fNameTxtBox.Text;
                string linkedIn = linkedTxtBox.Text;
                float basicSal = float.Parse(basicSalTxtBox.Text.ToString());
                float otRate = float.Parse(otRateTxtBox.Text.ToString());

                Designation desg = new Designation(desgCmbBox.SelectedItem.ToString());

                Staff stf2 = new Staff(firstName, lastName, Nic, pAddress, sAddress, telNumber, email, facebook, linkedIn, basicSal, otRate);

                MySqlDataReader reader = DBConnection.getData("Select desig_id from Designation where designation_name='" + desg.DesignationName + "'");

                while (reader.Read())
                {
                    desg.DesigId = reader.GetInt32("desig_id");
                }

                reader.Close();

                stf2.StaffId = id;
                stf2.Designation = desg;

                Database.updateStaff(stf2);

                MessageBox.Show("Member updated successfully.", "Member Updating", MessageBoxButtons.OK);

                closeForm();
            }
            catch (Exception)
            {
                MessageBox.Show("Every detail must be there!", "Member Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MemberListForm mem = new MemberListForm();
            mem.Show();

            closeForm();
        }

        private void closeForm()
        {
            this.Close();
        }

        private void fillDesigCmbBox()
        {
            MySqlDataReader reader = DBConnection.getData("select * from designation");

            desgCmbBox.Items.Clear();

            while (reader.Read())
            {
                desgCmbBox.Items.Add(reader.GetString("designation_name"));
            }

            reader.Close();
        }

        private void staffClearBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            fNameTxtBox.Clear();
            lNameTxtBox.Clear();
            addNICtxtBox.Clear();
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

        private void UpdateMemberForm_Load(object sender, EventArgs e)
        {
            
        }

        private void desgCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private void addNICtxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg = "";

            if (!Validation.isValidNic(addNICtxtBox.Text, out errorMsg))
            {
                e.Cancel = true;

                addNICtxtBox.Select(0, addNICtxtBox.Text.Length);

                this.errorProviderUpdateStaff.SetError(addNICtxtBox, errorMsg);
            }
        }

        private void addNICtxtBox_Validated(object sender, EventArgs e)
        {
            errorProviderUpdateStaff.SetError(addNICtxtBox, "");
            errorProviderUpdateStaff.Clear();
        }

        private void telMobileTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isValidPhoneNumber(telMobileTxtBox.Text, out errorMsg))
            {
                e.Cancel = true;

                telMobileTxtBox.Select(0, telMobileTxtBox.Text.Length);

                this.errorProviderUpdateStaff.SetError(telMobileTxtBox, errorMsg);
            }
        }

        private void telMobileTxtBox_Validated(object sender, EventArgs e)
        {
            errorProviderUpdateStaff.SetError(telMobileTxtBox, "");
            errorProviderUpdateStaff.Clear();
        }

        private void telLanTxtBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!Validation.isValidPhoneNumber(telLanTxtBox.Text, out errorMsg))
            {
                e.Cancel = true;

                telLanTxtBox.Select(0, telLanTxtBox.Text.Length);

                this.errorProviderUpdateStaff.SetError(telLanTxtBox, errorMsg);
            }
        }

        private void telLanTxtBox_Validated(object sender, EventArgs e)
        {
            errorProviderUpdateStaff.SetError(telLanTxtBox, "");
            errorProviderUpdateStaff.Clear();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }
    }
}


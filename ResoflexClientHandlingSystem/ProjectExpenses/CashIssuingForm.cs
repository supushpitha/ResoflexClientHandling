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

namespace ResoflexClientHandlingSystem
{
    public partial class CashIssuingForm : MetroFramework.Forms.MetroForm


    {

         Project projectOfSchedule;
         Schedule scheduleOfIou;
           float amount;
       string Comment;
        private object projectID;

        public CashIssuingForm()
        {
            InitializeComponent();
            // iouIdDisplay();

            MySqlDataReader reader = DBConnection.getData("select proj_name, proj_id from project");
            DataTable dt = new DataTable();

            dt.Load(reader);

            projectIdBox.DataSource = dt;
            projectIdBox.ValueMember = "proj_id";
            projectIdBox.DisplayMember = "proj_name";


        }


        public CashIssuingForm(Project projectOfIou, Schedule scheduleOfIou)
        {
            InitializeComponent();
           // iouIdDisplay();


        }

        private void CashIssuingForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           // ExpenseDetailSchedule ed = new ExpenseDetailSchedule();


           //ed.ScheduleOfExp = new Schedule(int.Parse(scheduleId.Text.ToString()));
           // ed.ProjectOfSchedule = new Project(int.Parse(projectIdBox.SelectedValue.ToString()));

           // if (Validation.isNumber(amountTxtBox.Text))
           // {
           //     ed.Amount = float.Parse(amountTxtBox.Text);
           //     ed.Comment = details.Text.ToString();


           //     Database.CashIssue(ed);
           // }
           // else
           // {
           //     MessageBox.Show("Invalid Number");
           // }

          



    }

   /*     public void iouIdDisplay()
        {
            MySqlDataReader r = DBConnection.getData("select iou_id from iou order by iou_id desc ");
            if(r.Read())
            {
                //iouIdBox.Text = (r.GetInt16("iou_id") + 1).ToString();
                r.Close();
            }
            else
            {
                //iouIdBox.Text = 1.ToString();
                r.Close();
            }
            

        }*/


        /* private void staffNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
         {
             fillstaffCmbBox();
             string staffName = staffNameComboBox.SelectedItem.ToString();
             staffNameComboBox.SelectedIndex = 1;

         }


         private void fillstaffCmbBox()
             {
                 staffNameComboBox.Items.Clear();

                 try
                 {
                     MySqlDataReader reader = DBConnection.getData("select staff_id, name from staff");

                     if (reader.HasRows)
                     {
                         while (reader.Read())
                         {
                             staffNameComboBox.Items.Add(reader.GetString("name"));
                         }
                     }

                     reader.Close();
                 }
                 catch (Exception)
                 {
                     MessageBox.Show("Error in filling the Staff comboBox!", "staff Filler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }



         }
         */

    }
}

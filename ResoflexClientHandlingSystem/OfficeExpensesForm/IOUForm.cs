using System;
using ResoflexClientHandlingSystem.Role;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResoflexClientHandlingSystem.Core;
using ResoflexClientHandlingSystem.OfficeExpensesForm;
using ResoflexClientHandlingSystem.Common;

namespace ResoflexClientHandlingSystem.OfficeExpenses
{
    public partial class IOUForm : MetroFramework.Forms.MetroForm
    {
        double Amount;
        String Comment;
        int IouNo;


        public IOUForm()
        {
            InitializeComponent();

            iouMethod();

            MySqlDataReader rdr1 = DBConnection.getData("select staff_id, first_name from staff");

            DataTable dt = new DataTable();
            dt.Load(rdr1);

            staffNameBox.DataSource = dt;
            staffNameBox.ValueMember = "staff_id";
            staffNameBox.DisplayMember = "first_name";

        }

        public void iouMethod()
        {
            MySqlDataReader r = DBConnection.getData("select iou_id from iou_office");
            if (r.Read())
            {
                iou.Text = (r.GetInt16("iou_id") + 1).ToString();

                
            }
            else
            {
                iou.Text = "1";
            }
            r.Close();
        }

        private void IOUForm_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
               /* DataGridViewRow row = iouGrid.CurrentRow;

                int id = Int32.Parse(row.Cells[0].Value.ToString());
                string name = row.Cells[1].Value.ToString();
                string address = row.Cells[2].Value.ToString();
                string mobile = row.Cells[3].Value.ToString();
                string office = row.Cells[4].Value.ToString();
                string fax = row.Cells[5].Value.ToString();
                string email = row.Cells[6].Value.ToString();

                UpdateClientForm frm = new UpdateClientForm(id, name, address, mobile, office, fax, email);

                frm.ShowDialog();

           // iouGrid.DataSource = get();
          */  }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            OfficeIou i = new OfficeIou();

            //i.IouNo = int.Parse(iou.Text.ToString());
            i.Name = staffNameBox.Text.ToString();
            

            
            if (Validation.isNumber(amt.Text))
            {
                i.Amount = int.Parse(amt.Text.ToString());
                i.Comment = comment.Text.ToString();
                Database.addIou(i);
            }
            else
            {
                MessageBox.Show("Invalid Number");
            }
        }

        private void View_Click(object sender, EventArgs e)
        {
           
        }
    }    
}

using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem.OfficeExpensesForm
{
    public partial class IOUMain : MetroFramework.Forms.MetroForm
    {
        private object dateTime;

        public IOUMain()
        {
            InitializeComponent();
        }

        private void IOUMain_Load(object sender, EventArgs e)
        {
            metroGrid1.DataSource = griddata1();
            fillTiles();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private DataTable griddata1()
        {
            DataTable table = new DataTable();

            MySqlDataReader reader = DBConnection.getData("select o.iou_id, s.first_name as Staff_Name, o.date as Date, o.Comment as Comment, o.Amount as Amount from iou_office o, staff s where s.staff_id = o.staff_id");

            table.Load(reader);

            return table;
        }


        //tiles
        private void fillTiles()
        {
            try
            {

                MySqlDataReader reader = DBConnection.getData("select count(iou_id) from iou_office");

                while (reader.Read())
                {
                    tile1.Text = (reader.GetValue(0).ToString());
                }

                reader.Close();

                DateTime curdate = DateTime.Now;
                curdate = curdate.AddDays(-30);

                Console.WriteLine("/n" + curdate + "/n" + DateTime.Today +"/n");
               

                reader = DBConnection.getData("select sum(amount) from iou_office where date = "+curdate.Day+"<"+DateTime.Now.Day+"");

                while (reader.Read())
                {
                    tile2.Text = "Rs." + reader.GetDouble(0);
                }

                reader.Close();

               
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            OfficeExpenses.IOUForm frm = new OfficeExpenses.IOUForm();
            frm.Show();
        }
    }
}

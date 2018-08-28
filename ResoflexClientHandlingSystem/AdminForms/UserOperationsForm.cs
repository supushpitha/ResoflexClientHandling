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

namespace ResoflexClientHandlingSystem.AdminForms
{
    public partial class UserOperationsForm : MetroFramework.Forms.MetroForm
    {
        private int LogId;

        public UserOperationsForm()
        {
            InitializeComponent();
        }

        public UserOperationsForm(int logid)
        {
            LogId = logid;
            InitializeComponent();
        }

        private void UserOperationsForm_Load(object sender, EventArgs e)
        {
            OpGrid.DataSource = getOpList(LogId);
        }

        private DataTable getOpList(int logid)
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT distinct o.log_id as LogID, o.operation as Operation, o.op_id as OperationID " +
                    " FROM user_operations o, user_log u where o.log_id ='"+logid+"';");

                dt.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return dt;
        }

        private void OpGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int logid = Int32.Parse(OpGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            string operation = OpGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            int opid = Int32.Parse(OpGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
            int chid;

            try
            {
                MySqlDataReader reader = DBConnection.getData("SELECT id from user_operations where log_id="+logid+" and operation ='"+operation+"'and op_id ="+opid+";");

                if (operation.Equals("Added a new User")&& reader.Read())
                {
                    chid = Int32.Parse(reader["id"].ToString());
                    reader.Close();

                    try
                    {
                        MySqlDataReader reader1 = DBConnection.getData("SELECT user_id, u_name, first_name, last_name, password, permission from " +
                            "user , staff  where user_id="+chid+" and user_id = staff_id;");

                        if (reader1.Read())
                        {
                            string name = reader1["first_name"].ToString() +" " +reader1["last_name"].ToString();
                            string uname = reader1["u_name"].ToString();
                            string pass = Eramake.eCryptography.Decrypt(reader1["password"].ToString());
                            string permission = reader1["permission"].ToString();

                            reader1.Close();
                            UserAddForm uaf = new UserAddForm(name, uname, pass, permission);
                            uaf.Show();
                            
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}

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

                        while (reader1.Read())
                        {
                            string name = reader1["first_name"].ToString() +" " +reader1["last_name"].ToString();
                            string uname = reader1["u_name"].ToString();
                            string pass = Eramake.eCryptography.Decrypt(reader1["password"].ToString());
                            string permission = reader1["permission"].ToString();

                            
                            UserAddForm uaf = new UserAddForm(name, uname, pass, permission);
                            uaf.Show();
                            
                        }
                        reader1.Close();
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                    }
                }
                else if (operation.Equals("Added a new Project") && reader.Read())
                {
                    chid = Int32.Parse(reader["id"].ToString());
                    reader.Close();

                    try
                    {
                        MySqlDataReader reader1 = DBConnection.getData("SELECT p.proj_name, c.name, p.description, p.proj_cat_id, p.proj_sub_cat_id, p.support_terms, p.visit_terms, p.warranty_terms from " +
                            "project p , client c  where p.proj_id=" + chid + " and p.client_id = c.client_id;");

                        while (reader1.Read())
                        {
                            string pname = reader1["proj_name"].ToString();
                            string clientname = reader1["name"].ToString();
                            string description = reader1["description"].ToString();
                            string supporttrms = reader1["support_terms"].ToString();
                            string visittrms = reader1["visit_terms"].ToString();
                            string warrantytrms = reader1["warranty_terms"].ToString();
                            int catid = int.Parse(reader1["proj_cat_id"].ToString());
                            int subcatid = int.Parse(reader1["proj_sub_cat_id"].ToString());
                            UpdateProjectForm upf = new UpdateProjectForm(pname, clientname, description, supporttrms, visittrms, warrantytrms, catid, subcatid);
                            upf.Show();                     

                        }
                        reader1.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                    }
                }
                else if (operation.Equals("Added a new Client") && reader.Read())
                {
                    chid = Int32.Parse(reader["id"].ToString());
                    reader.Close();

                    try
                    {
                        MySqlDataReader reader1 = DBConnection.getData("SELECT name, address, phone_mobile, phone_office, fax, email FROM" +
                            " client where client_id = " + chid + " ; ");

                        while (reader1.Read())
                        {
                            string name =reader1["name"].ToString();
                            string address = reader1["address"].ToString();
                            string phone_mob = reader1["phone_mobile"].ToString();
                            string phone_office = reader1["phone_office"].ToString();
                            string fax = reader1["fax"].ToString();
                            string email = reader1["email"].ToString();
                            AddNewClientForm anc = new AddNewClientForm(name, address, phone_mob, phone_office, fax, email);
                            anc.Show();

                        }
                        reader1.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                    }
                }
                reader.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void OpGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

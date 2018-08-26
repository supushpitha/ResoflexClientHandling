using MySql.Data.MySqlClient;
using System;
using ResoflexClientHandlingSystem.Role;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResoflexClientHandlingSystem.Core
{
    class Database
    {
        public static void saveClient(Client client)
        {
            try
            {
                DBConnection.updateDB("insert into client (name, address, phone_mobile, phone_office, fax, email)" +
                                      " values ('" + client.FirstName + " " + client.LastName + "', '" + client.Address + "', " +
                                      "'" + client.PhoneNo[0] + "', '" + client.PhoneNo[1] + "', '" + client.Fax + "', " +
                                      "'" + client.Email + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Add client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addUsers(User user)
        {
            try
            {
                DBConnection.updateDB("insert into user (user_id, u_name, password, permission) values ("+user.StaffId+",'"+user.UName+"','"+user.Pword+"','"+user.Permission+"')");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void addLog(int uid, string ip,string logIDatetime, string logODateTime, string det)
        {
            try
            {
                DBConnection.updateDB("insert into user_log (user_id, logged_in_dateTime, logged_out_dateTime, detail, ip) values " +
                    "(" + uid + ",'" + logIDatetime + "','" + logODateTime + "','" + det + "', '" + ip + "')");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong!", "Logging out", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void updateClient(Client client)
        {
            try
            {
                DBConnection.updateDB("update client set name='" + client.FirstName + " " + client.LastName + "', " +
                                      "address='" + client.Address + "', phone_mobile='" + client.PhoneNo[0] + "', " +
                                      "phone_office='" + client.PhoneNo[1] + "', fax='" + client.Fax + "', email='" + client.Email + "' " +
                                      "where client_id=" + client.ClientID);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void updateUser(User user)
        {
            try
            {
                DBConnection.updateDB("update user set u_name='" + user.UName + "', password='" +
                    user.Pword + "' where user_id ='" + user.UserId + "';");
            }
            catch (Exception)
            {
                MessageBox.Show("", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addProject(ResoflexClientHandlingSystem.Role.Project project)
        {
            Client client = project.ClientOfProject;

            try
            {
                DBConnection.updateDB("insert into project (client_id, proj_name, proj_sub_cat_id, description, warranty_terms, visit_terms, support_terms)"
                                        + " values (" + client.ClientID
                                        + ",'" + project.ProjectName
                                        + "'," + project.ProjectSubID
                                        + ",'" + project.Projectdesc
                                        + "','" + project.WarrantyTerms
                                        + "','" + project.VisitTerms
                                        + "','" + project.SupportTerms + "')");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc, "Project NOT added", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        public static void addProjectCat(ResoflexClientHandlingSystem.Role.ProjectCategory projectCat)
        {


            try
            {
                DBConnection.updateDB("insert into proj_category (cat_name) values ('" + projectCat.CategoryName + "')");

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error" + exc, "Project NOT added", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void updateProject(ResoflexClientHandlingSystem.Role.Project project)
         {
             try
             {
                DBConnection.updateDB("UPDATE project SET first_init_date ='"+project.FirstInitDate+"', training_comp_first_end_date='"+project.TEndDate1+"', training_comp_second_end_date='"+project.TEndDate2+"', warranty_start_date='"+project.WarrantyStart+"', warranty_period='"+project.WarrantyPeriod+"' WHERE proj_name='"+project.ProjectName+"';");
             }
             catch (Exception exc)
             {
                 MessageBox.Show("Error" + exc, "Project NOT added", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }
    }
}

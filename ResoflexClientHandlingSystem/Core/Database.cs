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


        public static void addLog(Role.UserLog log)
        {
            try
            {
                DBConnection.updateDB("insert into user_log (user_id, logged_in_dateTime, detail, ip) values " +
                    "(" + log.User.UserId+ ",'" + log.LoggedInDateTime + "','" + log.Detail + "', '" + log.Ip + "')");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Something went wrong!", "Logging in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void updateLog(Role.UserLog log)
        {
            try
            {
                DBConnection.updateDB("update user_log set logged_out_dateTime='" + log.LoggedOutDateTime + "', detail='" + log.Detail + "' where log_id = '" + log.LogId + "';");
                    
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
                    user.Pword + "' where user_id = "+ user.UserId + ";");
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


        /* public static void updateProject(ResoflexClientHandlingSystem.Role.Project project)
         {
             try
             {
                 DBConnection.updateDB("update project set (client_id, proj_name, proj_sub_cat_id, description, warranty_terms, visit_terms, support_terms)"
                                         + " values (" + project.ClientID
                                         + ",'" + project.ProjectName
                                         + "'," + project.Project_subID
                                         + ",'" + project.ProjectDesc
                                         + "','" + project.WarrantyTerms
                                         + "','" + project.VisitTerms
                                         + "','" + project.SupportTerms + "')");
             }
             catch (Exception exc)
             {
                 MessageBox.Show("Error" + exc, "Project NOT added", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
         }*/

        public static void addRecord(Attendance atten)
        {
            try
            {
                DBConnection.updateDB("insert into attendance(employee_no, name, in_time, out_time, hours_worked)values('" + atten.EmployeeNo + "','" + atten.Name + "', '" + atten.InTime + "', '" + atten.OutTime + "','" + atten.HoursWorked + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void addJobPerformance(JobPerformance jobPerformanceObj)
        {

            try
            {

                DBConnection.updateDB("insert into jobperformance(date, emp_no, knowledge, safety, quality, adaptability, productivity, Initiative, total)values('" + jobPerformanceObj.Date + "','" + jobPerformanceObj.EmployeeNo + "', '" + jobPerformanceObj.Knowledge + "', '" + jobPerformanceObj.Safety + "','" + jobPerformanceObj.Quality + "','" + jobPerformanceObj.Adaptability + "','" + jobPerformanceObj.Productivity + "','" + jobPerformanceObj.Initiative + "','" + jobPerformanceObj.Total + "')");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Update client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

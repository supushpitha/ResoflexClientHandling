using MySql.Data.MySqlClient;
using System;
using ResoflexClientHandlingSystem.Role;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

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

        //Adding a new schedule
        public static Boolean addSchedule(Schedule schedule)
        {
            try
            {
                //for now
                schedule.Vehicle = " ";
                schedule.Mileage = 0;

                DBConnection.updateDB("insert into schedule (proj_id, visit_type_id, vehicle_details, mileage, to_date_time, " +
                    "from_date_time, to_do_list, resource, check_list, travelling_mode, accommodation, meals, logs) " +
                    "VALUES (" + schedule.ProjectOfSchedule.ProjectID + ", " + schedule.Type.EventTypeId + ", '" + schedule.Vehicle + "'," +
                    "" + schedule.Mileage + ", '" + schedule.To.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + schedule.From.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + schedule.TodoList + "', " +
                    "'" + schedule.Resource + "', '" + schedule.Checklist + "', '" + schedule.TravelMode + "'," +
                    " '" + schedule.AccommodationMode + "', '" + schedule.Meals + "', '" + schedule.Logs + "'); ");

                foreach (var ary in schedule.ServEngineer)
                {
                    Staff s = (Staff) ary;

                    DBConnection.updateDB("insert into schedule_technicians(sch_no, staff_id, proj_id) values (" + schedule.ScheduleId + ", " + s.StaffId + ", " + schedule.ProjectOfSchedule.ProjectID + ")");
                }

                return true;

            }
            catch (Exception e)
            {

                MessageBox.Show("Something went wrong!\n" + e.GetType() , "Add Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public static Boolean deleteSchedule(Schedule schedule)
        {

            try
            {
                DBConnection.updateDB("delete from schedule where proj_id = " + schedule.ProjectOfSchedule.ProjectID + " and sch_no = " + schedule.ScheduleId + ";");

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!\n" + e.GetType(), "Schedule Deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }
    }
}

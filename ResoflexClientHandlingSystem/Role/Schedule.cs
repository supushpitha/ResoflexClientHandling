using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    class Schedule
    {
        private int scheduleId;
        private Project projectOfSchedule;
        private EventType type;
        private Staff servEngineer;
        private DateTime from;
        private DateTime to;
        private string vehicle;
        private float mileage;
        
        public Schedule()
        {

        }
        
        public Schedule(int scheduleId, Project projectOfSchedule, EventType type, Staff servEngineer, DateTime from, DateTime to, string vehicle, float mileage)
        {
            this.scheduleId = scheduleId;
            this.projectOfSchedule = projectOfSchedule;
            this.type = type;
            this.servEngineer = servEngineer;
            this.from = from;
            this.to = to;
            this.vehicle = vehicle;
            this.mileage = mileage;
        }
        
        public DataTable getSchedules()
        {
            DataTable dt = new DataTable();
            
            MySqlDataReader reader = DBConnection.getData("select * from schedule");
            
            dt.Load(reader);
            
            return dt;
        }
    }
}

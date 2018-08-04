using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ResoflexClientHandlingSystem.Core;

namespace ResoflexClientHandlingSystem.Role
{
    class Schedule
    {
        private int visitId;
        private int projectId;
        private String type;
        private String servEngineer;
        private DateTime from;
        private DateTime to;
        private String vehicle;
        private float mileage;

        public Schedule()
        {

        }

        public Schedule(int visitId, int projectId, string type, string servEngineer, DateTime from, DateTime to, string vehicle, float mileage)
        {
            this.visitId = visitId;
            this.projectId = projectId;
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

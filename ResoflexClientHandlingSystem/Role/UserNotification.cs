using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResoflexClientHandlingSystem.Role
{
    public class UserNotification
    {
        private int notificationID;
        private DateTime date;
        private int userID;
        private int view;
        private int admin_view;
        private int fuctionID;
        private bool statues;
        private string userID1;
        private string functionID;
       

        public UserNotification()
        {
        }

        public UserNotification(int notificationID, DateTime date, int userID, int fuctionID, bool statues, int view)
        {
            this.notificationID = notificationID;
            this.date = date;
            this.userID = userID;
            this.fuctionID = fuctionID;
            this.statues = statues;
            
        }

        public UserNotification(int view, int userID)
        {

            this.userID = userID;
            
            this.view = view;
        }

        public UserNotification(int userID, int fuctionID, bool statues)
        {
            
            this.userID = userID;
            this.fuctionID = fuctionID;
            this.statues = statues;
        }

        public UserNotification(int notificationID, int admin_view, int view)
        {

            this.notificationID=notificationID;
            this.admin_view = admin_view;
            this.view = view;
            
        }

        public UserNotification(int userID, int fuctionID, string functionID)
        {

            this.userID = userID;
            this.fuctionID = fuctionID;
            this.functionID = functionID;
            
        }

        public UserNotification(int userID, bool statues)
        {

            this.userID = userID;
            this.statues = statues;

        }



        public UserNotification(string userID1, string functionID, bool statues)
        {
            this.userID1 = userID1;
            this.functionID = functionID;
            this.statues = statues;
        }

        public int NotificationID { get => notificationID; set => notificationID = value; }
        public DateTime Date { get => date; set => date = value; }
        public int UserID { get => userID; set => userID = value; }
        public int FuctionID { get => fuctionID; set => fuctionID = value; }
        public bool Statues { get => statues; set => statues = value; }
        public int View { get => view; set => view = value; }

        public int Admin_view { get => admin_view; set => admin_view = value; }
    }
}

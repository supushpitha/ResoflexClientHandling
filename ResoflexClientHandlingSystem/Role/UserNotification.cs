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
        private int notiId;
        private DateTime notiDate;
        private int userId;
        private int view;
        private int adminView;
        private int fuctionId;
        private bool status;
        private int mainId;
        private int subId;

        public UserNotification()
        {

        }

        public UserNotification(int notiId, bool status)
        {
            NotiId = notiId;
            Status = status;
        }

        public UserNotification(int notiId, DateTime notiDate, int userId, int view, int adminView, int fuctionId, bool status, int mainId, int subId)
        {
            NotiId = notiId;
            NotiDate = notiDate;
            UserId = userId;
            View = view;
            AdminView = adminView;
            FuctionId = fuctionId;
            Status = status;
            MainId = mainId;
            SubId = subId;
        }

        public UserNotification(int userId, int fuctionId, bool status, int mainId, int subId)
        {
            UserId = userId;
            FuctionId = fuctionId;
            Status = status;
            MainId = mainId;
            SubId = subId;
        }
        
        public UserNotification(DateTime notiDate, int userId, int view, int adminView, int fuctionId, bool status, int mainId, int subId)
        {
            NotiDate = notiDate;
            UserId = userId;
            View = view;
            AdminView = adminView;
            FuctionId = fuctionId;
            Status = status;
            MainId = mainId;
            SubId = subId;
        }

        public int NotiId { get => notiId; set => notiId = value; }
        public DateTime NotiDate { get => notiDate; set => notiDate = value; }
        public int UserId { get => userId; set => userId = value; }
        public int View { get => view; set => view = value; }
        public int AdminView { get => adminView; set => adminView = value; }
        public int FuctionId { get => fuctionId; set => fuctionId = value; }
        public bool Status { get => status; set => status = value; }
        public int MainId { get => mainId; set => mainId = value; }
        public int SubId { get => subId; set => subId = value; }
    }
}

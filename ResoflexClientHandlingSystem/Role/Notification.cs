using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace ResoflexClientHandlingSystem.Role
{
    class Notification
    {
        public static void showNotification() {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.info2;
            popup.TitleText = "Notification";
            popup.ContentText = "Operation Successful";
            popup.Popup();
        }
    }
}

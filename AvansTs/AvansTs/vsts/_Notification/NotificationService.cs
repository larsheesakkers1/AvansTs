using System;
using System.Collections.Specialized;

namespace AvansTs.vsts._Notification
{
    public class NotificationService
    {

        private static NotificationService uniqueInstance;

        public static  NotificationService getInstance()
        {
            if (uniqueInstance == null)
            {
                Console.WriteLine("creating unique instance of notificationServices");
                uniqueInstance = new NotificationService();
            }
            return uniqueInstance;
        }
    }
}
using System;

namespace AvansTs.vsts._Notification
{
    internal class Slack : INotification
    {
        public bool Notify(string message)
        {
            try
            {
                Console.WriteLine("slack->" + message);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
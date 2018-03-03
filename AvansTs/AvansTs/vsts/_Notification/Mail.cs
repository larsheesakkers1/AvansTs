using System;

namespace AvansTs.vsts._Notification
{
    internal class Mail : INotification
    {
        public bool Notify(string message)
        {
            try
            {
                Console.WriteLine("mail->" + message);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
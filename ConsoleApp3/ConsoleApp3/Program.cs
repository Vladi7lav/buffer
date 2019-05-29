using Microsoft.Azure.NotificationHubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            SendNotificationAsync();
            Console.Write("Test");
            Console.ReadLine();
        }
        private static async void SendNotificationAsync()
        {
            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString("Endpoint=sb://pushcrm.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=KF47Bbxdhz+nnninLfbIEi/VXPPYVKa5ZaMwkO5I6/U=", "Test_notification_hub");
            String message = "{\"data\":{\"Test message\":\"Доров\"}}";
            await hub.SendFcmNativeNotificationAsync(message);
        }
    }
}

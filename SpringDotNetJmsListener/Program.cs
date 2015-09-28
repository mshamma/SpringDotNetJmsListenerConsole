using System;
using System.Configuration;
using Apache.NMS.ActiveMQ;
using Spring.Messaging.Nms.Listener;

namespace SpringDotNetJmsListener
{
    class Program
    {
        private static string URI = ConfigurationManager.AppSettings["connectUri"];
        private static string DESTINATION = ConfigurationManager.AppSettings["destination"];
        private static string USER = ConfigurationManager.AppSettings["userName"];
        private static string PASS = ConfigurationManager.AppSettings["userPassword"];

        static void Main(string[] args)
        {
            try
            {
                ConnectionFactory connectionFactory = new ConnectionFactory(URI);
                connectionFactory.UserName = USER;
                connectionFactory.Password = PASS;

                using (SimpleMessageListenerContainer listenerContainer = new SimpleMessageListenerContainer())
                {
                    listenerContainer.ConnectionFactory = connectionFactory;
                    listenerContainer.DestinationName = DESTINATION;
                    listenerContainer.MessageListener = new Listener();
                    listenerContainer.AfterPropertiesSet();
                    Console.WriteLine("Listener started.");
                    Console.WriteLine("Press <ENTER> to exit.");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Press <ENTER> to exit.");
                Console.Read();
            }
            // comment when testing
            Console.ReadLine();
        }
    }
}

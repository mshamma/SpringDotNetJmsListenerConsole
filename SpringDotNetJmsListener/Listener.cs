using System;
using Apache.NMS;
using Spring.Messaging.Nms.Core;

namespace SpringDotNetJmsListener
{
    class Listener : IMessageListener
    {
        public Listener()
        {
            Console.WriteLine("Listener created.\r\n");
        }

        #region IMessageListener Members

        public void OnMessage(IMessage message)
        {
            ITextMessage textMessage = message as ITextMessage;

            // Handle the message here 
            Console.WriteLine(textMessage.Text);
        }

        #endregion
    }
}

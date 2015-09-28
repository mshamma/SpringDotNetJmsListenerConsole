# SpringDotNetJmsListenerConsole
A console application that invokes a JMS consumer using the Spring.Net messaging library (e.g. NMS or .Net Messaging API).

Built in Visual Studio 2015 Community Edition 

The code for this console application was taken entirely from Mark Bloodworth's blog post, "Messaging with .Net and ActiveMQ" 
https://remark.wordpress.com/articles/messaging-with-net-and-activemq/

From the ApacheMQ NMS web page (http://activemq.apache.org/nms/apachenms.html)
"...The NMS API (.Net Message Service API) providers a standard .NET interface to Messaging Systems. There could be multiple implementations to different providers (including MSMQ). The NMS API This allows you to build .NET applications in C#, VB, or any other .NET language, using a single API to connect to multiple different providers using a JMS style API."

The SimpleMessageContainer comes from Spring.Net.  See Chapter 31. "Using Spring Messaging" in the Documentation for more information.
http://www.springframework.net/doc-latest/reference/html/messaging.html#activemq-using

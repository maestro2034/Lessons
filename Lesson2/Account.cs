using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class Account
    {
        public string NickName { get; set; }
        public string PhoneNumber { get; set; }
        public event EventHandler<Message> PrivateMessageSent;

        public void ReceiveMessage(object sender, string text)
        {
            Console.WriteLine(text);
        }

        public void SendPrivateMessage(string messageText)
        {
            Message message = new Message();
            message.MessageText = messageText;
            message.SenderName = NickName;
            PrivateMessageSent?.Invoke(this, message);
        }

        public void ReceivePrivateMessage(object sender, Message message)
        {
            Console.WriteLine("ALERT!");
            Console.WriteLine($"You have new message from {message.SenderName}");
            Console.WriteLine($"{message.SenderName} says {message.MessageText}");
            Console.WriteLine();
        }
        


    }
}

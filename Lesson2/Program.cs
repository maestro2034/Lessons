using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            acc1.NickName = "Jaweed";
            Account acc2 = new Account();
            acc2.NickName = "Tariel";
            ChatRoom room = new ChatRoom();
            room.Join(acc1);
            acc1.PrivateMessageSent += acc2.ReceivePrivateMessage;
            acc2.PrivateMessageSent += acc1.ReceivePrivateMessage;
        }


        //ChatRoom room = new ChatRoom();
        //Account acc = new Account();
        //Account acc1 = new Account();
        //room.Join(acc1);
        //room.Join(acc);
        //room.Join(new Account());
    }
}

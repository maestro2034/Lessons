using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2
{
    public class ChatRoom
    {
        private Account[] _accounts;
        public event EventHandler<string> MessageSent;
        
        public ChatRoom()
        {
            _accounts = new Account[100];
        }

        public void Join(Account account)
        {
            for (int i = 0; i < _accounts.Length; i++)
            {
                if (_accounts[i] == null)
                {
                    _accounts[i] = account;
                    this.MessageSent += account.ReceiveMessage;
                    MessageSent?.Invoke(this, $"{account.NickName} joined");
                    break;
                }
            }
        }

        public void SendMessage(string text)
        {
            MessageSent?.Invoke(this, text);
        }

        






    }
}

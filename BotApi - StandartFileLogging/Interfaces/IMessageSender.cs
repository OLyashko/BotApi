using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BotApi
{
    interface IMessageSender
    {
        string Send(Message message);
    }
}
